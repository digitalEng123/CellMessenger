Imports System
Imports System.Text
Imports System.Data
Imports System.Data.OleDb

Public Class SqlHelper

    ''' <summary>
    ''' Execute a scaler query againat the database, and return the results.
    ''' </summary>
    ''' <param name="sql"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function ExecuteScaler(ByVal sql As String, Optional ByVal connString As String = "") As Object

        Dim returnValue As Object

        Dim sqlConnString = ""

        If Not String.IsNullOrWhiteSpace(connString) Then
            sqlConnString = connString
        Else
            sqlConnString = System.Configuration.ConfigurationManager.ConnectionStrings("MSSQLCONNSTR1_OLEDB").ConnectionString
        End If

        Using cn As New OleDbConnection(sqlConnString)

            cn.Open()

            Using cm = cn.CreateCommand()

                cm.CommandType = CommandType.Text
                cm.CommandText = sql

                returnValue = cm.ExecuteScalar()
            End Using
        End Using

        Return returnValue
    End Function

    Public Shared Function ExecuteQuery(ByVal sql As String, ByRef ds As DataSet, Optional ByVal connString As String = "") As Boolean

        Dim returnValue As Boolean = False

        Dim sqlConnString = ""

        If Not String.IsNullOrWhiteSpace(connString) Then
            sqlConnString = connString
        Else
            sqlConnString = System.Configuration.ConfigurationManager.ConnectionStrings("MSSQLCONNSTR1_OLEDB").ConnectionString
        End If

        Using cn As New OleDbConnection(sqlConnString)

            cn.Open()

            Using cm As OleDbCommand = cn.CreateCommand()

                cm.CommandType = CommandType.Text
                cm.CommandText = sql

                Using da As New OleDbDataAdapter(cm)

                    Dim rowsAffected As Integer = da.Fill(ds)

                    returnValue = (rowsAffected > 0)
                End Using
            End Using
        End Using

        Return returnValue
    End Function

    ''' <summary>
    ''' 'Execute a non scaler query agaianst the database.
    ''' </summary>
    ''' <param name="sql"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function ExecuteNonQuery(ByVal sql As String, Optional ByVal connString As String = "") As Boolean

        Dim returnValue As Boolean = False

        Dim sqlConnString = ""

        If Not String.IsNullOrWhiteSpace(connString) Then
            sqlConnString = connString
        Else
            sqlConnString = System.Configuration.ConfigurationManager.ConnectionStrings("MSSQLCONNSTR1_OLEDB").ConnectionString
        End If

        Using cn As New OleDbConnection(sqlConnString)

            cn.Open()

            Using cm = cn.CreateCommand()

                cm.CommandType = CommandType.Text
                cm.CommandText = sql

                Dim rowsAffected As Integer = cm.ExecuteNonQuery()

                returnValue = (rowsAffected > 0)
            End Using
        End Using

        Return returnValue
    End Function

    Public Shared Function InsertQuery(ByVal sql As String, ByRef dsInsert As DataSet, Optional ByVal connString As String = "") As Boolean

        Dim returnValue As Boolean = False

        Dim sqlConnString = System.Configuration.ConfigurationManager.ConnectionStrings("MSSQLCONNSTR1_OLEDB").ConnectionString

        Using cn As New OleDbConnection(sqlConnString)

            Using cm As OleDbCommand = cn.CreateCommand()

                Dim sbSql As New StringBuilder()

                If sql.Contains("*") Then

                    Dim columnNames As List(Of String) = GetListColumns(dsInsert.Tables(0))

                    sbSql.Append(sql.Replace("*", String.Join(",", columnNames.ToArray())))
                Else
                    sbSql.Append(sql)
                End If

                cm.CommandType = CommandType.Text
                cm.CommandText = sbSql.ToString()

                Using da As New OleDbDataAdapter(cm)

                    Dim dsSelect As New DataSet()

                    Dim builder As OleDbCommandBuilder = New OleDbCommandBuilder(da)

                    Dim rowsAffected As Integer = da.Fill(dsSelect)

                    da.InsertCommand = builder.GetInsertCommand()

                    rowsAffected = da.Update(dsInsert)

                    returnValue = (rowsAffected > 0)
                End Using
            End Using
        End Using

        Return returnValue
    End Function

    Public Shared Function InsertQuery(ByVal cn As OleDbConnection, ByVal sql As String, ByRef dsInsert As DataSet) As Boolean

        Dim returnValue As Boolean = False

        Using cm As OleDbCommand = cn.CreateCommand()

            Dim sbSql As New StringBuilder()

            If sql.Contains("*") Then

                Dim columnNames As List(Of String) = GetListColumns(dsInsert.Tables(0))

                sbSql.Append(sql.Replace("*", String.Join(",", columnNames.ToArray())))
            Else
                sbSql.Append(sql)
            End If

            cm.CommandType = CommandType.Text
            cm.CommandText = sbSql.ToString()

            Using da As New OleDbDataAdapter(cm)

                Dim dsSelect As New DataSet()

                Dim builder As OleDbCommandBuilder = New OleDbCommandBuilder(da)

                Dim rowsAffected As Integer = da.Fill(dsSelect)

                da.InsertCommand = builder.GetInsertCommand()

                rowsAffected = da.Update(dsInsert)

                returnValue = (rowsAffected > 0)
            End Using
        End Using

        Return returnValue
    End Function

    Public Shared Function UpdateQuery(ByVal sql As String, ByRef dsUpdate As DataSet) As Boolean

        Dim returnValue As Boolean = False

        Dim sqlConnString As String = System.Configuration.ConfigurationManager.ConnectionStrings("MSSQLCONNSTR1_OLEDB").ConnectionString

        Using cn As New OleDbConnection(sqlConnString)

            cn.Open()

            Using cm As OleDbCommand = cn.CreateCommand()

                Dim sbSql As New StringBuilder()

                If sql.Contains("*") Then

                    Dim columnNames As List(Of String) = GetListColumns(dsUpdate.Tables(0))

                    sbSql.Append(sql.Replace("*", String.Join(",", columnNames.ToArray())))
                Else
                    sbSql.Append(sql)
                End If

                cm.CommandType = CommandType.Text
                cm.CommandText = sbSql.ToString()

                Using da As New OleDbDataAdapter(cm)

                    Dim dsSelect As New DataSet()

                    Dim builder As OleDbCommandBuilder = New OleDbCommandBuilder(da)

                    Dim rowsAffected As Integer = da.Fill(dsSelect)

                    da.UpdateCommand = builder.GetUpdateCommand()

                    rowsAffected = da.Update(dsUpdate)

                    returnValue = (rowsAffected > 0)
                End Using
            End Using
        End Using

        Return returnValue
    End Function

    Public Shared Function UpdateQuery(ByVal sql As String, ByRef dsUpdate As DataTable) As Boolean

        Dim returnValue As Boolean = False

        Dim sqlConnString As String = System.Configuration.ConfigurationManager.ConnectionStrings("c").ConnectionString

        Using cn As New OleDbConnection(sqlConnString)

            cn.Open()

            Using cm As OleDbCommand = cn.CreateCommand()

                Dim sbSql As New StringBuilder()

                If sql.Contains("*") Then

                    Dim columnNames As List(Of String) = GetListColumns(dsUpdate)

                    sbSql.Append(sql.Replace("*", String.Join(",", columnNames.ToArray())))
                Else
                    sbSql.Append(sql)
                End If

                cm.CommandType = CommandType.Text
                cm.CommandText = sbSql.ToString()

                Using da As New OleDbDataAdapter(cm)

                    Dim dsSelect As New DataSet()

                    Dim builder As OleDbCommandBuilder = New OleDbCommandBuilder(da)

                    Dim rowsAffected As Integer = da.Fill(dsSelect)

                    da.UpdateCommand = builder.GetUpdateCommand()

                    rowsAffected = da.Update(dsUpdate)

                    returnValue = (rowsAffected > 0)
                End Using
            End Using
        End Using

        Return returnValue
    End Function

    Public Shared Function UpdateQuery(ByVal cn As OleDbConnection, ByVal sql As String, ByRef dsUpdate As DataSet) As Boolean

        Dim returnValue As Boolean = False

        Using cm As OleDbCommand = cn.CreateCommand()

            Dim sbSql As New StringBuilder()

            If sql.Contains("*") Then

                Dim columnNames As List(Of String) = GetListColumns(dsUpdate.Tables(0))

                sbSql.Append(sql.Replace("*", String.Join(",", columnNames.ToArray())))
            Else
                sbSql.Append(sql)
            End If

            cm.CommandType = CommandType.Text
            cm.CommandText = sbSql.ToString()

            Using da As New OleDbDataAdapter(cm)

                Dim dsSelect As New DataSet()

                Dim builder As OleDbCommandBuilder = New OleDbCommandBuilder(da)

                Dim rowsAffected As Integer = da.Fill(dsSelect)

                da.UpdateCommand = builder.GetUpdateCommand()

                rowsAffected = da.Update(dsUpdate)

                returnValue = (rowsAffected > 0)
            End Using
        End Using

        Return returnValue
    End Function

    Public Shared Function UpdateQuery(ByVal cn As OleDbConnection, ByVal sql As String,
        ByRef dsUpdate As DataTable) As Boolean

        Dim returnValue As Boolean = False

        Using cm As OleDbCommand = cn.CreateCommand()

            Dim sbSql As New StringBuilder()

            If sql.Contains("*") Then

                Dim columnNames As List(Of String) = GetListColumns(dsUpdate)

                sbSql.Append(sql.Replace("*", String.Join(",", columnNames.ToArray())))
            Else
                sbSql.Append(sql)
            End If

            cm.CommandType = CommandType.Text
            cm.CommandText = sbSql.ToString()

            Using da As New OleDbDataAdapter(cm)

                Dim dsSelect As New DataSet()

                Dim builder As OleDbCommandBuilder = New OleDbCommandBuilder(da)

                da.Fill(dsSelect)

                Dim rowsAffected As Integer = 0

                If dsSelect.Tables(0).Columns.Contains("intRecordID") And dsSelect.Tables(0).PrimaryKey.Length = 0 Then

                    dsSelect.Tables(0).PrimaryKey = New DataColumn() {
                        dsSelect.Tables(0).Columns("intRecordID")}
                End If
                If dsUpdate.Columns.Contains("intRecordID") And dsUpdate.PrimaryKey.Length = 0 Then

                    dsUpdate.PrimaryKey = New DataColumn() {
                        dsUpdate.Columns("intRecordID")}
                End If

                dsSelect.Tables(0).TableName = dsUpdate.TableName

                Dim lstPrimaryKeys As List(Of String) = New List(Of String)

                lstPrimaryKeys.AddRange(New String() {"intRecordID"})

                Using updateCommand As OleDbCommand = GetUpdateCommand(dsSelect.Tables(0), lstPrimaryKeys)

                    updateCommand.Connection = cn

                    For Each row As DataRow In dsUpdate.Rows

                        PopulateoledbcommandParameterValues(updateCommand, row)

                        rowsAffected += updateCommand.ExecuteNonQuery()
                    Next
                End Using

                returnValue = (rowsAffected > 0)
            End Using
        End Using

        Return returnValue
    End Function

    Public Shared Function GetNextNumber(ByVal databaseName As String, ByVal tableName As String, ByVal columnName As String,
                                         Optional ByVal connString As String = "") As Long

        Dim sql As New StringBuilder()

        sql.AppendFormat("select max([{0}]) from [{1}].[dbo].[{2}]", columnName, databaseName, tableName)

        Dim rtnValue As Object = ExecuteScaler(sql.ToString(), connString)

        If Not System.Convert.IsDBNull(rtnValue) Then
            Return (CLng(rtnValue) + 1)
        Else
            Return 0L
        End If
    End Function

    Public Shared Function GetOleDbSchemaTable(ByVal sqlConnString As String, ByVal tableName As String) As DataTable

        Dim schemaDataTable As DataTable = Nothing

        Using cn As New OleDbConnection(sqlConnString)

            cn.Open()

            Using cmd As OleDbCommand = cn.CreateCommand()

                cmd.CommandText = String.Format("select top 1 * from [{0}]", tableName)
                cmd.CommandType = CommandType.Text

                Using myReader As OleDbDataReader = cmd.ExecuteReader(CommandBehavior.KeyInfo)

                    'Retrieve column schema into a DataTable.
                    schemaDataTable = myReader.GetSchemaTable()

                    'Always close the DataReader and connection.
                    myReader.Close()
                    cn.Close()
                End Using
            End Using
        End Using

        Return schemaDataTable
    End Function

    Public Shared Function GetSqlSchemaTable(ByVal sqlConnString As String, ByVal tableName As String) As DataTable

        Dim schemaDataTable As DataTable = Nothing

        Using cn As New System.Data.SqlClient.SqlConnection(sqlConnString)

            cn.Open()

            Using cmd As System.Data.SqlClient.SqlCommand = cn.CreateCommand()

                cmd.CommandText = String.Format("select top 1 * from [{0}]", tableName)
                cmd.CommandType = CommandType.Text

                Using myReader As System.Data.SqlClient.SqlDataReader = cmd.ExecuteReader(CommandBehavior.KeyInfo)

                    'Retrieve column schema into a DataTable.
                    schemaDataTable = myReader.GetSchemaTable()

                    'Always close the DataReader and connection.
                    myReader.Close()
                    cn.Close()
                End Using
            End Using
        End Using

        Return schemaDataTable
    End Function

    ''' <summary>
    ''' Get string value if any.
    ''' </summary>
    ''' <param name="value"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function GetValueIfAny(ByVal value As String) As Object

        If Not String.IsNullOrEmpty(value) Then
            Return value
        Else
            Return DBNull.Value
        End If
    End Function

    ''' <summary>
    ''' Get integer value if any.
    ''' </summary>
    ''' <param name="value"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function GetValueIfAny(ByVal value As Nullable(Of Integer)) As Object

        If value.HasValue Then
            Return value.Value
        Else
            Return DBNull.Value
        End If
    End Function

    ''' <summary>
    ''' Get double value if any.
    ''' </summary>
    ''' <param name="value"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function GetValueIfAny(ByVal value As Nullable(Of Double)) As Object

        If value.HasValue Then
            Return value.Value
        Else
            Return DBNull.Value
        End If
    End Function

    ''' <summary>
    ''' Get date value if any.
    ''' </summary>
    ''' <param name="value"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function GetValueIfAny(ByVal value As Nullable(Of Date)) As Object

        If value.HasValue Then
            Return value.Value
        Else
            Return DBNull.Value
        End If
    End Function

    ''' <summary>
    ''' Get date value if any.
    ''' </summary>
    ''' <param name="value"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function GetValueIfAny(ByVal value As Nullable(Of Guid)) As Object

        If value.HasValue Then

            If value.Value <> Guid.Empty Then
                Return value.Value
            Else
                Return DBNull.Value
            End If
        Else
            Return DBNull.Value
        End If
    End Function

    Public Shared Function ConvertValueToStringFormat(ByVal value As Object, ByVal frmt As String) As Object

        If IsNothing(value) Then
            Return DBNull.Value
        End If

        If TypeOf (value) Is Date Then
            Return CDate(value).ToString(frmt)
        ElseIf TypeOf (value) Is Double Then
            Return CDbl(value).ToString(frmt)
        ElseIf TypeOf (value) Is Integer Then
            Return CInt(value).ToString(frmt)
        End If

        Return DBNull.Value
    End Function

    Public Shared Function GetDataItems(ByVal sql As String) As List(Of DataItem)

        Dim returnValue As New List(Of DataItem)

        Dim sqlConnString = System.Configuration.ConfigurationManager.ConnectionStrings("MSSQLCONNSTR1").ConnectionString

        Using cn As New OleDbConnection(sqlConnString)

            cn.Open()

            Using cm = cn.CreateCommand()

                cm.CommandType = CommandType.Text
                cm.CommandText = sql

                Using dr As OleDbDataReader = cm.ExecuteReader()

                    While dr.Read()

                        Dim valueMember As Object = dr("ValueMember")
                        Dim displayMember As String = dr("DisplayMember")

                        Dim objDataItem As New DataItem(displayMember, valueMember)

                        returnValue.Add(objDataItem)
                    End While
                End Using

            End Using
        End Using

        Return returnValue
    End Function

    Public Shared Function GetDataItems(ByVal sql As String, ByVal valueColumnName As String, ByVal displayColumnName As String) As List(Of DataItem)

        Dim returnValue As New List(Of DataItem)

        Dim sqlConnString = System.Configuration.ConfigurationManager.ConnectionStrings("MSSQLCONNSTR1").ConnectionString

        Using cn As New OleDbConnection(sqlConnString)

            cn.Open()

            Using cm = cn.CreateCommand()

                cm.CommandType = CommandType.Text
                cm.CommandText = sql

                Using dr As OleDbDataReader = cm.ExecuteReader()

                    While dr.Read()

                        Dim valueMember As Object = dr(valueColumnName)
                        Dim displayMember As String = dr(displayColumnName)

                        Dim objDataItem As New DataItem(displayMember, valueMember)

                        returnValue.Add(objDataItem)
                    End While
                End Using

            End Using
        End Using

        Return returnValue
    End Function

    ''' <summary>
    ''' Trunicate string value is value is not DbNull, and or nothing
    ''' </summary>
    ''' <param name="value"></param>
    ''' <param name="length"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Shared Function TrunicateValueIfAny(ByVal value As Object, ByVal length As Integer) As Object

        Dim theNewValue As Object = value

        If TypeOf (value) Is String Then

            Dim strValue As String = CStr(value)

            If strValue.Length > length Then
                theNewValue = strValue.Substring(0, length)
            End If
        End If

        Return theNewValue
    End Function

    Public Shared Function GetListColumns(ByVal dt As DataTable) As List(Of String)

        Dim rtnList As New List(Of String)

        For index As Integer = 0 To dt.Columns.Count - 1

            Dim tableName As String = dt.Columns(index).ColumnName

            rtnList.Add(tableName)
        Next

        Return rtnList
    End Function

    Public Shared Function GetUpdateCommand(ByVal dt As DataTable,
                                           ByVal lstPrimaryKeys As List(Of String)) As OleDbCommand

        Dim cm As New OleDbCommand()

        Dim sbUpdateSql As New StringBuilder()
        Dim sbUpdateSql_WhereClause As New StringBuilder()

        'Dim columns As New List(Of DataColumn)
        Dim maxColumnIndex As Integer = dt.Columns.Count - 1
        For columnIndex As Integer = 0 To maxColumnIndex

            Dim column As DataColumn = dt.Columns(columnIndex)

            If Not lstPrimaryKeys.Contains(column.ColumnName) Then

                If sbUpdateSql.Length = 0 Then
                    sbUpdateSql.AppendFormat("UPDATE {0} SET ", dt.TableName)
                    sbUpdateSql.AppendFormat("[{0}]=@{1}", column.ColumnName, column.ColumnName)
                Else
                    sbUpdateSql.AppendFormat(",[{0}]=@{1}", column.ColumnName, column.ColumnName)
                End If

                Dim sqldbtype As SqlDbType = GetSqlDbType(column.DataType, column.MaxLength)

                Dim parm As New OleDbParameter(String.Format("@{0}",
                    column.ColumnName), sqldbtype)

                If column.AllowDBNull Then
                    parm.Value = DBNull.Value
                End If

                cm.Parameters.Add(parm)
            Else

                If sbUpdateSql_WhereClause.Length = 0 Then
                    sbUpdateSql_WhereClause.AppendFormat(" WHERE [{0}]=@{1} ", column.ColumnName, column.ColumnName)
                Else
                    sbUpdateSql_WhereClause.AppendFormat("and [{0}]=@{1} ", column.ColumnName, column.ColumnName)
                End If

                Dim sqldbtype As SqlDbType = GetSqlDbType(column.DataType, column.MaxLength)

                Dim parm As New OleDbParameter(String.Format("@{0}",
                    column.ColumnName), sqldbtype)

                If column.AllowDBNull Then
                    parm.Value = DBNull.Value
                End If

                cm.Parameters.Add(parm)
            End If
        Next

        cm.CommandType = CommandType.Text
        cm.CommandText = String.Concat(sbUpdateSql.ToString(), sbUpdateSql_WhereClause.ToString())

        Return cm
    End Function

    Public Shared Function GetSqlDbType(ByVal type As System.Type, ByVal length As Integer) As SqlDbType

        If type Is GetType(String) Then

            If (length = -1) Then
                Return SqlDbType.VarChar
            ElseIf (length > 255) Then
                Return SqlDbType.VarChar
            End If
        ElseIf type Is GetType(Boolean) Then
            Return SqlDbType.Bit
        ElseIf type Is GetType(Integer) Then
            Return SqlDbType.Int
        ElseIf type Is GetType(Long) Then
            Return SqlDbType.BigInt
        ElseIf type Is GetType(Short) Then
            Return SqlDbType.TinyInt
        ElseIf type Is GetType(Double) Then
            Return SqlDbType.Float
        ElseIf type Is GetType(Date) Then
            Return SqlDbType.DateTime
        ElseIf type Is GetType(DateTime) Then
            Return SqlDbType.DateTime
        ElseIf type Is GetType(Guid) Then
            Return SqlDbType.UniqueIdentifier
        Else
            Return SqlDbType.Variant
        End If

        Return SqlDbType.Variant
    End Function

    Public Shared Sub PopulateoledbcommandParameterValues(ByRef cm As OleDbCommand, ByVal dr As DataRow)

        Dim maxRowIndex As Integer = cm.Parameters.Count - 1
        For rowIndex As Integer = 0 To maxRowIndex

            Dim parm As OleDbParameter = cm.Parameters(rowIndex)

            Dim columnName As String = parm.ParameterName.Replace("@", "")

            parm.Value = dr(columnName)
        Next
    End Sub

End Class
