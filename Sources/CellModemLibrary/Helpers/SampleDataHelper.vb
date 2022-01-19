Imports System
Imports System.Text
Imports System.Data
Imports System.Data.OleDb

Public Class SampleDataHelper

    Public Shared Sub InsertMail(ByRef intRecordID_Mail As Long?, ByRef ixtCode As String, ByRef txtDescription As String,
        ByVal intRecordID_MailType As Long?, ByVal intRecordID_MailStatus As Long?, ByVal intRecordID_MailRouting As Long?, ByVal intRecordID_Contact As Long?,
            ByVal intRecordID_MemoTemplate As Long?, ByVal intRecordID_MailFolder As Long?, ByVal intRecordID_User_Creation As Long?, ByVal txtEmailFrom As String, ByVal mmoEmailTo As String,
            ByVal mmoEMailCC As String, ByVal mmoEMailBcc As String, ByVal txtSubject As String, ByVal mmoBody As String, ByVal mmoAttachment As String,
                                 Optional ByVal connString As String = "")

        intRecordID_MailType = ReplaceNullValueToLong(intRecordID_MailType, 2) ' Email=1,SMS Text=2,Text=3
        intRecordID_MailStatus = ReplaceNullValueToLong(intRecordID_MailStatus, 1) ' Pending/Waiting=1,Sent/Delivered=2,Failed/NotDelivered=3
        intRecordID_MailRouting = ReplaceNullValueToLong(intRecordID_MailRouting, 2) ' Inbound=1,Outbound=2
        intRecordID_Contact = ReplaceNullValueToLong(intRecordID_Contact, 0)
        'intRecordID_MemoTemplate = ReplaceNullValueToLong(intRecordID_MemoTemplate, 0)
        intRecordID_MailFolder = ReplaceNullValueToLong(intRecordID_MailFolder, 0)
        intRecordID_User_Creation = ReplaceNullValueToLong(intRecordID_User_Creation, 76)

        Dim rs As New DataSet()
        Dim rsDataTable As DataTable
        Dim rsRow As DataRow

        intRecordID_Mail = SqlHelper.GetNextNumber("telligent", "tblMail", "intRecordID", connString)

        Dim sql As New StringBuilder()

        sql.Append("SELECT * FROM tblMail WHERE [intRecordID] = -1")

        SqlHelper.ExecuteQuery(sql.ToString(), rs)

        rsDataTable = rs.Tables(0)

        rsRow = rsDataTable.NewRow()

        rsRow("intRecordID") = intRecordID_Mail
        rsRow("ixtCode") = ixtCode
        rsRow("txtDescription") = txtDescription

        rsRow("intRecordID_Company") = Constants.DEFAULT_VALUE_INTRECORDID_COMPANY
        rsRow("intRecordID_Division") = Constants.DEFAULT_VALUE_INTRECORDID_DIVISION
        rsRow("intRecordID_DatabaseID") = Constants.DEFAULT_VALUE_INTRECORDID_DATABASEID

        rsRow("intRecordID_MailType") = intRecordID_MailType
        rsRow("intRecordID_MailStatus") = intRecordID_MailStatus
        rsRow("intRecordID_MailRouting") = intRecordID_MailRouting
        rsRow("intRecordID_Contact") = intRecordID_Contact

        If intRecordID_MemoTemplate.HasValue Then
            rsRow("intRecordID_MemoTemplate") = intRecordID_MemoTemplate.Value
        Else
            rsRow("intRecordID_MemoTemplate") = DBNull.Value
        End If
        If intRecordID_MailFolder.HasValue Then
            rsRow("intRecordID_MailFolder") = intRecordID_MailFolder.Value
        Else
            rsRow("intRecordID_MailFolder") = DBNull.Value
        End If
        rsRow("intRecordID_User_Creation") = intRecordID_User_Creation.Value
        rsRow("txtEmailFrom") = txtEmailFrom
        rsRow("mmoEmailTo") = mmoEmailTo

        If Not String.IsNullOrWhiteSpace(mmoEMailCC) Then
            rsRow("mmoEMailCC") = mmoEMailCC
        Else
            rsRow("mmoEMailCC") = DBNull.Value
        End If
        If Not String.IsNullOrWhiteSpace(mmoEMailBcc) Then
            rsRow("mmoEMailBcc") = mmoEMailBcc
        Else
            rsRow("mmoEMailBcc") = DBNull.Value
        End If
        rsRow("txtSubject") = txtSubject
        rsRow("mmoBody") = mmoBody
        If Not String.IsNullOrWhiteSpace(mmoAttachment) Then
            rsRow("mmoAttachment") = mmoAttachment
        Else
            rsRow("mmoAttachment") = DBNull.Value
        End If
        rsRow("blnActive") = "Yes"
        rsRow("blnAttachment") = "No"
        rsRow("blnDeleted") = "No"
        rsRow("blnHighlight") = "No"
        rsRow("blnMemo") = "No"
        rsRow("blnProcess") = "No"
        rsRow("blnProject") = "No"
        rsRow("txtRecordCreationUser") = "system" ' Session("UserName")
        rsRow("dteRecordCreationDate") = Now()
        rsRow("txtGUID") = Guid.NewGuid().ToString()

        rsDataTable.Rows.Add(rsRow)

        SqlHelper.InsertQuery("Select * From [dbo].[tblMail] where [intrecordid] = -1", rs, connString)
    End Sub

    Public Shared Sub InsertMailDetails(ByRef intRecordID_MailDetail As Long?, ByRef ixtCode As String, ByVal txtTableName As String,
        ByVal intRecordIDTable As Long?, ByVal intRecordID_Mail As Long?, ByVal intRecordID_MailContentType As Long?,
        ByVal intRecordID_MailType As Long?, ByVal intRecordID_MailStatus As Long?, ByVal intRecordID_MailRouting As Long?,
                                        ByVal intRecordID_Contact As Long?, ByVal intRecordID_DatabaseID As Long?,
                                        Optional ByVal connString As String = "")

        On Error GoTo CapError

        intRecordID_MailDetail = ReplaceNullValueToLong(intRecordID_MailDetail, 0)
        intRecordIDTable = ReplaceNullValueToLong(intRecordIDTable, 0)
        intRecordID_Mail = ReplaceNullValueToLong(intRecordID_Mail, 0)
        intRecordID_MailContentType = ReplaceNullValueToLong(intRecordID_MailContentType, 0)
        intRecordID_MailType = ReplaceNullValueToLong(intRecordID_MailType, 2) ' Email=1,SMS Text=2,Text=3
        intRecordID_Contact = ReplaceNullValueToLong(intRecordID_Contact, 0)
        intRecordID_MailStatus = ReplaceNullValueToLong(intRecordID_MailStatus, 1) ' Pending/Waiting=1,Sent/Delivered=2,Failed/NotDelivered=3
        intRecordID_MailRouting = ReplaceNullValueToLong(intRecordID_MailRouting, 2) ' Inbound=1,Outbound=2

        If ixtCode = "0" Then

            ixtCode = SqlHelper.GetNextNumber("telligent", "tblMailDetail", "ixtCode", connString)
        End If

        Dim rs As New DataSet()
        Dim rsDataTable As DataTable
        Dim rsRow As DataRow

        intRecordID_MailDetail = SqlHelper.GetNextNumber("telligent", "tblMailDetail", "intRecordID", connString)

        Dim SqlS As String = "Select * FROM tblMailDetail " ' "Select intRecordID, ixtCode FROM tblMailDetail "

        SqlS = SqlS & "WHERE intRecordID = " & intRecordID_Mail & " " & vbCrLf

        SqlHelper.ExecuteQuery(SqlS, rs)

        rsDataTable = rs.Tables(0)

        rsRow = rsDataTable.NewRow()

        On Error GoTo RedoAdd
