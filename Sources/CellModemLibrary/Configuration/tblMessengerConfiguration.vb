Imports System.Text
Imports System.Data
Imports System.Data.OleDb

Namespace Configuration

    Public NotInheritable Class tblMessengerConfiguration

#Region "Fields"

        Private m_intrecordid_databaseid? As Int32
        Private m_lblmessengerconfigurationinformation As String
        Private m_ixtcode As String
        Private m_txtdescription As String
        Private m_lblmailmessengerconfiguration As String
        Private m_lbmifsettoyeswilloverrideusemodemoption As String
        Private m_blnusecommunicationprovider As String
        Private m_intrecordid_messengercommunicationprovider? As Int32
        Private m_intnumberofsecondstowaittorun? As Int32
        Private m_lblmessengerconfigurationmodemsettings As String
        Private m_lbmusecommunicationproviderwilloverridethisoption As String
        Private m_blnusemodem As String
        Private m_txtmodemmanufacturer As String
        Private m_txtmodemmodel As String
        Private m_txtphonenumberassigned As String
        Private m_txtport As String
        Private m_intbaudrate? As Int32
        Private m_intdatabits? As Int32
        Private m_txtparity As String
        Private m_decstopbits? As Double
        Private m_txtcellularmodemaccesspin As String
        Private m_intfailedmessageresendtimedelayinminutes? As Int32
        Private m_txtreturnerrorcodeforinvalidphone As String
        Private m_blndeletereceivedmessagesfrommodem As String
        Private m_intintervaltocheckfornewmessagesinminutes? As Int32
        Private m_lblmessengerconfigurationemailsettings As String
        Private m_lbmcellmessengerwillsendemailsasopposedtorocket As String
        Private m_lbmmustalsosetcompanysettingtousemessengerforemailtext As String
        Private m_blnusemessengertosendemailsviainternet As String
        Private m_lblmessengerconfigurationgeneralsettings As String
        Private m_txtfileattachmentpath As String
        Private m_lblmessengerconfigurationtextalert As String
        Private m_lbmusetonotifyuserswhenatextisreceived As String
        Private m_lbmseperateemailaddresswithasemicolon As String
        Private m_mmotextreceiptemailalertnotificationlist As String
        Private m_mmotextreceiptemailmessagetouserlist As String
        Private m_txtelectronicdataexchangecode As String
        Private m_lblcalendarreminder As String
        Private m_dtefollowupdate? As Date
        Private m_txteventstarttime As String
        Private m_txteventendtime As String
        Private m_lblmessengerconfigurationrecordinformation As String
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
        Private m_dterecordsynchronization? As Date
        Private m_blnwebsearch As String
        Private m_blnsecurity As String
        Private m_blnerrorlog As String
        Private m_blnaudittrail As String
        Private m_txtfieldvaluegenerator As String
        Private m_blnsystemrecord As String
        Private m_blnecommercetransmit As String
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
        ''' The lblMessengerConfigurationInformation column is in the DB
        ''' </summary>
        Public Property lblMessengerConfigurationInformation() As String
            <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
            Get
                If String.IsNullOrEmpty(m_lblmessengerconfigurationinformation) Then
                    Return String.Empty
                Else
                    Return m_lblmessengerconfigurationinformation
                End If
            End Get
            <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
            Set(ByVal value As String)
                If value Is Nothing Then
                    value = String.Empty
                End If
                If m_lblmessengerconfigurationinformation <> value Then
                    m_lblmessengerconfigurationinformation = value
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
        ''' The lblMailMessengerConfiguration column is in the DB
        ''' </summary>
        Public Property lblMailMessengerConfiguration() As String
            <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
            Get
                If String.IsNullOrEmpty(m_lblmailmessengerconfiguration) Then
                    Return String.Empty
                Else
                    Return m_lblmailmessengerconfiguration
                End If
            End Get
            <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
            Set(ByVal value As String)
                If value Is Nothing Then
                    value = String.Empty
                End If
                If m_lblmailmessengerconfiguration <> value Then
                    m_lblmailmessengerconfiguration = value
                End If
            End Set
        End Property

        ''' <summary>
        ''' The lbmIfSetToYesWillOverrideUseModemOption column is in the DB
        ''' </summary>
        Public Property lbmIfSetToYesWillOverrideUseModemOption() As String
            <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
            Get
                If String.IsNullOrEmpty(m_lbmifsettoyeswilloverrideusemodemoption) Then
                    Return String.Empty
                Else
                    Return m_lbmifsettoyeswilloverrideusemodemoption
                End If
            End Get
            <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
            Set(ByVal value As String)
                If value Is Nothing Then
                    value = String.Empty
                End If
                If m_lbmifsettoyeswilloverrideusemodemoption <> value Then
                    m_lbmifsettoyeswilloverrideusemodemoption = value
                End If
            End Set
        End Property

        ''' <summary>
        ''' The blnUseCommunicationProvider column is in the DB
        ''' </summary>
        Public Property blnUseCommunicationProvider() As String
            <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
            Get
                If String.IsNullOrEmpty(m_blnusecommunicationprovider) Then
                    Return String.Empty
                Else
                    Return m_blnusecommunicationprovider
                End If
            End Get
            <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
            Set(ByVal value As String)
                If value Is Nothing Then
                    value = String.Empty
                End If
                If m_blnusecommunicationprovider <> value Then
                    m_blnusecommunicationprovider = value
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
        ''' The intNumberOfSecondsToWaitToRun column is in the DB
        ''' </summary>
        Public Property intNumberOfSecondsToWaitToRun() As Int32?
            <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
            Get
                Return m_intnumberofsecondstowaittorun
            End Get
            <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
            Set(ByVal value? As Int32)
                If Not m_intnumberofsecondstowaittorun.Equals(value) Then
                    m_intnumberofsecondstowaittorun = value
                End If
            End Set
        End Property

        ''' <summary>
        ''' The lblMessengerConfigurationModemSettings column is in the DB
        ''' </summary>
        Public Property lblMessengerConfigurationModemSettings() As String
            <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
            Get
                If String.IsNullOrEmpty(m_lblmessengerconfigurationmodemsettings) Then
                    Return String.Empty
                Else
                    Return m_lblmessengerconfigurationmodemsettings
                End If
            End Get
            <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
            Set(ByVal value As String)
                If value Is Nothing Then
                    value = String.Empty
                End If
                If m_lblmessengerconfigurationmodemsettings <> value Then
                    m_lblmessengerconfigurationmodemsettings = value
                End If
            End Set
        End Property

        ''' <summary>
        ''' The lbmUseCommunicationProviderWillOverrideThisOption column is in the DB
        ''' </summary>
        Public Property lbmUseCommunicationProviderWillOverrideThisOption() As String
            <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
            Get
                If String.IsNullOrEmpty(m_lbmusecommunicationproviderwilloverridethisoption) Then
                    Return String.Empty
                Else
                    Return m_lbmusecommunicationproviderwilloverridethisoption
                End If
            End Get
            <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
            Set(ByVal value As String)
                If value Is Nothing Then
                    value = String.Empty
                End If
                If m_lbmusecommunicationproviderwilloverridethisoption <> value Then
                    m_lbmusecommunicationproviderwilloverridethisoption = value
                End If
            End Set
        End Property

        ''' <summary>
        ''' The blnUseModem column is in the DB
        ''' </summary>
        Public Property blnUseModem() As String
            <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
            Get
                If String.IsNullOrEmpty(m_blnusemodem) Then
                    Return String.Empty
                Else
                    Return m_blnusemodem
                End If
            End Get
            <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
            Set(ByVal value As String)
                If value Is Nothing Then
                    value = String.Empty
                End If
                If m_blnusemodem <> value Then
                    m_blnusemodem = value
                End If
            End Set
        End Property

        ''' <summary>
        ''' The txtModemManufacturer column is in the DB
        ''' </summary>
        Public Property txtModemManufacturer() As String
            <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
            Get
                If String.IsNullOrEmpty(m_txtmodemmanufacturer) Then
                    Return String.Empty
                Else
                    Return m_txtmodemmanufacturer
                End If
            End Get
            <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
            Set(ByVal value As String)
                If value Is Nothing Then
                    value = String.Empty
                End If
                If m_txtmodemmanufacturer <> value Then
                    m_txtmodemmanufacturer = value
                End If
            End Set
        End Property

        ''' <summary>
        ''' The txtModemModel column is in the DB
        ''' </summary>
        Public Property txtModemModel() As String
            <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
            Get
                If String.IsNullOrEmpty(m_txtmodemmodel) Then
                    Return String.Empty
                Else
                    Return m_txtmodemmodel
                End If
            End Get
            <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
            Set(ByVal value As String)
                If value Is Nothing Then
                    value = String.Empty
                End If
                If m_txtmodemmodel <> value Then
                    m_txtmodemmodel = value
                End If
            End Set
        End Property

        ''' <summary>
        ''' The txtPhoneNumberAssigned column is in the DB
        ''' </summary>
        Public Property txtPhoneNumberAssigned() As String
            <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
            Get
                If String.IsNullOrEmpty(m_txtphonenumberassigned) Then
                    Return String.Empty
                Else
                    Return m_txtphonenumberassigned
                End If
            End Get
            <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
            Set(ByVal value As String)
                If value Is Nothing Then
                    value = String.Empty
                End If
                If m_txtphonenumberassigned <> value Then
                    m_txtphonenumberassigned = value
                End If
            End Set
        End Property

        ''' <summary>
        ''' The txtPort column is in the DB
        ''' </summary>
        Public Property txtPort() As String
            <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
            Get
                If String.IsNullOrEmpty(m_txtport) Then
                    Return String.Empty
                Else
                    Return m_txtport
                End If
            End Get
            <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
            Set(ByVal value As String)
                If value Is Nothing Then
                    value = String.Empty
                End If
                If m_txtport <> value Then
                    m_txtport = value
                End If
            End Set
        End Property

        ''' <summary>
        ''' The intBaudRate column is in the DB
        ''' </summary>
        Public Property intBaudRate() As Int32?
            <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
            Get
                Return m_intbaudrate
            End Get
            <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
            Set(ByVal value? As Int32)
                If Not m_intbaudrate.Equals(value) Then
                    m_intbaudrate = value
                End If
            End Set
        End Property

        ''' <summary>
        ''' The intDataBits column is in the DB
        ''' </summary>
        Public Property intDataBits() As Int32?
            <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
            Get
                Return m_intdatabits
            End Get
            <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
            Set(ByVal value? As Int32)
                If Not m_intdatabits.Equals(value) Then
                    m_intdatabits = value
                End If
            End Set
        End Property

        ''' <summary>
        ''' The txtParity column is in the DB
        ''' </summary>
        Public Property txtParity() As String
            <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
            Get
                If String.IsNullOrEmpty(m_txtparity) Then
                    Return String.Empty
                Else
                    Return m_txtparity
                End If
            End Get
            <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
            Set(ByVal value As String)
                If value Is Nothing Then
                    value = String.Empty
                End If
                If m_txtparity <> value Then
                    m_txtparity = value
                End If
            End Set
        End Property

        ''' <summary>
        ''' The decStopBits column is in the DB
        ''' </summary>
        Public Property decStopBits() As Double?
            <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
            Get
                Return m_decstopbits
            End Get
            <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
            Set(ByVal value? As Double)
                If Not m_decstopbits.Equals(value) Then
                    m_decstopbits = value
                End If
            End Set
        End Property

        ''' <summary>
        ''' The txtCellularModemAccessPIN column is in the DB
        ''' </summary>
        Public Property txtCellularModemAccessPIN() As String
            <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
            Get
                If String.IsNullOrEmpty(m_txtcellularmodemaccesspin) Then
                    Return String.Empty
                Else
                    Return m_txtcellularmodemaccesspin
                End If
            End Get
            <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
            Set(ByVal value As String)
                If value Is Nothing Then
                    value = String.Empty
                End If
                If m_txtcellularmodemaccesspin <> value Then
                    m_txtcellularmodemaccesspin = value
                End If
            End Set
        End Property

        ''' <summary>
        ''' The intFailedMessageResendTimeDelayInMinutes column is in the DB
        ''' </summary>
        Public Property intFailedMessageResendTimeDelayInMinutes() As Int32?
            <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
            Get
                Return m_intfailedmessageresendtimedelayinminutes
            End Get
            <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
            Set(ByVal value? As Int32)
                If Not m_intfailedmessageresendtimedelayinminutes.Equals(value) Then
                    m_intfailedmessageresendtimedelayinminutes = value
                End If
            End Set
        End Property

        ''' <summary>
        ''' The txtReturnErrorCodeForInvalidPhone column is in the DB
        ''' </summary>
        Public Property txtReturnErrorCodeForInvalidPhone() As String
            <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
            Get
                If String.IsNullOrEmpty(m_txtreturnerrorcodeforinvalidphone) Then
                    Return String.Empty
                Else
                    Return m_txtreturnerrorcodeforinvalidphone
                End If
            End Get
            <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
            Set(ByVal value As String)
                If value Is Nothing Then
                    value = String.Empty
                End If
                If m_txtreturnerrorcodeforinvalidphone <> value Then
                    m_txtreturnerrorcodeforinvalidphone = value
                End If
            End Set
        End Property

        ''' <summary>
        ''' The blnDeleteReceivedMessagesFromModem column is in the DB
        ''' </summary>
        Public Property blnDeleteReceivedMessagesFromModem() As String
            <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
            Get
                If String.IsNullOrEmpty(m_blndeletereceivedmessagesfrommodem) Then
                    Return String.Empty
                Else
                    Return m_blndeletereceivedmessagesfrommodem
                End If
            End Get
            <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
            Set(ByVal value As String)
                If value Is Nothing Then
                    value = String.Empty
                End If
                If m_blndeletereceivedmessagesfrommodem <> value Then
                    m_blndeletereceivedmessagesfrommodem = value
                End If
            End Set
        End Property

        ''' <summary>
        ''' The intIntervalToCheckForNewMessagesInMinutes column is in the DB
        ''' </summary>
        Public Property intIntervalToCheckForNewMessagesInMinutes() As Int32?
            <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
            Get
                Return m_intintervaltocheckfornewmessagesinminutes
            End Get
            <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
            Set(ByVal value? As Int32)
                If Not m_intintervaltocheckfornewmessagesinminutes.Equals(value) Then
                    m_intintervaltocheckfornewmessagesinminutes = value
                End If
            End Set
        End Property

        ''' <summary>
        ''' The lblMessengerConfigurationEmailSettings column is in the DB
        ''' </summary>
        Public Property lblMessengerConfigurationEmailSettings() As String
            <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
            Get
                If String.IsNullOrEmpty(m_lblmessengerconfigurationemailsettings) Then
                    Return String.Empty
                Else
                    Return m_lblmessengerconfigurationemailsettings
                End If
            End Get
            <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
            Set(ByVal value As String)
                If value Is Nothing Then
                    value = String.Empty
                End If
                If m_lblmessengerconfigurationemailsettings <> value Then
                    m_lblmessengerconfigurationemailsettings = value
                End If
            End Set
        End Property

        ''' <summary>
        ''' The lbmCellMessengerWillSendEmailsAsOpposedToROCKET column is in the DB
        ''' </summary>
        Public Property lbmCellMessengerWillSendEmailsAsOpposedToROCKET() As String
            <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
            Get
                If String.IsNullOrEmpty(m_lbmcellmessengerwillsendemailsasopposedtorocket) Then
                    Return String.Empty
                Else
                    Return m_lbmcellmessengerwillsendemailsasopposedtorocket
                End If
            End Get
            <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
            Set(ByVal value As String)
                If value Is Nothing Then
                    value = String.Empty
                End If
                If m_lbmcellmessengerwillsendemailsasopposedtorocket <> value Then
                    m_lbmcellmessengerwillsendemailsasopposedtorocket = value
                End If
            End Set
        End Property

        ''' <summary>
        ''' The lbmMustAlsoSetCompanySettingToUseMessengerForEmailText column is in the DB
        ''' </summary>
        Public Property lbmMustAlsoSetCompanySettingToUseMessengerForEmailText() As String
            <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
            Get
                If String.IsNullOrEmpty(m_lbmmustalsosetcompanysettingtousemessengerforemailtext) Then
                    Return String.Empty
                Else
                    Return m_lbmmustalsosetcompanysettingtousemessengerforemailtext
                End If
            End Get
            <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
            Set(ByVal value As String)
                If value Is Nothing Then
                    value = String.Empty
                End If
                If m_lbmmustalsosetcompanysettingtousemessengerforemailtext <> value Then
                    m_lbmmustalsosetcompanysettingtousemessengerforemailtext = value
                End If
            End Set
        End Property

        ''' <summary>
        ''' The blnUseMessengerToSendEmailsViaInternet column is in the DB
        ''' </summary>
        Public Property blnUseMessengerToSendEmailsViaInternet() As String
            <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
            Get
                If String.IsNullOrEmpty(m_blnusemessengertosendemailsviainternet) Then
                    Return String.Empty
                Else
                    Return m_blnusemessengertosendemailsviainternet
                End If
            End Get
            <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
            Set(ByVal value As String)
                If value Is Nothing Then
                    value = String.Empty
                End If
                If m_blnusemessengertosendemailsviainternet <> value Then
                    m_blnusemessengertosendemailsviainternet = value
                End If
            End Set
        End Property

        ''' <summary>
        ''' The lblMessengerConfigurationGeneralSettings column is in the DB
        ''' </summary>
        Public Property lblMessengerConfigurationGeneralSettings() As String
            <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
            Get
                If String.IsNullOrEmpty(m_lblmessengerconfigurationgeneralsettings) Then
                    Return String.Empty
                Else
                    Return m_lblmessengerconfigurationgeneralsettings
                End If
            End Get
            <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
            Set(ByVal value As String)
                If value Is Nothing Then
                    value = String.Empty
                End If
                If m_lblmessengerconfigurationgeneralsettings <> value Then
                    m_lblmessengerconfigurationgeneralsettings = value
                End If
            End Set
        End Property

        ''' <summary>
        ''' The txtFileAttachmentPath column is in the DB
        ''' </summary>
        Public Property txtFileAttachmentPath() As String
            <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
            Get
                If String.IsNullOrEmpty(m_txtfileattachmentpath) Then
                    Return String.Empty
                Else
                    Return m_txtfileattachmentpath
                End If
            End Get
            <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
            Set(ByVal value As String)
                If value Is Nothing Then
                    value = String.Empty
                End If
                If m_txtfileattachmentpath <> value Then
                    m_txtfileattachmentpath = value
                End If
            End Set
        End Property

        ''' <summary>
        ''' The lblMessengerConfigurationTextAlert column is in the DB
        ''' </summary>
        Public Property lblMessengerConfigurationTextAlert() As String
            <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
            Get
                If String.IsNullOrEmpty(m_lblmessengerconfigurationtextalert) Then
                    Return String.Empty
                Else
                    Return m_lblmessengerconfigurationtextalert
                End If
            End Get
            <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
            Set(ByVal value As String)
                If value Is Nothing Then
                    value = String.Empty
                End If
                If m_lblmessengerconfigurationtextalert <> value Then
                    m_lblmessengerconfigurationtextalert = value
                End If
            End Set
        End Property

        ''' <summary>
        ''' The lbmUseToNotifyUsersWhenATextIsReceived column is in the DB
        ''' </summary>
        Public Property lbmUseToNotifyUsersWhenATextIsReceived() As String
            <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
            Get
                If String.IsNullOrEmpty(m_lbmusetonotifyuserswhenatextisreceived) Then
                    Return String.Empty
                Else
                    Return m_lbmusetonotifyuserswhenatextisreceived
                End If
            End Get
            <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
            Set(ByVal value As String)
                If value Is Nothing Then
                    value = String.Empty
                End If
                If m_lbmusetonotifyuserswhenatextisreceived <> value Then
                    m_lbmusetonotifyuserswhenatextisreceived = value
                End If
            End Set
        End Property

        ''' <summary>
        ''' The lbmSeperateEmailAddressWithASemicolon column is in the DB
        ''' </summary>
        Public Property lbmSeperateEmailAddressWithASemicolon() As String
            <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
            Get
                If String.IsNullOrEmpty(m_lbmseperateemailaddresswithasemicolon) Then
                    Return String.Empty
                Else
                    Return m_lbmseperateemailaddresswithasemicolon
                End If
            End Get
            <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
            Set(ByVal value As String)
                If value Is Nothing Then
                    value = String.Empty
                End If
                If m_lbmseperateemailaddresswithasemicolon <> value Then
                    m_lbmseperateemailaddresswithasemicolon = value
                End If
            End Set
        End Property

        ''' <summary>
        ''' The mmoTextReceiptEmailAlertNotificationList column is in the DB
        ''' </summary>
        Public Property mmoTextReceiptEmailAlertNotificationList() As String
            <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
            Get
                If String.IsNullOrEmpty(m_mmotextreceiptemailalertnotificationlist) Then
                    Return String.Empty
                Else
                    Return m_mmotextreceiptemailalertnotificationlist
                End If
            End Get
            <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
            Set(ByVal value As String)
                If value Is Nothing Then
                    value = String.Empty
                End If
                If m_mmotextreceiptemailalertnotificationlist <> value Then
                    m_mmotextreceiptemailalertnotificationlist = value
                End If
            End Set
        End Property

        ''' <summary>
        ''' The mmoTextReceiptEmailMessageToUserList column is in the DB
        ''' </summary>
        Public Property mmoTextReceiptEmailMessageToUserList() As String
            <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
            Get
                If String.IsNullOrEmpty(m_mmotextreceiptemailmessagetouserlist) Then
                    Return String.Empty
                Else
                    Return m_mmotextreceiptemailmessagetouserlist
                End If
            End Get
            <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
            Set(ByVal value As String)
                If value Is Nothing Then
                    value = String.Empty
                End If
                If m_mmotextreceiptemailmessagetouserlist <> value Then
                    m_mmotextreceiptemailmessagetouserlist = value
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
        ''' The lblMessengerConfigurationRecordInformation column is in the DB
        ''' </summary>
        Public Property lblMessengerConfigurationRecordInformation() As String
            <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
            Get
                If String.IsNullOrEmpty(m_lblmessengerconfigurationrecordinformation) Then
                    Return String.Empty
                Else
                    Return m_lblmessengerconfigurationrecordinformation
                End If
            End Get
            <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
            Set(ByVal value As String)
                If value Is Nothing Then
                    value = String.Empty
                End If
                If m_lblmessengerconfigurationrecordinformation <> value Then
                    m_lblmessengerconfigurationrecordinformation = value
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
            m_lblmessengerconfigurationinformation = String.Empty
            m_ixtcode = String.Empty
            m_txtdescription = String.Empty
            m_lblmailmessengerconfiguration = String.Empty
            m_lbmifsettoyeswilloverrideusemodemoption = String.Empty
            m_blnusecommunicationprovider = Constants.DEFAULT_VALUE_NO
            m_intrecordid_messengercommunicationprovider = Nothing
            m_intnumberofsecondstowaittorun = Nothing
            m_lblmessengerconfigurationmodemsettings = String.Empty
            m_lbmusecommunicationproviderwilloverridethisoption = String.Empty
            m_blnusemodem = Constants.DEFAULT_VALUE_NO
            m_txtmodemmanufacturer = String.Empty
            m_txtmodemmodel = String.Empty
            m_txtphonenumberassigned = String.Empty
            m_txtport = String.Empty
            m_intbaudrate = Nothing
            m_intdatabits = Nothing
            m_txtparity = String.Empty
            m_decstopbits = Nothing
            m_txtcellularmodemaccesspin = String.Empty
            m_intfailedmessageresendtimedelayinminutes = Nothing
            m_txtreturnerrorcodeforinvalidphone = String.Empty
            m_blndeletereceivedmessagesfrommodem = Constants.DEFAULT_VALUE_NO
            m_intintervaltocheckfornewmessagesinminutes = Nothing
            m_lblmessengerconfigurationemailsettings = String.Empty
            m_lbmcellmessengerwillsendemailsasopposedtorocket = String.Empty
            m_lbmmustalsosetcompanysettingtousemessengerforemailtext = String.Empty
            m_blnusemessengertosendemailsviainternet = Constants.DEFAULT_VALUE_NO
            m_lblmessengerconfigurationgeneralsettings = String.Empty
            m_txtfileattachmentpath = String.Empty
            m_lblmessengerconfigurationtextalert = String.Empty
            m_lbmusetonotifyuserswhenatextisreceived = String.Empty
            m_lbmseperateemailaddresswithasemicolon = String.Empty
            m_mmotextreceiptemailalertnotificationlist = String.Empty
            m_mmotextreceiptemailmessagetouserlist = String.Empty
            m_txtelectronicdataexchangecode = String.Empty
            m_lblcalendarreminder = String.Empty
            m_dtefollowupdate = Nothing
            m_txteventstarttime = String.Empty
            m_txteventendtime = String.Empty
            m_lblmessengerconfigurationrecordinformation = String.Empty
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
            m_dterecordsynchronization = Nothing
            m_blnwebsearch = Constants.DEFAULT_VALUE_NO
            m_blnsecurity = Constants.DEFAULT_VALUE_NO
            m_blnerrorlog = Constants.DEFAULT_VALUE_NO
            m_blnaudittrail = Constants.DEFAULT_VALUE_NO
            m_txtfieldvaluegenerator = String.Empty
            m_blnsystemrecord = Constants.DEFAULT_VALUE_NO
            m_blnecommercetransmit = Constants.DEFAULT_VALUE_NO
            m_txtguid = Guid.NewGuid()
            m_blnfavorite = Constants.DEFAULT_VALUE_NO
        End Sub

#End Region

#Region "Methods"

        Public Sub Load(ByVal sdr As OleDbDataReader)
            If Not System.Convert.IsDBNull(sdr("intRecordID_DatabaseID")) Then
                m_intrecordid_databaseid = sdr.GetInt32(sdr.GetOrdinal("intRecordID_DatabaseID"))
            End If
            If Not System.Convert.IsDBNull(sdr("lblMessengerConfigurationInformation")) Then
                m_lblmessengerconfigurationinformation = sdr.GetString(sdr.GetOrdinal("lblMessengerConfigurationInformation"))
            End If
            If Not System.Convert.IsDBNull(sdr("ixtCode")) Then
                m_ixtcode = sdr.GetString(sdr.GetOrdinal("ixtCode"))
            End If
            If Not System.Convert.IsDBNull(sdr("txtDescription")) Then
                m_txtdescription = sdr.GetString(sdr.GetOrdinal("txtDescription"))
            End If
            If Not System.Convert.IsDBNull(sdr("lblMailMessengerConfiguration")) Then
                m_lblmailmessengerconfiguration = sdr.GetString(sdr.GetOrdinal("lblMailMessengerConfiguration"))
            End If
            If Not System.Convert.IsDBNull(sdr("lbmIfSetToYesWillOverrideUseModemOption")) Then
                m_lbmifsettoyeswilloverrideusemodemoption = sdr.GetString(sdr.GetOrdinal("lbmIfSetToYesWillOverrideUseModemOption"))
            End If
            If Not System.Convert.IsDBNull(sdr("blnUseCommunicationProvider")) Then
                m_blnusecommunicationprovider = sdr.GetString(sdr.GetOrdinal("blnUseCommunicationProvider"))
            End If
            If Not System.Convert.IsDBNull(sdr("intRecordID_MessengerCommunicationProvider")) Then
                m_intrecordid_messengercommunicationprovider = sdr.GetInt32(sdr.GetOrdinal("intRecordID_MessengerCommunicationProvider"))
            End If
            If Not System.Convert.IsDBNull(sdr("intNumberOfSecondsToWaitToRun")) Then
                m_intnumberofsecondstowaittorun = sdr.GetInt32(sdr.GetOrdinal("intNumberOfSecondsToWaitToRun"))
            End If
            If Not System.Convert.IsDBNull(sdr("lblMessengerConfigurationModemSettings")) Then
                m_lblmessengerconfigurationmodemsettings = sdr.GetString(sdr.GetOrdinal("lblMessengerConfigurationModemSettings"))
            End If
            If Not System.Convert.IsDBNull(sdr("lbmUseCommunicationProviderWillOverrideThisOption")) Then
                m_lbmusecommunicationproviderwilloverridethisoption = sdr.GetString(sdr.GetOrdinal("lbmUseCommunicationProviderWillOverrideThisOption"))
            End If
            If Not System.Convert.IsDBNull(sdr("blnUseModem")) Then
                m_blnusemodem = sdr.GetString(sdr.GetOrdinal("blnUseModem"))
            End If
            If Not System.Convert.IsDBNull(sdr("txtModemManufacturer")) Then
                m_txtmodemmanufacturer = sdr.GetString(sdr.GetOrdinal("txtModemManufacturer"))
            End If
            If Not System.Convert.IsDBNull(sdr("txtModemModel")) Then
                m_txtmodemmodel = sdr.GetString(sdr.GetOrdinal("txtModemModel"))
            End If
            If Not System.Convert.IsDBNull(sdr("txtPhoneNumberAssigned")) Then
                m_txtphonenumberassigned = sdr.GetString(sdr.GetOrdinal("txtPhoneNumberAssigned"))
            End If
            If Not System.Convert.IsDBNull(sdr("txtPort")) Then
                m_txtport = sdr.GetString(sdr.GetOrdinal("txtPort"))
            End If
            If Not System.Convert.IsDBNull(sdr("intBaudRate")) Then
                m_intbaudrate = sdr.GetInt32(sdr.GetOrdinal("intBaudRate"))
            End If
            If Not System.Convert.IsDBNull(sdr("intDataBits")) Then
                m_intdatabits = sdr.GetInt32(sdr.GetOrdinal("intDataBits"))
            End If
            If Not System.Convert.IsDBNull(sdr("txtParity")) Then
                m_txtparity = sdr.GetString(sdr.GetOrdinal("txtParity"))
            End If
            If Not System.Convert.IsDBNull(sdr("decStopBits")) Then
                m_decstopbits = sdr.GetDouble(sdr.GetOrdinal("decStopBits"))
            End If
            If Not System.Convert.IsDBNull(sdr("txtCellularModemAccessPIN")) Then
                m_txtcellularmodemaccesspin = sdr.GetString(sdr.GetOrdinal("txtCellularModemAccessPIN"))
            End If
            If Not System.Convert.IsDBNull(sdr("intFailedMessageResendTimeDelayInMinutes")) Then
                m_intfailedmessageresendtimedelayinminutes = sdr.GetInt32(sdr.GetOrdinal("intFailedMessageResendTimeDelayInMinutes"))
            End If
            If Not System.Convert.IsDBNull(sdr("txtReturnErrorCodeForInvalidPhone")) Then
                m_txtreturnerrorcodeforinvalidphone = sdr.GetString(sdr.GetOrdinal("txtReturnErrorCodeForInvalidPhone"))
            End If
            If Not System.Convert.IsDBNull(sdr("blnDeleteReceivedMessagesFromModem")) Then
                m_blndeletereceivedmessagesfrommodem = sdr.GetString(sdr.GetOrdinal("blnDeleteReceivedMessagesFromModem"))
            End If
            If Not System.Convert.IsDBNull(sdr("intIntervalToCheckForNewMessagesInMinutes")) Then
                m_intintervaltocheckfornewmessagesinminutes = sdr.GetInt32(sdr.GetOrdinal("intIntervalToCheckForNewMessagesInMinutes"))
            End If
            If Not System.Convert.IsDBNull(sdr("lblMessengerConfigurationEmailSettings")) Then
                m_lblmessengerconfigurationemailsettings = sdr.GetString(sdr.GetOrdinal("lblMessengerConfigurationEmailSettings"))
            End If
            If Not System.Convert.IsDBNull(sdr("lbmCellMessengerWillSendEmailsAsOpposedToROCKET")) Then
                m_lbmcellmessengerwillsendemailsasopposedtorocket = sdr.GetString(sdr.GetOrdinal("lbmCellMessengerWillSendEmailsAsOpposedToROCKET"))
            End If
            If Not System.Convert.IsDBNull(sdr("lbmMustAlsoSetCompanySettingToUseMessengerForEmailText")) Then
                m_lbmmustalsosetcompanysettingtousemessengerforemailtext = sdr.GetString(sdr.GetOrdinal("lbmMustAlsoSetCompanySettingToUseMessengerForEmailText"))
            End If
            If Not System.Convert.IsDBNull(sdr("blnUseMessengerToSendEmailsViaInternet")) Then
                m_blnusemessengertosendemailsviainternet = sdr.GetString(sdr.GetOrdinal("blnUseMessengerToSendEmailsViaInternet"))
            End If
            If Not System.Convert.IsDBNull(sdr("lblMessengerConfigurationGeneralSettings")) Then
                m_lblmessengerconfigurationgeneralsettings = sdr.GetString(sdr.GetOrdinal("lblMessengerConfigurationGeneralSettings"))
            End If
            If Not System.Convert.IsDBNull(sdr("txtFileAttachmentPath")) Then
                m_txtfileattachmentpath = sdr.GetString(sdr.GetOrdinal("txtFileAttachmentPath"))
            End If
            If Not System.Convert.IsDBNull(sdr("lblMessengerConfigurationTextAlert")) Then
                m_lblmessengerconfigurationtextalert = sdr.GetString(sdr.GetOrdinal("lblMessengerConfigurationTextAlert"))
            End If
            If Not System.Convert.IsDBNull(sdr("lbmUseToNotifyUsersWhenATextIsReceived")) Then
                m_lbmusetonotifyuserswhenatextisreceived = sdr.GetString(sdr.GetOrdinal("lbmUseToNotifyUsersWhenATextIsReceived"))
            End If
            If Not System.Convert.IsDBNull(sdr("lbmSeperateEmailAddressWithASemicolon")) Then
                m_lbmseperateemailaddresswithasemicolon = sdr.GetString(sdr.GetOrdinal("lbmSeperateEmailAddressWithASemicolon"))
            End If
            If Not System.Convert.IsDBNull(sdr("mmoTextReceiptEmailAlertNotificationList")) Then
                m_mmotextreceiptemailalertnotificationlist = sdr.GetString(sdr.GetOrdinal("mmoTextReceiptEmailAlertNotificationList"))
            End If
            If Not System.Convert.IsDBNull(sdr("mmoTextReceiptEmailMessageToUserList")) Then
                m_mmotextreceiptemailmessagetouserlist = sdr.GetString(sdr.GetOrdinal("mmoTextReceiptEmailMessageToUserList"))
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
            If Not System.Convert.IsDBNull(sdr("lblMessengerConfigurationRecordInformation")) Then
                m_lblmessengerconfigurationrecordinformation = sdr.GetString(sdr.GetOrdinal("lblMessengerConfigurationRecordInformation"))
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
            If Not System.Convert.IsDBNull(sdr("dteRecordSynchronization")) Then
                m_dterecordsynchronization = sdr.GetDateTime(sdr.GetOrdinal("dteRecordSynchronization"))
            End If
            If Not System.Convert.IsDBNull(sdr("blnWebSearch")) Then
                m_blnwebsearch = sdr.GetString(sdr.GetOrdinal("blnWebSearch"))
            End If
            If Not System.Convert.IsDBNull(sdr("blnSecurity")) Then
                m_blnsecurity = sdr.GetString(sdr.GetOrdinal("blnSecurity"))
            End If
            If Not System.Convert.IsDBNull(sdr("blnErrorLog")) Then
                m_blnerrorlog = sdr.GetString(sdr.GetOrdinal("blnErrorLog"))
            End If
            If Not System.Convert.IsDBNull(sdr("blnAuditTrail")) Then
                m_blnaudittrail = sdr.GetString(sdr.GetOrdinal("blnAuditTrail"))
            End If
            If Not System.Convert.IsDBNull(sdr("txtFieldValueGenerator")) Then
                m_txtfieldvaluegenerator = sdr.GetString(sdr.GetOrdinal("txtFieldValueGenerator"))
            End If
            If Not System.Convert.IsDBNull(sdr("blnSystemRecord")) Then
                m_blnsystemrecord = sdr.GetString(sdr.GetOrdinal("blnSystemRecord"))
            End If
            If Not System.Convert.IsDBNull(sdr("blnEcommerceTransmit")) Then
                m_blnecommercetransmit = sdr.GetString(sdr.GetOrdinal("blnEcommerceTransmit"))
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
            retValue.Append(" lblMessengerConfigurationInformation = """)
            retValue.Append(m_lblmessengerconfigurationinformation)
            retValue.Append("""" & ControlChars.Lf)
            retValue.Append(" ixtCode = """)
            retValue.Append(m_ixtcode)
            retValue.Append("""" & ControlChars.Lf)
            retValue.Append(" txtDescription = """)
            retValue.Append(m_txtdescription)
            retValue.Append("""" & ControlChars.Lf)
            retValue.Append(" lblMailMessengerConfiguration = """)
            retValue.Append(m_lblmailmessengerconfiguration)
            retValue.Append("""" & ControlChars.Lf)
            retValue.Append(" lbmIfSetToYesWillOverrideUseModemOption = """)
            retValue.Append(m_lbmifsettoyeswilloverrideusemodemoption)
            retValue.Append("""" & ControlChars.Lf)
            retValue.Append(" blnUseCommunicationProvider = """)
            retValue.Append(m_blnusecommunicationprovider)
            retValue.Append("""" & ControlChars.Lf)
            retValue.Append(" intRecordID_MessengerCommunicationProvider = """)
            retValue.Append(m_intrecordid_messengercommunicationprovider)
            retValue.Append("""" & ControlChars.Lf)
            retValue.Append(" intNumberOfSecondsToWaitToRun = """)
            retValue.Append(m_intnumberofsecondstowaittorun)
            retValue.Append("""" & ControlChars.Lf)
            retValue.Append(" lblMessengerConfigurationModemSettings = """)
            retValue.Append(m_lblmessengerconfigurationmodemsettings)
            retValue.Append("""" & ControlChars.Lf)
            retValue.Append(" lbmUseCommunicationProviderWillOverrideThisOption = """)
            retValue.Append(m_lbmusecommunicationproviderwilloverridethisoption)
            retValue.Append("""" & ControlChars.Lf)
            retValue.Append(" blnUseModem = """)
            retValue.Append(m_blnusemodem)
            retValue.Append("""" & ControlChars.Lf)
            retValue.Append(" txtModemManufacturer = """)
            retValue.Append(m_txtmodemmanufacturer)
            retValue.Append("""" & ControlChars.Lf)
            retValue.Append(" txtModemModel = """)
            retValue.Append(m_txtmodemmodel)
            retValue.Append("""" & ControlChars.Lf)
            retValue.Append(" txtPhoneNumberAssigned = """)
            retValue.Append(m_txtphonenumberassigned)
            retValue.Append("""" & ControlChars.Lf)
            retValue.Append(" txtPort = """)
            retValue.Append(m_txtport)
            retValue.Append("""" & ControlChars.Lf)
            retValue.Append(" intBaudRate = """)
            retValue.Append(m_intbaudrate)
            retValue.Append("""" & ControlChars.Lf)
            retValue.Append(" intDataBits = """)
            retValue.Append(m_intdatabits)
            retValue.Append("""" & ControlChars.Lf)
            retValue.Append(" txtParity = """)
            retValue.Append(m_txtparity)
            retValue.Append("""" & ControlChars.Lf)
            retValue.Append(" decStopBits = """)
            retValue.Append(m_decstopbits)
            retValue.Append("""" & ControlChars.Lf)
            retValue.Append(" txtCellularModemAccessPIN = """)
            retValue.Append(m_txtcellularmodemaccesspin)
            retValue.Append("""" & ControlChars.Lf)
            retValue.Append(" intFailedMessageResendTimeDelayInMinutes = """)
            retValue.Append(m_intfailedmessageresendtimedelayinminutes)
            retValue.Append("""" & ControlChars.Lf)
            retValue.Append(" txtReturnErrorCodeForInvalidPhone = """)
            retValue.Append(m_txtreturnerrorcodeforinvalidphone)
            retValue.Append("""" & ControlChars.Lf)
            retValue.Append(" blnDeleteReceivedMessagesFromModem = """)
            retValue.Append(m_blndeletereceivedmessagesfrommodem)
            retValue.Append("""" & ControlChars.Lf)
            retValue.Append(" intIntervalToCheckForNewMessagesInMinutes = """)
            retValue.Append(m_intintervaltocheckfornewmessagesinminutes)
            retValue.Append("""" & ControlChars.Lf)
            retValue.Append(" lblMessengerConfigurationEmailSettings = """)
            retValue.Append(m_lblmessengerconfigurationemailsettings)
            retValue.Append("""" & ControlChars.Lf)
            retValue.Append(" lbmCellMessengerWillSendEmailsAsOpposedToROCKET = """)
            retValue.Append(m_lbmcellmessengerwillsendemailsasopposedtorocket)
            retValue.Append("""" & ControlChars.Lf)
            retValue.Append(" lbmMustAlsoSetCompanySettingToUseMessengerForEmailText = """)
            retValue.Append(m_lbmmustalsosetcompanysettingtousemessengerforemailtext)
            retValue.Append("""" & ControlChars.Lf)
            retValue.Append(" blnUseMessengerToSendEmailsViaInternet = """)
            retValue.Append(m_blnusemessengertosendemailsviainternet)
            retValue.Append("""" & ControlChars.Lf)
            retValue.Append(" lblMessengerConfigurationGeneralSettings = """)
            retValue.Append(m_lblmessengerconfigurationgeneralsettings)
            retValue.Append("""" & ControlChars.Lf)
            retValue.Append(" txtFileAttachmentPath = """)
            retValue.Append(m_txtfileattachmentpath)
            retValue.Append("""" & ControlChars.Lf)
            retValue.Append(" lblMessengerConfigurationTextAlert = """)
            retValue.Append(m_lblmessengerconfigurationtextalert)
            retValue.Append("""" & ControlChars.Lf)
            retValue.Append(" lbmUseToNotifyUsersWhenATextIsReceived = """)
            retValue.Append(m_lbmusetonotifyuserswhenatextisreceived)
            retValue.Append("""" & ControlChars.Lf)
            retValue.Append(" lbmSeperateEmailAddressWithASemicolon = """)
            retValue.Append(m_lbmseperateemailaddresswithasemicolon)
            retValue.Append("""" & ControlChars.Lf)
            retValue.Append(" mmoTextReceiptEmailAlertNotificationList = """)
            retValue.Append(m_mmotextreceiptemailalertnotificationlist)
            retValue.Append("""" & ControlChars.Lf)
            retValue.Append(" mmoTextReceiptEmailMessageToUserList = """)
            retValue.Append(m_mmotextreceiptemailmessagetouserlist)
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
            retValue.Append(" lblMessengerConfigurationRecordInformation = """)
            retValue.Append(m_lblmessengerconfigurationrecordinformation)
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
            retValue.Append(" dteRecordSynchronization = """)
            retValue.Append(m_dterecordsynchronization)
            retValue.Append("""" & ControlChars.Lf)
            retValue.Append(" blnWebSearch = """)
            retValue.Append(m_blnwebsearch)
            retValue.Append("""" & ControlChars.Lf)
            retValue.Append(" blnSecurity = """)
            retValue.Append(m_blnsecurity)
            retValue.Append("""" & ControlChars.Lf)
            retValue.Append(" blnErrorLog = """)
            retValue.Append(m_blnerrorlog)
            retValue.Append("""" & ControlChars.Lf)
            retValue.Append(" blnAuditTrail = """)
            retValue.Append(m_blnaudittrail)
            retValue.Append("""" & ControlChars.Lf)
            retValue.Append(" txtFieldValueGenerator = """)
            retValue.Append(m_txtfieldvaluegenerator)
            retValue.Append("""" & ControlChars.Lf)
            retValue.Append(" blnSystemRecord = """)
            retValue.Append(m_blnsystemrecord)
            retValue.Append("""" & ControlChars.Lf)
            retValue.Append(" blnEcommerceTransmit = """)
            retValue.Append(m_blnecommercetransmit)
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

        Public Shared Function SelectByID(ByVal intrecordid As Int32) As tblMessengerConfiguration
            If intrecordid <= 0 OrElse intrecordid >= Int32.MaxValue Then
                Return Nothing
            End If

            Dim obj As tblMessengerConfiguration = Nothing

            Try
                Using cn As New OleDbConnection(DbApplication.Context.ConnString)
                    Dim sql As New StringBuilder()

                    sql.Append("Select * From [dbo].[tblMessengerConfiguration] Where [intRecordID] = ? ")

                    Using cm As OleDbCommand = cn.CreateCommand()
                        cm.CommandType = CommandType.Text
                        cm.CommandText = sql.ToString()

                        cm.Parameters.AddWithValue("", intrecordid)

                        cn.Open()

                        Using sdr As OleDbDataReader = cm.ExecuteReader()
                            Do While sdr.Read()
                                obj = New tblMessengerConfiguration()

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

        Public Shared Function SelectByProviderID(ByVal intrecordid_messengerCommunicationProvider As Int32) As tblMessengerConfiguration

            If intrecordid_messengerCommunicationProvider <= 0 OrElse intrecordid_messengerCommunicationProvider >= Int32.MaxValue Then
                Return Nothing
            End If

            Dim obj As tblMessengerConfiguration = Nothing

            Try
                Using cn As New OleDbConnection(DbApplication.Context.ConnString)
                    Dim sql As New StringBuilder()

                    sql.Append("Select * From [dbo].[tblMessengerConfiguration] Where [intRecordID_MessengerCommunicationProvider] = ? ")

                    Using cm As OleDbCommand = cn.CreateCommand()
                        cm.CommandType = CommandType.Text
                        cm.CommandText = sql.ToString()

                        cm.Parameters.AddWithValue("", intrecordid_messengerCommunicationProvider)

                        cn.Open()

                        Using sdr As OleDbDataReader = cm.ExecuteReader()
                            Do While sdr.Read()
                                obj = New tblMessengerConfiguration()

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

        Public Shared Function SelectActive() As tblMessengerConfiguration


            Dim obj As tblMessengerConfiguration = Nothing

            Try
                Using cn As New OleDbConnection(DbApplication.Context.ConnString)
                    Dim sql As New StringBuilder()

                    sql.Append("Select top 1 t1.* From [dbo].[tblMessengerConfiguration] t1 Where [blnActive] = 'Yes' and [blnDeleted] = 'No' ")

                    Using cm As OleDbCommand = cn.CreateCommand()
                        cm.CommandType = CommandType.Text
                        cm.CommandText = sql.ToString()

                        cn.Open()

                        Using sdr As OleDbDataReader = cm.ExecuteReader()
                            Do While sdr.Read()
                                obj = New tblMessengerConfiguration()

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

                    sql.Append("Select MAX([intRecordID]) FROM [dbo].[tblMessengerConfiguration] ")

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

        Public Shared Function SelectDefault() As tblMessengerConfiguration

            Dim obj As tblMessengerConfiguration = Nothing

            Try
                Using cn As New OleDbConnection(DbApplication.Context.ConnString)
                    Dim sql As New StringBuilder()

                    sql.Append("Select Top 1 * From [dbo].[tblMessengerConfiguration] ")

                    Using cm As OleDbCommand = cn.CreateCommand()

                        cm.CommandType = CommandType.Text
                        cm.CommandText = sql.ToString()

                        cn.Open()

                        Using sdr As OleDbDataReader = cm.ExecuteReader()
                            Do While sdr.Read()
                                obj = New tblMessengerConfiguration()

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

        <System.ComponentModel.DataObjectMethod(System.ComponentModel.DataObjectMethodType.Insert)>
        Public Shared Function CreateNew(ByVal obj As tblMessengerConfiguration) As Boolean
            If obj Is Nothing Then
                Return False
            End If

            Try
                Using cn As New OleDbConnection(DbApplication.Context.ConnString)
                    Dim sql As New StringBuilder()

                    sql.Append("INSERT INTO [tblMessengerConfiguration] (")
                    sql.Append("[intRecordID_DatabaseID], ")
                    sql.Append("[lblMessengerConfigurationInformation], [ixtCode], [txtDescription], [lblMailMessengerConfiguration], ")
                    sql.Append("[lbmIfSetToYesWillOverrideUseModemOption], [blnUseCommunicationProvider], [intRecordID_MessengerCommunicationProvider], [intNumberOfSecondsToWaitToRun], ")
                    sql.Append("[lblMessengerConfigurationModemSettings], [lbmUseCommunicationProviderWillOverrideThisOption], [blnUseModem], [txtModemManufacturer], ")
                    sql.Append("[txtModemModel], [txtPhoneNumberAssigned], [txtPort], [intBaudRate], ")
                    sql.Append("[intDataBits], [txtParity], [decStopBits], [txtCellularModemAccessPIN], ")
                    sql.Append("[intFailedMessageResendTimeDelayInMinutes], [txtReturnErrorCodeForInvalidPhone], [blnDeleteReceivedMessagesFromModem], [intIntervalToCheckForNewMessagesInMinutes], ")
                    sql.Append("[lblMessengerConfigurationEmailSettings], [lbmCellMessengerWillSendEmailsAsOpposedToROCKET], [lbmMustAlsoSetCompanySettingToUseMessengerForEmailText], [blnUseMessengerToSendEmailsViaInternet], ")
                    sql.Append("[lblMessengerConfigurationGeneralSettings], [txtFileAttachmentPath], [lblMessengerConfigurationTextAlert], [lbmUseToNotifyUsersWhenATextIsReceived], ")
                    sql.Append("[lbmSeperateEmailAddressWithASemicolon], [mmoTextReceiptEmailAlertNotificationList], [mmoTextReceiptEmailMessageToUserList], [txtElectronicDataExchangeCode], ")
                    sql.Append("[lblCalendarReminder], [dteFollowUpDate], [txtEventStartTime], [txtEventEndTime], ")
                    sql.Append("[lblMessengerConfigurationRecordInformation], [blnMakePrivate], [blnActive], [txtRecordCreationUser], ")
                    sql.Append("[dteRecordCreationDate], [dteRecordUpdateDate], [blnCursor], [intRecordID_Company], ")
                    sql.Append("[intRecordID_Division], [intRecordID], [intRecordID_User_Creation], [blnAttachment], ")
                    sql.Append("[blnDeleted], [blnHighlight], [blnMemo], [blnProcess], ")
                    sql.Append("[blnProject], [intRecordID_ErrorLog], [intRecordID_Status], [blnPrint], ")
                    sql.Append("[txtRecordUpdateUser], [dteRecordSynchronization], [blnWebSearch], [blnSecurity], ")
                    sql.Append("[blnErrorLog], [blnAuditTrail], [txtFieldValueGenerator], [blnSystemRecord], ")
                    sql.Append("[blnEcommerceTransmit], [txtGUID], [blnFavorite])")
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
                    sql.Append("?, ?, ?, ?, ")
                    sql.Append("?, ?, ?, ?, ")
                    sql.Append("?, ?, ?, ?, ")
                    sql.Append("?, ?, ?, ?, ")
                    sql.Append("?, ?, ?, ?, ")
                    sql.Append("?, ?, ?, ?, ")
                    sql.Append("?, ?, ?)")

                    Using cm As OleDbCommand = cn.CreateCommand()
                        cm.CommandType = CommandType.Text
                        cm.CommandText = sql.ToString()

                        cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intRecordID_DatabaseID))
                        cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.lblMessengerConfigurationInformation))
                        cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.ixtCode))
                        cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.txtDescription))
                        cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.lblMailMessengerConfiguration))
                        cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.lbmIfSetToYesWillOverrideUseModemOption))
                        cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.blnUseCommunicationProvider))
                        cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intRecordID_MessengerCommunicationProvider))
                        cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intNumberOfSecondsToWaitToRun))
                        cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.lblMessengerConfigurationModemSettings))
                        cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.lbmUseCommunicationProviderWillOverrideThisOption))
                        cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.blnUseModem))
                        cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.txtModemManufacturer))
                        cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.txtModemModel))
                        cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.txtPhoneNumberAssigned))
                        cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.txtPort))
                        cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intBaudRate))
                        cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intDataBits))
                        cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.txtParity))
                        cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.decStopBits))
                        cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.txtCellularModemAccessPIN))
                        cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intFailedMessageResendTimeDelayInMinutes))
                        cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.txtReturnErrorCodeForInvalidPhone))
                        cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.blnDeleteReceivedMessagesFromModem))
                        cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intIntervalToCheckForNewMessagesInMinutes))
                        cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.lblMessengerConfigurationEmailSettings))
                        cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.lbmCellMessengerWillSendEmailsAsOpposedToROCKET))
                        cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.lbmMustAlsoSetCompanySettingToUseMessengerForEmailText))
                        cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.blnUseMessengerToSendEmailsViaInternet))
                        cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.lblMessengerConfigurationGeneralSettings))
                        cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.txtFileAttachmentPath))
                        cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.lblMessengerConfigurationTextAlert))
                        cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.lbmUseToNotifyUsersWhenATextIsReceived))
                        cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.lbmSeperateEmailAddressWithASemicolon))
                        cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.mmoTextReceiptEmailAlertNotificationList))
                        cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.mmoTextReceiptEmailMessageToUserList))
                        cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.txtElectronicDataExchangeCode))
                        cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.lblCalendarReminder))
                        cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.dteFollowUpDate)).OleDbType = OleDbType.Date
                        cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.txtEventStartTime))
                        cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.txtEventEndTime))
                        cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.lblMessengerConfigurationRecordInformation))
                        cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.blnMakePrivate))
                        cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.blnActive))
                        cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.txtRecordCreationUser))
                        cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.dteRecordCreationDate)).OleDbType = OleDbType.Date
                        cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.dteRecordUpdateDate)).OleDbType = OleDbType.Date
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
                        cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.dteRecordSynchronization)).OleDbType = OleDbType.Date
                        cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.blnWebSearch))
                        cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.blnSecurity))
                        cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.blnErrorLog))
                        cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.blnAuditTrail))
                        cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.txtFieldValueGenerator))
                        cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.blnSystemRecord))
                        cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.blnEcommerceTransmit))
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
        Public Shared Function Update(ByVal obj As tblMessengerConfiguration) As Boolean
            If obj Is Nothing OrElse obj.intRecordID <= 0 OrElse obj.intRecordID >= Int32.MaxValue Then
                Return False
            End If

            obj.txtRecordUpdateUser = My.Application.Info.AssemblyName
            obj.dteRecordUpdateDate = Date.Now

            Try
                Using cn As New OleDbConnection(DbApplication.Context.ConnString)
                    Dim sql As New StringBuilder()

                    sql.Append("UPDATE [dbo].[tblMessengerConfiguration] SET ")
                    sql.Append("[intRecordID_DatabaseID] = ?, ")
                    sql.Append("[lblMessengerConfigurationInformation] = ?, ")
                    sql.Append("[ixtCode] = ?, ")
                    sql.Append("[txtDescription] = ?, ")
                    sql.Append("[lblMailMessengerConfiguration] = ?, ")
                    sql.Append("[lbmIfSetToYesWillOverrideUseModemOption] = ?, ")
                    sql.Append("[blnUseCommunicationProvider] = ?, ")
                    sql.Append("[intRecordID_MessengerCommunicationProvider] = ?, ")
                    sql.Append("[intNumberOfSecondsToWaitToRun] = ?, ")
                    sql.Append("[lblMessengerConfigurationModemSettings] = ?, ")
                    sql.Append("[lbmUseCommunicationProviderWillOverrideThisOption] = ?, ")
                    sql.Append("[blnUseModem] = ?, ")
                    sql.Append("[txtModemManufacturer] = ?, ")
                    sql.Append("[txtModemModel] = ?, ")
                    sql.Append("[txtPhoneNumberAssigned] = ?, ")
                    sql.Append("[txtPort] = ?, ")
                    sql.Append("[intBaudRate] = ?, ")
                    sql.Append("[intDataBits] = ?, ")
                    sql.Append("[txtParity] = ?, ")
                    sql.Append("[decStopBits] = ?, ")
                    sql.Append("[txtCellularModemAccessPIN] = ?, ")
                    sql.Append("[intFailedMessageResendTimeDelayInMinutes] = ?, ")
                    sql.Append("[txtReturnErrorCodeForInvalidPhone] = ?, ")
                    sql.Append("[blnDeleteReceivedMessagesFromModem] = ?, ")
                    sql.Append("[intIntervalToCheckForNewMessagesInMinutes] = ?, ")
                    sql.Append("[lblMessengerConfigurationEmailSettings] = ?, ")
                    sql.Append("[lbmCellMessengerWillSendEmailsAsOpposedToROCKET] = ?, ")
                    sql.Append("[lbmMustAlsoSetCompanySettingToUseMessengerForEmailText] = ?, ")
                    sql.Append("[blnUseMessengerToSendEmailsViaInternet] = ?, ")
                    sql.Append("[lblMessengerConfigurationGeneralSettings] = ?, ")
                    sql.Append("[txtFileAttachmentPath] = ?, ")
                    sql.Append("[lblMessengerConfigurationTextAlert] = ?, ")
                    sql.Append("[lbmUseToNotifyUsersWhenATextIsReceived] = ?, ")
                    sql.Append("[lbmSeperateEmailAddressWithASemicolon] = ?, ")
                    sql.Append("[mmoTextReceiptEmailAlertNotificationList] = ?, ")
                    sql.Append("[mmoTextReceiptEmailMessageToUserList] = ?, ")
                    sql.Append("[txtElectronicDataExchangeCode] = ?, ")
                    sql.Append("[lblCalendarReminder] = ?, ")
                    sql.Append("[dteFollowUpDate] = ?, ")
                    sql.Append("[txtEventStartTime] = ?, ")
                    sql.Append("[txtEventEndTime] = ?, ")
                    sql.Append("[lblMessengerConfigurationRecordInformation] = ?, ")
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
                    sql.Append("[dteRecordSynchronization] = ?, ")
                    sql.Append("[blnWebSearch] = ?, ")
                    sql.Append("[blnSecurity] = ?, ")
                    sql.Append("[blnErrorLog] = ?, ")
                    sql.Append("[blnAuditTrail] = ?, ")
                    sql.Append("[txtFieldValueGenerator] = ?, ")
                    sql.Append("[blnSystemRecord] = ?, ")
                    sql.Append("[blnEcommerceTransmit] = ?, ")
                    sql.Append("[txtGUID] = ?, ")
                    sql.Append("[blnFavorite] = ? ")
                    sql.Append("WHERE intRecordID = ?")

                    Using cm As OleDbCommand = cn.CreateCommand()
                        cm.CommandType = CommandType.Text
                        cm.CommandText = sql.ToString()

                        cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intRecordID_DatabaseID))
                        cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.lblMessengerConfigurationInformation))
                        cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.ixtCode))
                        cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.txtDescription))
                        cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.lblMailMessengerConfiguration))
                        cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.lbmIfSetToYesWillOverrideUseModemOption))
                        cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.blnUseCommunicationProvider))
                        cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intRecordID_MessengerCommunicationProvider))
                        cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intNumberOfSecondsToWaitToRun))
                        cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.lblMessengerConfigurationModemSettings))
                        cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.lbmUseCommunicationProviderWillOverrideThisOption))
                        cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.blnUseModem))
                        cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.txtModemManufacturer))
                        cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.txtModemModel))
                        cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.txtPhoneNumberAssigned))
                        cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.txtPort))
                        cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intBaudRate))
                        cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intDataBits))
                        cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.txtParity))
                        cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.decStopBits))
                        cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.txtCellularModemAccessPIN))
                        cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intFailedMessageResendTimeDelayInMinutes))
                        cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.txtReturnErrorCodeForInvalidPhone))
                        cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.blnDeleteReceivedMessagesFromModem))
                        cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intIntervalToCheckForNewMessagesInMinutes))
                        cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.lblMessengerConfigurationEmailSettings))
                        cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.lbmCellMessengerWillSendEmailsAsOpposedToROCKET))
                        cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.lbmMustAlsoSetCompanySettingToUseMessengerForEmailText))
                        cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.blnUseMessengerToSendEmailsViaInternet))
                        cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.lblMessengerConfigurationGeneralSettings))
                        cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.txtFileAttachmentPath))
                        cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.lblMessengerConfigurationTextAlert))
                        cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.lbmUseToNotifyUsersWhenATextIsReceived))
                        cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.lbmSeperateEmailAddressWithASemicolon))
                        cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.mmoTextReceiptEmailAlertNotificationList))
                        cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.mmoTextReceiptEmailMessageToUserList))
                        cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.txtElectronicDataExchangeCode))
                        cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.lblCalendarReminder))
                        cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.dteFollowUpDate)).OleDbType = OleDbType.Date
                        cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.txtEventStartTime))
                        cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.txtEventEndTime))
                        cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.lblMessengerConfigurationRecordInformation))
                        cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.blnMakePrivate))
                        cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.blnActive))
                        cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.txtRecordCreationUser))
                        cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.dteRecordCreationDate)).OleDbType = OleDbType.Date
                        cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.dteRecordUpdateDate)).OleDbType = OleDbType.Date
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
                        cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.dteRecordSynchronization)).OleDbType = OleDbType.Date
                        cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.blnWebSearch))
                        cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.blnSecurity))
                        cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.blnErrorLog))
                        cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.blnAuditTrail))
                        cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.txtFieldValueGenerator))
                        cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.blnSystemRecord))
                        cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.blnEcommerceTransmit))
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
        Public Shared Function Delete(ByVal obj As tblMessengerConfiguration) As Boolean
            If obj Is Nothing OrElse obj.intRecordID <= 0 OrElse obj.intRecordID >= Int32.MaxValue Then
                Return False
            End If

            Try
                Using cn As New OleDbConnection(DbApplication.Context.ConnString)
                    Dim sql As New StringBuilder()

                    sql.Append("DELETE [dbo].[tblMessengerConfiguration] WHERE [intRecordID] = ?")

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

End Namespace
