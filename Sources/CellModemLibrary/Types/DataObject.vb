Imports System.Reflection

Imports CellModemLibrary.LinqExtensions

Public MustInherit Class DataObject

    Public Sub AddKeywords(ByVal UserName As String)

        Dim Data() As String = Me.GetDataFieldsForKeywords()
        Dim type As Type = Me.GetType()
        Dim type_FormConstants As Type = GetType(Helpers.FormConstants)

        Dim typeNameToUpper As String = type.Name.ToUpper()
        Dim constantsFields() As FieldInfo = type_FormConstants.GetConstants().ToArray()

        Dim fiFormID As FieldInfo = constantsFields.Where(Function(x) x.Name _
            = String.Format("DEFAULT_VALUE_FORMID_{0}", typeNameToUpper)).FirstOrDefault() ' 19295
        Dim fiShowFormID As FieldInfo = constantsFields.Where(Function(x) x.Name _
            = String.Format("DEFAULT_VALUE_SHOWFORMID_{0}", typeNameToUpper)).FirstOrDefault() ' 19295
        Dim fiRequest_HeaderRecord As FieldInfo = constantsFields.Where(Function(x) x.Name _
            = String.Format("DEFAULT_VALUE_REQUEST_HEADER_RECORD_{0}", typeNameToUpper)).FirstOrDefault() ' 0

        Dim intFormID As Integer? = Nothing ' 19295
        Dim intShowFormID As Integer? = Nothing ' 19295
        Dim lngRequest_HeaderRecord As Long? = Nothing ' 0

        If Not IsNothing(fiFormID) Then
            intFormID = fiFormID.GetValue(Nothing)
        End If
        If Not IsNothing(fiShowFormID) Then
            intShowFormID = fiShowFormID.GetValue(Nothing)
        End If
        If Not IsNothing(fiRequest_HeaderRecord) Then
            lngRequest_HeaderRecord = fiRequest_HeaderRecord.GetValue(Nothing)
        End If

        If intFormID.HasValue And intShowFormID.HasValue And lngRequest_HeaderRecord.HasValue Then

#If DEBUG Then

            Dim dumpToFile As Boolean = False

            dumpToFile = System.Diagnostics.Debugger.IsAttached

            Utils.KeywordUtils.ConvertToKeywordSearchForDataObject(Me, Data, type.Name, UserName, intFormID, intShowFormID, lngRequest_HeaderRecord, dumpToFile)
#Else
            Utils.KeywordUtils.ConvertToKeywordSearchForDataObject(Me, Data, type.Name, UserName, intFormID, intShowFormID, lngRequest_HeaderRecord)
#End If
        End If
    End Sub

End Class