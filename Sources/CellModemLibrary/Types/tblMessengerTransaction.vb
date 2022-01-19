Imports System.Text
Imports System.Data
Imports System.Data.OleDb

Public NotInheritable Class tblMessengerTransaction

#Region "Fields"

    Private m_intrecordid_databaseid? As Int32
    Private m_lblmessengertransactioninformation As String
    Private m_ixtcode As String
    Private m_txtdescription As String
    Private m_lblmessengertransaction As String
    Private m_intrecordid_messengerconfiguration? As Int32
    Private m_intrecordid_messengercommunicationprovider? As Int32
    Private m_intrecordid_messengerdeliverystate? As Int32
    Private m_intrecordid_messengerdeliverycode? As Int32
    Private m_intrecordid_mail? As Int32
    Private m_intrecordid_maildetail? As Int32
    Private m_decmaxnumberofcharacters? As Double
    Private m_mmotransaction As String
    Private m_txtelectronicdataexchangecode As String
    Private m_lblcalendarreminder As String
    Private m_dtefollowupdate? As Date
    Private m_txteventstarttime As String
    Private m_txteventendtime As String
    Private m_lblmessengertransactionrecordinformation As String
    Private m_blnmakeprivate As String
    Private m_blnactive As String
    Private m_txtrecordcreationuser As String
    Private m_dterecordcreationdate? As Date
    Private m_dterecordupdatedate? As Date
    Private m_blncursor As String
    Private m_intrecordid_company? As Int32
    Private m_intrecordid_division? As Int32
    Private m_intrecordid As Int32
    Private m_intrecordid_user_creation? As Int32
    Private m_blnattachment As String
    Private m_blndeleted As String
    Private m_blnhighlight As String
    Private m_blnmemo As String
    Private m_blnprocess As String
    Private m_blnproject As String
    Private m_intrecordid_errorlog? As Int32
    Private m_intrecordid_status? As Int32
    Private m_blnprint As String
    Private m_txtrecordupdateuser As String
    Private m_blnwebsearch As String
    Private m_blnecommercetransmit As String
    Private m_blnsecurity As String
    Private m_dterecordsynchronization? As Date
    Private m_blnerrorlog As String
    Private m_txtfieldvaluegenerator As String
    Private m_blnsystemrecord As String
    Private m_blnaudittrail As String
    Private m_txtguid? As Guid
    Private m_blnfavorite As String

#End Region

