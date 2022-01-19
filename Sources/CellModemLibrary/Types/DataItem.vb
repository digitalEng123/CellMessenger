Public Class DataItem

    Private ReadOnly m_displayMember As String
    Private ReadOnly m_valueMember As Object

    Public ReadOnly Property DisplayMember() As String
        Get
            Return m_displayMember
        End Get
    End Property

    Public ReadOnly Property ValueMember() As Object
        Get
            Return m_valueMember
        End Get
    End Property

    ''' <summary>
    ''' Constructor #1
    ''' </summary>
    ''' <remarks></remarks>
    Private Sub New()

    End Sub

    ''' <summary>
    ''' Constructor #2
    ''' </summary>
    ''' <param name="displayMember"></param>
    ''' <param name="valueMember"></param>
    ''' <remarks></remarks>
    Public Sub New(ByVal displayMember As String, ByVal valueMember As Object)

        m_displayMember = displayMember
        m_valueMember = valueMember
    End Sub

End Class
