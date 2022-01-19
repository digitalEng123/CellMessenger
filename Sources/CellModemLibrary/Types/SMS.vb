Imports System
Imports System.IO
Imports System.IO.Ports
Imports System.Threading
Imports System.Text
Imports System.Text.RegularExpressions
Imports Microsoft.VisualBasic

Public Class SMS

#Region "Delegate,Action,Events"

    Public Event OnSerialPort_DataReceived(ByVal sender As Object,
            ByVal e As System.IO.Ports.SerialDataReceivedEventArgs)

    Dim kickoffRead As Action = Nothing

#End Region

#Region "Fields"

    Private m_serialPort As SerialPort

    Private m_Inbox As InBox
    'Private m_IsConnected As Boolean

    Private m_OwnNumber As String

    Private m_PortName As String
    Private m_BaudRate As Integer
    Private m_DataBits As Short
    Private m_Parity As System.IO.Ports.Parity
    Private m_ParityName As String
    Private m_StopBits As System.IO.Ports.StopBits
    Private m_StopBitsName As String
    Private m_ModemCommandDelay As Integer
    Private m_Timeout As Integer

    Private m_Pin As String
    Private m_DisableCheckPIN As Boolean
    Private m_Validity As String

    Private m_ErrorCode As Integer
    Private m_ErrorDescription As String

    Public receiveNow As AutoResetEvent
    Private Shared readNow As AutoResetEvent = New AutoResetEvent(False)

    Private m_errors As New List(Of String)

#End Region

#Region "Properties"

    Public ReadOnly Property Inbox() As InBox
        Get
            Return m_Inbox
        End Get
    End Property

    Public Overridable ReadOnly Property IsConnected() As Boolean
        Get
            If Not IsNothing(m_serialPort) Then
                Return m_serialPort.IsOpen()
            Else
                Return False
            End If
        End Get
    End Property

    Public ReadOnly Property OwnNumber() As String
        Get
            Return m_OwnNumber
        End Get
    End Property

    Public Property PortName() As String
        Get
            Return m_PortName
        End Get
        Set(ByVal value As String)
            m_PortName = value
        End Set
    End Property

    Public Property BaudRate() As Integer
        Get
            Return m_BaudRate
        End Get
        Set(ByVal value As Integer)
            m_BaudRate = value
        End Set
    End Property

    Public Property DataBits() As Short
        Get
            Return m_DataBits
        End Get
        Set(ByVal value As Short)
            m_DataBits = value
        End Set
    End Property

    Public ReadOnly Property Parity() As System.IO.Ports.Parity
        Get
            Return m_Parity
        End Get
    End Property

    Public Property ParityName() As String
        Get
            Return m_ParityName
        End Get
        Set(ByVal value As String)
            m_ParityName = value
        End Set
    End Property

    Public ReadOnly Property StopBits() As System.IO.Ports.StopBits
        Get
            Return (m_StopBits)
        End Get
    End Property

    Public Property StopBitsName() As String
        Get
            Return m_StopBitsName
        End Get
        Set(ByVal value As String)
            m_StopBitsName = value
        End Set
    End Property

    Public Property ModemCommandDelay() As Integer
        Get
            Return m_ModemCommandDelay
        End Get
        Set(ByVal value As Integer)
            m_ModemCommandDelay = value
        End Set
    End Property

    Public Property Timeout() As Integer
        Get
            Return m_Timeout
        End Get
        Set(ByVal value As Integer)
            m_Timeout = value
        End Set
    End Property

    Public Property Pin() As String
        Get
            Return m_Pin
        End Get
        Set(ByVal value As String)
            m_Pin = value
        End Set
    End Property

    Public Property DisableCheckPIN() As Boolean
        Get
            Return m_DisableCheckPIN
        End Get
        Set(ByVal value As Boolean)
            m_DisableCheckPIN = value
        End Set
    End Property

    Public Property Validity() As String
        Get
            Return m_Validity
        End Get
        Set(ByVal value As String)
            m_Validity = value
        End Set
    End Property

    Public Property ErrorCode() As Integer
        Get
            Return m_ErrorCode
        End Get
        Protected Set(value As Integer)
            m_ErrorCode = value
        End Set
    End Property

    Public Property ErrorDescription() As String
        Get
            Return m_ErrorDescription
        End Get
        Protected Set(value As String)
            m_ErrorDescription = value
        End Set
    End Property

