Imports System.Linq
Imports System.Reflection

Namespace LinqExtensions

    Public Module KeywordExtensions

        Public Function ContainedInBlackListedTemplate(ByVal tableShortName As String, ByVal lstBlackListedTemplateNames As String(), ByVal theFieldName As String)

            Dim contained As Boolean = False

            For Each blackListedTemplate As String In lstBlackListedTemplateNames

                Dim fieldName As String = String.Format(blackListedTemplate, tableShortName)

                If fieldName.Equals(theFieldName) Then
                    contained = True
                    Exit For
                End If
            Next

            Return contained
        End Function

        <System.Runtime.CompilerServices.Extension>
        Public Function GetDataFieldsForKeywords(ByVal caller As Object) As String()

            Dim lstFieldsNames As New List(Of String)

            Dim blackListedFieldsName() As String = {"txtElectronicDataExchangeCode", "lblCalendarReminder", "dteFollowUpDate",
                "txtEventStartTime", "txtEventEndTime", "blnMakePrivate", "blnActive", "blnCursor", "blnAttachment", "blnDeleted", "blnHighlight", "blnMemo",
                "blnProcess", "blnProject", "intRecordID_ErrorLog", "intRecordID_Status", "blnPrint", "dteRecordSynchronization", "blnWebSearch",
                "blnSecurity", "blnErrorLog", "blnFavorite", "blnAuditTrail", "txtFieldValueGenerator", "blnSystemRecord", "blnEcommerceTransmit",
                                                     "txtGUID", "IsNew"}

            Dim blackListedFieldsNameTemplates() As String = {"lbl{0}Information", "lbl{0}", "lbl{0}RecordInformation",
                "lblRETS{0}Information", "lblRETS{0}", "lblRETS{0}RecordInformation"}

            blackListedFieldsName = blackListedFieldsName.Select(Function(o) o.ToLower()).ToArray()
            blackListedFieldsNameTemplates = blackListedFieldsNameTemplates.Select(Function(o) o.ToLower()).ToArray()

            Dim type As Type = caller.GetType()

            For Each prop As PropertyInfo In type.GetProperties()

                Dim propNameLowered As String = prop.Name.ToLower()

                If Not blackListedFieldsName.Contains(propNameLowered) And Not ContainedInBlackListedTemplate(
                    type.Name.Replace("tblRETS", "").Replace("tbl", ""), blackListedFieldsNameTemplates, propNameLowered) Then

                    lstFieldsNames.Add(prop.Name)
                End If
            Next

            Return lstFieldsNames.ToArray()
        End Function

        <System.Runtime.CompilerServices.Extension>
        Public Function GetDataFieldsForKeywords(ByVal caller As DataTable) As String()

            Dim lstFieldsNames As New List(Of String)

            Dim blackListedFieldsName() As String = {"txtElectronicDataExchangeCode", "lblCalendarReminder", "dteFollowUpDate",
                "txtEventStartTime", "txtEventEndTime", "blnMakePrivate", "blnActive", "blnCursor", "blnAttachment", "blnDeleted", "blnHighlight", "blnMemo",
                "blnProcess", "blnProject", "intRecordID_ErrorLog", "intRecordID_Status", "blnPrint", "dteRecordSynchronization", "blnWebSearch",
                "blnSecurity", "blnErrorLog", "blnFavorite", "blnAuditTrail", "txtFieldValueGenerator", "blnSystemRecord", "blnEcommerceTransmit",
                                                     "txtGUID", "IsNew"}

            Dim blackListedFieldsNameTemplates() As String = {"lbl{0}Information", "lbl{0}", "lbl{0}RecordInformation",
                "lblRETS{0}Information", "lblRETS{0}", "lblRETS{0}RecordInformation"}

            Dim type As Type = caller.GetType()

            For Each objDataColumn As DataColumn In caller.Columns

                If Not blackListedFieldsName.Contains(objDataColumn.ColumnName) And Not ContainedInBlackListedTemplate(
                    type.Name.Replace("tblRETS", "").Replace("tbl", ""), blackListedFieldsNameTemplates, objDataColumn.ColumnName) Then

                    lstFieldsNames.Add(objDataColumn.ColumnName)
                End If
            Next

            Return lstFieldsNames.ToArray()
        End Function

        <System.Runtime.CompilerServices.Extension>
        Public Function GetConstants(ByVal type As Type) As IEnumerable(Of FieldInfo)

            '' Gets all public and static fields
            '' BindingFlags.Public | BindingFlags.Static | 
            '' This tells it to get the fields from all base types as well
            Dim fieldInfos = type.GetFields(BindingFlags.Public Or BindingFlags.Static Or BindingFlags.FlattenHierarchy)

            '' IsLiteral determines if its value is written at 
            ''   compile time and not changeable
            '' IsInitOnly determine if the field can be set 
            ''   in the body of the constructor
            '' for C# a field which is readonly keyword would have both true 
            ''   but a const field would have only IsLiteral equal to true
            Return fieldInfos.Where(Function(fi) fi.IsLiteral AndAlso (Not fi.IsInitOnly))
        End Function

        <System.Runtime.CompilerServices.Extension>
        Public Function GetConstantsValues(Of T As Class)(ByVal type As Type) As IEnumerable(Of T)
            Dim fieldInfos = GetConstants(type)

            Return fieldInfos.Select(Function(fi) TryCast(fi.GetRawConstantValue(), T))
        End Function

    End Module

End Namespace
