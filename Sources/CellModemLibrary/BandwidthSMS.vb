Imports System.IO.Ports



Imports BandwidthSMSAPIConnectorLibrary40
Imports BandwidthSMSAPIConnectorLibrary40.BandWidth.Net
Imports BandwidthSMSAPIConnectorLibrary40.BandWidth.Net.API

Public Class BandwidthSMS
    Inherits SMS

#Region "Delegate,Actions,Events"

#End Region

#Region "Fields"

    Private m_isConnected As Boolean

#End Region

#Region "Properties"

    Public Overloads Property IsConnected() As Boolean
        Get
            Return m_isConnected
        End Get
        Private Set(value As Boolean)
            m_isConnected = value
        End Set
    End Property


#End Region

#Region "Constructors"

    ''' <summary>
    ''' Constructor #1
    ''' </summary>
    Public Sub New()
        MyBase.New()

    End Sub

    ''' <summary>
    ''' Constructor #2
    ''' </summary>
    ''' <param name="ownNumber"></param>
    ''' <param name="portName"></param>
    ''' <param name="baudRate"></param>
    ''' <param name="parityName"></param>
    ''' <param name="dataBits"></param>
    ''' <param name="stopBitsName"></param>
    Public Sub New(ByVal ownNumber As String, ByVal portName As String,
                   ByVal baudRate As Integer, ByVal parityName As String,
                   ByVal dataBits As Integer, ByVal stopBitsName As String)
        MyBase.New(ownNumber, portName, baudRate, parityName, dataBits, stopBitsName)

    End Sub

#End Region

#Region "Event Handlers"


#End Region

#Region "Methods"

    ''' <summary>
    ''' 
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks>
    ''' Ref Link #1: Await Deadlock issue: https://blog.stephencleary.com/2012/07/dont-block-on-async-code.html
    ''' </remarks>
    Public Overrides Function Connect() As Boolean

        Try

            'Dim cfgBandWidth_UserId = System.Configuration.ConfigurationManager.AppSettings("BANDWIDTH_USER_ID")
            'Dim cfgBandWidth_APIToken = System.Configuration.ConfigurationManager.AppSettings("BANDWIDTH_API_TOKEN")
            'Dim cfgBandWidth_APISecret = System.Configuration.ConfigurationManager.AppSettings("BANDWIDTH_API_SECRET")

            'CommonApplication.SetBandWidth_USER_ID(cfgBandWidth_UserId)
            'CommonApplication.SetBandwidth_API_TOKEN(cfgBandWidth_APIToken)
            'CommonApplication.SetBandwidth_API_SECRET(cfgBandWidth_APISecret)

            ConfigurationUtils.InitializeTheProviderAndTheConfiguration()

            Dim getListOfPhoneNumbersTask = AwaitExtensions.GetAwaiter(APIHelper.GetListOfPhoneNumbers(10, Nothing, Nothing, Nothing, Nothing, PhoneNumberState.Enabled))
            'Dim getListOfPhoneNumbersTask = AwaitExtensions.GetAwaiter(ApiHelperV10r1.GetListOfPhoneNumbers(10, Nothing, Nothing, Nothing, Nothing, PhoneNumberState.Enabled))

            Dim getListOfPhoneNumbersResults = getListOfPhoneNumbersTask.GetResult()

            If getListOfPhoneNumbersResults.Any() Then
                Me.IsConnected = True
            End If

            'Return MyBase.Connect()
        Catch ex As Exception
            MyBase.ErrorCode = Information.Err().Number
            MyBase.ErrorDescription = ex.ToString() ' Information.Err().Description

            Me.AddError(ex)
        End Try

        Return False
    End Function

    Public Overrides Function Disconnect() As Boolean

        Try

            Me.IsConnected = False

            'Return MyBase.Disconnect()
        Catch ex As Exception
            MyBase.ErrorCode = Information.Err().Number
            MyBase.ErrorDescription = ex.ToString() ' Information.Err().Description

            Me.AddError(ex)
        End Try

        Return False
    End Function

    Public Overrides Function IsError(Optional ShowMsgBox As Boolean = False, Optional MsgBoxTitle As String = "mCore Error") As Boolean
        Return MyBase.IsError(ShowMsgBox, MsgBoxTitle)
    End Function

#Region "Send SMS"

    <Obsolete("Use the other send message function instead.")>
    Public Overrides Function SendMessage(ByVal phoneNo As String,
                                ByVal message As String) As String
        Throw New NotSupportedException("SendMessage(string,string)")
    End Function

    Public Overloads Function SendMessage(ByVal from As String, ByVal [to] As String,
                                ByVal text As String, Optional ByVal media As String() = Nothing, Optional ByVal callBackUrl As String = Nothing,
        Optional ByVal callbackTimeout As Integer? = Nothing, Optional ByVal fallbackUrl As String = Nothing, Optional ByVal tag As String = Nothing,
        Optional ByVal receiptRequested As API.MessageReceiptRequested? = Nothing) As String

        Try

            Dim objResponseTask = System.Threading.Tasks.Task.Factory.StartNew(
            Function()
                Dim response = APIHelper.SendASingleSMSMessage(from, [to], text, media, callBackUrl, callbackTimeout, fallbackUrl, tag, receiptRequested)

                Return response.Result
            End Function).ConfigureAwait(False).GetAwaiter()

            Dim objRequestResults = objResponseTask.GetResult()

            Return objRequestResults
        Catch ex As Exception
            MyBase.ErrorCode = Information.Err().Number
            MyBase.ErrorDescription = ex.ToString() ' Information.Err().Description

            Me.AddError(ex)
        End Try

        Return String.Empty
    End Function

    Public Overrides Function SendATCommand(ByVal objSerialPort As System.IO.Ports.SerialPort,
                                  ByVal command As String, ByVal responseTimeout As Integer,
                                  ByVal errorMessage As String) As String

        Throw New NotSupportedException("SendATCommand")
    End Function

#End Region

#Region "Helpers"

#End Region

#End Region

End Class