#End Region

#Region "Constructors"

    ''' <summary>
    ''' Constructor #1
    ''' </summary>
    ''' <remarks></remarks>
    Public Sub New()

        m_Inbox = New InBox()

        m_Validity = "24H"

        AddHandler OnSerialPort_DataReceived, AddressOf DataReceived
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
    ''' <remarks></remarks>
    Public Sub New(ByVal ownNumber As String, ByVal portName As String,
                   ByVal baudRate As Integer, ByVal parityName As String,
                   ByVal dataBits As Integer, ByVal stopBitsName As String)
        Me.New()

        m_OwnNumber = ownNumber

        m_PortName = portName
        m_BaudRate = baudRate
        m_ParityName = parityName
        m_DataBits = dataBits
        m_StopBitsName = stopBitsName
    End Sub

#End Region

#Region "Events"

    Public Sub SerialPort_DataReceived(ByVal sender As Object,
        ByVal e As System.IO.Ports.SerialDataReceivedEventArgs)

        Try

            If e.EventType = SerialData.Chars Then
                receiveNow.Set()

                RaiseEvent OnSerialPort_DataReceived(Me, e)
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Public Sub DataReceived(ByVal sender As Object, ByVal e As SerialDataReceivedEventArgs)

        Try

            If e.EventType = SerialData.Chars Then

                readNow.Set()
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

    Shared Sub SerialPort_ErrorReceived(ByVal sender As Object, ByVal e As SerialErrorReceivedEventArgs)

        Dim isStop As Boolean = False

        If isStop Then

        End If
    End Sub

    Shared Sub SerialPort_PinChanged(ByVal sender As Object, ByVal e As System.IO.Ports.SerialPinChangedEventArgs)

        Dim isStop As Boolean = False

        If isStop Then

        End If
    End Sub

#End Region

#Region "Methods"

    ''' <summary>
    ''' Connect to the GSM Modem
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overridable Function Connect() As Boolean

        Try

            m_Parity = Me.GetParity(m_ParityName)
            m_StopBits = Me.GetStopBits(m_StopBitsName)

            m_serialPort = OpenPort(m_PortName, m_BaudRate, m_Parity, m_DataBits, m_StopBits, 300, 300)

            Return True
        Catch ex As Exception
            m_ErrorCode = Information.Err().Number
            m_ErrorDescription = Information.Err().Description

            AddError(ex)
        End Try

        Return False
    End Function

    ''' <summary>
    ''' 'Disconnect from the GSM Modem.
    ''' </summary>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overridable Function Disconnect() As Boolean

        Try

            If Not IsNothing(m_serialPort) Then

                If m_serialPort.IsOpen() Then
                    Me.ClosePort(m_serialPort)
                End If

                Return True
            Else
                Return False
            End If
        Catch ex As Exception
            m_ErrorCode = Information.Err().Number
            m_ErrorDescription = Information.Err().Description

            AddError(ex)
        End Try

        Return False
    End Function

    ''' <summary>
    ''' Check if any error occured during Connect method
    ''' </summary>
    ''' <param name="ShowMsgBox"></param>
    ''' <param name="MsgBoxTitle"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Public Overridable Function IsError(Optional ByVal ShowMsgBox As Boolean = False,
                            Optional ByVal MsgBoxTitle As String = "mCore Error") As Boolean

        Dim errorOccured As Boolean = False

        If Not ShowMsgBox Then

            If m_errors.Any() Then

                errorOccured = True
            End If
        Else

            If m_errors.Any() Then

                Dim sbErrors As New StringBuilder()

                For Each strError In m_errors

                    sbErrors.AppendLine(strError)
                    sbErrors.AppendLine("")
                Next

                errorOccured = True
            End If
        End If

        Return errorOccured
    End Function

    Public Overridable Function SendATCommand(ByVal objSerialPort As System.IO.Ports.SerialPort,
                                  ByVal command As String, ByVal responseTimeout As Integer,
                                  ByVal errorMessage As String) As String

        Try

            objSerialPort.DiscardOutBuffer()
            objSerialPort.DiscardInBuffer()
            receiveNow.Reset()
            objSerialPort.Write(command & "\r")

            Dim input As String = ReadResponse(objSerialPort, responseTimeout)
            If (input.Length = 0) OrElse (((Not input.EndsWith(ControlChars.CrLf & "> "))) _
                        AndAlso ((Not input.EndsWith(ControlChars.CrLf & "OK" & ControlChars.CrLf)))) Then
                Throw New ApplicationException("No success message was received.")
            End If
            Return input
        Catch ex As Exception
            Throw ex
        End Try

        Return String.Empty
    End Function

    Private Function OpenPort(ByVal portName As String,
                   ByVal baudRate As Integer, ByVal parity As System.IO.Ports.Parity,
                   ByVal dataBits As Integer, ByVal stopBits As System.IO.Ports.StopBits,
                   ByVal readTimeout As Integer, ByVal writeTimeout As Integer) As SerialPort

        receiveNow = New AutoResetEvent(False)

        Dim objSerialPort As SerialPort = Nothing

        Try

            objSerialPort = New SerialPort(portName, baudRate, parity, dataBits, stopBits)

            objSerialPort.ReadTimeout = readTimeout
            objSerialPort.WriteTimeout = writeTimeout
            objSerialPort.Encoding = System.Text.Encoding.GetEncoding("iso-8859-1")
            objSerialPort.Handshake = Handshake.None

            AddHandler objSerialPort.DataReceived, AddressOf SerialPort_DataReceived
            AddHandler objSerialPort.ErrorReceived, AddressOf SerialPort_ErrorReceived
            AddHandler objSerialPort.PinChanged, AddressOf SerialPort_PinChanged

            objSerialPort.Open()
            objSerialPort.DtrEnable = True
            objSerialPort.RtsEnable = True
        Catch ex As Exception
            Throw ex
        End Try

        Return objSerialPort
    End Function

    Private Sub ClosePort(ByRef objSerialPort As System.IO.Ports.SerialPort)

        Try

            If Not IsNothing(objSerialPort) Then

                objSerialPort.Close()
                RemoveHandler objSerialPort.DataReceived, AddressOf SerialPort_DataReceived
                objSerialPort.Dispose()
                objSerialPort = Nothing
            End If
        Catch ex As Exception
            Throw ex
        End Try
    End Sub

#Region "Helpers"

    Private Function ReadResponse(ByVal port As SerialPort, ByVal timeout As Integer) As String

        Dim serialPortData As String = String.Empty

        Try
            Do
                If receiveNow.WaitOne(timeout, False) Then
                    Dim data As String = port.ReadExisting()
                    serialPortData &= data
                Else
                    If serialPortData.Length > 0 Then
                        Throw New ApplicationException("Response received is incomplete.")
                    Else
                        Throw New ApplicationException("No data received from phone.")
                    End If
                End If
            Loop While (Not serialPortData.EndsWith(ControlChars.CrLf & "OK" & ControlChars.CrLf)) AndAlso (Not serialPortData.EndsWith(ControlChars.CrLf & "> ")) AndAlso Not serialPortData.EndsWith(ControlChars.CrLf & "ERROR" & ControlChars.CrLf)
        Catch ex As Exception
            Throw ex
        End Try
        Return serialPortData
    End Function

    Private Function GetMessageCount(ByVal recievedData As String, ByRef encounteredError As Boolean) As Integer

        encounteredError = False

        Dim messageCount As Integer = 0

        If recievedData.StartsWith("AT+CPMS") _
        AndAlso recievedData.Contains(ControlChars.CrLf & "OK" & ControlChars.CrLf) Then

            Dim receivedDataSplitted() As String = recievedData.Split(","c)
            Dim messageStorageArea As String = receivedDataSplitted(0)
            Dim messageReceivedCount As String = receivedDataSplitted(1)
            messageCount = Convert.ToInt32(messageReceivedCount)
        ElseIf recievedData.Contains("ERROR") Then

            Dim recievedError As String = recievedData
            recievedError = recievedError.Trim()
            recievedData = "Following error occured while counting the message " & recievedError
            encounteredError = True
            messageCount = 0
        End If

        Return messageCount
    End Function

    ''' <summary>
    ''' Get System.IO.Port.Parity from value specified in string format.
    ''' </summary>
    ''' <param name="parityName"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function GetParity(ByVal parityName As String) As System.IO.Ports.Parity

        Dim parityNameLowered As String = parityName.ToLower()

        Select Case parityNameLowered
            Case "none", "n"
                Return Ports.Parity.None
            Case "even", "e"
                Return Ports.Parity.Even
            Case "odd", "o"
                Return Ports.Parity.Odd
            Case "mark", "m"
                Return Ports.Parity.Mark
            Case "space", "s"
                Return Ports.Parity.Space
            Case Else
                Return Ports.Parity.None
        End Select
    End Function

    ''' <summary>
    ''' Get System.IO.Port.StopBits from value specified in string format.
    ''' </summary>
    ''' <param name="stopBitsName"></param>
    ''' <returns></returns>
    ''' <remarks></remarks>
    Private Function GetStopBits(ByVal stopBitsName As String) As System.IO.Ports.StopBits

        Dim stopBitsNameLowered As String = stopBitsName.ToLower()

        Select Case stopBitsNameLowered
            Case "none", "n", "0"
                Return Ports.StopBits.None
            Case "one", "o", "1"
                Return Ports.StopBits.One
            Case "two", "t", "2"
                Return Ports.StopBits.Two
            Case "onepointfive", "1.5"
                Return Ports.StopBits.OnePointFive
        End Select
    End Function

    ''' <summary>
    ''' Add an error message to the collection.
    ''' </summary>
    ''' <param name="errMessage"></param>
    ''' <remarks></remarks>
    Protected Sub AddError(ByVal errMessage As String)

        m_errors.Add(errMessage)
    End Sub

    ''' <summary>
    ''' 'Add and exception to the collection.
    ''' </summary>
    ''' <param name="ex"></param>
    ''' <remarks></remarks>
    Protected Sub AddError(ByVal ex As Exception)

        m_errors.Add(ex.ToString())
    End Sub

    ''' <summary>
    ''' Clear all errors.
    ''' </summary>
    ''' <remarks></remarks>
    Protected Sub ClearErrors()

        m_ErrorCode = ""
        m_ErrorDescription = ""

        m_errors.Clear()
    End Sub

#End Region

#Region "Read SMS"

    Public Function ReadSMS(ByVal port As SerialPort, ByVal atCommand As String) As MessageCollection

        ' Set up the phone and read the messages
        Dim messages As MessageCollection = Nothing

        Try

            '				#Region "Execute Command"
            ' Check connection
            SendATCommand(port, "AT", 300, "No phone connected")
            ' Use message format "Text mode"
            SendATCommand(port, "AT+CMGF=1", 300, "Failed to set message format.")
            ' Use character set "PCCP437"
            'ExecCommand(port,"AT+CSCS=\"PCCP437\"", 300, "Failed to set character set.");
            ' Select SIM storage
            '(port,"AT+CPMS=\"SM\"", 300, "Failed to select message storage.");
            ' Read the messages
            Dim input As String = SendATCommand(port, atCommand, 5000, "Failed to read the messages.")
            '				#End Region

            '				#Region "Parse messages"
            messages = ParseMessages(input)
            '				#End Region

        Catch ex As Exception
            Throw ex
        End Try

        If messages IsNot Nothing Then
            Return messages
        Else
            Return Nothing
        End If
    End Function

    Private Function ParseMessages(ByVal input As String) As MessageCollection

        Dim messages As New MessageCollection()

        Try

            Dim r As New Regex("\+CMGL: (\d+),""(.+)"",""(.+)"",(.*),""(.+)""\r\n(.+)\r\n")
            Dim m As Match = r.Match(input)

            Do While m.Success

                Dim msg As New Message()

                msg.Index = m.Groups(1).Value
                msg.Status = m.Groups(2).Value
                msg.Sender = m.Groups(3).Value
                msg.Alphabet = m.Groups(4).Value
                msg.Sent = m.Groups(5).Value
                msg.Message = m.Groups(6).Value
                messages.Add(msg)
                m = m.NextMatch()
            Loop
        Catch ex As Exception
            Throw ex
        End Try
        Return messages
    End Function

#End Region

#Region "Send SMS"

    Public Overridable Function SendMessage(ByVal phoneNo As String,
                                ByVal message As String) As String

        Dim isSend As Boolean = False
        Dim recievedData As String = ""

        Try

            recievedData = SendATCommand(m_serialPort, "AT", 300, "No phone connected")

            Dim command As String = "AT+CMGF=1" & Char.ConvertFromUtf32(13)

            recievedData = SendATCommand(m_serialPort, command, 300, "Failed to set message format.")

            ' AT Command Syntax - http://www.smssolutions.net/tutorials/gsm/sendsmsat/
            command = "AT+CMGS=""" & phoneNo & """" & Char.ConvertFromUtf32(13)
            recievedData = SendATCommand(m_serialPort, command, 300, "Failed to accept phoneNo")

            command = message & Char.ConvertFromUtf32(26)
            recievedData = SendATCommand(m_serialPort, command, 3000, "Failed to send message") '3 seconds

            If recievedData.EndsWith(ControlChars.CrLf & "OK" & ControlChars.CrLf) Then
                isSend = True
            ElseIf recievedData.Contains("ERROR") Then
                isSend = False
            End If
        Catch ex As Exception

            m_ErrorCode = Information.Err().Number
            m_ErrorDescription = Information.Err().Description

            AddError(ex)
        End Try

        Return recievedData
    End Function

    Private Function SendMessage(ByVal port As SerialPort, ByVal phoneNo As String,
                                ByVal message As String) As Boolean

        Dim isSend As Boolean = False

        Try

            Dim recievedData As String = SendATCommand(port, "AT", 300, "No phone connected")
            Dim command As String = "AT+CMGF=1" & Char.ConvertFromUtf32(13)

            recievedData = SendATCommand(port, command, 300, "Failed to set message format.")

            ' AT Command Syntax - http://www.smssolutions.net/tutorials/gsm/sendsmsat/
            command = "AT+CMGS=""" & phoneNo & """" & Char.ConvertFromUtf32(13)
            recievedData = SendATCommand(port, command, 300, "Failed to accept phoneNo")

            command = message & Char.ConvertFromUtf32(26)
            recievedData = SendATCommand(port, command, 3000, "Failed to send message") '3 seconds

            If recievedData.EndsWith(ControlChars.CrLf & "OK" & ControlChars.CrLf) Then
                isSend = True
            ElseIf recievedData.Contains("ERROR") Then
                isSend = False
            End If

            Return isSend
        Catch ex As Exception
            Throw ex
        End Try
    End Function

#End Region

#Region "Delete SMS"

    Public Function DeleteMessage(ByVal port As SerialPort, ByVal atCommand As String) As Boolean

        Dim isDeleted As Boolean = False

        Try

            '				#Region "Execute Command"
            Dim recievedData As String = SendATCommand(port, "AT", 300, "No phone connected")

            recievedData = SendATCommand(port, "AT+CMGF=1", 300, "Failed to set message format.")

            Dim command As String = atCommand

            recievedData = SendATCommand(port, command, 300, "Failed to delete message")
            '				#End Region

            If recievedData.EndsWith(ControlChars.CrLf & "OK" & ControlChars.CrLf) Then
                isDeleted = True
            End If

            If recievedData.Contains("ERROR") Then
                isDeleted = False
            End If

            Return isDeleted
        Catch ex As Exception
            Throw ex
        End Try
    End Function

#End Region

#End Region

End Class
