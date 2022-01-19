Imports System.Text
Imports System.Data
Imports System.Data.OleDb

Public Class LookupHelper

    Public Shared Function LookUpTable_GettblMailStatus(ByVal value As String) As Nullable(Of Integer)

        Dim valueLowered As String = value.ToLower()

        Dim lookUpValue = SqlHelper.ExecuteScaler(
            String.Format("select [intRecordID] from [dbo].[tblMailStatus] " _
                & "where [ixtCode] like '%{0}%'", valueLowered))

        If Not IsNothing(lookUpValue) And Not System.Convert.IsDBNull(lookUpValue) Then
            Return CInt(lookUpValue)
        Else
            Return Nothing
        End If
    End Function

    Public Shared Sub Insert_tblMailStatus(ByVal theNewId As Integer, ByVal ixtCode As String, ByVal txtDescription As String)

        Dim theNewIxtCode As String = ixtCode
        Dim theNewTxtDescription As String = txtDescription

        If ixtCode.Length > 50 Then
            theNewIxtCode = ixtCode.Substring(0, 50)
        End If
        If txtDescription.Length > 150 Then
            theNewTxtDescription = txtDescription.Substring(0, 150)
        End If

        Dim sql As New StringBuilder()

        sql.Append("INSERT INTO [dbo].[tblMailStatus] ([intRecordID],[ixtCode],[txtDescription],[intRecordID_DatabaseID],[intRecordID_Company], ")
        sql.Append("[intRecordID_Division],[blnactive],[blnAttachment],[blnSystemRecord],[blnHighlight],[blnMakePrivate],[blnDeleted], ")
        sql.Append("[blnMemo],[blnProject],[blnPrint],[blnWebSearch],[blnSecurity],[blnErrorLog],[blnFavorite],[blnAuditTrail],[blnEcommerceTransmit],[txtRecordCreationUser],[dteRecordCreationDate],[txtGUID]) ")
        sql.AppendFormat(" VALUES ({0}, '{1}', '{2}', 1, 5, 13, 'Yes', 'No', 'Yes', 'No', 'No', 'No', ",
            theNewId, theNewIxtCode, theNewTxtDescription)
        sql.AppendFormat("'No', 'No', 'No', 'No', 'No', 'No', 'No', 'No', 'No', 'system', '{0}', '{1}') ",
             DateTime.Now, Guid.NewGuid())

        SqlHelper.ExecuteNonQuery(sql.ToString())
    End Sub

    Public Shared Function LookUpTable_GettblMessengerDeliveryState(ByVal value As String) As Nullable(Of Integer)

        Dim valueLowered As String = value.ToLower()

        Dim lookUpValue = SqlHelper.ExecuteScaler(
            String.Format("select [intRecordID] from [dbo].[tblMessengerDeliveryState] " _
                & "where [ixtCode] like '%{0}%'", valueLowered))

        If Not IsNothing(lookUpValue) And Not System.Convert.IsDBNull(lookUpValue) Then
            Return CInt(lookUpValue)
        Else
            Return Nothing
        End If
    End Function

    Public Shared Sub Insert_tblMessengerDeliveryState(ByVal theNewId As Integer, ByVal ixtCode As String, ByVal txtDescription As String)

        Dim theNewIxtCode As String = ixtCode
        Dim theNewTxtDescription As String = txtDescription

        If ixtCode.Length > 50 Then
            theNewIxtCode = ixtCode.Substring(0, 50)
        End If
        If txtDescription.Length > 150 Then
            theNewTxtDescription = txtDescription.Substring(0, 150)
        End If

        Dim sql As New StringBuilder()

        sql.Append("INSERT INTO [dbo].[tblMessengerDeliveryState] ([intRecordID],[ixtCode],[txtDescription],[intRecordID_DatabaseID],[intRecordID_Company], ")
        sql.Append("[intRecordID_Division],[blnactive],[blnAttachment],[blnSystemRecord],[blnHighlight],[blnMakePrivate],[blnDeleted], ")
        sql.Append("[blnMemo],[blnProject],[blnPrint],[blnWebSearch],[blnSecurity],[blnErrorLog],[blnFavorite],[blnAuditTrail],[blnEcommerceTransmit],[txtRecordCreationUser],[dteRecordCreationDate],[txtGUID]) ")
        sql.AppendFormat(" VALUES ({0}, '{1}', '{2}', 1, 5, 13, 'Yes', 'No', 'Yes', 'No', 'No', 'No', ",
            theNewId, theNewIxtCode, theNewTxtDescription)
        sql.AppendFormat("'No', 'No', 'No', 'No', 'No', 'No', 'No', 'No', 'No', 'system', '{0}', '{1}') ",
             DateTime.Now, Guid.NewGuid())

        SqlHelper.ExecuteNonQuery(sql.ToString())
    End Sub

    Public Shared Function LookUpTable_GettblMessengerDeliveryCode(ByVal value As String) As Nullable(Of Integer)

        Dim valueLowered As String = value.ToLower()

        Dim lookUpValue = SqlHelper.ExecuteScaler(
            String.Format("select [intRecordID] from [dbo].[tblMessengerDeliveryCode] " _
                & "where [ixtCode] like '%{0}%'", valueLowered))

        If Not IsNothing(lookUpValue) And Not System.Convert.IsDBNull(lookUpValue) Then
            Return CInt(lookUpValue)
        Else
            Return Nothing
        End If
    End Function

    Public Shared Sub Insert_tblMessengerDeliveryCode(ByVal theNewId As Integer, ByVal ixtCode As String, ByVal txtDescription As String)

        Dim theNewIxtCode As String = ixtCode
        Dim theNewTxtDescription As String = txtDescription

        If ixtCode.Length > 50 Then
            theNewIxtCode = ixtCode.Substring(0, 50)
        End If
        If txtDescription.Length > 150 Then
            theNewTxtDescription = txtDescription.Substring(0, 150)
        End If

        Dim sql As New StringBuilder()

        sql.Append("INSERT INTO [dbo].[tblMessengerDeliveryCode] ([intRecordID],[ixtCode],[txtDescription],[intRecordID_DatabaseID],[intRecordID_Company], ")
        sql.Append("[intRecordID_Division],[blnactive],[blnAttachment],[blnSystemRecord],[blnHighlight],[blnMakePrivate],[blnDeleted], ")
        sql.Append("[blnMemo],[blnProject],[blnPrint],[blnWebSearch],[blnSecurity],[blnErrorLog],[blnFavorite],[blnAuditTrail],[blnEcommerceTransmit],[txtRecordCreationUser],[dteRecordCreationDate],[txtGUID]) ")
        sql.AppendFormat(" VALUES ({0}, '{1}', '{2}', 1, 5, 13, 'Yes', 'No', 'Yes', 'No', 'No', 'No', ",
            theNewId, theNewIxtCode, theNewTxtDescription)
        sql.AppendFormat("'No', 'No', 'No', 'No', 'No', 'No', 'No', 'No', 'No', 'system', '{0}', '{1}') ",
             DateTime.Now, Guid.NewGuid())

        SqlHelper.ExecuteNonQuery(sql.ToString())
    End Sub

    Public Shared Function LookUpTable_GettblMailType(ByVal value As String) As Nullable(Of Integer)

        Dim valueLowered As String = value.ToLower()

        Dim lookUpValue = SqlHelper.ExecuteScaler(
            String.Format("select [intRecordID] from [dbo].[tblMailType] " _
                & "where [ixtCode] like '%{0}%'", valueLowered))

        If Not IsNothing(lookUpValue) And Not System.Convert.IsDBNull(lookUpValue) Then
            Return CInt(lookUpValue)
        Else
            Return Nothing
        End If
    End Function

    Public Shared Sub Insert_tblMailType(ByVal theNewId As Integer, ByVal ixtCode As String, ByVal txtDescription As String)

        Dim theNewIxtCode As String = ixtCode
        Dim theNewTxtDescription As String = txtDescription

        If ixtCode.Length > 50 Then
            theNewIxtCode = ixtCode.Substring(0, 50)
        End If
        If txtDescription.Length > 150 Then
            theNewTxtDescription = txtDescription.Substring(0, 150)
        End If

        Dim sql As New StringBuilder()

        sql.Append("INSERT INTO [dbo].[tblMailType] ([intRecordID],[ixtCode],[txtDescription],[intRecordID_DatabaseID],[intRecordID_Company], ")
        sql.Append("[intRecordID_Division],[blnactive],[blnAttachment],[blnSystemRecord],[blnHighlight],[blnMakePrivate],[blnDeleted], ")
        sql.Append("[blnMemo],[blnProject],[blnPrint],[blnWebSearch],[blnSecurity],[blnErrorLog],[blnFavorite],[blnAuditTrail],[blnEcommerceTransmit],[txtRecordCreationUser],[dteRecordCreationDate],[txtGUID]) ")
        sql.AppendFormat(" VALUES ({0}, '{1}', '{2}', 1, 5, 13, 'Yes', 'No', 'Yes', 'No', 'No', 'No', ",
            theNewId, theNewIxtCode, theNewTxtDescription)
        sql.AppendFormat("'No', 'No', 'No', 'No', 'No', 'No', 'No', 'No', 'No', 'system', '{0}', '{1}') ",
             DateTime.Now, Guid.NewGuid())

        SqlHelper.ExecuteNonQuery(sql.ToString())
    End Sub

    Public Shared Function LookUpTable_GettblMailRouting(ByVal value As String) As Nullable(Of Integer)

        Dim valueLowered As String = value.ToLower()

        Dim lookUpValue = SqlHelper.ExecuteScaler(
            String.Format("select [intRecordID] from [dbo].[tblMailRouting] " _
                & "where [ixtCode] like '%{0}%'", valueLowered))

        If Not IsNothing(lookUpValue) And Not System.Convert.IsDBNull(lookUpValue) Then
            Return CInt(lookUpValue)
        Else
            Return Nothing
        End If
    End Function

    Public Shared Sub Insert_tblMailRouting(ByVal theNewId As Integer, ByVal ixtCode As String, ByVal txtDescription As String)

        Dim theNewIxtCode As String = ixtCode
        Dim theNewTxtDescription As String = txtDescription

        If ixtCode.Length > 50 Then
            theNewIxtCode = ixtCode.Substring(0, 50)
        End If
        If txtDescription.Length > 150 Then
            theNewTxtDescription = txtDescription.Substring(0, 150)
        End If

        Dim sql As New StringBuilder()

        sql.Append("INSERT INTO [dbo].[tblMailRouting] ([intRecordID],[ixtCode],[txtDescription],[intRecordID_DatabaseID],[intRecordID_Company], ")
        sql.Append("[intRecordID_Division],[blnactive],[blnAttachment],[blnSystemRecord],[blnHighlight],[blnMakePrivate],[blnDeleted], ")
        sql.Append("[blnMemo],[blnProject],[blnPrint],[blnWebSearch],[blnSecurity],[blnErrorLog],[blnFavorite],[blnAuditTrail],[blnEcommerceTransmit],[txtRecordCreationUser],[dteRecordCreationDate],[txtGUID]) ")
        sql.AppendFormat(" VALUES ({0}, '{1}', '{2}', 1, 5, 13, 'Yes', 'No', 'Yes', 'No', 'No', 'No', ",
            theNewId, theNewIxtCode, theNewTxtDescription)
        sql.AppendFormat("'No', 'No', 'No', 'No', 'No', 'No', 'No', 'No', 'No', 'system', '{0}', '{1}') ",
             DateTime.Now, Guid.NewGuid())

        SqlHelper.ExecuteNonQuery(sql.ToString())
    End Sub

End Class
