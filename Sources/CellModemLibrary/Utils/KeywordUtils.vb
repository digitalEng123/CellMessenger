Imports System.IO
Imports System.Text
Imports System.Linq
Imports System.Data
Imports System.Reflection

Imports CellModemLibrary.LinqExtensions

Namespace Utils

    Public Class KeywordUtils

        Public Const LOG_PATH As String = "D:\Telligent\LogFiles\"

        ''' <summary>Write Error to Local Log File</summary>
        ''' <param name="ApplicationName"><c>String</c> specifing the Application Name</param>
        ''' <param name="ThrownException"><c>Exception</c> containing the error that occured.</param>
        ''' <remarks>
        ''' <para>
        ''' Captures the error mesasge and, through the stack trace, the Line number and the filename, then
        ''' checks to see if the folder path "D:\Telligent\LogFiles\" exists, if it does, it goes ahead and 
        ''' attempts to append to that path and the application name.
        ''' </para>
        ''' </remarks>
        Public Shared Sub WriteErrorToLocalLogFile(ByVal ApplicationName As String, ByVal ThrownException As Exception)

            Dim Result As String = ThrownException.Message

            Dim StackTrace As StackTrace = New StackTrace(ThrownException, True)

            Dim StackFrameList() As StackFrame = StackTrace.GetFrames()
            If StackFrameList IsNot Nothing Then
                For Each stackframe As StackFrame In StackFrameList
                    If stackframe.GetFileLineNumber() > 0 Then
                        Result = "Line:" & stackframe.GetFileLineNumber() &
                                 " Filename: " & IO.Path.GetFileName(stackframe.GetFileName) &
                                 " Function: " & stackframe.GetMethod.Name & " - " & Result
                    End If
                Next
            End If

            If System.IO.Directory.Exists(LOG_PATH) Then
                Try
                    Using OutFile As New StreamWriter(LOG_PATH & ApplicationName.Replace(" ", "") & ".log", True)
                        OutFile.WriteLine(Now().ToShortDateString & " " & Now().ToShortTimeString & ": " & Result)
                    End Using
                Catch ex As Exception
                End Try
            End If
        End Sub

        Public Shared Function ConvertStringToSQLString(ByVal FieldValue As String) As String
            Return "'" & FieldValue.Replace("'", "''") & "'"
        End Function

        ''' <summary>Convert Data Object to Keyword Search</summary>
        ''' <param name="DataObject"><c>Object</c> specifying the Data Object</param>
        ''' <param name="KeywordFieldNames">Array of <c>Strings</c> specifying the Field Names that are to be converted to the Keywords.</param>
        ''' <param name="TableName"><c>String</c> specifying the name of the Table to associate to the Keywords</param>
        ''' <param name="UserName"><c>String</c> specifying the name of the user creating the record.</param>
        ''' <param name="FormID"><c>Integer</c> specifying the form that is associated.</param>
        ''' <param name="ShowFormID"><c>Integer</c> specifying the form to show when the user double clicks on the record.</param>
        ''' <param name="HeaderRecord"><c>Integer</c> specifying the Record ID of the Header Record.</param>
        ''' <remarks>
        ''' <para>
        ''' Does a reflection on the <paramref name="DataObject" /> to read all of the <paramref name="KeywordFieldNames" /> properties that are public and 
        ''' in the instance of the <paramref name="DataObject" />
        ''' </para>
        ''' <para>
        ''' Added 11/07/2017 By Eric Forkrud (V1.00.06) to handle the Link to the <c>telligent.C4.InsertKeywordRecordExe</c>
        ''' </para>
        ''' </remarks>
        Public Shared Sub ConvertToKeywordSearchForDataObject(ByVal DataObject As Object, ByVal KeywordFieldNames() As String, ByVal TableName As String,
                                                              ByVal UserName As String, ByVal FormID As Integer, ByVal ShowFormID As Integer,
                                                              ByVal HeaderRecord As Long, Optional ByVal dumpToFile As Boolean = False)
            Dim Fields As New StringBuilder()
            Dim Values As New StringBuilder()

            Dim objType As Type = DataObject.GetType()

            For Each Element As String In KeywordFieldNames

                Dim pInfo As System.Reflection.PropertyInfo = objType.GetProperty(Element, BindingFlags.IgnoreCase + BindingFlags.Public + BindingFlags.Instance)

                If pInfo IsNot Nothing Then

                    Dim PropValue As Object = pInfo.GetValue(DataObject, Reflection.BindingFlags.GetProperty, Nothing, Nothing, Nothing)

                    If PropValue IsNot Nothing Then

                        Dim TempValue As String = PropValue.ToString

                        If Not String.IsNullOrEmpty(TempValue) Then
                            If Fields.Length > 0 Then
                                Fields.Append("^")
                                Values.Append("^")
                            End If

                            Fields.Append(Element.Replace("'", "''"))
                            Values.Append(TempValue.Replace(" ", "+"))
                        End If
                    End If
                End If
            Next

            Dim C4 As New telligent.C4
            Dim STATUS As Integer = 4

            Dim enumbindingFlags As System.Reflection.BindingFlags = BindingFlags.Instance + BindingFlags.Public + BindingFlags.IgnoreCase

            If dumpToFile Then

                Dim Output() As String = {UserName, 0,
                                      DataObject.GetType().GetProperty("IntRecordID_Company", enumbindingFlags).GetValue(DataObject, Nothing),
                                      DataObject.GetType().GetProperty("IntRecordID_Division", enumbindingFlags).GetValue(DataObject, Nothing),
                                      DataObject.GetType().GetProperty("IntRecordID_DatabaseID", enumbindingFlags).GetValue(DataObject, Nothing), STATUS,
                                      DataObject.GetType().GetProperty("IntRecordID", enumbindingFlags).GetValue(DataObject, Nothing),
                                      TableName, Values.ToString(), Fields.ToString(), FormID, ShowFormID, HeaderRecord}

                For Each Line As String In Output
                    DumpLine(Line)
                Next
            Else

                C4.InsertKeywordRecordExe(UserName, 0,
                                          DataObject.GetType().GetProperty("IntRecordID_Company", enumbindingFlags).GetValue(DataObject, Nothing),
                                          DataObject.GetType().GetProperty("IntRecordID_Division", enumbindingFlags).GetValue(DataObject, Nothing),
                                          DataObject.GetType().GetProperty("IntRecordID_DatabaseID", enumbindingFlags).GetValue(DataObject, Nothing), STATUS,
                                          DataObject.GetType().GetProperty("IntRecordID", enumbindingFlags).GetValue(DataObject, Nothing),
                                          TableName, Values, Fields, FormID, ShowFormID, HeaderRecord)
            End If
        End Sub

        Public Shared Sub AddKeywordSearchDataToDataObject(ByVal DataObject As Object, ByVal DataTableObject As DataTable, ByVal DataRowObject As DataRow)

            Dim KeywordFieldNames() = DataTableObject.GetDataFieldsForKeywords()

            Dim objType As Type = DataObject.GetType()

            For Each Element As String In KeywordFieldNames

                Dim pInfo As System.Reflection.PropertyInfo = objType.GetProperty(Element, BindingFlags.IgnoreCase + BindingFlags.Public + BindingFlags.Instance)

                If pInfo IsNot Nothing Then

                    If pInfo.CanRead And pInfo.CanWrite Then

                        Dim propValue As Object = DataRowObject(Element)

                        If Not IsDBNull(propValue) Then
                            pInfo.SetValue(DataObject, propValue, Nothing)
                        End If
                    End If
                End If
            Next
        End Sub

        Shared Sub DumpLine(ByVal Message As String)
            Dim FILE_NAME As String = "D:\Telligent\LogFiles\DumpFile.txt"

            If System.IO.File.Exists(FILE_NAME) = True Then
                Using Writer As StreamWriter = File.AppendText(FILE_NAME)
                    Writer.WriteLine(Now().ToString & " - " & Message)
                End Using
            Else
                Using Writer As StreamWriter = File.CreateText(FILE_NAME)
                    Writer.WriteLine(Now().ToString & " - " & Message)
                End Using
            End If
        End Sub

    End Class

End Namespace