RedoAdd:
        'intRecordID_MailDetail = getNextNumber("telligent", "tblMailDetail", "intRecordID", "", 0, "", 0, "InsertMailDetail(2)")
        intRecordID_MailDetail = SqlHelper.GetNextNumber("telligent", "tblMailDetail", "intRecordID", connString)
        rsRow("intRecordID") = intRecordID_MailDetail
        rsRow("ixtCode") = ixtCode

        rsRow("intRecordID_Company") = Constants.DEFAULT_VALUE_INTRECORDID_COMPANY ' Session("intRecordID_Company")
        rsRow("intRecordID_Division") = Constants.DEFAULT_VALUE_INTRECORDID_DIVISION ' Session("intRecordID_Division")
        rsRow("intRecordID_DatabaseID") = Constants.DEFAULT_VALUE_INTRECORDID_DATABASEID ' Session("intRecordID_DatabaseID")

        If Not String.IsNullOrWhiteSpace(txtTableName) Then
            If Len(txtTableName) > 0 Then
                rsRow("txtTableName") = txtTableName
            Else
                rsRow("txtTableName") = ""
            End If
        Else
            rsRow("txtTableName") = ""
        End If

        rsRow("intRecordIDTable") = intRecordIDTable
        rsRow("intRecordID_Mail") = intRecordID_Mail
        rsRow("intRecordID_MailType") = intRecordID_MailType
        rsRow("intRecordID_MailStatus") = intRecordID_MailStatus
        rsRow("intRecordID_MailRouting") = intRecordID_MailRouting
        rsRow("intRecordID_Contact") = intRecordID_Contact
        rsRow("blnActive") = "Yes"
        rsRow("blnAttachment") = "No"
        rsRow("blnDeleted") = "No"
        rsRow("blnHighlight") = "No"
        rsRow("blnMemo") = "No"
        rsRow("blnProcess") = "No"
        rsRow("blnProject") = "No"
        rsRow("txtRecordCreationUser") = "ROCKET Messenger"
        rsRow("dteRecordCreationDate") = Now()
        rsRow("txtGUID") = Guid.NewGuid().ToString()

        rsDataTable.Rows.Add(rsRow)

        SqlHelper.InsertQuery("Select * From [dbo].[tblMailDetail] where [intrecordid] = -1", rs, connString)
        Exit Sub
CapError:
        Dim txtErrorNumber As String
        txtErrorNumber = Err.Number
        If txtErrorNumber <> 0 Then
            Dim txtErrorDescription As String, txtErrorSource As String, txtErrorLine As String
            txtErrorDescription = Err.Description
            txtErrorLine = Erl()
            txtErrorSource = Err.Source
            ''CODE CHANGE 030106 - pass Err.Description as txtActualError
            'Call InsertErrorLog(Session, Request, Response, "", 0, txtErrorNumber, txtErrorSource, txtErrorDescription, txtErrorLine, Request.ServerVariables("SCRIPT_NAME") & "?" & Request.ServerVariables("QUERY_STRING"), "list", "No", "Application Error", "InsertMailDetail", "", Err.Description, "", "")
            ''Resume Next
            'If Session("blnShowPageErrorMessageOntheWeb") = "Yes" Then
            '    Response.Write "InsertMailDetail Error Source=" & txtErrorSource & ", encountered: " & vbCrLf & txtErrorNumber & ", " & txtErrorDescription & "<br>"
            'End If
        End If
    End Sub

    Public Shared Function ReplaceNullValueToLong(ByVal theValue As Long?, ByVal defValue As Long) As Long
        If theValue.HasValue Then
            Return theValue.Value
        Else
            Return defValue
        End If
    End Function

End Class
