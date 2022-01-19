
Namespace LinqExtensions

    Public Module EnumExtensions

        ''' <summary>
        ''' Gets the name of the enum based on it value.
        ''' </summary>
        ''' <param name="enumVaue">The enum value.</param>
        ''' <returns></returns>
        ''' <remarks></remarks>
        <System.Runtime.CompilerServices.Extension>
        Public Function GetEnumName(ByVal enumVaue As Object) As String
            Return System.Enum.GetName(enumVaue.GetType(), enumVaue)
        End Function

        ''' <summary>
        ''' Get the <seealso cref="System.Enum"/> <seealso cref="System.ComponentModel. DescriptionAttribute"/>.
        ''' </summary>
        ''' <param name="enumValue"></param>
        ''' <param name="defDesc"></param>
        ''' <returns></returns>
        <System.Runtime.CompilerServices.Extension>
        Public Function GetEnumDescription(ByVal enumValue As Object, ByVal defDesc As String) As String
            Dim fi As System.Reflection.FieldInfo = enumValue.GetType().GetField(enumValue.ToString())

            If Nothing IsNot fi Then
                Dim attrs() As Object = fi.GetCustomAttributes(GetType(System.ComponentModel.DescriptionAttribute), True)
                If attrs IsNot Nothing AndAlso attrs.Length > 0 Then
                    Return DirectCast(attrs(0), System.ComponentModel.DescriptionAttribute).Description
                End If
            End If

            Return defDesc
        End Function

        ''' <summary>
        ''' Get enum value from string representation.
        ''' </summary>
        ''' <typeparam name="T">The enum type.</typeparam>
        ''' <param name="value">The enum string value.</param>
        ''' <returns></returns>
        Public Function GetEnumValue(Of T)(ByVal value As String) As T
            Return DirectCast(System.Enum.Parse(GetType(T), value), T)
        End Function

    End Module

End Namespace

