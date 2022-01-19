Imports CellModemLibrary.Configuration

Public Class DbApplication

    Public Class clsContext

        Private m_ConnString As String = ""

        Private m_theProvider As tblMessengerCommunicationProvider
        Private m_theConfiguration As tblMessengerConfiguration

        Private m_SysDateTime As Date

        Public Property ConnString() As String
            Get
                Return m_ConnString
            End Get
            Set(ByVal value As String)
                m_ConnString = value
            End Set
        End Property

        Public Property TheProvider As tblMessengerCommunicationProvider
            Get
                Return m_theProvider
            End Get
            Friend Set(value As tblMessengerCommunicationProvider)
                m_theProvider = value
            End Set
        End Property

        Public Property TheConfiguration As tblMessengerConfiguration
            Get
                Return m_theConfiguration
            End Get
            Friend Set(value As tblMessengerConfiguration)
                m_theConfiguration = value
            End Set
        End Property

        Public Property SysDateTime As Date
            Get
                Return m_SysDateTime
            End Get
            Set(value As Date)
                m_SysDateTime = value
            End Set
        End Property

    End Class

    Private Shared m_Context As clsContext

    Public Shared ReadOnly Property Context() As clsContext
        Get
            If IsNothing(m_Context) Then
                m_Context = New clsContext()
            End If

            Return m_Context
        End Get
    End Property

    Public Shared ProgramExePath As String

    Public Shared Function GetFileLogDirPath()

        Dim cfgSetting As String = System.Configuration.ConfigurationManager.AppSettings("TELLIGENT_LOGFILES_PATH")

        If String.IsNullOrWhiteSpace(cfgSetting) Then
            Throw New ArgumentNullException("app.config->appSettings->TELLIGENT_LOGFILES_PATH is required!")
        End If

        Return cfgSetting
    End Function

    Public Shared Function GetLog4NetConfigPath() As System.IO.FileInfo

        If String.IsNullOrWhiteSpace(ProgramExePath) Then
            ProgramExePath = My.Application.Info.DirectoryPath
        End If

        Dim cfgSetting As String = System.Configuration.ConfigurationManager.AppSettings("LOG4NET_CONFIGFILE_SUBPATH")

        Dim fullLogPath As String = System.IO.Path.Combine(ProgramExePath, cfgSetting)
        Dim fInfo As New System.IO.FileInfo(fullLogPath)

        Return fInfo
    End Function

End Class
