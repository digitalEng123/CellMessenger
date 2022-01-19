Public Class Message

#Region "Fields"

    Private m_MessageId As String
    Private m_Index As Integer
    Private m_Delated As Boolean

    Private m_Phone As String
    Private m_SMSC As String
    Private m_TimeStamp As Nullable(Of Date)
    Private m_TimeStampUTC As Nullable(Of DateTime)
    Private m_TimeStampRFC As String
    Private m_TimeZone As Short

    Private m_Status As String
    Private m_Sender As String
    Private m_Sent As String
    Private m_Message As String
    Private m_Alphabet As String
    Private m_Text As String

#End Region

#Region "Properties"

    Public Property MessageId As String
        Get
            Return m_MessageId
        End Get
        Set(value As String)
            m_MessageId = value
        End Set
    End Property

    Public Property Index() As Integer
        Get
            Return m_Index
        End Get
        Set(ByVal value As Integer)
            m_Index = value
        End Set
    End Property

    Public Property Status() As String
        Get
            Return m_Status
        End Get
        Set(ByVal value As String)
            m_Status = value
        End Set
    End Property

    Public Property Sender() As String
        Get
            Return m_Sender
        End Get
        Set(ByVal value As String)
            m_Sender = value
        End Set
    End Property

    Public Property Sent() As String
        Get
            Return m_Sent
        End Get
        Set(ByVal value As String)
            m_Sent = value
        End Set
    End Property

    Public Property Alphabet() As String
        Get
            Return m_Alphabet
        End Get
        Set(ByVal value As String)
            m_Alphabet = value
        End Set
    End Property

    Public Property Text() As String
        Get
            Return m_Text
        End Get
        Set(ByVal value As String)
            m_Text = value
        End Set
    End Property

    Public Property Deleted() As Boolean
        Get
            Return m_Delated
        End Get
        Set(ByVal value As Boolean)
            m_Delated = value
        End Set
    End Property

    Public Property Phone() As String
        Get
            Return m_Phone
        End Get
        Set(ByVal value As String)
            m_Phone = value
        End Set
    End Property

    Public Property SMSC() As String
        Get
            Return m_SMSC
        End Get
        Set(ByVal value As String)
            m_SMSC = value
        End Set
    End Property

    Public Property Message() As String
        Get
            Return m_Message
        End Get
        Set(ByVal value As String)
            m_Message = value
        End Set
    End Property

    Public Property TimeStamp() As Nullable(Of Date)
        Get
            Return m_TimeStamp
        End Get
        Set(ByVal value As Nullable(Of Date))
            m_TimeStamp = value
        End Set
    End Property

    Public Property TimeStampUTC() As Nullable(Of DateTime)
        Get
            Return m_TimeStampUTC
        End Get
        Set(ByVal value As Nullable(Of DateTime))
            m_TimeStampUTC = value
        End Set
    End Property

    Public Property TimeStampRFC() As String
        Get
            Return m_TimeStampRFC
        End Get
        Set(ByVal value As String)
            m_TimeStampRFC = value
        End Set
    End Property

    Public Property TimeZone() As Short
        Get
            Return m_TimeZone
        End Get
        Set(ByVal value As Short)
            m_TimeZone = value
        End Set
    End Property

#End Region

#Region "Constructors"

    ''' <summary>
    ''' Constructor #1
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()

        'm_Delate = False
        m_Index = -1
        m_Status = ""
        m_Sender = ""
        m_Sent = ""
        m_Alphabet = ""
        m_Message = ""
        m_Text = ""
        m_Phone = ""
        m_SMSC = ""
        m_TimeStamp = Nothing
        m_TimeStampRFC = ""
        m_TimeZone = -1
    End Sub

    ''' <summary>
    ''' Constructor #2
    ''' </summary>
    ''' <param name="index"></param>
    ''' <param name="phone"></param>
    ''' <param name="smsc"></param>
    ''' <param name="timeStamp"></param>
    ''' <param name="timeStampRFC"></param>
    ''' <param name="timeZone"></param>
    ''' <param name="deleted"></param>
    ''' <remarks></remarks>
    Public Sub New(ByVal index As Integer, ByVal phone As String, ByVal smsc As String, _
                   ByVal timeStamp As Nullable(Of Date), ByVal timeStampRFC As String, _
                   ByVal timeZone As Short)
        Me.New()

        m_Index = index
        m_Phone = phone
        m_SMSC = smsc
        m_TimeStamp = timeStamp
        m_TimeStampRFC = timeStampRFC
        'm_Delate = deleted

        If Not timeStamp.HasValue Then
            m_TimeStamp = Now()
        End If
    End Sub

#End Region

#Region "Methods"

    Public Sub Delete()

        m_Delated = True
    End Sub

#End Region

End Class