#Region "Properties"

    ''' <summary>
    ''' The intRecordID_DatabaseID column is in the DB
    ''' </summary>
    Public Property intRecordID_DatabaseID() As Int32?
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            Return m_intrecordid_databaseid
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value? As Int32)
            If Not m_intrecordid_databaseid.Equals(value) Then
                m_intrecordid_databaseid = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The lblMessengerTransactionInformation column is in the DB
    ''' </summary>
    Public Property lblMessengerTransactionInformation() As String
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            If String.IsNullOrEmpty(m_lblmessengertransactioninformation) Then
                Return String.Empty
            Else
                Return m_lblmessengertransactioninformation
            End If
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value As String)
            If value Is Nothing Then
                value = String.Empty
            End If
            If m_lblmessengertransactioninformation <> value Then
                m_lblmessengertransactioninformation = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The ixtCode column is in the DB
    ''' </summary>
    Public Property ixtCode() As String
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            If String.IsNullOrEmpty(m_ixtcode) Then
                Return String.Empty
            Else
                Return m_ixtcode
            End If
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value As String)
            If value Is Nothing Then
                value = String.Empty
            End If
            If m_ixtcode <> value Then
                m_ixtcode = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The txtDescription column is in the DB
    ''' </summary>
    Public Property txtDescription() As String
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            If String.IsNullOrEmpty(m_txtdescription) Then
                Return String.Empty
            Else
                Return m_txtdescription
            End If
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value As String)
            If value Is Nothing Then
                value = String.Empty
            End If
            If m_txtdescription <> value Then
                m_txtdescription = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The lblMessengerTransaction column is in the DB
    ''' </summary>
    Public Property lblMessengerTransaction() As String
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            If String.IsNullOrEmpty(m_lblmessengertransaction) Then
                Return String.Empty
            Else
                Return m_lblmessengertransaction
            End If
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value As String)
            If value Is Nothing Then
                value = String.Empty
            End If
            If m_lblmessengertransaction <> value Then
                m_lblmessengertransaction = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The intRecordID_MessengerConfiguration column is in the DB
    ''' </summary>
    Public Property intRecordID_MessengerConfiguration() As Int32?
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            Return m_intrecordid_messengerconfiguration
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value? As Int32)
            If Not m_intrecordid_messengerconfiguration.Equals(value) Then
                m_intrecordid_messengerconfiguration = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The intRecordID_MessengerCommunicationProvider column is in the DB
    ''' </summary>
    Public Property intRecordID_MessengerCommunicationProvider() As Int32?
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            Return m_intrecordid_messengercommunicationprovider
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value? As Int32)
            If Not m_intrecordid_messengercommunicationprovider.Equals(value) Then
                m_intrecordid_messengercommunicationprovider = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The intRecordID_MessengerDeliveryState column is in the DB
    ''' </summary>
    Public Property intRecordID_MessengerDeliveryState() As Int32?
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            Return m_intrecordid_messengerdeliverystate
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value? As Int32)
            If Not m_intrecordid_messengerdeliverystate.Equals(value) Then
                m_intrecordid_messengerdeliverystate = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The intRecordID_MessengerDeliveryCode column is in the DB
    ''' </summary>
    Public Property intRecordID_MessengerDeliveryCode() As Int32?
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            Return m_intrecordid_messengerdeliverycode
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value? As Int32)
            If Not m_intrecordid_messengerdeliverycode.Equals(value) Then
                m_intrecordid_messengerdeliverycode = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The intRecordID_Mail column is in the DB
    ''' </summary>
    Public Property intRecordID_Mail() As Int32?
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            Return m_intrecordid_mail
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value? As Int32)
            If Not m_intrecordid_mail.Equals(value) Then
                m_intrecordid_mail = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The intRecordID_MailDetail column is in the DB
    ''' </summary>
    Public Property intRecordID_MailDetail() As Int32?
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            Return m_intrecordid_maildetail
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value? As Int32)
            If Not m_intrecordid_maildetail.Equals(value) Then
                m_intrecordid_maildetail = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The decMaxNumberOfCharacters column is in the DB
    ''' </summary>
    Public Property decMaxNumberOfCharacters() As Double?
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            Return m_decmaxnumberofcharacters
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value? As Double)
            If Not m_decmaxnumberofcharacters.Equals(value) Then
                m_decmaxnumberofcharacters = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The mmoTransaction column is in the DB
    ''' </summary>
    Public Property mmoTransaction() As String
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            If String.IsNullOrEmpty(m_mmotransaction) Then
                Return String.Empty
            Else
                Return m_mmotransaction
            End If
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value As String)
            If value Is Nothing Then
                value = String.Empty
            End If
            If m_mmotransaction <> value Then
                m_mmotransaction = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The txtElectronicDataExchangeCode column is in the DB
    ''' </summary>
    Public Property txtElectronicDataExchangeCode() As String
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            If String.IsNullOrEmpty(m_txtelectronicdataexchangecode) Then
                Return String.Empty
            Else
                Return m_txtelectronicdataexchangecode
            End If
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value As String)
            If value Is Nothing Then
                value = String.Empty
            End If
            If m_txtelectronicdataexchangecode <> value Then
                m_txtelectronicdataexchangecode = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The lblCalendarReminder column is in the DB
    ''' </summary>
    Public Property lblCalendarReminder() As String
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            If String.IsNullOrEmpty(m_lblcalendarreminder) Then
                Return String.Empty
            Else
                Return m_lblcalendarreminder
            End If
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value As String)
            If value Is Nothing Then
                value = String.Empty
            End If
            If m_lblcalendarreminder <> value Then
                m_lblcalendarreminder = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The dteFollowUpDate column is in the DB
    ''' </summary>
    Public Property dteFollowUpDate() As Date?
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            Return m_dtefollowupdate
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value? As Date)
            If Not m_dtefollowupdate.Equals(value) Then
                m_dtefollowupdate = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The txtEventStartTime column is in the DB
    ''' </summary>
    Public Property txtEventStartTime() As String
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            If String.IsNullOrEmpty(m_txteventstarttime) Then
                Return String.Empty
            Else
                Return m_txteventstarttime
            End If
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value As String)
            If value Is Nothing Then
                value = String.Empty
            End If
            If m_txteventstarttime <> value Then
                m_txteventstarttime = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The txtEventEndTime column is in the DB
    ''' </summary>
    Public Property txtEventEndTime() As String
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            If String.IsNullOrEmpty(m_txteventendtime) Then
                Return String.Empty
            Else
                Return m_txteventendtime
            End If
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value As String)
            If value Is Nothing Then
                value = String.Empty
            End If
            If m_txteventendtime <> value Then
                m_txteventendtime = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The lblMessengerTransactionRecordInformation column is in the DB
    ''' </summary>
    Public Property lblMessengerTransactionRecordInformation() As String
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            If String.IsNullOrEmpty(m_lblmessengertransactionrecordinformation) Then
                Return String.Empty
            Else
                Return m_lblmessengertransactionrecordinformation
            End If
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value As String)
            If value Is Nothing Then
                value = String.Empty
            End If
            If m_lblmessengertransactionrecordinformation <> value Then
                m_lblmessengertransactionrecordinformation = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The blnMakePrivate column is in the DB
    ''' </summary>
    Public Property blnMakePrivate() As String
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            If String.IsNullOrEmpty(m_blnmakeprivate) Then
                Return String.Empty
            Else
                Return m_blnmakeprivate
            End If
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value As String)
            If value Is Nothing Then
                value = String.Empty
            End If
            If m_blnmakeprivate <> value Then
                m_blnmakeprivate = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The blnActive column is in the DB
    ''' </summary>
    Public Property blnActive() As String
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            If String.IsNullOrEmpty(m_blnactive) Then
                Return String.Empty
            Else
                Return m_blnactive
            End If
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value As String)
            If value Is Nothing Then
                value = String.Empty
            End If
            If m_blnactive <> value Then
                m_blnactive = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The txtRecordCreationUser column is in the DB
    ''' </summary>
    Public Property txtRecordCreationUser() As String
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            If String.IsNullOrEmpty(m_txtrecordcreationuser) Then
                Return String.Empty
            Else
                Return m_txtrecordcreationuser
            End If
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value As String)
            If value Is Nothing Then
                value = String.Empty
            End If
            If m_txtrecordcreationuser <> value Then
                m_txtrecordcreationuser = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The dteRecordCreationDate column is in the DB
    ''' </summary>
    Public Property dteRecordCreationDate() As Date?
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            Return m_dterecordcreationdate
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value? As Date)
            If Not m_dterecordcreationdate.Equals(value) Then
                m_dterecordcreationdate = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The dteRecordUpdateDate column is in the DB
    ''' </summary>
    Public Property dteRecordUpdateDate() As Date?
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            Return m_dterecordupdatedate
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value? As Date)
            If Not m_dterecordupdatedate.Equals(value) Then
                m_dterecordupdatedate = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The blnCursor column is in the DB
    ''' </summary>
    Public Property blnCursor() As String
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            If String.IsNullOrEmpty(m_blncursor) Then
                Return String.Empty
            Else
                Return m_blncursor
            End If
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value As String)
            If value Is Nothing Then
                value = String.Empty
            End If
            If m_blncursor <> value Then
                m_blncursor = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The intRecordID_Company column is in the DB
    ''' </summary>
    Public Property intRecordID_Company() As Int32?
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            Return m_intrecordid_company
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value? As Int32)
            If Not m_intrecordid_company.Equals(value) Then
                m_intrecordid_company = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The intRecordID_Division column is in the DB
    ''' </summary>
    Public Property intRecordID_Division() As Int32?
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            Return m_intrecordid_division
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value? As Int32)
            If Not m_intrecordid_division.Equals(value) Then
                m_intrecordid_division = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The intRecordID column is in the DB
    ''' </summary>
    Public Property intRecordID() As Int32
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            Return m_intrecordid
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value As Int32)
            If m_intrecordid <> value Then
                m_intrecordid = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The intRecordID_User_Creation column is in the DB
    ''' </summary>
    Public Property intRecordID_User_Creation() As Int32?
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            Return m_intrecordid_user_creation
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value? As Int32)
            If Not m_intrecordid_user_creation.Equals(value) Then
                m_intrecordid_user_creation = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The blnAttachment column is in the DB
    ''' </summary>
    Public Property blnAttachment() As String
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            If String.IsNullOrEmpty(m_blnattachment) Then
                Return String.Empty
            Else
                Return m_blnattachment
            End If
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value As String)
            If value Is Nothing Then
                value = String.Empty
            End If
            If m_blnattachment <> value Then
                m_blnattachment = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The blnDeleted column is in the DB
    ''' </summary>
    Public Property blnDeleted() As String
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            If String.IsNullOrEmpty(m_blndeleted) Then
                Return String.Empty
            Else
                Return m_blndeleted
            End If
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value As String)
            If value Is Nothing Then
                value = String.Empty
            End If
            If m_blndeleted <> value Then
                m_blndeleted = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The blnHighlight column is in the DB
    ''' </summary>
    Public Property blnHighlight() As String
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            If String.IsNullOrEmpty(m_blnhighlight) Then
                Return String.Empty
            Else
                Return m_blnhighlight
            End If
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value As String)
            If value Is Nothing Then
                value = String.Empty
            End If
            If m_blnhighlight <> value Then
                m_blnhighlight = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The blnMemo column is in the DB
    ''' </summary>
    Public Property blnMemo() As String
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            If String.IsNullOrEmpty(m_blnmemo) Then
                Return String.Empty
            Else
                Return m_blnmemo
            End If
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value As String)
            If value Is Nothing Then
                value = String.Empty
            End If
            If m_blnmemo <> value Then
                m_blnmemo = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The blnProcess column is in the DB
    ''' </summary>
    Public Property blnProcess() As String
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            If String.IsNullOrEmpty(m_blnprocess) Then
                Return String.Empty
            Else
                Return m_blnprocess
            End If
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value As String)
            If value Is Nothing Then
                value = String.Empty
            End If
            If m_blnprocess <> value Then
                m_blnprocess = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The blnProject column is in the DB
    ''' </summary>
    Public Property blnProject() As String
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            If String.IsNullOrEmpty(m_blnproject) Then
                Return String.Empty
            Else
                Return m_blnproject
            End If
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value As String)
            If value Is Nothing Then
                value = String.Empty
            End If
            If m_blnproject <> value Then
                m_blnproject = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The intRecordID_ErrorLog column is in the DB
    ''' </summary>
    Public Property intRecordID_ErrorLog() As Int32?
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            Return m_intrecordid_errorlog
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value? As Int32)
            If Not m_intrecordid_errorlog.Equals(value) Then
                m_intrecordid_errorlog = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The intRecordID_Status column is in the DB
    ''' </summary>
    Public Property intRecordID_Status() As Int32?
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            Return m_intrecordid_status
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value? As Int32)
            If Not m_intrecordid_status.Equals(value) Then
                m_intrecordid_status = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The blnPrint column is in the DB
    ''' </summary>
    Public Property blnPrint() As String
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            If String.IsNullOrEmpty(m_blnprint) Then
                Return String.Empty
            Else
                Return m_blnprint
            End If
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value As String)
            If value Is Nothing Then
                value = String.Empty
            End If
            If m_blnprint <> value Then
                m_blnprint = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The txtRecordUpdateUser column is in the DB
    ''' </summary>
    Public Property txtRecordUpdateUser() As String
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            If String.IsNullOrEmpty(m_txtrecordupdateuser) Then
                Return String.Empty
            Else
                Return m_txtrecordupdateuser
            End If
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value As String)
            If value Is Nothing Then
                value = String.Empty
            End If
            If m_txtrecordupdateuser <> value Then
                m_txtrecordupdateuser = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The blnWebSearch column is in the DB
    ''' </summary>
    Public Property blnWebSearch() As String
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            If String.IsNullOrEmpty(m_blnwebsearch) Then
                Return String.Empty
            Else
                Return m_blnwebsearch
            End If
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value As String)
            If value Is Nothing Then
                value = String.Empty
            End If
            If m_blnwebsearch <> value Then
                m_blnwebsearch = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The blnEcommerceTransmit column is in the DB
    ''' </summary>
    Public Property blnEcommerceTransmit() As String
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            If String.IsNullOrEmpty(m_blnecommercetransmit) Then
                Return String.Empty
            Else
                Return m_blnecommercetransmit
            End If
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value As String)
            If value Is Nothing Then
                value = String.Empty
            End If
            If m_blnecommercetransmit <> value Then
                m_blnecommercetransmit = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The blnSecurity column is in the DB
    ''' </summary>
    Public Property blnSecurity() As String
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            If String.IsNullOrEmpty(m_blnsecurity) Then
                Return String.Empty
            Else
                Return m_blnsecurity
            End If
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value As String)
            If value Is Nothing Then
                value = String.Empty
            End If
            If m_blnsecurity <> value Then
                m_blnsecurity = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The dteRecordSynchronization column is in the DB
    ''' </summary>
    Public Property dteRecordSynchronization() As Date?
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            Return m_dterecordsynchronization
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value? As Date)
            If Not m_dterecordsynchronization.Equals(value) Then
                m_dterecordsynchronization = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The blnErrorLog column is in the DB
    ''' </summary>
    Public Property blnErrorLog() As String
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            If String.IsNullOrEmpty(m_blnerrorlog) Then
                Return String.Empty
            Else
                Return m_blnerrorlog
            End If
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value As String)
            If value Is Nothing Then
                value = String.Empty
            End If
            If m_blnerrorlog <> value Then
                m_blnerrorlog = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The txtFieldValueGenerator column is in the DB
    ''' </summary>
    Public Property txtFieldValueGenerator() As String
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            If String.IsNullOrEmpty(m_txtfieldvaluegenerator) Then
                Return String.Empty
            Else
                Return m_txtfieldvaluegenerator
            End If
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value As String)
            If value Is Nothing Then
                value = String.Empty
            End If
            If m_txtfieldvaluegenerator <> value Then
                m_txtfieldvaluegenerator = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The blnSystemRecord column is in the DB
    ''' </summary>
    Public Property blnSystemRecord() As String
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            If String.IsNullOrEmpty(m_blnsystemrecord) Then
                Return String.Empty
            Else
                Return m_blnsystemrecord
            End If
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value As String)
            If value Is Nothing Then
                value = String.Empty
            End If
            If m_blnsystemrecord <> value Then
                m_blnsystemrecord = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The blnAuditTrail column is in the DB
    ''' </summary>
    Public Property blnAuditTrail() As String
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            If String.IsNullOrEmpty(m_blnaudittrail) Then
                Return String.Empty
            Else
                Return m_blnaudittrail
            End If
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value As String)
            If value Is Nothing Then
                value = String.Empty
            End If
            If m_blnaudittrail <> value Then
                m_blnaudittrail = value
            End If
        End Set
    End Property
    ''' <summary>
    ''' The txtGUID column is in the DB
    ''' </summary>
    Public Property txtGUID() As Guid?
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            Return m_txtguid
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value? As Guid)
            If Not m_txtguid.Equals(value) Then
                m_txtguid = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The blnFavorite column is in the DB
    ''' </summary>
    Public Property blnFavorite() As String
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            If String.IsNullOrEmpty(m_blnfavorite) Then
                Return String.Empty
            Else
                Return m_blnfavorite
            End If
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value As String)
            If value Is Nothing Then
                value = String.Empty
            End If
            If m_blnfavorite <> value Then
                m_blnfavorite = value
            End If
        End Set
    End Property

#End Region

#Region "Constructors"

    Public Sub New()
        m_intrecordid_databaseid = Constants.DEFAULT_VALUE_INTRECORDID_DATABASEID
        m_lblmessengertransactioninformation = String.Empty
        m_ixtcode = String.Empty
        m_txtdescription = String.Empty
        m_lblmessengertransaction = String.Empty
        m_intrecordid_messengerconfiguration = Nothing
        m_intrecordid_messengercommunicationprovider = Nothing
        m_intrecordid_messengerdeliverystate = Nothing
        m_intrecordid_messengerdeliverycode = Nothing
        m_intrecordid_mail = Nothing
        m_intrecordid_maildetail = Nothing
        m_decmaxnumberofcharacters = Nothing
        m_mmotransaction = String.Empty
        m_txtelectronicdataexchangecode = String.Empty
        m_lblcalendarreminder = String.Empty
        m_dtefollowupdate = Nothing
        m_txteventstarttime = String.Empty
        m_txteventendtime = String.Empty
        m_lblmessengertransactionrecordinformation = String.Empty
        m_blnmakeprivate = Constants.DEFAULT_VALUE_NO
        m_blnactive = Constants.DEFAULT_VALUE_NO
        m_txtrecordcreationuser = My.Application.Info.AssemblyName
        m_dterecordcreationdate = Date.Now
        m_dterecordupdatedate = Nothing
        m_blncursor = Constants.DEFAULT_VALUE_NO
        m_intrecordid_company = Constants.DEFAULT_VALUE_INTRECORDID_COMPANY
        m_intrecordid_division = Constants.DEFAULT_VALUE_INTRECORDID_DIVISION
        m_intrecordid = Int32.MinValue
        m_intrecordid_user_creation = Nothing
        m_blnattachment = Constants.DEFAULT_VALUE_NO
        m_blndeleted = Constants.DEFAULT_VALUE_NO
        m_blnhighlight = Constants.DEFAULT_VALUE_NO
        m_blnmemo = Constants.DEFAULT_VALUE_NO
        m_blnprocess = Constants.DEFAULT_VALUE_NO
        m_blnproject = Constants.DEFAULT_VALUE_NO
        m_intrecordid_errorlog = Nothing
        m_intrecordid_status = Nothing
        m_blnprint = Constants.DEFAULT_VALUE_NO
        m_txtrecordupdateuser = String.Empty
        m_blnwebsearch = Constants.DEFAULT_VALUE_NO
        m_blnecommercetransmit = Constants.DEFAULT_VALUE_NO
        m_blnsecurity = Constants.DEFAULT_VALUE_NO
        m_dterecordsynchronization = Nothing
        m_blnerrorlog = Constants.DEFAULT_VALUE_NO
        m_txtfieldvaluegenerator = String.Empty
        m_blnsystemrecord = Constants.DEFAULT_VALUE_NO
        m_blnaudittrail = Constants.DEFAULT_VALUE_NO
        m_txtguid = Guid.NewGuid()
        m_blnfavorite = Constants.DEFAULT_VALUE_NO
    End Sub

#End Region

#Region "Methods"

    Public Sub Load(ByVal sdr As OleDbDataReader)
        If Not System.Convert.IsDBNull(sdr("intRecordID_DatabaseID")) Then
            m_intrecordid_databaseid = sdr.GetInt32(sdr.GetOrdinal("intRecordID_DatabaseID"))
        End If
        If Not System.Convert.IsDBNull(sdr("lblMessengerTransactionInformation")) Then
            m_lblmessengertransactioninformation = sdr.GetString(sdr.GetOrdinal("lblMessengerTransactionInformation"))
        End If
        If Not System.Convert.IsDBNull(sdr("ixtCode")) Then
            m_ixtcode = sdr.GetString(sdr.GetOrdinal("ixtCode"))
        End If
        If Not System.Convert.IsDBNull(sdr("txtDescription")) Then
            m_txtdescription = sdr.GetString(sdr.GetOrdinal("txtDescription"))
        End If
        If Not System.Convert.IsDBNull(sdr("lblMessengerTransaction")) Then
            m_lblmessengertransaction = sdr.GetString(sdr.GetOrdinal("lblMessengerTransaction"))
        End If
        If Not System.Convert.IsDBNull(sdr("intRecordID_MessengerConfiguration")) Then
            m_intrecordid_messengerconfiguration = sdr.GetInt32(sdr.GetOrdinal("intRecordID_MessengerConfiguration"))
        End If
        If Not System.Convert.IsDBNull(sdr("intRecordID_MessengerCommunicationProvider")) Then
            m_intrecordid_messengercommunicationprovider = sdr.GetInt32(sdr.GetOrdinal("intRecordID_MessengerCommunicationProvider"))
        End If
        If Not System.Convert.IsDBNull(sdr("intRecordID_MessengerDeliveryState")) Then
            m_intrecordid_messengerdeliverystate = sdr.GetInt32(sdr.GetOrdinal("intRecordID_MessengerDeliveryState"))
        End If
        If Not System.Convert.IsDBNull(sdr("intRecordID_MessengerDeliveryCode")) Then
            m_intrecordid_messengerdeliverycode = sdr.GetInt32(sdr.GetOrdinal("intRecordID_MessengerDeliveryCode"))
        End If
        If Not System.Convert.IsDBNull(sdr("intRecordID_Mail")) Then
            m_intrecordid_mail = sdr.GetInt32(sdr.GetOrdinal("intRecordID_Mail"))
        End If
        If Not System.Convert.IsDBNull(sdr("intRecordID_MailDetail")) Then
            m_intrecordid_maildetail = sdr.GetInt32(sdr.GetOrdinal("intRecordID_MailDetail"))
        End If
        If Not System.Convert.IsDBNull(sdr("decMaxNumberOfCharacters")) Then
            m_decmaxnumberofcharacters = sdr.GetDouble(sdr.GetOrdinal("decMaxNumberOfCharacters"))
        End If
        If Not System.Convert.IsDBNull(sdr("mmoTransaction")) Then
            m_mmotransaction = sdr.GetString(sdr.GetOrdinal("mmoTransaction"))
        End If
        If Not System.Convert.IsDBNull(sdr("txtElectronicDataExchangeCode")) Then
            m_txtelectronicdataexchangecode = sdr.GetString(sdr.GetOrdinal("txtElectronicDataExchangeCode"))
        End If
        If Not System.Convert.IsDBNull(sdr("lblCalendarReminder")) Then
            m_lblcalendarreminder = sdr.GetString(sdr.GetOrdinal("lblCalendarReminder"))
        End If
        If Not System.Convert.IsDBNull(sdr("dteFollowUpDate")) Then
            m_dtefollowupdate = sdr.GetDateTime(sdr.GetOrdinal("dteFollowUpDate"))
        End If
        If Not System.Convert.IsDBNull(sdr("txtEventStartTime")) Then
            m_txteventstarttime = sdr.GetString(sdr.GetOrdinal("txtEventStartTime"))
        End If
        If Not System.Convert.IsDBNull(sdr("txtEventEndTime")) Then
            m_txteventendtime = sdr.GetString(sdr.GetOrdinal("txtEventEndTime"))
        End If
        If Not System.Convert.IsDBNull(sdr("lblMessengerTransactionRecordInformation")) Then
            m_lblmessengertransactionrecordinformation = sdr.GetString(sdr.GetOrdinal("lblMessengerTransactionRecordInformation"))
        End If
        If Not System.Convert.IsDBNull(sdr("blnMakePrivate")) Then
            m_blnmakeprivate = sdr.GetString(sdr.GetOrdinal("blnMakePrivate"))
        End If
        If Not System.Convert.IsDBNull(sdr("blnActive")) Then
            m_blnactive = sdr.GetString(sdr.GetOrdinal("blnActive"))
        End If
        If Not System.Convert.IsDBNull(sdr("txtRecordCreationUser")) Then
            m_txtrecordcreationuser = sdr.GetString(sdr.GetOrdinal("txtRecordCreationUser"))
        End If
        If Not System.Convert.IsDBNull(sdr("dteRecordCreationDate")) Then
            m_dterecordcreationdate = sdr.GetDateTime(sdr.GetOrdinal("dteRecordCreationDate"))
        End If
        If Not System.Convert.IsDBNull(sdr("dteRecordUpdateDate")) Then
            m_dterecordupdatedate = sdr.GetDateTime(sdr.GetOrdinal("dteRecordUpdateDate"))
        End If
        If Not System.Convert.IsDBNull(sdr("blnCursor")) Then
            m_blncursor = sdr.GetString(sdr.GetOrdinal("blnCursor"))
        End If
        If Not System.Convert.IsDBNull(sdr("intRecordID_Company")) Then
            m_intrecordid_company = sdr.GetInt32(sdr.GetOrdinal("intRecordID_Company"))
        End If
        If Not System.Convert.IsDBNull(sdr("intRecordID_Division")) Then
            m_intrecordid_division = sdr.GetInt32(sdr.GetOrdinal("intRecordID_Division"))
        End If
        If Not System.Convert.IsDBNull(sdr("intRecordID")) Then
            m_intrecordid = sdr.GetInt32(sdr.GetOrdinal("intRecordID"))
        End If
        If Not System.Convert.IsDBNull(sdr("intRecordID_User_Creation")) Then
            m_intrecordid_user_creation = sdr.GetInt32(sdr.GetOrdinal("intRecordID_User_Creation"))
        End If
        If Not System.Convert.IsDBNull(sdr("blnAttachment")) Then
            m_blnattachment = sdr.GetString(sdr.GetOrdinal("blnAttachment"))
        End If
        If Not System.Convert.IsDBNull(sdr("blnDeleted")) Then
            m_blndeleted = sdr.GetString(sdr.GetOrdinal("blnDeleted"))
        End If
        If Not System.Convert.IsDBNull(sdr("blnHighlight")) Then
            m_blnhighlight = sdr.GetString(sdr.GetOrdinal("blnHighlight"))
        End If
        If Not System.Convert.IsDBNull(sdr("blnMemo")) Then
            m_blnmemo = sdr.GetString(sdr.GetOrdinal("blnMemo"))
        End If
        If Not System.Convert.IsDBNull(sdr("blnProcess")) Then
            m_blnprocess = sdr.GetString(sdr.GetOrdinal("blnProcess"))
        End If
        If Not System.Convert.IsDBNull(sdr("blnProject")) Then
            m_blnproject = sdr.GetString(sdr.GetOrdinal("blnProject"))
        End If
        If Not System.Convert.IsDBNull(sdr("intRecordID_ErrorLog")) Then
            m_intrecordid_errorlog = sdr.GetInt32(sdr.GetOrdinal("intRecordID_ErrorLog"))
        End If
        If Not System.Convert.IsDBNull(sdr("intRecordID_Status")) Then
            m_intrecordid_status = sdr.GetInt32(sdr.GetOrdinal("intRecordID_Status"))
        End If
        If Not System.Convert.IsDBNull(sdr("blnPrint")) Then
            m_blnprint = sdr.GetString(sdr.GetOrdinal("blnPrint"))
        End If
        If Not System.Convert.IsDBNull(sdr("txtRecordUpdateUser")) Then
            m_txtrecordupdateuser = sdr.GetString(sdr.GetOrdinal("txtRecordUpdateUser"))
        End If
        If Not System.Convert.IsDBNull(sdr("blnWebSearch")) Then
            m_blnwebsearch = sdr.GetString(sdr.GetOrdinal("blnWebSearch"))
        End If
        If Not System.Convert.IsDBNull(sdr("blnEcommerceTransmit")) Then
            m_blnecommercetransmit = sdr.GetString(sdr.GetOrdinal("blnEcommerceTransmit"))
        End If
        If Not System.Convert.IsDBNull(sdr("blnSecurity")) Then
            m_blnsecurity = sdr.GetString(sdr.GetOrdinal("blnSecurity"))
        End If
        If Not System.Convert.IsDBNull(sdr("dteRecordSynchronization")) Then
            m_dterecordsynchronization = sdr.GetDateTime(sdr.GetOrdinal("dteRecordSynchronization"))
        End If
        If Not System.Convert.IsDBNull(sdr("blnErrorLog")) Then
            m_blnerrorlog = sdr.GetString(sdr.GetOrdinal("blnErrorLog"))
        End If
        If Not System.Convert.IsDBNull(sdr("txtFieldValueGenerator")) Then
            m_txtfieldvaluegenerator = sdr.GetString(sdr.GetOrdinal("txtFieldValueGenerator"))
        End If
        If Not System.Convert.IsDBNull(sdr("blnSystemRecord")) Then
            m_blnsystemrecord = sdr.GetString(sdr.GetOrdinal("blnSystemRecord"))
        End If
        If Not System.Convert.IsDBNull(sdr("blnAuditTrail")) Then
            m_blnaudittrail = sdr.GetString(sdr.GetOrdinal("blnAuditTrail"))
        End If
        If Not System.Convert.IsDBNull(sdr("txtGUID")) Then
            m_txtguid = sdr.GetGuid(sdr.GetOrdinal("txtGUID"))
        End If
        If Not System.Convert.IsDBNull(sdr("blnFavorite")) Then
            m_blnfavorite = sdr.GetString(sdr.GetOrdinal("blnFavorite"))
        End If
    End Sub

    ''' <summary>
    ''' Overrides the ToString Function.
    ''' </summary>
    ''' <returns>The string representation of the Object</returns>
    Public Overrides Function ToString() As String
        Dim retValue As New System.Text.StringBuilder("Keys:" & ControlChars.Lf)

        retValue.Append(" intRecordID = """)
        retValue.Append(m_intrecordid)
        retValue.Append("")

        retValue.Append("Columns:" & ControlChars.Lf)
        retValue.Append(" intRecordID_DatabaseID = """)
        retValue.Append(m_intrecordid_databaseid)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" lblMessengerTransactionInformation = """)
        retValue.Append(m_lblmessengertransactioninformation)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" ixtCode = """)
        retValue.Append(m_ixtcode)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" txtDescription = """)
        retValue.Append(m_txtdescription)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" lblMessengerTransaction = """)
        retValue.Append(m_lblmessengertransaction)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" intRecordID_MessengerConfiguration = """)
        retValue.Append(m_intrecordid_messengerconfiguration)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" intRecordID_MessengerCommunicationProvider = """)
        retValue.Append(m_intrecordid_messengercommunicationprovider)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" intRecordID_MessengerDeliveryState = """)
        retValue.Append(m_intrecordid_messengerdeliverystate)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" intRecordID_MessengerDeliveryCode = """)
        retValue.Append(m_intrecordid_messengerdeliverycode)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" intRecordID_Mail = """)
        retValue.Append(m_intrecordid_mail)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" intRecordID_MailDetail = """)
        retValue.Append(m_intrecordid_maildetail)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" decMaxNumberOfCharacters = """)
        retValue.Append(m_decmaxnumberofcharacters)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" mmoTransaction = """)
        retValue.Append(m_mmotransaction)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" txtElectronicDataExchangeCode = """)
        retValue.Append(m_txtelectronicdataexchangecode)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" lblCalendarReminder = """)
        retValue.Append(m_lblcalendarreminder)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" dteFollowUpDate = """)
        retValue.Append(m_dtefollowupdate)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" txtEventStartTime = """)
        retValue.Append(m_txteventstarttime)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" txtEventEndTime = """)
        retValue.Append(m_txteventendtime)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" lblMessengerTransactionRecordInformation = """)
        retValue.Append(m_lblmessengertransactionrecordinformation)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" blnMakePrivate = """)
        retValue.Append(m_blnmakeprivate)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" blnActive = """)
        retValue.Append(m_blnactive)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" txtRecordCreationUser = """)
        retValue.Append(m_txtrecordcreationuser)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" dteRecordCreationDate = """)
        retValue.Append(m_dterecordcreationdate)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" dteRecordUpdateDate = """)
        retValue.Append(m_dterecordupdatedate)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" blnCursor = """)
        retValue.Append(m_blncursor)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" intRecordID_Company = """)
        retValue.Append(m_intrecordid_company)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" intRecordID_Division = """)
        retValue.Append(m_intrecordid_division)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" intRecordID_User_Creation = """)
        retValue.Append(m_intrecordid_user_creation)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" blnAttachment = """)
        retValue.Append(m_blnattachment)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" blnDeleted = """)
        retValue.Append(m_blndeleted)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" blnHighlight = """)
        retValue.Append(m_blnhighlight)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" blnMemo = """)
        retValue.Append(m_blnmemo)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" blnProcess = """)
        retValue.Append(m_blnprocess)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" blnProject = """)
        retValue.Append(m_blnproject)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" intRecordID_ErrorLog = """)
        retValue.Append(m_intrecordid_errorlog)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" intRecordID_Status = """)
        retValue.Append(m_intrecordid_status)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" blnPrint = """)
        retValue.Append(m_blnprint)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" txtRecordUpdateUser = """)
        retValue.Append(m_txtrecordupdateuser)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" blnWebSearch = """)
        retValue.Append(m_blnwebsearch)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" blnEcommerceTransmit = """)
        retValue.Append(m_blnecommercetransmit)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" blnSecurity = """)
        retValue.Append(m_blnsecurity)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" dteRecordSynchronization = """)
        retValue.Append(m_dterecordsynchronization)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" blnErrorLog = """)
        retValue.Append(m_blnerrorlog)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" txtFieldValueGenerator = """)
        retValue.Append(m_txtfieldvaluegenerator)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" blnSystemRecord = """)
        retValue.Append(m_blnsystemrecord)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" blnAuditTrail = """)
        retValue.Append(m_blnaudittrail)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" txtGUID = """)
        retValue.Append(m_txtguid)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" blnFavorite = """)
        retValue.Append(m_blnfavorite)
        retValue.Append("""" & ControlChars.Lf)

        Return retValue.ToString()
    End Function

#End Region

#Region "Shared Methods"

    Public Shared Function SelectByID(ByVal intrecordid As Int32) As tblMessengerTransaction
        If intrecordid <= 0 OrElse intrecordid >= Int32.MaxValue Then
            Return Nothing
        End If

        Dim obj As tblMessengerTransaction = Nothing

        Try
            Using cn As New OleDbConnection(DbApplication.Context.ConnString)
                Dim sql As New StringBuilder()

                sql.Append("Select * From [dbo].[tblMessengerTransaction] Where [intRecordID] = ? ")

                Using cm As OleDbCommand = cn.CreateCommand()
                    cm.CommandType = CommandType.Text
                    cm.CommandText = sql.ToString()

                    cm.Parameters.AddWithValue("", intrecordid)

                    cn.Open()

                    Using sdr As OleDbDataReader = cm.ExecuteReader()
                        Do While sdr.Read()
                            obj = New tblMessengerTransaction()

                            obj.Load(sdr)
                        Loop
                    End Using
                End Using
            End Using
        Catch e1 As OleDbException
            Throw
        End Try

        Return obj
    End Function

    Public Shared Function SelectNextID() As Integer
        Dim returnValue As Integer = -1

        Try
            Using cn As New OleDbConnection(DbApplication.Context.ConnString)
                Dim sql As New StringBuilder()

                sql.Append("Select MAX([intRecordID]) FROM [dbo].[tblMessengerTransaction] ")

                Using cm As OleDbCommand = cn.CreateCommand()
                    cm.CommandType = CommandType.Text
                    cm.CommandText = sql.ToString()

                    cn.Open()

                    Dim results As Object = cm.ExecuteScalar()

                    If results IsNot Nothing AndAlso ((Not System.Convert.IsDBNull(results))) Then
                        returnValue = DirectCast(results, Integer)
                        returnValue = (returnValue + 1)
                    Else
                        returnValue = 1
                    End If
                End Using
            End Using
        Catch e1 As OleDbException
            Throw
        End Try

        Return returnValue
    End Function

    <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert)>
    Public Shared Function CreateNew(ByVal obj As tblMessengerTransaction) As Boolean
        If obj Is Nothing Then
            Return False
        End If

        Try
            Using cn As New OleDbConnection(DbApplication.Context.ConnString)
                Dim sql As New StringBuilder()

                sql.Append("INSERT INTO [tblMessengerTransaction] (")
                sql.Append("[intRecordID_DatabaseID], ")
                sql.Append("[lblMessengerTransactionInformation], [ixtCode], [txtDescription], [lblMessengerTransaction], ")
                sql.Append("[intRecordID_MessengerConfiguration], [intRecordID_MessengerCommunicationProvider], [intRecordID_MessengerDeliveryState], [intRecordID_MessengerDeliveryCode], ")
                sql.Append("[intRecordID_Mail], [intRecordID_MailDetail], [decMaxNumberOfCharacters], [mmoTransaction], ")
                sql.Append("[txtElectronicDataExchangeCode], [lblCalendarReminder], [dteFollowUpDate], [txtEventStartTime], ")
                sql.Append("[txtEventEndTime], [lblMessengerTransactionRecordInformation], [blnMakePrivate], [blnActive], ")
                sql.Append("[txtRecordCreationUser], [dteRecordCreationDate], [dteRecordUpdateDate], [blnCursor], ")
                sql.Append("[intRecordID_Company], [intRecordID_Division], [intRecordID], [intRecordID_User_Creation], ")
                sql.Append("[blnAttachment], [blnDeleted], [blnHighlight], [blnMemo], ")
                sql.Append("[blnProcess], [blnProject], [intRecordID_ErrorLog], [intRecordID_Status], ")
                sql.Append("[blnPrint], [txtRecordUpdateUser], [blnWebSearch], [blnEcommerceTransmit], ")
                sql.Append("[blnSecurity], [dteRecordSynchronization], [blnErrorLog], [txtFieldValueGenerator], ")
                sql.Append("[blnSystemRecord], [blnAuditTrail], [txtGUID], [blnFavorite])")
                sql.Append("VALUES 	(")
                sql.Append("?, ")
                sql.Append("?, ?, ?, ?, ")
                sql.Append("?, ?, ?, ?, ")
                sql.Append("?, ?, ?, ?, ")
                sql.Append("?, ?, ?, ?, ")
                sql.Append("?, ?, ?, ?, ")
                sql.Append("?, ?, ?, ?, ")
                sql.Append("?, ?, ?, ?, ")
                sql.Append("?, ?, ?, ?, ")
                sql.Append("?, ?, ?, ?, ")
                sql.Append("?, ?, ?, ?, ")
                sql.Append("?, ?, ?, ?, ")
                sql.Append("?, ?, ?, ?)")

                Using cm As OleDbCommand = cn.CreateCommand()
                    cm.CommandType = CommandType.Text
                    cm.CommandText = sql.ToString()

                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intRecordID_DatabaseID))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.lblMessengerTransactionInformation))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.ixtCode))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.txtDescription))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.lblMessengerTransaction))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intRecordID_MessengerConfiguration))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intRecordID_MessengerCommunicationProvider))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intRecordID_MessengerDeliveryState))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intRecordID_MessengerDeliveryCode))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intRecordID_Mail))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intRecordID_MailDetail))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.decMaxNumberOfCharacters))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.mmoTransaction))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.txtElectronicDataExchangeCode))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.lblCalendarReminder))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.dteFollowUpDate)).OleDbType = OleDbType.Date
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.txtEventStartTime))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.txtEventEndTime))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.lblMessengerTransactionRecordInformation))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.blnMakePrivate))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.blnActive))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.txtRecordCreationUser))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.dteRecordCreationDate))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.dteRecordUpdateDate))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.blnCursor))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intRecordID_Company))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intRecordID_Division))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intRecordID))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intRecordID_User_Creation))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.blnAttachment))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.blnDeleted))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.blnHighlight))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.blnMemo))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.blnProcess))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.blnProject))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intRecordID_ErrorLog))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intRecordID_Status))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.blnPrint))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.txtRecordUpdateUser))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.blnWebSearch))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.blnEcommerceTransmit))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.blnSecurity))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.dteRecordSynchronization)).OleDbType = OleDbType.Date
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.blnErrorLog))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.txtFieldValueGenerator))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.blnSystemRecord))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.blnAuditTrail))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.txtGUID))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.blnFavorite))

                    cn.Open()

                    Dim rowsAffected As Integer = cm.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        Return True
                    End If
                End Using
            End Using

            Return False
        Catch e1 As OleDbException
            Throw
        End Try
    End Function

    <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Update)>
    Public Shared Function Update(ByVal obj As tblMessengerTransaction) As Boolean
        If obj Is Nothing OrElse obj.intRecordID <= 0 OrElse obj.intRecordID >= Int32.MaxValue Then
            Return False
        End If

        obj.txtRecordUpdateUser = My.Application.Info.AssemblyName
        obj.dteRecordUpdateDate = Date.Now

        Try
            Using cn As New OleDbConnection(DbApplication.Context.ConnString)
                Dim sql As New StringBuilder()

                sql.Append("UPDATE [dbo].[tblMessengerTransaction] SET ")
                sql.Append("[intRecordID_DatabaseID] = ?, ")
                sql.Append("[lblMessengerTransactionInformation] = ?, ")
                sql.Append("[ixtCode] = ?, ")
                sql.Append("[txtDescription] = ?, ")
                sql.Append("[lblMessengerTransaction] = ?, ")
                sql.Append("[intRecordID_MessengerConfiguration] = ?, ")
                sql.Append("[intRecordID_MessengerCommunicationProvider] = ?, ")
                sql.Append("[intRecordID_MessengerDeliveryState] = ?, ")
                sql.Append("[intRecordID_MessengerDeliveryCode] = ?, ")
                sql.Append("[intRecordID_Mail] = ?, ")
                sql.Append("[intRecordID_MailDetail] = ?, ")
                sql.Append("[decMaxNumberOfCharacters] = ?, ")
                sql.Append("[mmoTransaction] = ?, ")
                sql.Append("[txtElectronicDataExchangeCode] = ?, ")
                sql.Append("[lblCalendarReminder] = ?, ")
                sql.Append("[dteFollowUpDate] = ?, ")
                sql.Append("[txtEventStartTime] = ?, ")
                sql.Append("[txtEventEndTime] = ?, ")
                sql.Append("[lblMessengerTransactionRecordInformation] = ?, ")
                sql.Append("[blnMakePrivate] = ?, ")
                sql.Append("[blnActive] = ?, ")
                sql.Append("[txtRecordCreationUser] = ?, ")
                sql.Append("[dteRecordCreationDate] = ?, ")
                sql.Append("[dteRecordUpdateDate] = ?, ")
                sql.Append("[blnCursor] = ?, ")
                sql.Append("[intRecordID_Company] = ?, ")
                sql.Append("[intRecordID_Division] = ?, ")
                sql.Append("[intRecordID_User_Creation] = ?, ")
                sql.Append("[blnAttachment] = ?, ")
                sql.Append("[blnDeleted] = ?, ")
                sql.Append("[blnHighlight] = ?, ")
                sql.Append("[blnMemo] = ?, ")
                sql.Append("[blnProcess] = ?, ")
                sql.Append("[blnProject] = ?, ")
                sql.Append("[intRecordID_ErrorLog] = ?, ")
                sql.Append("[intRecordID_Status] = ?, ")
                sql.Append("[blnPrint] = ?, ")
                sql.Append("[txtRecordUpdateUser] = ?, ")
                sql.Append("[blnWebSearch] = ?, ")
                sql.Append("[blnEcommerceTransmit] = ?, ")
                sql.Append("[blnSecurity] = ?, ")
                sql.Append("[dteRecordSynchronization] = ?, ")
                sql.Append("[blnErrorLog] = ?, ")
                sql.Append("[txtFieldValueGenerator] = ?, ")
                sql.Append("[blnSystemRecord] = ?, ")
                sql.Append("[blnAuditTrail] = ?, ")
                sql.Append("[txtGUID] = ?, ")
                sql.Append("[blnFavorite] = ? ")
                sql.Append("WHERE intRecordID = ?")

                Using cm As OleDbCommand = cn.CreateCommand()
                    cm.CommandType = CommandType.Text
                    cm.CommandText = sql.ToString()

                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intRecordID_DatabaseID))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.lblMessengerTransactionInformation))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.ixtCode))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.txtDescription))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.lblMessengerTransaction))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intRecordID_MessengerConfiguration))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intRecordID_MessengerCommunicationProvider))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intRecordID_MessengerDeliveryState))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intRecordID_MessengerDeliveryCode))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intRecordID_Mail))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intRecordID_MailDetail))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.decMaxNumberOfCharacters))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.mmoTransaction))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.txtElectronicDataExchangeCode))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.lblCalendarReminder))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.dteFollowUpDate)).OleDbType = OleDbType.Date
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.txtEventStartTime))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.txtEventEndTime))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.lblMessengerTransactionRecordInformation))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.blnMakePrivate))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.blnActive))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.txtRecordCreationUser))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.dteRecordCreationDate))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.dteRecordUpdateDate))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.blnCursor))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intRecordID_Company))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intRecordID_Division))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intRecordID_User_Creation))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.blnAttachment))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.blnDeleted))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.blnHighlight))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.blnMemo))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.blnProcess))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.blnProject))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intRecordID_ErrorLog))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intRecordID_Status))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.blnPrint))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.txtRecordUpdateUser))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.blnWebSearch))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.blnEcommerceTransmit))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.blnSecurity))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.dteRecordSynchronization)).OleDbType = OleDbType.Date
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.blnErrorLog))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.txtFieldValueGenerator))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.blnSystemRecord))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.blnAuditTrail))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.txtGUID))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.blnFavorite))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intRecordID))

                    cn.Open()

                    Dim rowsAffected As Integer = cm.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        Return True
                    End If
                End Using
            End Using
        Catch e1 As OleDbException
            Throw
        End Try

        Return False
    End Function

    <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Delete)>
    Public Shared Function Delete(ByVal obj As tblMessengerTransaction) As Boolean
        If obj Is Nothing OrElse obj.intRecordID <= 0 OrElse obj.intRecordID >= Int32.MaxValue Then
            Return False
        End If

        Try
            Using cn As New OleDbConnection(DbApplication.Context.ConnString)
                Dim sql As New StringBuilder()

                sql.Append("DELETE [dbo].[tblMessengerTransaction] WHERE [intRecordID] = ?")

                Using cm As OleDbCommand = cn.CreateCommand()
                    cm.CommandType = CommandType.Text
                    cm.CommandText = sql.ToString()

                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intRecordID))

                    cn.Open()

                    Dim rowsAffected As Integer = cm.ExecuteNonQuery()

                    If rowsAffected > 0 Then
                        Return True
                    End If
                End Using
            End Using
        Catch e1 As OleDbException
            Throw
        End Try

        Return False
    End Function

#End Region

End Class