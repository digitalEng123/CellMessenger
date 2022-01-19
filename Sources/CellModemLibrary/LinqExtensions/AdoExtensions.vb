
Namespace LinqExtensions

    Public Module AdoExtensions

        <System.Runtime.CompilerServices.Extension()>
        Public Function GetColumnInfoDataRow(ByVal schema As DataTable, ByVal columnName As String)

            Dim dataRowObject As DataRow = Nothing

            Dim maxColumnIndex As Integer = schema.Rows.Count
            For columnIndex As Integer = 0 To (maxColumnIndex - 1)

                Dim dr As DataRow = schema.Rows(columnIndex)

                If CStr(dr("ColumnName")) = columnName Then

                    dataRowObject = dr

                    Exit For
                End If
            Next

            Return dataRowObject
        End Function


    End Module

End Namespace

