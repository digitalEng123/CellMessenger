Imports Microsoft.VisualBasic
Imports System
Imports System.Text
Imports System.Data
Imports System.Data.OleDb

Imports RETSLibrary.Common

Public NotInheritable Class tblContact
    Inherits DataObject

#Region "Fields"

    Private m_intrecordid_databaseid? As Int32
    Private m_lblcontactinformation As String
    Private m_ixtcode As String
    Private m_txtdescription As String
    Private m_txtprovideridentificationnumber As String
    Private m_intrecordid_document_picture? As Int32
    Private m_intrecordid_account? As Int32
    Private m_intrecordid_contactsalutation? As Int32
    Private m_txtfirstname As String
    Private m_txtmiddlename As String
    Private m_txtmiddleinitial As String
    Private m_txtlastname As String
    Private m_txtbesttime As String
    Private m_txtsuffix As String
    Private m_txtcompanyname As String
    Private m_txtdba As String
    Private m_intrecordid_contacttitle? As Int32
    Private m_txtaddress1 As String
    Private m_txtaddress2 As String
    Private m_txtaddress3 As String
    Private m_txtcity As String
    Private m_intrecordid_state? As Int32
    Private m_txtpostalcode As String
    Private m_intrecordid_county? As Int32
    Private m_intrecordid_country? As Int32
    Private m_lblcontactaccessinformation As String
    Private m_txtskypeid As String
    Private m_txtphonenumberoffice As String
    Private m_txtphonenumbermobile As String
    Private m_intrecordid_mailsmscarriers? As Int32
    Private m_txtphonenumberhome As String
    Private m_txtfaxnumber As String
    Private m_txtpager As String
    Private m_txtemailaddress As String
    Private m_blnmailreturned As String
    Private m_txtwebsitetitle As String
    Private m_lblcontactpersonalinformation As String
    Private m_dtedateofbirth? As Date
    Private m_clccontactage? As Double
    Private m_txtdriverslicense As String
    Private m_txtssn As String
    Private m_txtemergencycontactname As String
    Private m_txtemergencycontactphone As String
    Private m_lblcontactpreferences As String
    Private m_txtbillingday As String
    Private m_blnbackorder As String
    Private m_blnproductcatalog As String
    Private m_blnconfirmsalesorder As String
    Private m_blnprintpricelist As String
    Private m_blnsubscribetonewsletter As String
    Private m_lblcontactdetails As String
    Private m_intrecordid_campaign? As Int32
    Private m_intrecordid_contactcategory? As Int32
    Private m_intrecordid_industry? As Int32
    Private m_intrecordid_region? As Int32
    Private m_intrecordid_contactstatus? As Int32
    Private m_intrecordid_contactprocessstatus? As Int32
    Private m_lblcontactbillingandshippinginformation As String
    Private m_intrecordid_contactbillto? As Int32
    Private m_intrecordid_contactshipto? As Int32
    Private m_intrecordid_shipmethod? As Int32
    Private m_intrecordid_contact_shipvia? As Int32
    Private m_txtfob As String
    Private m_lblcontactmanagementdetails As String
    Private m_intrecordid_contact_salesrep? As Int32
    Private m_intrecordid_marketingsource? As Int32
    Private m_blninspectionrequired As String
    Private m_lblcontactwebaccessinformation As String
    Private m_lbmuserinformation As String
    Private m_txtusername As String
    Private m_txtpassword As String
    Private m_txtsecretquestionanswer As String
    Private m_intrecordid_secretquestion? As Int32
    Private m_dtepasswordexpiration? As Date
    Private m_blnpasswordautoexpire As String
    Private m_intpasswordexpireintervalday? As Int32
    Private m_intfailedloginattempt? As Int32
    Private m_txtuserregistrationkey As String
    Private m_lblcontactsurveyinformation As String
    Private m_intrecordid_surveyusertype? As Int32
    Private m_intrecordid_surveylogintype? As Int32
    Private m_txtsurveyusernetworkdomain As String
    Private m_lblcontacthrinformation As String
    Private m_txtaccountglreferencecode As String
    Private m_txtothernamesused As String
    Private m_intrecordid_contact_union? As Int32
    Private m_intrecordid_hremployeeuniontype? As Int32
    Private m_intrecordid_hremployeestatus? As Int32
    Private m_lbmworkcentermustbeassignedforcorrectlaborreporting As String
    Private m_intrecordid_workcenter? As Int32
    Private m_intrecordid_hrshift? As Int32
    Private m_intrecordid_language? As Int32
    Private m_lbmdiversityinformation As String
    Private m_intrecordid_hrethnicorigin? As Int32
    Private m_intrecordid_hrgender? As Int32
    Private m_intrecordid_hremployeepaycheckdeliverymethod? As Int32
    Private m_intrecordid_hrmilitaryservice? As Int32
    Private m_intrecordid_contact_supervisor? As Int32
    Private m_lblcontactextendedhrinformation As String
    Private m_intrecordid_contacthrinformation? As Int32
    Private m_lblmemberothermedicalinsurance As String
    Private m_blnmedicare As String
    Private m_blncob As String
    Private m_dtecobletterreceiveddate? As Date
    Private m_lblmemberbenefitplaninformation As String
    Private m_dtertwdate? As Date
    Private m_dteterminationdate? As Date
    Private m_intrecordid_hrbenefitplanemployeecontribution? As Int32
    Private m_dtedatestart? As Date
    Private m_dteeffectivestartdate? As Date
    Private m_dtefulltimepromotiondate? As Date
    Private m_dtefulltimeeffectivedate? As Date
    Private m_dteparttimedemotiondate? As Date
    Private m_dteparttimeeffectivedate? As Date
    Private m_dteretirementdate? As Date
    Private m_intrecordid_hrbenefitcoverageterminationreason? As Int32
    Private m_blnreportmemberassubscriber As String
    Private m_lblcustomerinformation As String
    Private m_intrecordid_contactcustomerinformation? As Int32
    Private m_lblbenefitinformation As String
    Private m_intrecordid_contactbenefitinformation? As Int32
    Private m_lblcontactcreditinformation As String
    Private m_intrecordid_contactcreditinformation? As Int32
    Private m_lblcontactpromotioninformation As String
    Private m_inttargetgp? As Int32
    Private m_blnqualifiesforrebate As String
    Private m_blnproductpromotion As String
    Private m_intrecordid_contactdiscount? As Int32
    Private m_intrecordid_contact_buyinggroup? As Int32
    Private m_dtebuyinggroupstartdate? As Date
    Private m_decrebatepercent? As Double
    Private m_lblcontactaccountinginformation As String
    Private m_intrecordid_glchart_apexpense? As Int32
    Private m_intrecordid_glchartdivision_apexpense? As Int32
    Private m_intrecordid_glchartdepartment_apexpense? As Int32
    Private m_clcpremiumcost? As Double
    Private m_clcpremiummemberprice? As Double
    Private m_clcemployercontribution? As Double
    Private m_clcemployeededuction? As Double
    Private m_lblcontactrecordinformation As String
    Private m_blnmakeprivate As String
    Private m_blnactive As String
    Private m_txtrecordcreationuser As String
    Private m_dterecordcreationdate? As Date
    Private m_dterecordupdatedate? As Date
    Private m_blncursor As String
    Private m_txtjobseekerid As String
    Private m_txtsearchproviderresumeid As String
    Private m_intrecordid As Int32
    Private m_txtguid? As Guid
    Private m_txtemployeessn As String
    Private m_intrecordid_company? As Int32
    Private m_intrecordid_division? As Int32
    Private m_intrecordid_company_ecommerce? As Int32
    Private m_intrecordid_division_ecommerce? As Int32
    Private m_intrecordid_databaseid_ecommerce? As Int32
    Private m_intrecordid_user_ecommerce? As Int32
    Private m_txttablename_ecommerce As String
    Private m_intrecordidtable_ecommerce? As Int32
    Private m_intrecordid_marketingsalessize? As Int32
    Private m_intrecordid_apfinancecharge? As Int32
    Private m_intrecordid_arfinancecharge? As Int32
    Private m_blnpayroll As String
    Private m_intrecordid_contactcommerce? As Int32
    Private m_intrecordid_contact_customerservicerep? As Int32
    Private m_blnreceiveinspectionrequired As String
    Private m_blnpayhold As String
    Private m_intrecordid_currency? As Int32
    Private m_intrecordid_shiproute? As Int32
    Private m_intrecordid_contactpricingmethod? As Int32
    Private m_intrecordid_productpricelist? As Int32
    Private m_intrecordid_hrcontactsecurityclearance? As Int32
    Private m_intrecordid_user_creation? As Int32
    Private m_blnmemo As String
    Private m_blnattachment As String
    Private m_blndeleted As String
    Private m_blnhighlight As String
    Private m_blnprocess As String
    Private m_blnproject As String
    Private m_txthold01 As String
    Private m_txthold02 As String
    Private m_txthold03 As String
    Private m_txthold04 As String
    Private m_txthold05 As String
    Private m_txthold06 As String
    Private m_txthold07 As String
    Private m_txthold08 As String
    Private m_txthold09 As String
    Private m_txthold10 As String
    Private m_dechold01? As Double
    Private m_dechold02? As Double
    Private m_dechold03? As Double
    Private m_dechold04? As Double
    Private m_dechold05? As Double
    Private m_inthold01? As Int32
    Private m_inthold02? As Int32
    Private m_inthold03? As Int32
    Private m_inthold04? As Int32
    Private m_inthold05? As Int32
    Private m_dtehold01? As Date
    Private m_dtehold02? As Date
    Private m_dtehold03? As Date
    Private m_dtehold04? As Date
    Private m_dtehold05? As Date
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
    Private m_lblcalendarreminder As String
    Private m_dtefollowupdate? As Date
    Private m_txteventstarttime As String
    Private m_txteventendtime As String
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
    ''' The lblContactInformation column is in the DB
    ''' </summary>
    Public Property lblContactInformation() As String
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            If String.IsNullOrEmpty(m_lblcontactinformation) Then
                Return String.Empty
            Else
                Return m_lblcontactinformation
            End If
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value As String)
            If value Is Nothing Then
                value = String.Empty
            End If
            If m_lblcontactinformation <> value Then
                m_lblcontactinformation = value
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
    ''' The txtProviderIdentificationNumber column is in the DB
    ''' </summary>
    Public Property txtProviderIdentificationNumber() As String
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            If String.IsNullOrEmpty(m_txtprovideridentificationnumber) Then
                Return String.Empty
            Else
                Return m_txtprovideridentificationnumber
            End If
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value As String)
            If value Is Nothing Then
                value = String.Empty
            End If
            If m_txtprovideridentificationnumber <> value Then
                m_txtprovideridentificationnumber = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The intRecordID_Document_Picture column is in the DB
    ''' </summary>
    Public Property intRecordID_Document_Picture() As Int32?
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            Return m_intrecordid_document_picture
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value? As Int32)
            If Not m_intrecordid_document_picture.Equals(value) Then
                m_intrecordid_document_picture = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The intRecordID_Account column is in the DB
    ''' </summary>
    Public Property intRecordID_Account() As Int32?
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            Return m_intrecordid_account
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value? As Int32)
            If Not m_intrecordid_account.Equals(value) Then
                m_intrecordid_account = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The intRecordID_ContactSalutation column is in the DB
    ''' </summary>
    Public Property intRecordID_ContactSalutation() As Int32?
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            Return m_intrecordid_contactsalutation
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value? As Int32)
            If Not m_intrecordid_contactsalutation.Equals(value) Then
                m_intrecordid_contactsalutation = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The txtFirstName column is in the DB
    ''' </summary>
    Public Property txtFirstName() As String
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            If String.IsNullOrEmpty(m_txtfirstname) Then
                Return String.Empty
            Else
                Return m_txtfirstname
            End If
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value As String)
            If value Is Nothing Then
                value = String.Empty
            End If
            If m_txtfirstname <> value Then
                m_txtfirstname = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The txtMiddleName column is in the DB
    ''' </summary>
    Public Property txtMiddleName() As String
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            If String.IsNullOrEmpty(m_txtmiddlename) Then
                Return String.Empty
            Else
                Return m_txtmiddlename
            End If
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value As String)
            If value Is Nothing Then
                value = String.Empty
            End If
            If m_txtmiddlename <> value Then
                m_txtmiddlename = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The txtMiddleInitial column is in the DB
    ''' </summary>
    Public Property txtMiddleInitial() As String
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            If String.IsNullOrEmpty(m_txtmiddleinitial) Then
                Return String.Empty
            Else
                Return m_txtmiddleinitial
            End If
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value As String)
            If value Is Nothing Then
                value = String.Empty
            End If
            If m_txtmiddleinitial <> value Then
                m_txtmiddleinitial = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The txtLastName column is in the DB
    ''' </summary>
    Public Property txtLastName() As String
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            If String.IsNullOrEmpty(m_txtlastname) Then
                Return String.Empty
            Else
                Return m_txtlastname
            End If
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value As String)
            If value Is Nothing Then
                value = String.Empty
            End If
            If m_txtlastname <> value Then
                m_txtlastname = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The txtBestTime column is in the DB
    ''' </summary>
    Public Property txtBestTime() As String
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            If String.IsNullOrEmpty(m_txtbesttime) Then
                Return String.Empty
            Else
                Return m_txtbesttime
            End If
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value As String)
            If value Is Nothing Then
                value = String.Empty
            End If
            If m_txtbesttime <> value Then
                m_txtbesttime = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The txtSuffix column is in the DB
    ''' </summary>
    Public Property txtSuffix() As String
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            If String.IsNullOrEmpty(m_txtsuffix) Then
                Return String.Empty
            Else
                Return m_txtsuffix
            End If
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value As String)
            If value Is Nothing Then
                value = String.Empty
            End If
            If m_txtsuffix <> value Then
                m_txtsuffix = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The txtCompanyName column is in the DB
    ''' </summary>
    Public Property txtCompanyName() As String
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            If String.IsNullOrEmpty(m_txtcompanyname) Then
                Return String.Empty
            Else
                Return m_txtcompanyname
            End If
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value As String)
            If value Is Nothing Then
                value = String.Empty
            End If
            If m_txtcompanyname <> value Then
                m_txtcompanyname = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The txtDBA column is in the DB
    ''' </summary>
    Public Property txtDBA() As String
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            If String.IsNullOrEmpty(m_txtdba) Then
                Return String.Empty
            Else
                Return m_txtdba
            End If
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value As String)
            If value Is Nothing Then
                value = String.Empty
            End If
            If m_txtdba <> value Then
                m_txtdba = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The intRecordID_ContactTitle column is in the DB
    ''' </summary>
    Public Property intRecordID_ContactTitle() As Int32?
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            Return m_intrecordid_contacttitle
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value? As Int32)
            If Not m_intrecordid_contacttitle.Equals(value) Then
                m_intrecordid_contacttitle = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The txtAddress1 column is in the DB
    ''' </summary>
    Public Property txtAddress1() As String
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            If String.IsNullOrEmpty(m_txtaddress1) Then
                Return String.Empty
            Else
                Return m_txtaddress1
            End If
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value As String)
            If value Is Nothing Then
                value = String.Empty
            End If
            If m_txtaddress1 <> value Then
                m_txtaddress1 = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The txtAddress2 column is in the DB
    ''' </summary>
    Public Property txtAddress2() As String
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            If String.IsNullOrEmpty(m_txtaddress2) Then
                Return String.Empty
            Else
                Return m_txtaddress2
            End If
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value As String)
            If value Is Nothing Then
                value = String.Empty
            End If
            If m_txtaddress2 <> value Then
                m_txtaddress2 = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The txtAddress3 column is in the DB
    ''' </summary>
    Public Property txtAddress3() As String
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            If String.IsNullOrEmpty(m_txtaddress3) Then
                Return String.Empty
            Else
                Return m_txtaddress3
            End If
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value As String)
            If value Is Nothing Then
                value = String.Empty
            End If
            If m_txtaddress3 <> value Then
                m_txtaddress3 = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The txtCity column is in the DB
    ''' </summary>
    Public Property txtCity() As String
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            If String.IsNullOrEmpty(m_txtcity) Then
                Return String.Empty
            Else
                Return m_txtcity
            End If
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value As String)
            If value Is Nothing Then
                value = String.Empty
            End If
            If m_txtcity <> value Then
                m_txtcity = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The intRecordID_State column is in the DB
    ''' </summary>
    Public Property intRecordID_State() As Int32?
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            Return m_intrecordid_state
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value? As Int32)
            If Not m_intrecordid_state.Equals(value) Then
                m_intrecordid_state = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The txtPostalCode column is in the DB
    ''' </summary>
    Public Property txtPostalCode() As String
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            If String.IsNullOrEmpty(m_txtpostalcode) Then
                Return String.Empty
            Else
                Return m_txtpostalcode
            End If
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value As String)
            If value Is Nothing Then
                value = String.Empty
            End If
            If m_txtpostalcode <> value Then
                m_txtpostalcode = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The intRecordID_County column is in the DB
    ''' </summary>
    Public Property intRecordID_County() As Int32?
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            Return m_intrecordid_county
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value? As Int32)
            If Not m_intrecordid_county.Equals(value) Then
                m_intrecordid_county = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The intRecordID_Country column is in the DB
    ''' </summary>
    Public Property intRecordID_Country() As Int32?
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            Return m_intrecordid_country
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value? As Int32)
            If Not m_intrecordid_country.Equals(value) Then
                m_intrecordid_country = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The lblContactAccessInformation column is in the DB
    ''' </summary>
    Public Property lblContactAccessInformation() As String
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            If String.IsNullOrEmpty(m_lblcontactaccessinformation) Then
                Return String.Empty
            Else
                Return m_lblcontactaccessinformation
            End If
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value As String)
            If value Is Nothing Then
                value = String.Empty
            End If
            If m_lblcontactaccessinformation <> value Then
                m_lblcontactaccessinformation = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The txtSkypeID column is in the DB
    ''' </summary>
    Public Property txtSkypeID() As String
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            If String.IsNullOrEmpty(m_txtskypeid) Then
                Return String.Empty
            Else
                Return m_txtskypeid
            End If
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value As String)
            If value Is Nothing Then
                value = String.Empty
            End If
            If m_txtskypeid <> value Then
                m_txtskypeid = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The txtPhoneNumberOffice column is in the DB
    ''' </summary>
    Public Property txtPhoneNumberOffice() As String
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            If String.IsNullOrEmpty(m_txtphonenumberoffice) Then
                Return String.Empty
            Else
                Return m_txtphonenumberoffice
            End If
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value As String)
            If value Is Nothing Then
                value = String.Empty
            End If
            If m_txtphonenumberoffice <> value Then
                m_txtphonenumberoffice = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The txtPhoneNumberMobile column is in the DB
    ''' </summary>
    Public Property txtPhoneNumberMobile() As String
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            If String.IsNullOrEmpty(m_txtphonenumbermobile) Then
                Return String.Empty
            Else
                Return m_txtphonenumbermobile
            End If
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value As String)
            If value Is Nothing Then
                value = String.Empty
            End If
            If m_txtphonenumbermobile <> value Then
                m_txtphonenumbermobile = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The intRecordID_MailSMSCarriers column is in the DB
    ''' </summary>
    Public Property intRecordID_MailSMSCarriers() As Int32?
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            Return m_intrecordid_mailsmscarriers
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value? As Int32)
            If Not m_intrecordid_mailsmscarriers.Equals(value) Then
                m_intrecordid_mailsmscarriers = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The txtPhoneNumberHome column is in the DB
    ''' </summary>
    Public Property txtPhoneNumberHome() As String
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            If String.IsNullOrEmpty(m_txtphonenumberhome) Then
                Return String.Empty
            Else
                Return m_txtphonenumberhome
            End If
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value As String)
            If value Is Nothing Then
                value = String.Empty
            End If
            If m_txtphonenumberhome <> value Then
                m_txtphonenumberhome = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The txtFaxNumber column is in the DB
    ''' </summary>
    Public Property txtFaxNumber() As String
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            If String.IsNullOrEmpty(m_txtfaxnumber) Then
                Return String.Empty
            Else
                Return m_txtfaxnumber
            End If
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value As String)
            If value Is Nothing Then
                value = String.Empty
            End If
            If m_txtfaxnumber <> value Then
                m_txtfaxnumber = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The txtPager column is in the DB
    ''' </summary>
    Public Property txtPager() As String
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            If String.IsNullOrEmpty(m_txtpager) Then
                Return String.Empty
            Else
                Return m_txtpager
            End If
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value As String)
            If value Is Nothing Then
                value = String.Empty
            End If
            If m_txtpager <> value Then
                m_txtpager = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The txtEmailAddress column is in the DB
    ''' </summary>
    Public Property txtEmailAddress() As String
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            If String.IsNullOrEmpty(m_txtemailaddress) Then
                Return String.Empty
            Else
                Return m_txtemailaddress
            End If
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value As String)
            If value Is Nothing Then
                value = String.Empty
            End If
            If m_txtemailaddress <> value Then
                m_txtemailaddress = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The blnMailReturned column is in the DB
    ''' </summary>
    Public Property blnMailReturned() As String
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            If String.IsNullOrEmpty(m_blnmailreturned) Then
                Return String.Empty
            Else
                Return m_blnmailreturned
            End If
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value As String)
            If value Is Nothing Then
                value = String.Empty
            End If
            If m_blnmailreturned <> value Then
                m_blnmailreturned = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The txtWebsiteTitle column is in the DB
    ''' </summary>
    Public Property txtWebsiteTitle() As String
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            If String.IsNullOrEmpty(m_txtwebsitetitle) Then
                Return String.Empty
            Else
                Return m_txtwebsitetitle
            End If
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value As String)
            If value Is Nothing Then
                value = String.Empty
            End If
            If m_txtwebsitetitle <> value Then
                m_txtwebsitetitle = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The lblContactPersonalInformation column is in the DB
    ''' </summary>
    Public Property lblContactPersonalInformation() As String
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            If String.IsNullOrEmpty(m_lblcontactpersonalinformation) Then
                Return String.Empty
            Else
                Return m_lblcontactpersonalinformation
            End If
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value As String)
            If value Is Nothing Then
                value = String.Empty
            End If
            If m_lblcontactpersonalinformation <> value Then
                m_lblcontactpersonalinformation = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The dteDateOfBirth column is in the DB
    ''' </summary>
    Public Property dteDateOfBirth() As Date?
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            Return m_dtedateofbirth
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value? As Date)
            If Not m_dtedateofbirth.Equals(value) Then
                m_dtedateofbirth = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The clcContactAge column is in the DB
    ''' </summary>
    Public Property clcContactAge() As Double?
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            Return m_clccontactage
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value? As Double)
            If Not m_clccontactage.Equals(value) Then
                m_clccontactage = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The txtDriversLicense column is in the DB
    ''' </summary>
    Public Property txtDriversLicense() As String
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            If String.IsNullOrEmpty(m_txtdriverslicense) Then
                Return String.Empty
            Else
                Return m_txtdriverslicense
            End If
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value As String)
            If value Is Nothing Then
                value = String.Empty
            End If
            If m_txtdriverslicense <> value Then
                m_txtdriverslicense = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The txtSSN column is in the DB
    ''' </summary>
    Public Property txtSSN() As String
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            If String.IsNullOrEmpty(m_txtssn) Then
                Return String.Empty
            Else
                Return m_txtssn
            End If
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value As String)
            If value Is Nothing Then
                value = String.Empty
            End If
            If m_txtssn <> value Then
                m_txtssn = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The txtEmergencyContactName column is in the DB
    ''' </summary>
    Public Property txtEmergencyContactName() As String
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            If String.IsNullOrEmpty(m_txtemergencycontactname) Then
                Return String.Empty
            Else
                Return m_txtemergencycontactname
            End If
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value As String)
            If value Is Nothing Then
                value = String.Empty
            End If
            If m_txtemergencycontactname <> value Then
                m_txtemergencycontactname = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The txtEmergencyContactPhone column is in the DB
    ''' </summary>
    Public Property txtEmergencyContactPhone() As String
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            If String.IsNullOrEmpty(m_txtemergencycontactphone) Then
                Return String.Empty
            Else
                Return m_txtemergencycontactphone
            End If
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value As String)
            If value Is Nothing Then
                value = String.Empty
            End If
            If m_txtemergencycontactphone <> value Then
                m_txtemergencycontactphone = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The lblContactPreferences column is in the DB
    ''' </summary>
    Public Property lblContactPreferences() As String
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            If String.IsNullOrEmpty(m_lblcontactpreferences) Then
                Return String.Empty
            Else
                Return m_lblcontactpreferences
            End If
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value As String)
            If value Is Nothing Then
                value = String.Empty
            End If
            If m_lblcontactpreferences <> value Then
                m_lblcontactpreferences = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The txtBillingDay column is in the DB
    ''' </summary>
    Public Property txtBillingDay() As String
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            If String.IsNullOrEmpty(m_txtbillingday) Then
                Return String.Empty
            Else
                Return m_txtbillingday
            End If
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value As String)
            If value Is Nothing Then
                value = String.Empty
            End If
            If m_txtbillingday <> value Then
                m_txtbillingday = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The blnBackOrder column is in the DB
    ''' </summary>
    Public Property blnBackOrder() As String
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            If String.IsNullOrEmpty(m_blnbackorder) Then
                Return String.Empty
            Else
                Return m_blnbackorder
            End If
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value As String)
            If value Is Nothing Then
                value = String.Empty
            End If
            If m_blnbackorder <> value Then
                m_blnbackorder = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The blnProductCatalog column is in the DB
    ''' </summary>
    Public Property blnProductCatalog() As String
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            If String.IsNullOrEmpty(m_blnproductcatalog) Then
                Return String.Empty
            Else
                Return m_blnproductcatalog
            End If
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value As String)
            If value Is Nothing Then
                value = String.Empty
            End If
            If m_blnproductcatalog <> value Then
                m_blnproductcatalog = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The blnConfirmSalesOrder column is in the DB
    ''' </summary>
    Public Property blnConfirmSalesOrder() As String
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            If String.IsNullOrEmpty(m_blnconfirmsalesorder) Then
                Return String.Empty
            Else
                Return m_blnconfirmsalesorder
            End If
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value As String)
            If value Is Nothing Then
                value = String.Empty
            End If
            If m_blnconfirmsalesorder <> value Then
                m_blnconfirmsalesorder = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The blnPrintPriceList column is in the DB
    ''' </summary>
    Public Property blnPrintPriceList() As String
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            If String.IsNullOrEmpty(m_blnprintpricelist) Then
                Return String.Empty
            Else
                Return m_blnprintpricelist
            End If
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value As String)
            If value Is Nothing Then
                value = String.Empty
            End If
            If m_blnprintpricelist <> value Then
                m_blnprintpricelist = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The blnSubscribeToNewsletter column is in the DB
    ''' </summary>
    Public Property blnSubscribeToNewsletter() As String
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            If String.IsNullOrEmpty(m_blnsubscribetonewsletter) Then
                Return String.Empty
            Else
                Return m_blnsubscribetonewsletter
            End If
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value As String)
            If value Is Nothing Then
                value = String.Empty
            End If
            If m_blnsubscribetonewsletter <> value Then
                m_blnsubscribetonewsletter = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The lblContactDetails column is in the DB
    ''' </summary>
    Public Property lblContactDetails() As String
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            If String.IsNullOrEmpty(m_lblcontactdetails) Then
                Return String.Empty
            Else
                Return m_lblcontactdetails
            End If
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value As String)
            If value Is Nothing Then
                value = String.Empty
            End If
            If m_lblcontactdetails <> value Then
                m_lblcontactdetails = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The intRecordID_Campaign column is in the DB
    ''' </summary>
    Public Property intRecordID_Campaign() As Int32?
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            Return m_intrecordid_campaign
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value? As Int32)
            If Not m_intrecordid_campaign.Equals(value) Then
                m_intrecordid_campaign = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The intRecordID_ContactCategory column is in the DB
    ''' </summary>
    Public Property intRecordID_ContactCategory() As Int32?
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            Return m_intrecordid_contactcategory
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value? As Int32)
            If Not m_intrecordid_contactcategory.Equals(value) Then
                m_intrecordid_contactcategory = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The intRecordID_Industry column is in the DB
    ''' </summary>
    Public Property intRecordID_Industry() As Int32?
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            Return m_intrecordid_industry
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value? As Int32)
            If Not m_intrecordid_industry.Equals(value) Then
                m_intrecordid_industry = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The intRecordID_Region column is in the DB
    ''' </summary>
    Public Property intRecordID_Region() As Int32?
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            Return m_intrecordid_region
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value? As Int32)
            If Not m_intrecordid_region.Equals(value) Then
                m_intrecordid_region = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The intRecordID_ContactStatus column is in the DB
    ''' </summary>
    Public Property intRecordID_ContactStatus() As Int32?
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            Return m_intrecordid_contactstatus
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value? As Int32)
            If Not m_intrecordid_contactstatus.Equals(value) Then
                m_intrecordid_contactstatus = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The intRecordID_ContactProcessStatus column is in the DB
    ''' </summary>
    Public Property intRecordID_ContactProcessStatus() As Int32?
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            Return m_intrecordid_contactprocessstatus
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value? As Int32)
            If Not m_intrecordid_contactprocessstatus.Equals(value) Then
                m_intrecordid_contactprocessstatus = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The lblContactBillingAndShippingInformation column is in the DB
    ''' </summary>
    Public Property lblContactBillingAndShippingInformation() As String
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            If String.IsNullOrEmpty(m_lblcontactbillingandshippinginformation) Then
                Return String.Empty
            Else
                Return m_lblcontactbillingandshippinginformation
            End If
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value As String)
            If value Is Nothing Then
                value = String.Empty
            End If
            If m_lblcontactbillingandshippinginformation <> value Then
                m_lblcontactbillingandshippinginformation = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The intRecordID_ContactBillTo column is in the DB
    ''' </summary>
    Public Property intRecordID_ContactBillTo() As Int32?
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            Return m_intrecordid_contactbillto
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value? As Int32)
            If Not m_intrecordid_contactbillto.Equals(value) Then
                m_intrecordid_contactbillto = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The intRecordID_ContactShipTo column is in the DB
    ''' </summary>
    Public Property intRecordID_ContactShipTo() As Int32?
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            Return m_intrecordid_contactshipto
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value? As Int32)
            If Not m_intrecordid_contactshipto.Equals(value) Then
                m_intrecordid_contactshipto = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The intRecordID_ShipMethod column is in the DB
    ''' </summary>
    Public Property intRecordID_ShipMethod() As Int32?
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            Return m_intrecordid_shipmethod
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value? As Int32)
            If Not m_intrecordid_shipmethod.Equals(value) Then
                m_intrecordid_shipmethod = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The intRecordID_Contact_ShipVia column is in the DB
    ''' </summary>
    Public Property intRecordID_Contact_ShipVia() As Int32?
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            Return m_intrecordid_contact_shipvia
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value? As Int32)
            If Not m_intrecordid_contact_shipvia.Equals(value) Then
                m_intrecordid_contact_shipvia = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The txtFOB column is in the DB
    ''' </summary>
    Public Property txtFOB() As String
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            If String.IsNullOrEmpty(m_txtfob) Then
                Return String.Empty
            Else
                Return m_txtfob
            End If
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value As String)
            If value Is Nothing Then
                value = String.Empty
            End If
            If m_txtfob <> value Then
                m_txtfob = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The lblContactManagementDetails column is in the DB
    ''' </summary>
    Public Property lblContactManagementDetails() As String
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            If String.IsNullOrEmpty(m_lblcontactmanagementdetails) Then
                Return String.Empty
            Else
                Return m_lblcontactmanagementdetails
            End If
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value As String)
            If value Is Nothing Then
                value = String.Empty
            End If
            If m_lblcontactmanagementdetails <> value Then
                m_lblcontactmanagementdetails = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The intRecordID_Contact_SalesRep column is in the DB
    ''' </summary>
    Public Property intRecordID_Contact_SalesRep() As Int32?
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            Return m_intrecordid_contact_salesrep
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value? As Int32)
            If Not m_intrecordid_contact_salesrep.Equals(value) Then
                m_intrecordid_contact_salesrep = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The intRecordID_MarketingSource column is in the DB
    ''' </summary>
    Public Property intRecordID_MarketingSource() As Int32?
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            Return m_intrecordid_marketingsource
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value? As Int32)
            If Not m_intrecordid_marketingsource.Equals(value) Then
                m_intrecordid_marketingsource = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The blnInspectionRequired column is in the DB
    ''' </summary>
    Public Property blnInspectionRequired() As String
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            If String.IsNullOrEmpty(m_blninspectionrequired) Then
                Return String.Empty
            Else
                Return m_blninspectionrequired
            End If
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value As String)
            If value Is Nothing Then
                value = String.Empty
            End If
            If m_blninspectionrequired <> value Then
                m_blninspectionrequired = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The lblContactWebAccessInformation column is in the DB
    ''' </summary>
    Public Property lblContactWebAccessInformation() As String
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            If String.IsNullOrEmpty(m_lblcontactwebaccessinformation) Then
                Return String.Empty
            Else
                Return m_lblcontactwebaccessinformation
            End If
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value As String)
            If value Is Nothing Then
                value = String.Empty
            End If
            If m_lblcontactwebaccessinformation <> value Then
                m_lblcontactwebaccessinformation = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The lbmUserInformation column is in the DB
    ''' </summary>
    Public Property lbmUserInformation() As String
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            If String.IsNullOrEmpty(m_lbmuserinformation) Then
                Return String.Empty
            Else
                Return m_lbmuserinformation
            End If
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value As String)
            If value Is Nothing Then
                value = String.Empty
            End If
            If m_lbmuserinformation <> value Then
                m_lbmuserinformation = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The txtUserName column is in the DB
    ''' </summary>
    Public Property txtUserName() As String
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            If String.IsNullOrEmpty(m_txtusername) Then
                Return String.Empty
            Else
                Return m_txtusername
            End If
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value As String)
            If value Is Nothing Then
                value = String.Empty
            End If
            If m_txtusername <> value Then
                m_txtusername = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The txtPassword column is in the DB
    ''' </summary>
    Public Property txtPassword() As String
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            If String.IsNullOrEmpty(m_txtpassword) Then
                Return String.Empty
            Else
                Return m_txtpassword
            End If
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value As String)
            If value Is Nothing Then
                value = String.Empty
            End If
            If m_txtpassword <> value Then
                m_txtpassword = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The txtSecretQuestionAnswer column is in the DB
    ''' </summary>
    Public Property txtSecretQuestionAnswer() As String
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            If String.IsNullOrEmpty(m_txtsecretquestionanswer) Then
                Return String.Empty
            Else
                Return m_txtsecretquestionanswer
            End If
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value As String)
            If value Is Nothing Then
                value = String.Empty
            End If
            If m_txtsecretquestionanswer <> value Then
                m_txtsecretquestionanswer = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The intRecordID_SecretQuestion column is in the DB
    ''' </summary>
    Public Property intRecordID_SecretQuestion() As Int32?
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            Return m_intrecordid_secretquestion
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value? As Int32)
            If Not m_intrecordid_secretquestion.Equals(value) Then
                m_intrecordid_secretquestion = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The dtePasswordExpiration column is in the DB
    ''' </summary>
    Public Property dtePasswordExpiration() As Date?
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            Return m_dtepasswordexpiration
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value? As Date)
            If Not m_dtepasswordexpiration.Equals(value) Then
                m_dtepasswordexpiration = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The blnPasswordAutoExpire column is in the DB
    ''' </summary>
    Public Property blnPasswordAutoExpire() As String
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            If String.IsNullOrEmpty(m_blnpasswordautoexpire) Then
                Return String.Empty
            Else
                Return m_blnpasswordautoexpire
            End If
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value As String)
            If value Is Nothing Then
                value = String.Empty
            End If
            If m_blnpasswordautoexpire <> value Then
                m_blnpasswordautoexpire = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The intPasswordExpireIntervalDay column is in the DB
    ''' </summary>
    Public Property intPasswordExpireIntervalDay() As Int32?
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            Return m_intpasswordexpireintervalday
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value? As Int32)
            If Not m_intpasswordexpireintervalday.Equals(value) Then
                m_intpasswordexpireintervalday = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The intFailedLoginAttempt column is in the DB
    ''' </summary>
    Public Property intFailedLoginAttempt() As Int32?
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            Return m_intfailedloginattempt
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value? As Int32)
            If Not m_intfailedloginattempt.Equals(value) Then
                m_intfailedloginattempt = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The txtUserRegistrationKey column is in the DB
    ''' </summary>
    Public Property txtUserRegistrationKey() As String
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            If String.IsNullOrEmpty(m_txtuserregistrationkey) Then
                Return String.Empty
            Else
                Return m_txtuserregistrationkey
            End If
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value As String)
            If value Is Nothing Then
                value = String.Empty
            End If
            If m_txtuserregistrationkey <> value Then
                m_txtuserregistrationkey = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The lblContactSurveyInformation column is in the DB
    ''' </summary>
    Public Property lblContactSurveyInformation() As String
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            If String.IsNullOrEmpty(m_lblcontactsurveyinformation) Then
                Return String.Empty
            Else
                Return m_lblcontactsurveyinformation
            End If
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value As String)
            If value Is Nothing Then
                value = String.Empty
            End If
            If m_lblcontactsurveyinformation <> value Then
                m_lblcontactsurveyinformation = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The intRecordID_SurveyUserType column is in the DB
    ''' </summary>
    Public Property intRecordID_SurveyUserType() As Int32?
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            Return m_intrecordid_surveyusertype
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value? As Int32)
            If Not m_intrecordid_surveyusertype.Equals(value) Then
                m_intrecordid_surveyusertype = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The intRecordID_SurveyLoginType column is in the DB
    ''' </summary>
    Public Property intRecordID_SurveyLoginType() As Int32?
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            Return m_intrecordid_surveylogintype
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value? As Int32)
            If Not m_intrecordid_surveylogintype.Equals(value) Then
                m_intrecordid_surveylogintype = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The txtSurveyUserNetworkDomain column is in the DB
    ''' </summary>
    Public Property txtSurveyUserNetworkDomain() As String
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            If String.IsNullOrEmpty(m_txtsurveyusernetworkdomain) Then
                Return String.Empty
            Else
                Return m_txtsurveyusernetworkdomain
            End If
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value As String)
            If value Is Nothing Then
                value = String.Empty
            End If
            If m_txtsurveyusernetworkdomain <> value Then
                m_txtsurveyusernetworkdomain = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The lblContactHRInformation column is in the DB
    ''' </summary>
    Public Property lblContactHRInformation() As String
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            If String.IsNullOrEmpty(m_lblcontacthrinformation) Then
                Return String.Empty
            Else
                Return m_lblcontacthrinformation
            End If
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value As String)
            If value Is Nothing Then
                value = String.Empty
            End If
            If m_lblcontacthrinformation <> value Then
                m_lblcontacthrinformation = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The txtAccountGLReferenceCode column is in the DB
    ''' </summary>
    Public Property txtAccountGLReferenceCode() As String
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            If String.IsNullOrEmpty(m_txtaccountglreferencecode) Then
                Return String.Empty
            Else
                Return m_txtaccountglreferencecode
            End If
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value As String)
            If value Is Nothing Then
                value = String.Empty
            End If
            If m_txtaccountglreferencecode <> value Then
                m_txtaccountglreferencecode = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The txtOtherNamesUsed column is in the DB
    ''' </summary>
    Public Property txtOtherNamesUsed() As String
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            If String.IsNullOrEmpty(m_txtothernamesused) Then
                Return String.Empty
            Else
                Return m_txtothernamesused
            End If
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value As String)
            If value Is Nothing Then
                value = String.Empty
            End If
            If m_txtothernamesused <> value Then
                m_txtothernamesused = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The intRecordID_Contact_Union column is in the DB
    ''' </summary>
    Public Property intRecordID_Contact_Union() As Int32?
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            Return m_intrecordid_contact_union
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value? As Int32)
            If Not m_intrecordid_contact_union.Equals(value) Then
                m_intrecordid_contact_union = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The intRecordID_HREmployeeUnionType column is in the DB
    ''' </summary>
    Public Property intRecordID_HREmployeeUnionType() As Int32?
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            Return m_intrecordid_hremployeeuniontype
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value? As Int32)
            If Not m_intrecordid_hremployeeuniontype.Equals(value) Then
                m_intrecordid_hremployeeuniontype = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The intRecordID_HREmployeeStatus column is in the DB
    ''' </summary>
    Public Property intRecordID_HREmployeeStatus() As Int32?
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            Return m_intrecordid_hremployeestatus
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value? As Int32)
            If Not m_intrecordid_hremployeestatus.Equals(value) Then
                m_intrecordid_hremployeestatus = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The lbmWorkCenterMustBeAssignedForCorrectLaborReporting column is in the DB
    ''' </summary>
    Public Property lbmWorkCenterMustBeAssignedForCorrectLaborReporting() As String
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            If String.IsNullOrEmpty(m_lbmworkcentermustbeassignedforcorrectlaborreporting) Then
                Return String.Empty
            Else
                Return m_lbmworkcentermustbeassignedforcorrectlaborreporting
            End If
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value As String)
            If value Is Nothing Then
                value = String.Empty
            End If
            If m_lbmworkcentermustbeassignedforcorrectlaborreporting <> value Then
                m_lbmworkcentermustbeassignedforcorrectlaborreporting = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The intRecordID_WorkCenter column is in the DB
    ''' </summary>
    Public Property intRecordID_WorkCenter() As Int32?
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            Return m_intrecordid_workcenter
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value? As Int32)
            If Not m_intrecordid_workcenter.Equals(value) Then
                m_intrecordid_workcenter = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The intRecordID_HRShift column is in the DB
    ''' </summary>
    Public Property intRecordID_HRShift() As Int32?
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            Return m_intrecordid_hrshift
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value? As Int32)
            If Not m_intrecordid_hrshift.Equals(value) Then
                m_intrecordid_hrshift = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The intRecordID_Language column is in the DB
    ''' </summary>
    Public Property intRecordID_Language() As Int32?
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            Return m_intrecordid_language
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value? As Int32)
            If Not m_intrecordid_language.Equals(value) Then
                m_intrecordid_language = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The lbmDiversityInformation column is in the DB
    ''' </summary>
    Public Property lbmDiversityInformation() As String
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            If String.IsNullOrEmpty(m_lbmdiversityinformation) Then
                Return String.Empty
            Else
                Return m_lbmdiversityinformation
            End If
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value As String)
            If value Is Nothing Then
                value = String.Empty
            End If
            If m_lbmdiversityinformation <> value Then
                m_lbmdiversityinformation = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The intRecordID_HREthnicOrigin column is in the DB
    ''' </summary>
    Public Property intRecordID_HREthnicOrigin() As Int32?
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            Return m_intrecordid_hrethnicorigin
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value? As Int32)
            If Not m_intrecordid_hrethnicorigin.Equals(value) Then
                m_intrecordid_hrethnicorigin = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The intRecordID_HRGender column is in the DB
    ''' </summary>
    Public Property intRecordID_HRGender() As Int32?
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            Return m_intrecordid_hrgender
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value? As Int32)
            If Not m_intrecordid_hrgender.Equals(value) Then
                m_intrecordid_hrgender = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The intRecordID_HREmployeePayCheckDeliveryMethod column is in the DB
    ''' </summary>
    Public Property intRecordID_HREmployeePayCheckDeliveryMethod() As Int32?
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            Return m_intrecordid_hremployeepaycheckdeliverymethod
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value? As Int32)
            If Not m_intrecordid_hremployeepaycheckdeliverymethod.Equals(value) Then
                m_intrecordid_hremployeepaycheckdeliverymethod = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The intRecordID_HRMilitaryService column is in the DB
    ''' </summary>
    Public Property intRecordID_HRMilitaryService() As Int32?
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            Return m_intrecordid_hrmilitaryservice
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value? As Int32)
            If Not m_intrecordid_hrmilitaryservice.Equals(value) Then
                m_intrecordid_hrmilitaryservice = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The intRecordID_Contact_Supervisor column is in the DB
    ''' </summary>
    Public Property intRecordID_Contact_Supervisor() As Int32?
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            Return m_intrecordid_contact_supervisor
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value? As Int32)
            If Not m_intrecordid_contact_supervisor.Equals(value) Then
                m_intrecordid_contact_supervisor = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The lblContactExtendedHRInformation column is in the DB
    ''' </summary>
    Public Property lblContactExtendedHRInformation() As String
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            If String.IsNullOrEmpty(m_lblcontactextendedhrinformation) Then
                Return String.Empty
            Else
                Return m_lblcontactextendedhrinformation
            End If
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value As String)
            If value Is Nothing Then
                value = String.Empty
            End If
            If m_lblcontactextendedhrinformation <> value Then
                m_lblcontactextendedhrinformation = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The intRecordID_ContactHRInformation column is in the DB
    ''' </summary>
    Public Property intRecordID_ContactHRInformation() As Int32?
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            Return m_intrecordid_contacthrinformation
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value? As Int32)
            If Not m_intrecordid_contacthrinformation.Equals(value) Then
                m_intrecordid_contacthrinformation = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The lblMemberOtherMedicalInsurance column is in the DB
    ''' </summary>
    Public Property lblMemberOtherMedicalInsurance() As String
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            If String.IsNullOrEmpty(m_lblmemberothermedicalinsurance) Then
                Return String.Empty
            Else
                Return m_lblmemberothermedicalinsurance
            End If
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value As String)
            If value Is Nothing Then
                value = String.Empty
            End If
            If m_lblmemberothermedicalinsurance <> value Then
                m_lblmemberothermedicalinsurance = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The blnMedicare column is in the DB
    ''' </summary>
    Public Property blnMedicare() As String
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            If String.IsNullOrEmpty(m_blnmedicare) Then
                Return String.Empty
            Else
                Return m_blnmedicare
            End If
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value As String)
            If value Is Nothing Then
                value = String.Empty
            End If
            If m_blnmedicare <> value Then
                m_blnmedicare = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The blnCOB column is in the DB
    ''' </summary>
    Public Property blnCOB() As String
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            If String.IsNullOrEmpty(m_blncob) Then
                Return String.Empty
            Else
                Return m_blncob
            End If
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value As String)
            If value Is Nothing Then
                value = String.Empty
            End If
            If m_blncob <> value Then
                m_blncob = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The dteCOBLetterReceivedDate column is in the DB
    ''' </summary>
    Public Property dteCOBLetterReceivedDate() As Date?
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            Return m_dtecobletterreceiveddate
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value? As Date)
            If Not m_dtecobletterreceiveddate.Equals(value) Then
                m_dtecobletterreceiveddate = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The lblMemberBenefitPlanInformation column is in the DB
    ''' </summary>
    Public Property lblMemberBenefitPlanInformation() As String
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            If String.IsNullOrEmpty(m_lblmemberbenefitplaninformation) Then
                Return String.Empty
            Else
                Return m_lblmemberbenefitplaninformation
            End If
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value As String)
            If value Is Nothing Then
                value = String.Empty
            End If
            If m_lblmemberbenefitplaninformation <> value Then
                m_lblmemberbenefitplaninformation = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The dteRTWDate column is in the DB
    ''' </summary>
    Public Property dteRTWDate() As Date?
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            Return m_dtertwdate
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value? As Date)
            If Not m_dtertwdate.Equals(value) Then
                m_dtertwdate = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The dteTerminationDate column is in the DB
    ''' </summary>
    Public Property dteTerminationDate() As Date?
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            Return m_dteterminationdate
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value? As Date)
            If Not m_dteterminationdate.Equals(value) Then
                m_dteterminationdate = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The intRecordID_HRBenefitPlanEmployeeContribution column is in the DB
    ''' </summary>
    Public Property intRecordID_HRBenefitPlanEmployeeContribution() As Int32?
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            Return m_intrecordid_hrbenefitplanemployeecontribution
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value? As Int32)
            If Not m_intrecordid_hrbenefitplanemployeecontribution.Equals(value) Then
                m_intrecordid_hrbenefitplanemployeecontribution = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The dteDateStart column is in the DB
    ''' </summary>
    Public Property dteDateStart() As Date?
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            Return m_dtedatestart
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value? As Date)
            If Not m_dtedatestart.Equals(value) Then
                m_dtedatestart = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The dteEffectiveStartDate column is in the DB
    ''' </summary>
    Public Property dteEffectiveStartDate() As Date?
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            Return m_dteeffectivestartdate
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value? As Date)
            If Not m_dteeffectivestartdate.Equals(value) Then
                m_dteeffectivestartdate = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The dteFullTimePromotionDate column is in the DB
    ''' </summary>
    Public Property dteFullTimePromotionDate() As Date?
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            Return m_dtefulltimepromotiondate
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value? As Date)
            If Not m_dtefulltimepromotiondate.Equals(value) Then
                m_dtefulltimepromotiondate = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The dteFullTimeEffectiveDate column is in the DB
    ''' </summary>
    Public Property dteFullTimeEffectiveDate() As Date?
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            Return m_dtefulltimeeffectivedate
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value? As Date)
            If Not m_dtefulltimeeffectivedate.Equals(value) Then
                m_dtefulltimeeffectivedate = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The dtePartTimeDemotionDate column is in the DB
    ''' </summary>
    Public Property dtePartTimeDemotionDate() As Date?
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            Return m_dteparttimedemotiondate
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value? As Date)
            If Not m_dteparttimedemotiondate.Equals(value) Then
                m_dteparttimedemotiondate = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The dtePartTimeEffectiveDate column is in the DB
    ''' </summary>
    Public Property dtePartTimeEffectiveDate() As Date?
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            Return m_dteparttimeeffectivedate
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value? As Date)
            If Not m_dteparttimeeffectivedate.Equals(value) Then
                m_dteparttimeeffectivedate = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The dteRetirementDate column is in the DB
    ''' </summary>
    Public Property dteRetirementDate() As Date?
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            Return m_dteretirementdate
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value? As Date)
            If Not m_dteretirementdate.Equals(value) Then
                m_dteretirementdate = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The intRecordID_HRBenefitCoverageTerminationReason column is in the DB
    ''' </summary>
    Public Property intRecordID_HRBenefitCoverageTerminationReason() As Int32?
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            Return m_intrecordid_hrbenefitcoverageterminationreason
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value? As Int32)
            If Not m_intrecordid_hrbenefitcoverageterminationreason.Equals(value) Then
                m_intrecordid_hrbenefitcoverageterminationreason = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The blnReportMemberAsSubscriber column is in the DB
    ''' </summary>
    Public Property blnReportMemberAsSubscriber() As String
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            If String.IsNullOrEmpty(m_blnreportmemberassubscriber) Then
                Return String.Empty
            Else
                Return m_blnreportmemberassubscriber
            End If
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value As String)
            If value Is Nothing Then
                value = String.Empty
            End If
            If m_blnreportmemberassubscriber <> value Then
                m_blnreportmemberassubscriber = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The lblCustomerInformation column is in the DB
    ''' </summary>
    Public Property lblCustomerInformation() As String
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            If String.IsNullOrEmpty(m_lblcustomerinformation) Then
                Return String.Empty
            Else
                Return m_lblcustomerinformation
            End If
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value As String)
            If value Is Nothing Then
                value = String.Empty
            End If
            If m_lblcustomerinformation <> value Then
                m_lblcustomerinformation = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The intRecordID_ContactCustomerInformation column is in the DB
    ''' </summary>
    Public Property intRecordID_ContactCustomerInformation() As Int32?
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            Return m_intrecordid_contactcustomerinformation
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value? As Int32)
            If Not m_intrecordid_contactcustomerinformation.Equals(value) Then
                m_intrecordid_contactcustomerinformation = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The lblBenefitInformation column is in the DB
    ''' </summary>
    Public Property lblBenefitInformation() As String
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            If String.IsNullOrEmpty(m_lblbenefitinformation) Then
                Return String.Empty
            Else
                Return m_lblbenefitinformation
            End If
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value As String)
            If value Is Nothing Then
                value = String.Empty
            End If
            If m_lblbenefitinformation <> value Then
                m_lblbenefitinformation = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The intRecordID_ContactBenefitInformation column is in the DB
    ''' </summary>
    Public Property intRecordID_ContactBenefitInformation() As Int32?
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            Return m_intrecordid_contactbenefitinformation
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value? As Int32)
            If Not m_intrecordid_contactbenefitinformation.Equals(value) Then
                m_intrecordid_contactbenefitinformation = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The lblContactCreditInformation column is in the DB
    ''' </summary>
    Public Property lblContactCreditInformation() As String
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            If String.IsNullOrEmpty(m_lblcontactcreditinformation) Then
                Return String.Empty
            Else
                Return m_lblcontactcreditinformation
            End If
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value As String)
            If value Is Nothing Then
                value = String.Empty
            End If
            If m_lblcontactcreditinformation <> value Then
                m_lblcontactcreditinformation = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The intRecordID_ContactCreditInformation column is in the DB
    ''' </summary>
    Public Property intRecordID_ContactCreditInformation() As Int32?
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            Return m_intrecordid_contactcreditinformation
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value? As Int32)
            If Not m_intrecordid_contactcreditinformation.Equals(value) Then
                m_intrecordid_contactcreditinformation = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The lblContactPromotionInformation column is in the DB
    ''' </summary>
    Public Property lblContactPromotionInformation() As String
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            If String.IsNullOrEmpty(m_lblcontactpromotioninformation) Then
                Return String.Empty
            Else
                Return m_lblcontactpromotioninformation
            End If
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value As String)
            If value Is Nothing Then
                value = String.Empty
            End If
            If m_lblcontactpromotioninformation <> value Then
                m_lblcontactpromotioninformation = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The intTargetGP column is in the DB
    ''' </summary>
    Public Property intTargetGP() As Int32?
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            Return m_inttargetgp
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value? As Int32)
            If Not m_inttargetgp.Equals(value) Then
                m_inttargetgp = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The blnQualifiesForRebate column is in the DB
    ''' </summary>
    Public Property blnQualifiesForRebate() As String
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            If String.IsNullOrEmpty(m_blnqualifiesforrebate) Then
                Return String.Empty
            Else
                Return m_blnqualifiesforrebate
            End If
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value As String)
            If value Is Nothing Then
                value = String.Empty
            End If
            If m_blnqualifiesforrebate <> value Then
                m_blnqualifiesforrebate = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The blnProductPromotion column is in the DB
    ''' </summary>
    Public Property blnProductPromotion() As String
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            If String.IsNullOrEmpty(m_blnproductpromotion) Then
                Return String.Empty
            Else
                Return m_blnproductpromotion
            End If
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value As String)
            If value Is Nothing Then
                value = String.Empty
            End If
            If m_blnproductpromotion <> value Then
                m_blnproductpromotion = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The intRecordID_ContactDiscount column is in the DB
    ''' </summary>
    Public Property intRecordID_ContactDiscount() As Int32?
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            Return m_intrecordid_contactdiscount
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value? As Int32)
            If Not m_intrecordid_contactdiscount.Equals(value) Then
                m_intrecordid_contactdiscount = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The intRecordID_Contact_BuyingGroup column is in the DB
    ''' </summary>
    Public Property intRecordID_Contact_BuyingGroup() As Int32?
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            Return m_intrecordid_contact_buyinggroup
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value? As Int32)
            If Not m_intrecordid_contact_buyinggroup.Equals(value) Then
                m_intrecordid_contact_buyinggroup = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The dteBuyingGroupStartDate column is in the DB
    ''' </summary>
    Public Property dteBuyingGroupStartDate() As Date?
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            Return m_dtebuyinggroupstartdate
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value? As Date)
            If Not m_dtebuyinggroupstartdate.Equals(value) Then
                m_dtebuyinggroupstartdate = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The decRebatePercent column is in the DB
    ''' </summary>
    Public Property decRebatePercent() As Double?
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            Return m_decrebatepercent
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value? As Double)
            If Not m_decrebatepercent.Equals(value) Then
                m_decrebatepercent = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The lblContactAccountingInformation column is in the DB
    ''' </summary>
    Public Property lblContactAccountingInformation() As String
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            If String.IsNullOrEmpty(m_lblcontactaccountinginformation) Then
                Return String.Empty
            Else
                Return m_lblcontactaccountinginformation
            End If
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value As String)
            If value Is Nothing Then
                value = String.Empty
            End If
            If m_lblcontactaccountinginformation <> value Then
                m_lblcontactaccountinginformation = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The intRecordID_GLChart_APExpense column is in the DB
    ''' </summary>
    Public Property intRecordID_GLChart_APExpense() As Int32?
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            Return m_intrecordid_glchart_apexpense
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value? As Int32)
            If Not m_intrecordid_glchart_apexpense.Equals(value) Then
                m_intrecordid_glchart_apexpense = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The intRecordID_GLChartDivision_APExpense column is in the DB
    ''' </summary>
    Public Property intRecordID_GLChartDivision_APExpense() As Int32?
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            Return m_intrecordid_glchartdivision_apexpense
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value? As Int32)
            If Not m_intrecordid_glchartdivision_apexpense.Equals(value) Then
                m_intrecordid_glchartdivision_apexpense = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The intRecordID_GLChartDepartment_APExpense column is in the DB
    ''' </summary>
    Public Property intRecordID_GLChartDepartment_APExpense() As Int32?
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            Return m_intrecordid_glchartdepartment_apexpense
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value? As Int32)
            If Not m_intrecordid_glchartdepartment_apexpense.Equals(value) Then
                m_intrecordid_glchartdepartment_apexpense = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The clcPremiumCost column is in the DB
    ''' </summary>
    Public Property clcPremiumCost() As Double?
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            Return m_clcpremiumcost
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value? As Double)
            If Not m_clcpremiumcost.Equals(value) Then
                m_clcpremiumcost = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The clcPremiumMemberPrice column is in the DB
    ''' </summary>
    Public Property clcPremiumMemberPrice() As Double?
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            Return m_clcpremiummemberprice
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value? As Double)
            If Not m_clcpremiummemberprice.Equals(value) Then
                m_clcpremiummemberprice = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The clcEmployerContribution column is in the DB
    ''' </summary>
    Public Property clcEmployerContribution() As Double?
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            Return m_clcemployercontribution
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value? As Double)
            If Not m_clcemployercontribution.Equals(value) Then
                m_clcemployercontribution = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The clcEmployeeDeduction column is in the DB
    ''' </summary>
    Public Property clcEmployeeDeduction() As Double?
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            Return m_clcemployeededuction
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value? As Double)
            If Not m_clcemployeededuction.Equals(value) Then
                m_clcemployeededuction = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The lblContactRecordInformation column is in the DB
    ''' </summary>
    Public Property lblContactRecordInformation() As String
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            If String.IsNullOrEmpty(m_lblcontactrecordinformation) Then
                Return String.Empty
            Else
                Return m_lblcontactrecordinformation
            End If
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value As String)
            If value Is Nothing Then
                value = String.Empty
            End If
            If m_lblcontactrecordinformation <> value Then
                m_lblcontactrecordinformation = value
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
    ''' The txtJoBSeekerID column is in the DB
    ''' </summary>
    Public Property txtJoBSeekerID() As String
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            If String.IsNullOrEmpty(m_txtjobseekerid) Then
                Return String.Empty
            Else
                Return m_txtjobseekerid
            End If
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value As String)
            If value Is Nothing Then
                value = String.Empty
            End If
            If m_txtjobseekerid <> value Then
                m_txtjobseekerid = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The txtSearchProviderResumeID column is in the DB
    ''' </summary>
    Public Property txtSearchProviderResumeID() As String
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            If String.IsNullOrEmpty(m_txtsearchproviderresumeid) Then
                Return String.Empty
            Else
                Return m_txtsearchproviderresumeid
            End If
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value As String)
            If value Is Nothing Then
                value = String.Empty
            End If
            If m_txtsearchproviderresumeid <> value Then
                m_txtsearchproviderresumeid = value
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
    ''' The txtEmployeeSSN column is in the DB
    ''' </summary>
    Public Property txtEmployeeSSN() As String
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            If String.IsNullOrEmpty(m_txtemployeessn) Then
                Return String.Empty
            Else
                Return m_txtemployeessn
            End If
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value As String)
            If value Is Nothing Then
                value = String.Empty
            End If
            If m_txtemployeessn <> value Then
                m_txtemployeessn = value
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
    ''' The intRecordID_Company_Ecommerce column is in the DB
    ''' </summary>
    Public Property intRecordID_Company_Ecommerce() As Int32?
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            Return m_intrecordid_company_ecommerce
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value? As Int32)
            If Not m_intrecordid_company_ecommerce.Equals(value) Then
                m_intrecordid_company_ecommerce = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The intRecordID_Division_Ecommerce column is in the DB
    ''' </summary>
    Public Property intRecordID_Division_Ecommerce() As Int32?
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            Return m_intrecordid_division_ecommerce
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value? As Int32)
            If Not m_intrecordid_division_ecommerce.Equals(value) Then
                m_intrecordid_division_ecommerce = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The intRecordID_DatabaseID_Ecommerce column is in the DB
    ''' </summary>
    Public Property intRecordID_DatabaseID_Ecommerce() As Int32?
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            Return m_intrecordid_databaseid_ecommerce
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value? As Int32)
            If Not m_intrecordid_databaseid_ecommerce.Equals(value) Then
                m_intrecordid_databaseid_ecommerce = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The intRecordID_User_Ecommerce column is in the DB
    ''' </summary>
    Public Property intRecordID_User_Ecommerce() As Int32?
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            Return m_intrecordid_user_ecommerce
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value? As Int32)
            If Not m_intrecordid_user_ecommerce.Equals(value) Then
                m_intrecordid_user_ecommerce = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The txtTableName_Ecommerce column is in the DB
    ''' </summary>
    Public Property txtTableName_Ecommerce() As String
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            If String.IsNullOrEmpty(m_txttablename_ecommerce) Then
                Return String.Empty
            Else
                Return m_txttablename_ecommerce
            End If
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value As String)
            If value Is Nothing Then
                value = String.Empty
            End If
            If m_txttablename_ecommerce <> value Then
                m_txttablename_ecommerce = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The intRecordIDTable_Ecommerce column is in the DB
    ''' </summary>
    Public Property intRecordIDTable_Ecommerce() As Int32?
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            Return m_intrecordidtable_ecommerce
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value? As Int32)
            If Not m_intrecordidtable_ecommerce.Equals(value) Then
                m_intrecordidtable_ecommerce = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The intRecordID_MarketingSalesSize column is in the DB
    ''' </summary>
    Public Property intRecordID_MarketingSalesSize() As Int32?
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            Return m_intrecordid_marketingsalessize
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value? As Int32)
            If Not m_intrecordid_marketingsalessize.Equals(value) Then
                m_intrecordid_marketingsalessize = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The intRecordID_APFinanceCharge column is in the DB
    ''' </summary>
    Public Property intRecordID_APFinanceCharge() As Int32?
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            Return m_intrecordid_apfinancecharge
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value? As Int32)
            If Not m_intrecordid_apfinancecharge.Equals(value) Then
                m_intrecordid_apfinancecharge = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The intRecordID_ARFinanceCharge column is in the DB
    ''' </summary>
    Public Property intRecordID_ARFinanceCharge() As Int32?
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            Return m_intrecordid_arfinancecharge
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value? As Int32)
            If Not m_intrecordid_arfinancecharge.Equals(value) Then
                m_intrecordid_arfinancecharge = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The blnPayroll column is in the DB
    ''' </summary>
    Public Property blnPayroll() As String
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            If String.IsNullOrEmpty(m_blnpayroll) Then
                Return String.Empty
            Else
                Return m_blnpayroll
            End If
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value As String)
            If value Is Nothing Then
                value = String.Empty
            End If
            If m_blnpayroll <> value Then
                m_blnpayroll = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The intRecordID_ContactCommerce column is in the DB
    ''' </summary>
    Public Property intRecordID_ContactCommerce() As Int32?
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            Return m_intrecordid_contactcommerce
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value? As Int32)
            If Not m_intrecordid_contactcommerce.Equals(value) Then
                m_intrecordid_contactcommerce = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The intRecordID_Contact_CustomerServiceRep column is in the DB
    ''' </summary>
    Public Property intRecordID_Contact_CustomerServiceRep() As Int32?
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            Return m_intrecordid_contact_customerservicerep
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value? As Int32)
            If Not m_intrecordid_contact_customerservicerep.Equals(value) Then
                m_intrecordid_contact_customerservicerep = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The blnReceiveInspectionRequired column is in the DB
    ''' </summary>
    Public Property blnReceiveInspectionRequired() As String
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            If String.IsNullOrEmpty(m_blnreceiveinspectionrequired) Then
                Return String.Empty
            Else
                Return m_blnreceiveinspectionrequired
            End If
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value As String)
            If value Is Nothing Then
                value = String.Empty
            End If
            If m_blnreceiveinspectionrequired <> value Then
                m_blnreceiveinspectionrequired = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The blnPayHold column is in the DB
    ''' </summary>
    Public Property blnPayHold() As String
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            If String.IsNullOrEmpty(m_blnpayhold) Then
                Return String.Empty
            Else
                Return m_blnpayhold
            End If
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value As String)
            If value Is Nothing Then
                value = String.Empty
            End If
            If m_blnpayhold <> value Then
                m_blnpayhold = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The intRecordID_Currency column is in the DB
    ''' </summary>
    Public Property intRecordID_Currency() As Int32?
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            Return m_intrecordid_currency
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value? As Int32)
            If Not m_intrecordid_currency.Equals(value) Then
                m_intrecordid_currency = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The intRecordID_ShipRoute column is in the DB
    ''' </summary>
    Public Property intRecordID_ShipRoute() As Int32?
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            Return m_intrecordid_shiproute
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value? As Int32)
            If Not m_intrecordid_shiproute.Equals(value) Then
                m_intrecordid_shiproute = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The intRecordID_ContactPricingMethod column is in the DB
    ''' </summary>
    Public Property intRecordID_ContactPricingMethod() As Int32?
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            Return m_intrecordid_contactpricingmethod
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value? As Int32)
            If Not m_intrecordid_contactpricingmethod.Equals(value) Then
                m_intrecordid_contactpricingmethod = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The intRecordID_ProductPriceList column is in the DB
    ''' </summary>
    Public Property intRecordID_ProductPriceList() As Int32?
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            Return m_intrecordid_productpricelist
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value? As Int32)
            If Not m_intrecordid_productpricelist.Equals(value) Then
                m_intrecordid_productpricelist = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The intRecordID_HRContactSecurityClearance column is in the DB
    ''' </summary>
    Public Property intRecordID_HRContactSecurityClearance() As Int32?
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            Return m_intrecordid_hrcontactsecurityclearance
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value? As Int32)
            If Not m_intrecordid_hrcontactsecurityclearance.Equals(value) Then
                m_intrecordid_hrcontactsecurityclearance = value
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
    ''' The txtHold01 column is in the DB
    ''' </summary>
    Public Property txtHold01() As String
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            If String.IsNullOrEmpty(m_txthold01) Then
                Return String.Empty
            Else
                Return m_txthold01
            End If
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value As String)
            If value Is Nothing Then
                value = String.Empty
            End If
            If m_txthold01 <> value Then
                m_txthold01 = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The txtHold02 column is in the DB
    ''' </summary>
    Public Property txtHold02() As String
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            If String.IsNullOrEmpty(m_txthold02) Then
                Return String.Empty
            Else
                Return m_txthold02
            End If
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value As String)
            If value Is Nothing Then
                value = String.Empty
            End If
            If m_txthold02 <> value Then
                m_txthold02 = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The txtHold03 column is in the DB
    ''' </summary>
    Public Property txtHold03() As String
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            If String.IsNullOrEmpty(m_txthold03) Then
                Return String.Empty
            Else
                Return m_txthold03
            End If
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value As String)
            If value Is Nothing Then
                value = String.Empty
            End If
            If m_txthold03 <> value Then
                m_txthold03 = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The txtHold04 column is in the DB
    ''' </summary>
    Public Property txtHold04() As String
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            If String.IsNullOrEmpty(m_txthold04) Then
                Return String.Empty
            Else
                Return m_txthold04
            End If
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value As String)
            If value Is Nothing Then
                value = String.Empty
            End If
            If m_txthold04 <> value Then
                m_txthold04 = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The txtHold05 column is in the DB
    ''' </summary>
    Public Property txtHold05() As String
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            If String.IsNullOrEmpty(m_txthold05) Then
                Return String.Empty
            Else
                Return m_txthold05
            End If
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value As String)
            If value Is Nothing Then
                value = String.Empty
            End If
            If m_txthold05 <> value Then
                m_txthold05 = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The txtHold06 column is in the DB
    ''' </summary>
    Public Property txtHold06() As String
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            If String.IsNullOrEmpty(m_txthold06) Then
                Return String.Empty
            Else
                Return m_txthold06
            End If
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value As String)
            If value Is Nothing Then
                value = String.Empty
            End If
            If m_txthold06 <> value Then
                m_txthold06 = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The txtHold07 column is in the DB
    ''' </summary>
    Public Property txtHold07() As String
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            If String.IsNullOrEmpty(m_txthold07) Then
                Return String.Empty
            Else
                Return m_txthold07
            End If
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value As String)
            If value Is Nothing Then
                value = String.Empty
            End If
            If m_txthold07 <> value Then
                m_txthold07 = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The txtHold08 column is in the DB
    ''' </summary>
    Public Property txtHold08() As String
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            If String.IsNullOrEmpty(m_txthold08) Then
                Return String.Empty
            Else
                Return m_txthold08
            End If
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value As String)
            If value Is Nothing Then
                value = String.Empty
            End If
            If m_txthold08 <> value Then
                m_txthold08 = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The txtHold09 column is in the DB
    ''' </summary>
    Public Property txtHold09() As String
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            If String.IsNullOrEmpty(m_txthold09) Then
                Return String.Empty
            Else
                Return m_txthold09
            End If
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value As String)
            If value Is Nothing Then
                value = String.Empty
            End If
            If m_txthold09 <> value Then
                m_txthold09 = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The txtHold10 column is in the DB
    ''' </summary>
    Public Property txtHold10() As String
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            If String.IsNullOrEmpty(m_txthold10) Then
                Return String.Empty
            Else
                Return m_txthold10
            End If
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value As String)
            If value Is Nothing Then
                value = String.Empty
            End If
            If m_txthold10 <> value Then
                m_txthold10 = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The decHold01 column is in the DB
    ''' </summary>
    Public Property decHold01() As Double?
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            Return m_dechold01
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value? As Double)
            If Not m_dechold01.Equals(value) Then
                m_dechold01 = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The decHold02 column is in the DB
    ''' </summary>
    Public Property decHold02() As Double?
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            Return m_dechold02
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value? As Double)
            If Not m_dechold02.Equals(value) Then
                m_dechold02 = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The decHold03 column is in the DB
    ''' </summary>
    Public Property decHold03() As Double?
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            Return m_dechold03
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value? As Double)
            If Not m_dechold03.Equals(value) Then
                m_dechold03 = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The decHold04 column is in the DB
    ''' </summary>
    Public Property decHold04() As Double?
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            Return m_dechold04
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value? As Double)
            If Not m_dechold04.Equals(value) Then
                m_dechold04 = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The decHold05 column is in the DB
    ''' </summary>
    Public Property decHold05() As Double?
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            Return m_dechold05
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value? As Double)
            If Not m_dechold05.Equals(value) Then
                m_dechold05 = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The intHold01 column is in the DB
    ''' </summary>
    Public Property intHold01() As Int32?
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            Return m_inthold01
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value? As Int32)
            If Not m_inthold01.Equals(value) Then
                m_inthold01 = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The intHold02 column is in the DB
    ''' </summary>
    Public Property intHold02() As Int32?
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            Return m_inthold02
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value? As Int32)
            If Not m_inthold02.Equals(value) Then
                m_inthold02 = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The intHold03 column is in the DB
    ''' </summary>
    Public Property intHold03() As Int32?
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            Return m_inthold03
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value? As Int32)
            If Not m_inthold03.Equals(value) Then
                m_inthold03 = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The intHold04 column is in the DB
    ''' </summary>
    Public Property intHold04() As Int32?
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            Return m_inthold04
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value? As Int32)
            If Not m_inthold04.Equals(value) Then
                m_inthold04 = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The intHold05 column is in the DB
    ''' </summary>
    Public Property intHold05() As Int32?
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            Return m_inthold05
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value? As Int32)
            If Not m_inthold05.Equals(value) Then
                m_inthold05 = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The dteHold01 column is in the DB
    ''' </summary>
    Public Property dteHold01() As Date?
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            Return m_dtehold01
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value? As Date)
            If Not m_dtehold01.Equals(value) Then
                m_dtehold01 = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The dteHold02 column is in the DB
    ''' </summary>
    Public Property dteHold02() As Date?
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            Return m_dtehold02
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value? As Date)
            If Not m_dtehold02.Equals(value) Then
                m_dtehold02 = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The dteHold03 column is in the DB
    ''' </summary>
    Public Property dteHold03() As Date?
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            Return m_dtehold03
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value? As Date)
            If Not m_dtehold03.Equals(value) Then
                m_dtehold03 = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The dteHold04 column is in the DB
    ''' </summary>
    Public Property dteHold04() As Date?
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            Return m_dtehold04
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value? As Date)
            If Not m_dtehold04.Equals(value) Then
                m_dtehold04 = value
            End If
        End Set
    End Property

    ''' <summary>
    ''' The dteHold05 column is in the DB
    ''' </summary>
    Public Property dteHold05() As Date?
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Get
            Return m_dtehold05
        End Get
        <System.Runtime.CompilerServices.MethodImpl(System.Runtime.CompilerServices.MethodImplOptions.NoInlining)>
        Set(ByVal value? As Date)
            If Not m_dtehold05.Equals(value) Then
                m_dtehold05 = value
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
        m_lblcontactinformation = String.Empty
        m_ixtcode = String.Empty
        m_txtdescription = String.Empty
        m_txtprovideridentificationnumber = String.Empty
        m_intrecordid_document_picture = Nothing
        m_intrecordid_account = Nothing
        m_intrecordid_contactsalutation = Nothing
        m_txtfirstname = String.Empty
        m_txtmiddlename = String.Empty
        m_txtmiddleinitial = String.Empty
        m_txtlastname = String.Empty
        m_txtbesttime = String.Empty
        m_txtsuffix = String.Empty
        m_txtcompanyname = String.Empty
        m_txtdba = String.Empty
        m_intrecordid_contacttitle = Nothing
        m_txtaddress1 = String.Empty
        m_txtaddress2 = String.Empty
        m_txtaddress3 = String.Empty
        m_txtcity = String.Empty
        m_intrecordid_state = Nothing
        m_txtpostalcode = String.Empty
        m_intrecordid_county = Nothing
        m_intrecordid_country = Nothing
        m_lblcontactaccessinformation = String.Empty
        m_txtskypeid = String.Empty
        m_txtphonenumberoffice = String.Empty
        m_txtphonenumbermobile = String.Empty
        m_intrecordid_mailsmscarriers = Nothing
        m_txtphonenumberhome = String.Empty
        m_txtfaxnumber = String.Empty
        m_txtpager = String.Empty
        m_txtemailaddress = String.Empty
        m_blnmailreturned = Constants.DEFAULT_VALUE_NO
        m_txtwebsitetitle = String.Empty
        m_lblcontactpersonalinformation = String.Empty
        m_dtedateofbirth = Nothing
        m_clccontactage = Nothing
        m_txtdriverslicense = String.Empty
        m_txtssn = String.Empty
        m_txtemergencycontactname = String.Empty
        m_txtemergencycontactphone = String.Empty
        m_lblcontactpreferences = String.Empty
        m_txtbillingday = String.Empty
        m_blnbackorder = Constants.DEFAULT_VALUE_NO
        m_blnproductcatalog = Constants.DEFAULT_VALUE_NO
        m_blnconfirmsalesorder = Constants.DEFAULT_VALUE_NO
        m_blnprintpricelist = Constants.DEFAULT_VALUE_NO
        m_blnsubscribetonewsletter = Constants.DEFAULT_VALUE_NO
        m_lblcontactdetails = String.Empty
        m_intrecordid_campaign = Nothing
        m_intrecordid_contactcategory = Nothing
        m_intrecordid_industry = Nothing
        m_intrecordid_region = Nothing
        m_intrecordid_contactstatus = Nothing
        m_intrecordid_contactprocessstatus = Nothing
        m_lblcontactbillingandshippinginformation = String.Empty
        m_intrecordid_contactbillto = Nothing
        m_intrecordid_contactshipto = Nothing
        m_intrecordid_shipmethod = Nothing
        m_intrecordid_contact_shipvia = Nothing
        m_txtfob = String.Empty
        m_lblcontactmanagementdetails = String.Empty
        m_intrecordid_contact_salesrep = Nothing
        m_intrecordid_marketingsource = Nothing
        m_blninspectionrequired = Constants.DEFAULT_VALUE_NO
        m_lblcontactwebaccessinformation = String.Empty
        m_lbmuserinformation = String.Empty
        m_txtusername = String.Empty
        m_txtpassword = String.Empty
        m_txtsecretquestionanswer = String.Empty
        m_intrecordid_secretquestion = Nothing
        m_dtepasswordexpiration = Nothing
        m_blnpasswordautoexpire = Constants.DEFAULT_VALUE_NO
        m_intpasswordexpireintervalday = Nothing
        m_intfailedloginattempt = Nothing
        m_txtuserregistrationkey = String.Empty
        m_lblcontactsurveyinformation = String.Empty
        m_intrecordid_surveyusertype = Nothing
        m_intrecordid_surveylogintype = Nothing
        m_txtsurveyusernetworkdomain = String.Empty
        m_lblcontacthrinformation = String.Empty
        m_txtaccountglreferencecode = String.Empty
        m_txtothernamesused = String.Empty
        m_intrecordid_contact_union = Nothing
        m_intrecordid_hremployeeuniontype = Nothing
        m_intrecordid_hremployeestatus = Nothing
        m_lbmworkcentermustbeassignedforcorrectlaborreporting = String.Empty
        m_intrecordid_workcenter = Nothing
        m_intrecordid_hrshift = Nothing
        m_intrecordid_language = Nothing
        m_lbmdiversityinformation = String.Empty
        m_intrecordid_hrethnicorigin = Nothing
        m_intrecordid_hrgender = Nothing
        m_intrecordid_hremployeepaycheckdeliverymethod = Nothing
        m_intrecordid_hrmilitaryservice = Nothing
        m_intrecordid_contact_supervisor = Nothing
        m_lblcontactextendedhrinformation = String.Empty
        m_intrecordid_contacthrinformation = Nothing
        m_lblmemberothermedicalinsurance = String.Empty
        m_blnmedicare = Constants.DEFAULT_VALUE_NO
        m_blncob = Constants.DEFAULT_VALUE_NO
        m_dtecobletterreceiveddate = Nothing
        m_lblmemberbenefitplaninformation = String.Empty
        m_dtertwdate = Nothing
        m_dteterminationdate = Nothing
        m_intrecordid_hrbenefitplanemployeecontribution = Nothing
        m_dtedatestart = Nothing
        m_dteeffectivestartdate = Nothing
        m_dtefulltimepromotiondate = Nothing
        m_dtefulltimeeffectivedate = Nothing
        m_dteparttimedemotiondate = Nothing
        m_dteparttimeeffectivedate = Nothing
        m_dteretirementdate = Nothing
        m_intrecordid_hrbenefitcoverageterminationreason = Nothing
        m_blnreportmemberassubscriber = Constants.DEFAULT_VALUE_NO
        m_lblcustomerinformation = String.Empty
        m_intrecordid_contactcustomerinformation = Nothing
        m_lblbenefitinformation = String.Empty
        m_intrecordid_contactbenefitinformation = Nothing
        m_lblcontactcreditinformation = String.Empty
        m_intrecordid_contactcreditinformation = Nothing
        m_lblcontactpromotioninformation = String.Empty
        m_inttargetgp = Nothing
        m_blnqualifiesforrebate = Constants.DEFAULT_VALUE_NO
        m_blnproductpromotion = Constants.DEFAULT_VALUE_NO
        m_intrecordid_contactdiscount = Nothing
        m_intrecordid_contact_buyinggroup = Nothing
        m_dtebuyinggroupstartdate = Nothing
        m_decrebatepercent = Nothing
        m_lblcontactaccountinginformation = String.Empty
        m_intrecordid_glchart_apexpense = Nothing
        m_intrecordid_glchartdivision_apexpense = Nothing
        m_intrecordid_glchartdepartment_apexpense = Nothing
        m_clcpremiumcost = Nothing
        m_clcpremiummemberprice = Nothing
        m_clcemployercontribution = Nothing
        m_clcemployeededuction = Nothing
        m_lblcontactrecordinformation = String.Empty
        m_blnmakeprivate = Constants.DEFAULT_VALUE_NO
        m_blnactive = Constants.DEFAULT_VALUE_NO
        m_txtrecordcreationuser = My.Application.Info.AssemblyName
        m_dterecordcreationdate = Date.Now
        m_dterecordupdatedate = Nothing
        m_blncursor = Constants.DEFAULT_VALUE_NO
        m_txtjobseekerid = String.Empty
        m_txtsearchproviderresumeid = String.Empty
        m_intrecordid = Int32.MinValue
        m_txtguid = Guid.NewGuid()
        m_txtemployeessn = String.Empty
        m_intrecordid_company = Constants.DEFAULT_VALUE_INTRECORDID_COMPANY
        m_intrecordid_division = Constants.DEFAULT_VALUE_INTRECORDID_DIVISION
        m_intrecordid_company_ecommerce = Nothing
        m_intrecordid_division_ecommerce = Nothing
        m_intrecordid_databaseid_ecommerce = Nothing
        m_intrecordid_user_ecommerce = Nothing
        m_txttablename_ecommerce = String.Empty
        m_intrecordidtable_ecommerce = Nothing
        m_intrecordid_marketingsalessize = Nothing
        m_intrecordid_apfinancecharge = Nothing
        m_intrecordid_arfinancecharge = Nothing
        m_blnpayroll = Constants.DEFAULT_VALUE_NO
        m_intrecordid_contactcommerce = Nothing
        m_intrecordid_contact_customerservicerep = Nothing
        m_blnreceiveinspectionrequired = Constants.DEFAULT_VALUE_NO
        m_blnpayhold = Constants.DEFAULT_VALUE_NO
        m_intrecordid_currency = Nothing
        m_intrecordid_shiproute = Nothing
        m_intrecordid_contactpricingmethod = Nothing
        m_intrecordid_productpricelist = Nothing
        m_intrecordid_hrcontactsecurityclearance = Nothing
        m_intrecordid_user_creation = Nothing
        m_blnmemo = Constants.DEFAULT_VALUE_NO
        m_blnattachment = Constants.DEFAULT_VALUE_NO
        m_blndeleted = Constants.DEFAULT_VALUE_NO
        m_blnhighlight = Constants.DEFAULT_VALUE_NO
        m_blnprocess = Constants.DEFAULT_VALUE_NO
        m_blnproject = Constants.DEFAULT_VALUE_NO
        m_txthold01 = String.Empty
        m_txthold02 = String.Empty
        m_txthold03 = String.Empty
        m_txthold04 = String.Empty
        m_txthold05 = String.Empty
        m_txthold06 = String.Empty
        m_txthold07 = String.Empty
        m_txthold08 = String.Empty
        m_txthold09 = String.Empty
        m_txthold10 = String.Empty
        m_dechold01 = Nothing
        m_dechold02 = Nothing
        m_dechold03 = Nothing
        m_dechold04 = Nothing
        m_dechold05 = Nothing
        m_inthold01 = Nothing
        m_inthold02 = Nothing
        m_inthold03 = Nothing
        m_inthold04 = Nothing
        m_inthold05 = Nothing
        m_dtehold01 = Nothing
        m_dtehold02 = Nothing
        m_dtehold03 = Nothing
        m_dtehold04 = Nothing
        m_dtehold05 = Nothing
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
        m_lblcalendarreminder = String.Empty
        m_dtefollowupdate = Nothing
        m_txteventstarttime = String.Empty
        m_txteventendtime = String.Empty
        m_blnfavorite = Constants.DEFAULT_VALUE_NO
    End Sub

#End Region

#Region "Methods"

    Public Sub Load(ByVal sdr As OleDbDataReader)
        If Not System.Convert.IsDBNull(sdr("intRecordID_DatabaseID")) Then
            m_intrecordid_databaseid = sdr.GetInt32(sdr.GetOrdinal("intRecordID_DatabaseID"))
        End If
        If Not System.Convert.IsDBNull(sdr("lblContactInformation")) Then
            m_lblcontactinformation = sdr.GetString(sdr.GetOrdinal("lblContactInformation"))
        End If
        If Not System.Convert.IsDBNull(sdr("ixtCode")) Then
            m_ixtcode = sdr.GetString(sdr.GetOrdinal("ixtCode"))
        End If
        If Not System.Convert.IsDBNull(sdr("txtDescription")) Then
            m_txtdescription = sdr.GetString(sdr.GetOrdinal("txtDescription"))
        End If
        If Not System.Convert.IsDBNull(sdr("txtProviderIdentificationNumber")) Then
            m_txtprovideridentificationnumber = sdr.GetString(sdr.GetOrdinal("txtProviderIdentificationNumber"))
        End If
        If Not System.Convert.IsDBNull(sdr("intRecordID_Document_Picture")) Then
            m_intrecordid_document_picture = sdr.GetInt32(sdr.GetOrdinal("intRecordID_Document_Picture"))
        End If
        If Not System.Convert.IsDBNull(sdr("intRecordID_Account")) Then
            m_intrecordid_account = sdr.GetInt32(sdr.GetOrdinal("intRecordID_Account"))
        End If
        If Not System.Convert.IsDBNull(sdr("intRecordID_ContactSalutation")) Then
            m_intrecordid_contactsalutation = sdr.GetInt32(sdr.GetOrdinal("intRecordID_ContactSalutation"))
        End If
        If Not System.Convert.IsDBNull(sdr("txtFirstName")) Then
            m_txtfirstname = sdr.GetString(sdr.GetOrdinal("txtFirstName"))
        End If
        If Not System.Convert.IsDBNull(sdr("txtMiddleName")) Then
            m_txtmiddlename = sdr.GetString(sdr.GetOrdinal("txtMiddleName"))
        End If
        If Not System.Convert.IsDBNull(sdr("txtMiddleInitial")) Then
            m_txtmiddleinitial = sdr.GetString(sdr.GetOrdinal("txtMiddleInitial"))
        End If
        If Not System.Convert.IsDBNull(sdr("txtLastName")) Then
            m_txtlastname = sdr.GetString(sdr.GetOrdinal("txtLastName"))
        End If
        If Not System.Convert.IsDBNull(sdr("txtBestTime")) Then
            m_txtbesttime = sdr.GetString(sdr.GetOrdinal("txtBestTime"))
        End If
        If Not System.Convert.IsDBNull(sdr("txtSuffix")) Then
            m_txtsuffix = sdr.GetString(sdr.GetOrdinal("txtSuffix"))
        End If
        If Not System.Convert.IsDBNull(sdr("txtCompanyName")) Then
            m_txtcompanyname = sdr.GetString(sdr.GetOrdinal("txtCompanyName"))
        End If
        If Not System.Convert.IsDBNull(sdr("txtDBA")) Then
            m_txtdba = sdr.GetString(sdr.GetOrdinal("txtDBA"))
        End If
        If Not System.Convert.IsDBNull(sdr("intRecordID_ContactTitle")) Then
            m_intrecordid_contacttitle = sdr.GetInt32(sdr.GetOrdinal("intRecordID_ContactTitle"))
        End If
        If Not System.Convert.IsDBNull(sdr("txtAddress1")) Then
            m_txtaddress1 = sdr.GetString(sdr.GetOrdinal("txtAddress1"))
        End If
        If Not System.Convert.IsDBNull(sdr("txtAddress2")) Then
            m_txtaddress2 = sdr.GetString(sdr.GetOrdinal("txtAddress2"))
        End If
        If Not System.Convert.IsDBNull(sdr("txtAddress3")) Then
            m_txtaddress3 = sdr.GetString(sdr.GetOrdinal("txtAddress3"))
        End If
        If Not System.Convert.IsDBNull(sdr("txtCity")) Then
            m_txtcity = sdr.GetString(sdr.GetOrdinal("txtCity"))
        End If
        If Not System.Convert.IsDBNull(sdr("intRecordID_State")) Then
            m_intrecordid_state = sdr.GetInt32(sdr.GetOrdinal("intRecordID_State"))
        End If
        If Not System.Convert.IsDBNull(sdr("txtPostalCode")) Then
            m_txtpostalcode = sdr.GetString(sdr.GetOrdinal("txtPostalCode"))
        End If
        If Not System.Convert.IsDBNull(sdr("intRecordID_County")) Then
            m_intrecordid_county = sdr.GetInt32(sdr.GetOrdinal("intRecordID_County"))
        End If
        If Not System.Convert.IsDBNull(sdr("intRecordID_Country")) Then
            m_intrecordid_country = sdr.GetInt32(sdr.GetOrdinal("intRecordID_Country"))
        End If
        If Not System.Convert.IsDBNull(sdr("lblContactAccessInformation")) Then
            m_lblcontactaccessinformation = sdr.GetString(sdr.GetOrdinal("lblContactAccessInformation"))
        End If
        If Not System.Convert.IsDBNull(sdr("txtSkypeID")) Then
            m_txtskypeid = sdr.GetString(sdr.GetOrdinal("txtSkypeID"))
        End If
        If Not System.Convert.IsDBNull(sdr("txtPhoneNumberOffice")) Then
            m_txtphonenumberoffice = sdr.GetString(sdr.GetOrdinal("txtPhoneNumberOffice"))
        End If
        If Not System.Convert.IsDBNull(sdr("txtPhoneNumberMobile")) Then
            m_txtphonenumbermobile = sdr.GetString(sdr.GetOrdinal("txtPhoneNumberMobile"))
        End If
        If Not System.Convert.IsDBNull(sdr("intRecordID_MailSMSCarriers")) Then
            m_intrecordid_mailsmscarriers = sdr.GetInt32(sdr.GetOrdinal("intRecordID_MailSMSCarriers"))
        End If
        If Not System.Convert.IsDBNull(sdr("txtPhoneNumberHome")) Then
            m_txtphonenumberhome = sdr.GetString(sdr.GetOrdinal("txtPhoneNumberHome"))
        End If
        If Not System.Convert.IsDBNull(sdr("txtFaxNumber")) Then
            m_txtfaxnumber = sdr.GetString(sdr.GetOrdinal("txtFaxNumber"))
        End If
        If Not System.Convert.IsDBNull(sdr("txtPager")) Then
            m_txtpager = sdr.GetString(sdr.GetOrdinal("txtPager"))
        End If
        If Not System.Convert.IsDBNull(sdr("txtEmailAddress")) Then
            m_txtemailaddress = sdr.GetString(sdr.GetOrdinal("txtEmailAddress"))
        End If
        If Not System.Convert.IsDBNull(sdr("blnMailReturned")) Then
            m_blnmailreturned = sdr.GetString(sdr.GetOrdinal("blnMailReturned"))
        End If
        If Not System.Convert.IsDBNull(sdr("txtWebsiteTitle")) Then
            m_txtwebsitetitle = sdr.GetString(sdr.GetOrdinal("txtWebsiteTitle"))
        End If
        If Not System.Convert.IsDBNull(sdr("lblContactPersonalInformation")) Then
            m_lblcontactpersonalinformation = sdr.GetString(sdr.GetOrdinal("lblContactPersonalInformation"))
        End If
        If Not System.Convert.IsDBNull(sdr("dteDateOfBirth")) Then
            m_dtedateofbirth = sdr.GetDateTime(sdr.GetOrdinal("dteDateOfBirth"))
        End If
        If Not System.Convert.IsDBNull(sdr("clcContactAge")) Then
            m_clccontactage = sdr.GetDouble(sdr.GetOrdinal("clcContactAge"))
        End If
        If Not System.Convert.IsDBNull(sdr("txtDriversLicense")) Then
            m_txtdriverslicense = sdr.GetString(sdr.GetOrdinal("txtDriversLicense"))
        End If
        If Not System.Convert.IsDBNull(sdr("txtSSN")) Then
            m_txtssn = sdr.GetString(sdr.GetOrdinal("txtSSN"))
        End If
        If Not System.Convert.IsDBNull(sdr("txtEmergencyContactName")) Then
            m_txtemergencycontactname = sdr.GetString(sdr.GetOrdinal("txtEmergencyContactName"))
        End If
        If Not System.Convert.IsDBNull(sdr("txtEmergencyContactPhone")) Then
            m_txtemergencycontactphone = sdr.GetString(sdr.GetOrdinal("txtEmergencyContactPhone"))
        End If
        If Not System.Convert.IsDBNull(sdr("lblContactPreferences")) Then
            m_lblcontactpreferences = sdr.GetString(sdr.GetOrdinal("lblContactPreferences"))
        End If
        If Not System.Convert.IsDBNull(sdr("txtBillingDay")) Then
            m_txtbillingday = sdr.GetString(sdr.GetOrdinal("txtBillingDay"))
        End If
        If Not System.Convert.IsDBNull(sdr("blnBackOrder")) Then
            m_blnbackorder = sdr.GetString(sdr.GetOrdinal("blnBackOrder"))
        End If
        If Not System.Convert.IsDBNull(sdr("blnProductCatalog")) Then
            m_blnproductcatalog = sdr.GetString(sdr.GetOrdinal("blnProductCatalog"))
        End If
        If Not System.Convert.IsDBNull(sdr("blnConfirmSalesOrder")) Then
            m_blnconfirmsalesorder = sdr.GetString(sdr.GetOrdinal("blnConfirmSalesOrder"))
        End If
        If Not System.Convert.IsDBNull(sdr("blnPrintPriceList")) Then
            m_blnprintpricelist = sdr.GetString(sdr.GetOrdinal("blnPrintPriceList"))
        End If
        If Not System.Convert.IsDBNull(sdr("blnSubscribeToNewsletter")) Then
            m_blnsubscribetonewsletter = sdr.GetString(sdr.GetOrdinal("blnSubscribeToNewsletter"))
        End If
        If Not System.Convert.IsDBNull(sdr("lblContactDetails")) Then
            m_lblcontactdetails = sdr.GetString(sdr.GetOrdinal("lblContactDetails"))
        End If
        If Not System.Convert.IsDBNull(sdr("intRecordID_Campaign")) Then
            m_intrecordid_campaign = sdr.GetInt32(sdr.GetOrdinal("intRecordID_Campaign"))
        End If
        If Not System.Convert.IsDBNull(sdr("intRecordID_ContactCategory")) Then
            m_intrecordid_contactcategory = sdr.GetInt32(sdr.GetOrdinal("intRecordID_ContactCategory"))
        End If
        If Not System.Convert.IsDBNull(sdr("intRecordID_Industry")) Then
            m_intrecordid_industry = sdr.GetInt32(sdr.GetOrdinal("intRecordID_Industry"))
        End If
        If Not System.Convert.IsDBNull(sdr("intRecordID_Region")) Then
            m_intrecordid_region = sdr.GetInt32(sdr.GetOrdinal("intRecordID_Region"))
        End If
        If Not System.Convert.IsDBNull(sdr("intRecordID_ContactStatus")) Then
            m_intrecordid_contactstatus = sdr.GetInt32(sdr.GetOrdinal("intRecordID_ContactStatus"))
        End If
        If Not System.Convert.IsDBNull(sdr("intRecordID_ContactProcessStatus")) Then
            m_intrecordid_contactprocessstatus = sdr.GetInt32(sdr.GetOrdinal("intRecordID_ContactProcessStatus"))
        End If
        If Not System.Convert.IsDBNull(sdr("lblContactBillingAndShippingInformation")) Then
            m_lblcontactbillingandshippinginformation = sdr.GetString(sdr.GetOrdinal("lblContactBillingAndShippingInformation"))
        End If
        If Not System.Convert.IsDBNull(sdr("intRecordID_ContactBillTo")) Then
            m_intrecordid_contactbillto = sdr.GetInt32(sdr.GetOrdinal("intRecordID_ContactBillTo"))
        End If
        If Not System.Convert.IsDBNull(sdr("intRecordID_ContactShipTo")) Then
            m_intrecordid_contactshipto = sdr.GetInt32(sdr.GetOrdinal("intRecordID_ContactShipTo"))
        End If
        If Not System.Convert.IsDBNull(sdr("intRecordID_ShipMethod")) Then
            m_intrecordid_shipmethod = sdr.GetInt32(sdr.GetOrdinal("intRecordID_ShipMethod"))
        End If
        If Not System.Convert.IsDBNull(sdr("intRecordID_Contact_ShipVia")) Then
            m_intrecordid_contact_shipvia = sdr.GetInt32(sdr.GetOrdinal("intRecordID_Contact_ShipVia"))
        End If
        If Not System.Convert.IsDBNull(sdr("txtFOB")) Then
            m_txtfob = sdr.GetString(sdr.GetOrdinal("txtFOB"))
        End If
        If Not System.Convert.IsDBNull(sdr("lblContactManagementDetails")) Then
            m_lblcontactmanagementdetails = sdr.GetString(sdr.GetOrdinal("lblContactManagementDetails"))
        End If
        If Not System.Convert.IsDBNull(sdr("intRecordID_Contact_SalesRep")) Then
            m_intrecordid_contact_salesrep = sdr.GetInt32(sdr.GetOrdinal("intRecordID_Contact_SalesRep"))
        End If
        If Not System.Convert.IsDBNull(sdr("intRecordID_MarketingSource")) Then
            m_intrecordid_marketingsource = sdr.GetInt32(sdr.GetOrdinal("intRecordID_MarketingSource"))
        End If
        If Not System.Convert.IsDBNull(sdr("blnInspectionRequired")) Then
            m_blninspectionrequired = sdr.GetString(sdr.GetOrdinal("blnInspectionRequired"))
        End If
        If Not System.Convert.IsDBNull(sdr("lblContactWebAccessInformation")) Then
            m_lblcontactwebaccessinformation = sdr.GetString(sdr.GetOrdinal("lblContactWebAccessInformation"))
        End If
        If Not System.Convert.IsDBNull(sdr("lbmUserInformation")) Then
            m_lbmuserinformation = sdr.GetString(sdr.GetOrdinal("lbmUserInformation"))
        End If
        If Not System.Convert.IsDBNull(sdr("txtUserName")) Then
            m_txtusername = sdr.GetString(sdr.GetOrdinal("txtUserName"))
        End If
        If Not System.Convert.IsDBNull(sdr("txtPassword")) Then
            m_txtpassword = sdr.GetString(sdr.GetOrdinal("txtPassword"))
        End If
        If Not System.Convert.IsDBNull(sdr("txtSecretQuestionAnswer")) Then
            m_txtsecretquestionanswer = sdr.GetString(sdr.GetOrdinal("txtSecretQuestionAnswer"))
        End If
        If Not System.Convert.IsDBNull(sdr("intRecordID_SecretQuestion")) Then
            m_intrecordid_secretquestion = sdr.GetInt32(sdr.GetOrdinal("intRecordID_SecretQuestion"))
        End If
        If Not System.Convert.IsDBNull(sdr("dtePasswordExpiration")) Then
            m_dtepasswordexpiration = sdr.GetDateTime(sdr.GetOrdinal("dtePasswordExpiration"))
        End If
        If Not System.Convert.IsDBNull(sdr("blnPasswordAutoExpire")) Then
            m_blnpasswordautoexpire = sdr.GetString(sdr.GetOrdinal("blnPasswordAutoExpire"))
        End If
        If Not System.Convert.IsDBNull(sdr("intPasswordExpireIntervalDay")) Then
            m_intpasswordexpireintervalday = sdr.GetInt32(sdr.GetOrdinal("intPasswordExpireIntervalDay"))
        End If
        If Not System.Convert.IsDBNull(sdr("intFailedLoginAttempt")) Then
            m_intfailedloginattempt = sdr.GetInt32(sdr.GetOrdinal("intFailedLoginAttempt"))
        End If
        If Not System.Convert.IsDBNull(sdr("txtUserRegistrationKey")) Then
            m_txtuserregistrationkey = sdr.GetString(sdr.GetOrdinal("txtUserRegistrationKey"))
        End If
        If Not System.Convert.IsDBNull(sdr("lblContactSurveyInformation")) Then
            m_lblcontactsurveyinformation = sdr.GetString(sdr.GetOrdinal("lblContactSurveyInformation"))
        End If
        If Not System.Convert.IsDBNull(sdr("intRecordID_SurveyUserType")) Then
            m_intrecordid_surveyusertype = sdr.GetInt32(sdr.GetOrdinal("intRecordID_SurveyUserType"))
        End If
        If Not System.Convert.IsDBNull(sdr("intRecordID_SurveyLoginType")) Then
            m_intrecordid_surveylogintype = sdr.GetInt32(sdr.GetOrdinal("intRecordID_SurveyLoginType"))
        End If
        If Not System.Convert.IsDBNull(sdr("txtSurveyUserNetworkDomain")) Then
            m_txtsurveyusernetworkdomain = sdr.GetString(sdr.GetOrdinal("txtSurveyUserNetworkDomain"))
        End If
        If Not System.Convert.IsDBNull(sdr("lblContactHRInformation")) Then
            m_lblcontacthrinformation = sdr.GetString(sdr.GetOrdinal("lblContactHRInformation"))
        End If
        If Not System.Convert.IsDBNull(sdr("txtAccountGLReferenceCode")) Then
            m_txtaccountglreferencecode = sdr.GetString(sdr.GetOrdinal("txtAccountGLReferenceCode"))
        End If
        If Not System.Convert.IsDBNull(sdr("txtOtherNamesUsed")) Then
            m_txtothernamesused = sdr.GetString(sdr.GetOrdinal("txtOtherNamesUsed"))
        End If
        If Not System.Convert.IsDBNull(sdr("intRecordID_Contact_Union")) Then
            m_intrecordid_contact_union = sdr.GetInt32(sdr.GetOrdinal("intRecordID_Contact_Union"))
        End If
        If Not System.Convert.IsDBNull(sdr("intRecordID_HREmployeeUnionType")) Then
            m_intrecordid_hremployeeuniontype = sdr.GetInt32(sdr.GetOrdinal("intRecordID_HREmployeeUnionType"))
        End If
        If Not System.Convert.IsDBNull(sdr("intRecordID_HREmployeeStatus")) Then
            m_intrecordid_hremployeestatus = sdr.GetInt32(sdr.GetOrdinal("intRecordID_HREmployeeStatus"))
        End If
        If Not System.Convert.IsDBNull(sdr("lbmWorkCenterMustBeAssignedForCorrectLaborReporting")) Then
            m_lbmworkcentermustbeassignedforcorrectlaborreporting = sdr.GetString(sdr.GetOrdinal("lbmWorkCenterMustBeAssignedForCorrectLaborReporting"))
        End If
        If Not System.Convert.IsDBNull(sdr("intRecordID_WorkCenter")) Then
            m_intrecordid_workcenter = sdr.GetInt32(sdr.GetOrdinal("intRecordID_WorkCenter"))
        End If
        If Not System.Convert.IsDBNull(sdr("intRecordID_HRShift")) Then
            m_intrecordid_hrshift = sdr.GetInt32(sdr.GetOrdinal("intRecordID_HRShift"))
        End If
        If Not System.Convert.IsDBNull(sdr("intRecordID_Language")) Then
            m_intrecordid_language = sdr.GetInt32(sdr.GetOrdinal("intRecordID_Language"))
        End If
        If Not System.Convert.IsDBNull(sdr("lbmDiversityInformation")) Then
            m_lbmdiversityinformation = sdr.GetString(sdr.GetOrdinal("lbmDiversityInformation"))
        End If
        If Not System.Convert.IsDBNull(sdr("intRecordID_HREthnicOrigin")) Then
            m_intrecordid_hrethnicorigin = sdr.GetInt32(sdr.GetOrdinal("intRecordID_HREthnicOrigin"))
        End If
        If Not System.Convert.IsDBNull(sdr("intRecordID_HRGender")) Then
            m_intrecordid_hrgender = sdr.GetInt32(sdr.GetOrdinal("intRecordID_HRGender"))
        End If
        If Not System.Convert.IsDBNull(sdr("intRecordID_HREmployeePayCheckDeliveryMethod")) Then
            m_intrecordid_hremployeepaycheckdeliverymethod = sdr.GetInt32(sdr.GetOrdinal("intRecordID_HREmployeePayCheckDeliveryMethod"))
        End If
        If Not System.Convert.IsDBNull(sdr("intRecordID_HRMilitaryService")) Then
            m_intrecordid_hrmilitaryservice = sdr.GetInt32(sdr.GetOrdinal("intRecordID_HRMilitaryService"))
        End If
        If Not System.Convert.IsDBNull(sdr("intRecordID_Contact_Supervisor")) Then
            m_intrecordid_contact_supervisor = sdr.GetInt32(sdr.GetOrdinal("intRecordID_Contact_Supervisor"))
        End If
        If Not System.Convert.IsDBNull(sdr("lblContactExtendedHRInformation")) Then
            m_lblcontactextendedhrinformation = sdr.GetString(sdr.GetOrdinal("lblContactExtendedHRInformation"))
        End If
        If Not System.Convert.IsDBNull(sdr("intRecordID_ContactHRInformation")) Then
            m_intrecordid_contacthrinformation = sdr.GetInt32(sdr.GetOrdinal("intRecordID_ContactHRInformation"))
        End If
        If Not System.Convert.IsDBNull(sdr("lblMemberOtherMedicalInsurance")) Then
            m_lblmemberothermedicalinsurance = sdr.GetString(sdr.GetOrdinal("lblMemberOtherMedicalInsurance"))
        End If
        If Not System.Convert.IsDBNull(sdr("blnMedicare")) Then
            m_blnmedicare = sdr.GetString(sdr.GetOrdinal("blnMedicare"))
        End If
        If Not System.Convert.IsDBNull(sdr("blnCOB")) Then
            m_blncob = sdr.GetString(sdr.GetOrdinal("blnCOB"))
        End If
        If Not System.Convert.IsDBNull(sdr("dteCOBLetterReceivedDate")) Then
            m_dtecobletterreceiveddate = sdr.GetDateTime(sdr.GetOrdinal("dteCOBLetterReceivedDate"))
        End If
        If Not System.Convert.IsDBNull(sdr("lblMemberBenefitPlanInformation")) Then
            m_lblmemberbenefitplaninformation = sdr.GetString(sdr.GetOrdinal("lblMemberBenefitPlanInformation"))
        End If
        If Not System.Convert.IsDBNull(sdr("dteRTWDate")) Then
            m_dtertwdate = sdr.GetDateTime(sdr.GetOrdinal("dteRTWDate"))
        End If
        If Not System.Convert.IsDBNull(sdr("dteTerminationDate")) Then
            m_dteterminationdate = sdr.GetDateTime(sdr.GetOrdinal("dteTerminationDate"))
        End If
        If Not System.Convert.IsDBNull(sdr("intRecordID_HRBenefitPlanEmployeeContribution")) Then
            m_intrecordid_hrbenefitplanemployeecontribution = sdr.GetInt32(sdr.GetOrdinal("intRecordID_HRBenefitPlanEmployeeContribution"))
        End If
        If Not System.Convert.IsDBNull(sdr("dteDateStart")) Then
            m_dtedatestart = sdr.GetDateTime(sdr.GetOrdinal("dteDateStart"))
        End If
        If Not System.Convert.IsDBNull(sdr("dteEffectiveStartDate")) Then
            m_dteeffectivestartdate = sdr.GetDateTime(sdr.GetOrdinal("dteEffectiveStartDate"))
        End If
        If Not System.Convert.IsDBNull(sdr("dteFullTimePromotionDate")) Then
            m_dtefulltimepromotiondate = sdr.GetDateTime(sdr.GetOrdinal("dteFullTimePromotionDate"))
        End If
        If Not System.Convert.IsDBNull(sdr("dteFullTimeEffectiveDate")) Then
            m_dtefulltimeeffectivedate = sdr.GetDateTime(sdr.GetOrdinal("dteFullTimeEffectiveDate"))
        End If
        If Not System.Convert.IsDBNull(sdr("dtePartTimeDemotionDate")) Then
            m_dteparttimedemotiondate = sdr.GetDateTime(sdr.GetOrdinal("dtePartTimeDemotionDate"))
        End If
        If Not System.Convert.IsDBNull(sdr("dtePartTimeEffectiveDate")) Then
            m_dteparttimeeffectivedate = sdr.GetDateTime(sdr.GetOrdinal("dtePartTimeEffectiveDate"))
        End If
        If Not System.Convert.IsDBNull(sdr("dteRetirementDate")) Then
            m_dteretirementdate = sdr.GetDateTime(sdr.GetOrdinal("dteRetirementDate"))
        End If
        If Not System.Convert.IsDBNull(sdr("intRecordID_HRBenefitCoverageTerminationReason")) Then
            m_intrecordid_hrbenefitcoverageterminationreason = sdr.GetInt32(sdr.GetOrdinal("intRecordID_HRBenefitCoverageTerminationReason"))
        End If
        If Not System.Convert.IsDBNull(sdr("blnReportMemberAsSubscriber")) Then
            m_blnreportmemberassubscriber = sdr.GetString(sdr.GetOrdinal("blnReportMemberAsSubscriber"))
        End If
        If Not System.Convert.IsDBNull(sdr("lblCustomerInformation")) Then
            m_lblcustomerinformation = sdr.GetString(sdr.GetOrdinal("lblCustomerInformation"))
        End If
        If Not System.Convert.IsDBNull(sdr("intRecordID_ContactCustomerInformation")) Then
            m_intrecordid_contactcustomerinformation = sdr.GetInt32(sdr.GetOrdinal("intRecordID_ContactCustomerInformation"))
        End If
        If Not System.Convert.IsDBNull(sdr("lblBenefitInformation")) Then
            m_lblbenefitinformation = sdr.GetString(sdr.GetOrdinal("lblBenefitInformation"))
        End If
        If Not System.Convert.IsDBNull(sdr("intRecordID_ContactBenefitInformation")) Then
            m_intrecordid_contactbenefitinformation = sdr.GetInt32(sdr.GetOrdinal("intRecordID_ContactBenefitInformation"))
        End If
        If Not System.Convert.IsDBNull(sdr("lblContactCreditInformation")) Then
            m_lblcontactcreditinformation = sdr.GetString(sdr.GetOrdinal("lblContactCreditInformation"))
        End If
        If Not System.Convert.IsDBNull(sdr("intRecordID_ContactCreditInformation")) Then
            m_intrecordid_contactcreditinformation = sdr.GetInt32(sdr.GetOrdinal("intRecordID_ContactCreditInformation"))
        End If
        If Not System.Convert.IsDBNull(sdr("lblContactPromotionInformation")) Then
            m_lblcontactpromotioninformation = sdr.GetString(sdr.GetOrdinal("lblContactPromotionInformation"))
        End If
        If Not System.Convert.IsDBNull(sdr("intTargetGP")) Then
            m_inttargetgp = sdr.GetInt32(sdr.GetOrdinal("intTargetGP"))
        End If
        If Not System.Convert.IsDBNull(sdr("blnQualifiesForRebate")) Then
            m_blnqualifiesforrebate = sdr.GetString(sdr.GetOrdinal("blnQualifiesForRebate"))
        End If
        If Not System.Convert.IsDBNull(sdr("blnProductPromotion")) Then
            m_blnproductpromotion = sdr.GetString(sdr.GetOrdinal("blnProductPromotion"))
        End If
        If Not System.Convert.IsDBNull(sdr("intRecordID_ContactDiscount")) Then
            m_intrecordid_contactdiscount = sdr.GetInt32(sdr.GetOrdinal("intRecordID_ContactDiscount"))
        End If
        If Not System.Convert.IsDBNull(sdr("intRecordID_Contact_BuyingGroup")) Then
            m_intrecordid_contact_buyinggroup = sdr.GetInt32(sdr.GetOrdinal("intRecordID_Contact_BuyingGroup"))
        End If
        If Not System.Convert.IsDBNull(sdr("dteBuyingGroupStartDate")) Then
            m_dtebuyinggroupstartdate = sdr.GetDateTime(sdr.GetOrdinal("dteBuyingGroupStartDate"))
        End If
        If Not System.Convert.IsDBNull(sdr("decRebatePercent")) Then
            m_decrebatepercent = sdr.GetDouble(sdr.GetOrdinal("decRebatePercent"))
        End If
        If Not System.Convert.IsDBNull(sdr("lblContactAccountingInformation")) Then
            m_lblcontactaccountinginformation = sdr.GetString(sdr.GetOrdinal("lblContactAccountingInformation"))
        End If
        If Not System.Convert.IsDBNull(sdr("intRecordID_GLChart_APExpense")) Then
            m_intrecordid_glchart_apexpense = sdr.GetInt32(sdr.GetOrdinal("intRecordID_GLChart_APExpense"))
        End If
        If Not System.Convert.IsDBNull(sdr("intRecordID_GLChartDivision_APExpense")) Then
            m_intrecordid_glchartdivision_apexpense = sdr.GetInt32(sdr.GetOrdinal("intRecordID_GLChartDivision_APExpense"))
        End If
        If Not System.Convert.IsDBNull(sdr("intRecordID_GLChartDepartment_APExpense")) Then
            m_intrecordid_glchartdepartment_apexpense = sdr.GetInt32(sdr.GetOrdinal("intRecordID_GLChartDepartment_APExpense"))
        End If
        If Not System.Convert.IsDBNull(sdr("clcPremiumCost")) Then
            m_clcpremiumcost = sdr.GetDouble(sdr.GetOrdinal("clcPremiumCost"))
        End If
        If Not System.Convert.IsDBNull(sdr("clcPremiumMemberPrice")) Then
            m_clcpremiummemberprice = sdr.GetDouble(sdr.GetOrdinal("clcPremiumMemberPrice"))
        End If
        If Not System.Convert.IsDBNull(sdr("clcEmployerContribution")) Then
            m_clcemployercontribution = sdr.GetDouble(sdr.GetOrdinal("clcEmployerContribution"))
        End If
        If Not System.Convert.IsDBNull(sdr("clcEmployeeDeduction")) Then
            m_clcemployeededuction = sdr.GetDouble(sdr.GetOrdinal("clcEmployeeDeduction"))
        End If
        If Not System.Convert.IsDBNull(sdr("lblContactRecordInformation")) Then
            m_lblcontactrecordinformation = sdr.GetString(sdr.GetOrdinal("lblContactRecordInformation"))
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
        If Not System.Convert.IsDBNull(sdr("txtJoBSeekerID")) Then
            m_txtjobseekerid = sdr.GetString(sdr.GetOrdinal("txtJoBSeekerID"))
        End If
        If Not System.Convert.IsDBNull(sdr("txtSearchProviderResumeID")) Then
            m_txtsearchproviderresumeid = sdr.GetString(sdr.GetOrdinal("txtSearchProviderResumeID"))
        End If
        If Not System.Convert.IsDBNull(sdr("intRecordID")) Then
            m_intrecordid = sdr.GetInt32(sdr.GetOrdinal("intRecordID"))
        End If
        If Not System.Convert.IsDBNull(sdr("txtGUID")) Then
            m_txtguid = sdr.GetGuid(sdr.GetOrdinal("txtGUID"))
        End If
        If Not System.Convert.IsDBNull(sdr("txtEmployeeSSN")) Then
            m_txtemployeessn = sdr.GetString(sdr.GetOrdinal("txtEmployeeSSN"))
        End If
        If Not System.Convert.IsDBNull(sdr("intRecordID_Company")) Then
            m_intrecordid_company = sdr.GetInt32(sdr.GetOrdinal("intRecordID_Company"))
        End If
        If Not System.Convert.IsDBNull(sdr("intRecordID_Division")) Then
            m_intrecordid_division = sdr.GetInt32(sdr.GetOrdinal("intRecordID_Division"))
        End If
        If Not System.Convert.IsDBNull(sdr("intRecordID_Company_Ecommerce")) Then
            m_intrecordid_company_ecommerce = sdr.GetInt32(sdr.GetOrdinal("intRecordID_Company_Ecommerce"))
        End If
        If Not System.Convert.IsDBNull(sdr("intRecordID_Division_Ecommerce")) Then
            m_intrecordid_division_ecommerce = sdr.GetInt32(sdr.GetOrdinal("intRecordID_Division_Ecommerce"))
        End If
        If Not System.Convert.IsDBNull(sdr("intRecordID_DatabaseID_Ecommerce")) Then
            m_intrecordid_databaseid_ecommerce = sdr.GetInt32(sdr.GetOrdinal("intRecordID_DatabaseID_Ecommerce"))
        End If
        If Not System.Convert.IsDBNull(sdr("intRecordID_User_Ecommerce")) Then
            m_intrecordid_user_ecommerce = sdr.GetInt32(sdr.GetOrdinal("intRecordID_User_Ecommerce"))
        End If
        If Not System.Convert.IsDBNull(sdr("txtTableName_Ecommerce")) Then
            m_txttablename_ecommerce = sdr.GetString(sdr.GetOrdinal("txtTableName_Ecommerce"))
        End If
        If Not System.Convert.IsDBNull(sdr("intRecordIDTable_Ecommerce")) Then
            m_intrecordidtable_ecommerce = sdr.GetInt32(sdr.GetOrdinal("intRecordIDTable_Ecommerce"))
        End If
        If Not System.Convert.IsDBNull(sdr("intRecordID_MarketingSalesSize")) Then
            m_intrecordid_marketingsalessize = sdr.GetInt32(sdr.GetOrdinal("intRecordID_MarketingSalesSize"))
        End If
        If Not System.Convert.IsDBNull(sdr("intRecordID_APFinanceCharge")) Then
            m_intrecordid_apfinancecharge = sdr.GetInt32(sdr.GetOrdinal("intRecordID_APFinanceCharge"))
        End If
        If Not System.Convert.IsDBNull(sdr("intRecordID_ARFinanceCharge")) Then
            m_intrecordid_arfinancecharge = sdr.GetInt32(sdr.GetOrdinal("intRecordID_ARFinanceCharge"))
        End If
        If Not System.Convert.IsDBNull(sdr("blnPayroll")) Then
            m_blnpayroll = sdr.GetString(sdr.GetOrdinal("blnPayroll"))
        End If
        If Not System.Convert.IsDBNull(sdr("intRecordID_ContactCommerce")) Then
            m_intrecordid_contactcommerce = sdr.GetInt32(sdr.GetOrdinal("intRecordID_ContactCommerce"))
        End If
        If Not System.Convert.IsDBNull(sdr("intRecordID_Contact_CustomerServiceRep")) Then
            m_intrecordid_contact_customerservicerep = sdr.GetInt32(sdr.GetOrdinal("intRecordID_Contact_CustomerServiceRep"))
        End If
        If Not System.Convert.IsDBNull(sdr("blnReceiveInspectionRequired")) Then
            m_blnreceiveinspectionrequired = sdr.GetString(sdr.GetOrdinal("blnReceiveInspectionRequired"))
        End If
        If Not System.Convert.IsDBNull(sdr("blnPayHold")) Then
            m_blnpayhold = sdr.GetString(sdr.GetOrdinal("blnPayHold"))
        End If
        If Not System.Convert.IsDBNull(sdr("intRecordID_Currency")) Then
            m_intrecordid_currency = sdr.GetInt32(sdr.GetOrdinal("intRecordID_Currency"))
        End If
        If Not System.Convert.IsDBNull(sdr("intRecordID_ShipRoute")) Then
            m_intrecordid_shiproute = sdr.GetInt32(sdr.GetOrdinal("intRecordID_ShipRoute"))
        End If
        If Not System.Convert.IsDBNull(sdr("intRecordID_ContactPricingMethod")) Then
            m_intrecordid_contactpricingmethod = sdr.GetInt32(sdr.GetOrdinal("intRecordID_ContactPricingMethod"))
        End If
        If Not System.Convert.IsDBNull(sdr("intRecordID_ProductPriceList")) Then
            m_intrecordid_productpricelist = sdr.GetInt32(sdr.GetOrdinal("intRecordID_ProductPriceList"))
        End If
        If Not System.Convert.IsDBNull(sdr("intRecordID_HRContactSecurityClearance")) Then
            m_intrecordid_hrcontactsecurityclearance = sdr.GetInt32(sdr.GetOrdinal("intRecordID_HRContactSecurityClearance"))
        End If
        If Not System.Convert.IsDBNull(sdr("intRecordID_User_Creation")) Then
            m_intrecordid_user_creation = sdr.GetInt32(sdr.GetOrdinal("intRecordID_User_Creation"))
        End If
        If Not System.Convert.IsDBNull(sdr("blnMemo")) Then
            m_blnmemo = sdr.GetString(sdr.GetOrdinal("blnMemo"))
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
        If Not System.Convert.IsDBNull(sdr("blnProcess")) Then
            m_blnprocess = sdr.GetString(sdr.GetOrdinal("blnProcess"))
        End If
        If Not System.Convert.IsDBNull(sdr("blnProject")) Then
            m_blnproject = sdr.GetString(sdr.GetOrdinal("blnProject"))
        End If
        If Not System.Convert.IsDBNull(sdr("txtHold01")) Then
            m_txthold01 = sdr.GetString(sdr.GetOrdinal("txtHold01"))
        End If
        If Not System.Convert.IsDBNull(sdr("txtHold02")) Then
            m_txthold02 = sdr.GetString(sdr.GetOrdinal("txtHold02"))
        End If
        If Not System.Convert.IsDBNull(sdr("txtHold03")) Then
            m_txthold03 = sdr.GetString(sdr.GetOrdinal("txtHold03"))
        End If
        If Not System.Convert.IsDBNull(sdr("txtHold04")) Then
            m_txthold04 = sdr.GetString(sdr.GetOrdinal("txtHold04"))
        End If
        If Not System.Convert.IsDBNull(sdr("txtHold05")) Then
            m_txthold05 = sdr.GetString(sdr.GetOrdinal("txtHold05"))
        End If
        If Not System.Convert.IsDBNull(sdr("txtHold06")) Then
            m_txthold06 = sdr.GetString(sdr.GetOrdinal("txtHold06"))
        End If
        If Not System.Convert.IsDBNull(sdr("txtHold07")) Then
            m_txthold07 = sdr.GetString(sdr.GetOrdinal("txtHold07"))
        End If
        If Not System.Convert.IsDBNull(sdr("txtHold08")) Then
            m_txthold08 = sdr.GetString(sdr.GetOrdinal("txtHold08"))
        End If
        If Not System.Convert.IsDBNull(sdr("txtHold09")) Then
            m_txthold09 = sdr.GetString(sdr.GetOrdinal("txtHold09"))
        End If
        If Not System.Convert.IsDBNull(sdr("txtHold10")) Then
            m_txthold10 = sdr.GetString(sdr.GetOrdinal("txtHold10"))
        End If
        If Not System.Convert.IsDBNull(sdr("decHold01")) Then
            m_dechold01 = sdr.GetDouble(sdr.GetOrdinal("decHold01"))
        End If
        If Not System.Convert.IsDBNull(sdr("decHold02")) Then
            m_dechold02 = sdr.GetDouble(sdr.GetOrdinal("decHold02"))
        End If
        If Not System.Convert.IsDBNull(sdr("decHold03")) Then
            m_dechold03 = sdr.GetDouble(sdr.GetOrdinal("decHold03"))
        End If
        If Not System.Convert.IsDBNull(sdr("decHold04")) Then
            m_dechold04 = sdr.GetDouble(sdr.GetOrdinal("decHold04"))
        End If
        If Not System.Convert.IsDBNull(sdr("decHold05")) Then
            m_dechold05 = sdr.GetDouble(sdr.GetOrdinal("decHold05"))
        End If
        If Not System.Convert.IsDBNull(sdr("intHold01")) Then
            m_inthold01 = sdr.GetInt32(sdr.GetOrdinal("intHold01"))
        End If
        If Not System.Convert.IsDBNull(sdr("intHold02")) Then
            m_inthold02 = sdr.GetInt32(sdr.GetOrdinal("intHold02"))
        End If
        If Not System.Convert.IsDBNull(sdr("intHold03")) Then
            m_inthold03 = sdr.GetInt32(sdr.GetOrdinal("intHold03"))
        End If
        If Not System.Convert.IsDBNull(sdr("intHold04")) Then
            m_inthold04 = sdr.GetInt32(sdr.GetOrdinal("intHold04"))
        End If
        If Not System.Convert.IsDBNull(sdr("intHold05")) Then
            m_inthold05 = sdr.GetInt32(sdr.GetOrdinal("intHold05"))
        End If
        If Not System.Convert.IsDBNull(sdr("dteHold01")) Then
            m_dtehold01 = sdr.GetDateTime(sdr.GetOrdinal("dteHold01"))
        End If
        If Not System.Convert.IsDBNull(sdr("dteHold02")) Then
            m_dtehold02 = sdr.GetDateTime(sdr.GetOrdinal("dteHold02"))
        End If
        If Not System.Convert.IsDBNull(sdr("dteHold03")) Then
            m_dtehold03 = sdr.GetDateTime(sdr.GetOrdinal("dteHold03"))
        End If
        If Not System.Convert.IsDBNull(sdr("dteHold04")) Then
            m_dtehold04 = sdr.GetDateTime(sdr.GetOrdinal("dteHold04"))
        End If
        If Not System.Convert.IsDBNull(sdr("dteHold05")) Then
            m_dtehold05 = sdr.GetDateTime(sdr.GetOrdinal("dteHold05"))
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
        retValue.Append(" lblContactInformation = """)
        retValue.Append(m_lblcontactinformation)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" ixtCode = """)
        retValue.Append(m_ixtcode)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" txtDescription = """)
        retValue.Append(m_txtdescription)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" txtProviderIdentificationNumber = """)
        retValue.Append(m_txtprovideridentificationnumber)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" intRecordID_Document_Picture = """)
        retValue.Append(m_intrecordid_document_picture)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" intRecordID_Account = """)
        retValue.Append(m_intrecordid_account)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" intRecordID_ContactSalutation = """)
        retValue.Append(m_intrecordid_contactsalutation)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" txtFirstName = """)
        retValue.Append(m_txtfirstname)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" txtMiddleName = """)
        retValue.Append(m_txtmiddlename)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" txtMiddleInitial = """)
        retValue.Append(m_txtmiddleinitial)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" txtLastName = """)
        retValue.Append(m_txtlastname)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" txtBestTime = """)
        retValue.Append(m_txtbesttime)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" txtSuffix = """)
        retValue.Append(m_txtsuffix)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" txtCompanyName = """)
        retValue.Append(m_txtcompanyname)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" txtDBA = """)
        retValue.Append(m_txtdba)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" intRecordID_ContactTitle = """)
        retValue.Append(m_intrecordid_contacttitle)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" txtAddress1 = """)
        retValue.Append(m_txtaddress1)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" txtAddress2 = """)
        retValue.Append(m_txtaddress2)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" txtAddress3 = """)
        retValue.Append(m_txtaddress3)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" txtCity = """)
        retValue.Append(m_txtcity)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" intRecordID_State = """)
        retValue.Append(m_intrecordid_state)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" txtPostalCode = """)
        retValue.Append(m_txtpostalcode)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" intRecordID_County = """)
        retValue.Append(m_intrecordid_county)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" intRecordID_Country = """)
        retValue.Append(m_intrecordid_country)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" lblContactAccessInformation = """)
        retValue.Append(m_lblcontactaccessinformation)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" txtSkypeID = """)
        retValue.Append(m_txtskypeid)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" txtPhoneNumberOffice = """)
        retValue.Append(m_txtphonenumberoffice)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" txtPhoneNumberMobile = """)
        retValue.Append(m_txtphonenumbermobile)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" intRecordID_MailSMSCarriers = """)
        retValue.Append(m_intrecordid_mailsmscarriers)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" txtPhoneNumberHome = """)
        retValue.Append(m_txtphonenumberhome)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" txtFaxNumber = """)
        retValue.Append(m_txtfaxnumber)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" txtPager = """)
        retValue.Append(m_txtpager)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" txtEmailAddress = """)
        retValue.Append(m_txtemailaddress)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" blnMailReturned = """)
        retValue.Append(m_blnmailreturned)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" txtWebsiteTitle = """)
        retValue.Append(m_txtwebsitetitle)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" lblContactPersonalInformation = """)
        retValue.Append(m_lblcontactpersonalinformation)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" dteDateOfBirth = """)
        retValue.Append(m_dtedateofbirth)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" clcContactAge = """)
        retValue.Append(m_clccontactage)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" txtDriversLicense = """)
        retValue.Append(m_txtdriverslicense)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" txtSSN = """)
        retValue.Append(m_txtssn)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" txtEmergencyContactName = """)
        retValue.Append(m_txtemergencycontactname)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" txtEmergencyContactPhone = """)
        retValue.Append(m_txtemergencycontactphone)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" lblContactPreferences = """)
        retValue.Append(m_lblcontactpreferences)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" txtBillingDay = """)
        retValue.Append(m_txtbillingday)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" blnBackOrder = """)
        retValue.Append(m_blnbackorder)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" blnProductCatalog = """)
        retValue.Append(m_blnproductcatalog)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" blnConfirmSalesOrder = """)
        retValue.Append(m_blnconfirmsalesorder)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" blnPrintPriceList = """)
        retValue.Append(m_blnprintpricelist)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" blnSubscribeToNewsletter = """)
        retValue.Append(m_blnsubscribetonewsletter)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" lblContactDetails = """)
        retValue.Append(m_lblcontactdetails)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" intRecordID_Campaign = """)
        retValue.Append(m_intrecordid_campaign)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" intRecordID_ContactCategory = """)
        retValue.Append(m_intrecordid_contactcategory)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" intRecordID_Industry = """)
        retValue.Append(m_intrecordid_industry)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" intRecordID_Region = """)
        retValue.Append(m_intrecordid_region)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" intRecordID_ContactStatus = """)
        retValue.Append(m_intrecordid_contactstatus)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" intRecordID_ContactProcessStatus = """)
        retValue.Append(m_intrecordid_contactprocessstatus)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" lblContactBillingAndShippingInformation = """)
        retValue.Append(m_lblcontactbillingandshippinginformation)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" intRecordID_ContactBillTo = """)
        retValue.Append(m_intrecordid_contactbillto)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" intRecordID_ContactShipTo = """)
        retValue.Append(m_intrecordid_contactshipto)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" intRecordID_ShipMethod = """)
        retValue.Append(m_intrecordid_shipmethod)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" intRecordID_Contact_ShipVia = """)
        retValue.Append(m_intrecordid_contact_shipvia)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" txtFOB = """)
        retValue.Append(m_txtfob)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" lblContactManagementDetails = """)
        retValue.Append(m_lblcontactmanagementdetails)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" intRecordID_Contact_SalesRep = """)
        retValue.Append(m_intrecordid_contact_salesrep)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" intRecordID_MarketingSource = """)
        retValue.Append(m_intrecordid_marketingsource)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" blnInspectionRequired = """)
        retValue.Append(m_blninspectionrequired)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" lblContactWebAccessInformation = """)
        retValue.Append(m_lblcontactwebaccessinformation)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" lbmUserInformation = """)
        retValue.Append(m_lbmuserinformation)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" txtUserName = """)
        retValue.Append(m_txtusername)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" txtPassword = """)
        retValue.Append(m_txtpassword)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" txtSecretQuestionAnswer = """)
        retValue.Append(m_txtsecretquestionanswer)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" intRecordID_SecretQuestion = """)
        retValue.Append(m_intrecordid_secretquestion)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" dtePasswordExpiration = """)
        retValue.Append(m_dtepasswordexpiration)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" blnPasswordAutoExpire = """)
        retValue.Append(m_blnpasswordautoexpire)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" intPasswordExpireIntervalDay = """)
        retValue.Append(m_intpasswordexpireintervalday)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" intFailedLoginAttempt = """)
        retValue.Append(m_intfailedloginattempt)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" txtUserRegistrationKey = """)
        retValue.Append(m_txtuserregistrationkey)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" lblContactSurveyInformation = """)
        retValue.Append(m_lblcontactsurveyinformation)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" intRecordID_SurveyUserType = """)
        retValue.Append(m_intrecordid_surveyusertype)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" intRecordID_SurveyLoginType = """)
        retValue.Append(m_intrecordid_surveylogintype)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" txtSurveyUserNetworkDomain = """)
        retValue.Append(m_txtsurveyusernetworkdomain)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" lblContactHRInformation = """)
        retValue.Append(m_lblcontacthrinformation)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" txtAccountGLReferenceCode = """)
        retValue.Append(m_txtaccountglreferencecode)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" txtOtherNamesUsed = """)
        retValue.Append(m_txtothernamesused)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" intRecordID_Contact_Union = """)
        retValue.Append(m_intrecordid_contact_union)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" intRecordID_HREmployeeUnionType = """)
        retValue.Append(m_intrecordid_hremployeeuniontype)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" intRecordID_HREmployeeStatus = """)
        retValue.Append(m_intrecordid_hremployeestatus)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" lbmWorkCenterMustBeAssignedForCorrectLaborReporting = """)
        retValue.Append(m_lbmworkcentermustbeassignedforcorrectlaborreporting)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" intRecordID_WorkCenter = """)
        retValue.Append(m_intrecordid_workcenter)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" intRecordID_HRShift = """)
        retValue.Append(m_intrecordid_hrshift)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" intRecordID_Language = """)
        retValue.Append(m_intrecordid_language)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" lbmDiversityInformation = """)
        retValue.Append(m_lbmdiversityinformation)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" intRecordID_HREthnicOrigin = """)
        retValue.Append(m_intrecordid_hrethnicorigin)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" intRecordID_HRGender = """)
        retValue.Append(m_intrecordid_hrgender)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" intRecordID_HREmployeePayCheckDeliveryMethod = """)
        retValue.Append(m_intrecordid_hremployeepaycheckdeliverymethod)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" intRecordID_HRMilitaryService = """)
        retValue.Append(m_intrecordid_hrmilitaryservice)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" intRecordID_Contact_Supervisor = """)
        retValue.Append(m_intrecordid_contact_supervisor)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" lblContactExtendedHRInformation = """)
        retValue.Append(m_lblcontactextendedhrinformation)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" intRecordID_ContactHRInformation = """)
        retValue.Append(m_intrecordid_contacthrinformation)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" lblMemberOtherMedicalInsurance = """)
        retValue.Append(m_lblmemberothermedicalinsurance)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" blnMedicare = """)
        retValue.Append(m_blnmedicare)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" blnCOB = """)
        retValue.Append(m_blncob)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" dteCOBLetterReceivedDate = """)
        retValue.Append(m_dtecobletterreceiveddate)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" lblMemberBenefitPlanInformation = """)
        retValue.Append(m_lblmemberbenefitplaninformation)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" dteRTWDate = """)
        retValue.Append(m_dtertwdate)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" dteTerminationDate = """)
        retValue.Append(m_dteterminationdate)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" intRecordID_HRBenefitPlanEmployeeContribution = """)
        retValue.Append(m_intrecordid_hrbenefitplanemployeecontribution)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" dteDateStart = """)
        retValue.Append(m_dtedatestart)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" dteEffectiveStartDate = """)
        retValue.Append(m_dteeffectivestartdate)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" dteFullTimePromotionDate = """)
        retValue.Append(m_dtefulltimepromotiondate)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" dteFullTimeEffectiveDate = """)
        retValue.Append(m_dtefulltimeeffectivedate)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" dtePartTimeDemotionDate = """)
        retValue.Append(m_dteparttimedemotiondate)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" dtePartTimeEffectiveDate = """)
        retValue.Append(m_dteparttimeeffectivedate)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" dteRetirementDate = """)
        retValue.Append(m_dteretirementdate)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" intRecordID_HRBenefitCoverageTerminationReason = """)
        retValue.Append(m_intrecordid_hrbenefitcoverageterminationreason)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" blnReportMemberAsSubscriber = """)
        retValue.Append(m_blnreportmemberassubscriber)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" lblCustomerInformation = """)
        retValue.Append(m_lblcustomerinformation)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" intRecordID_ContactCustomerInformation = """)
        retValue.Append(m_intrecordid_contactcustomerinformation)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" lblBenefitInformation = """)
        retValue.Append(m_lblbenefitinformation)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" intRecordID_ContactBenefitInformation = """)
        retValue.Append(m_intrecordid_contactbenefitinformation)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" lblContactCreditInformation = """)
        retValue.Append(m_lblcontactcreditinformation)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" intRecordID_ContactCreditInformation = """)
        retValue.Append(m_intrecordid_contactcreditinformation)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" lblContactPromotionInformation = """)
        retValue.Append(m_lblcontactpromotioninformation)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" intTargetGP = """)
        retValue.Append(m_inttargetgp)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" blnQualifiesForRebate = """)
        retValue.Append(m_blnqualifiesforrebate)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" blnProductPromotion = """)
        retValue.Append(m_blnproductpromotion)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" intRecordID_ContactDiscount = """)
        retValue.Append(m_intrecordid_contactdiscount)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" intRecordID_Contact_BuyingGroup = """)
        retValue.Append(m_intrecordid_contact_buyinggroup)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" dteBuyingGroupStartDate = """)
        retValue.Append(m_dtebuyinggroupstartdate)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" decRebatePercent = """)
        retValue.Append(m_decrebatepercent)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" lblContactAccountingInformation = """)
        retValue.Append(m_lblcontactaccountinginformation)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" intRecordID_GLChart_APExpense = """)
        retValue.Append(m_intrecordid_glchart_apexpense)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" intRecordID_GLChartDivision_APExpense = """)
        retValue.Append(m_intrecordid_glchartdivision_apexpense)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" intRecordID_GLChartDepartment_APExpense = """)
        retValue.Append(m_intrecordid_glchartdepartment_apexpense)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" clcPremiumCost = """)
        retValue.Append(m_clcpremiumcost)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" clcPremiumMemberPrice = """)
        retValue.Append(m_clcpremiummemberprice)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" clcEmployerContribution = """)
        retValue.Append(m_clcemployercontribution)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" clcEmployeeDeduction = """)
        retValue.Append(m_clcemployeededuction)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" lblContactRecordInformation = """)
        retValue.Append(m_lblcontactrecordinformation)
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
        retValue.Append(" txtJoBSeekerID = """)
        retValue.Append(m_txtjobseekerid)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" txtSearchProviderResumeID = """)
        retValue.Append(m_txtsearchproviderresumeid)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" txtGUID = """)
        retValue.Append(m_txtguid)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" txtEmployeeSSN = """)
        retValue.Append(m_txtemployeessn)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" intRecordID_Company = """)
        retValue.Append(m_intrecordid_company)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" intRecordID_Division = """)
        retValue.Append(m_intrecordid_division)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" intRecordID_Company_Ecommerce = """)
        retValue.Append(m_intrecordid_company_ecommerce)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" intRecordID_Division_Ecommerce = """)
        retValue.Append(m_intrecordid_division_ecommerce)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" intRecordID_DatabaseID_Ecommerce = """)
        retValue.Append(m_intrecordid_databaseid_ecommerce)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" intRecordID_User_Ecommerce = """)
        retValue.Append(m_intrecordid_user_ecommerce)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" txtTableName_Ecommerce = """)
        retValue.Append(m_txttablename_ecommerce)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" intRecordIDTable_Ecommerce = """)
        retValue.Append(m_intrecordidtable_ecommerce)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" intRecordID_MarketingSalesSize = """)
        retValue.Append(m_intrecordid_marketingsalessize)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" intRecordID_APFinanceCharge = """)
        retValue.Append(m_intrecordid_apfinancecharge)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" intRecordID_ARFinanceCharge = """)
        retValue.Append(m_intrecordid_arfinancecharge)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" blnPayroll = """)
        retValue.Append(m_blnpayroll)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" intRecordID_ContactCommerce = """)
        retValue.Append(m_intrecordid_contactcommerce)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" intRecordID_Contact_CustomerServiceRep = """)
        retValue.Append(m_intrecordid_contact_customerservicerep)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" blnReceiveInspectionRequired = """)
        retValue.Append(m_blnreceiveinspectionrequired)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" blnPayHold = """)
        retValue.Append(m_blnpayhold)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" intRecordID_Currency = """)
        retValue.Append(m_intrecordid_currency)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" intRecordID_ShipRoute = """)
        retValue.Append(m_intrecordid_shiproute)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" intRecordID_ContactPricingMethod = """)
        retValue.Append(m_intrecordid_contactpricingmethod)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" intRecordID_ProductPriceList = """)
        retValue.Append(m_intrecordid_productpricelist)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" intRecordID_HRContactSecurityClearance = """)
        retValue.Append(m_intrecordid_hrcontactsecurityclearance)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" intRecordID_User_Creation = """)
        retValue.Append(m_intrecordid_user_creation)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" blnMemo = """)
        retValue.Append(m_blnmemo)
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
        retValue.Append(" blnProcess = """)
        retValue.Append(m_blnprocess)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" blnProject = """)
        retValue.Append(m_blnproject)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" txtHold01 = """)
        retValue.Append(m_txthold01)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" txtHold02 = """)
        retValue.Append(m_txthold02)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" txtHold03 = """)
        retValue.Append(m_txthold03)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" txtHold04 = """)
        retValue.Append(m_txthold04)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" txtHold05 = """)
        retValue.Append(m_txthold05)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" txtHold06 = """)
        retValue.Append(m_txthold06)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" txtHold07 = """)
        retValue.Append(m_txthold07)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" txtHold08 = """)
        retValue.Append(m_txthold08)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" txtHold09 = """)
        retValue.Append(m_txthold09)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" txtHold10 = """)
        retValue.Append(m_txthold10)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" decHold01 = """)
        retValue.Append(m_dechold01)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" decHold02 = """)
        retValue.Append(m_dechold02)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" decHold03 = """)
        retValue.Append(m_dechold03)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" decHold04 = """)
        retValue.Append(m_dechold04)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" decHold05 = """)
        retValue.Append(m_dechold05)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" intHold01 = """)
        retValue.Append(m_inthold01)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" intHold02 = """)
        retValue.Append(m_inthold02)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" intHold03 = """)
        retValue.Append(m_inthold03)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" intHold04 = """)
        retValue.Append(m_inthold04)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" intHold05 = """)
        retValue.Append(m_inthold05)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" dteHold01 = """)
        retValue.Append(m_dtehold01)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" dteHold02 = """)
        retValue.Append(m_dtehold02)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" dteHold03 = """)
        retValue.Append(m_dtehold03)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" dteHold04 = """)
        retValue.Append(m_dtehold04)
        retValue.Append("""" & ControlChars.Lf)
        retValue.Append(" dteHold05 = """)
        retValue.Append(m_dtehold05)
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
        retValue.Append(" blnFavorite = """)
        retValue.Append(m_blnfavorite)
        retValue.Append("""" & ControlChars.Lf)

        Return retValue.ToString()
    End Function

#End Region

#Region "Shared Methods"

    Public Shared Function SelectByID(ByVal intrecordid As Int32) As tblContact
        If intrecordid <= 0 OrElse intrecordid >= Int32.MaxValue Then
            Return Nothing
        End If

        Dim obj As tblContact = Nothing

        Try
            Using cn As New OleDbConnection(DbApplication.Context.ConnString)
                Dim sql As New StringBuilder()

                sql.Append("Select * From [dbo].[tblContact] Where [intRecordID] = ? ")

                Using cm As OleDbCommand = cn.CreateCommand()
                    cm.CommandType = CommandType.Text
                    cm.CommandText = sql.ToString()

                    cm.Parameters.AddWithValue("", intrecordid)

                    cn.Open()

                    Using sdr As OleDbDataReader = cm.ExecuteReader()
                        Do While sdr.Read()
                            obj = New tblContact()

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

                sql.Append("Select MAX([intRecordID]) FROM [dbo].[tblContact] ")

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
    Public Shared Function CreateNew(ByVal obj As tblContact) As Boolean

        If obj Is Nothing Then
            Return False
        End If

        Try

            Using cn As New OleDbConnection(DbApplication.Context.ConnString)

                Dim sql As New StringBuilder()

                sql.Append("INSERT INTO [tblContact] (")
                sql.Append("[intRecordID_DatabaseID], ")
                sql.Append("[lblContactInformation], [ixtCode], [txtDescription], [txtProviderIdentificationNumber], ")
                sql.Append("[intRecordID_Document_Picture], [intRecordID_Account], [intRecordID_ContactSalutation], [txtFirstName], ")
                sql.Append("[txtMiddleName], [txtMiddleInitial], [txtLastName], [txtBestTime], ")
                sql.Append("[txtSuffix], [txtCompanyName], [txtDBA], [intRecordID_ContactTitle], ")
                sql.Append("[txtAddress1], [txtAddress2], [txtAddress3], [txtCity], ")
                sql.Append("[intRecordID_State], [txtPostalCode], [intRecordID_County], [intRecordID_Country], ")
                sql.Append("[lblContactAccessInformation], [txtSkypeID], [txtPhoneNumberOffice], [txtPhoneNumberMobile], ")
                sql.Append("[intRecordID_MailSMSCarriers], [txtPhoneNumberHome], [txtFaxNumber], [txtPager], ")
                sql.Append("[txtEmailAddress], [blnMailReturned], [txtWebsiteTitle], [lblContactPersonalInformation], ")
                sql.Append("[dteDateOfBirth], [clcContactAge], [txtDriversLicense], [txtSSN], ")
                sql.Append("[txtEmergencyContactName], [txtEmergencyContactPhone], [lblContactPreferences], [txtBillingDay], ")
                sql.Append("[blnBackOrder], [blnProductCatalog], [blnConfirmSalesOrder], [blnPrintPriceList], ")
                sql.Append("[blnSubscribeToNewsletter], [lblContactDetails], [intRecordID_Campaign], [intRecordID_ContactCategory], ")
                sql.Append("[intRecordID_Industry], [intRecordID_Region], [intRecordID_ContactStatus], [intRecordID_ContactProcessStatus], ")
                sql.Append("[lblContactBillingAndShippingInformation], [intRecordID_ContactBillTo], [intRecordID_ContactShipTo], [intRecordID_ShipMethod], ")
                sql.Append("[intRecordID_Contact_ShipVia], [txtFOB], [lblContactManagementDetails], [intRecordID_Contact_SalesRep], ")
                sql.Append("[intRecordID_MarketingSource], [blnInspectionRequired], [lblContactWebAccessInformation], [lbmUserInformation], ")
                sql.Append("[txtUserName], [txtPassword], [txtSecretQuestionAnswer], [intRecordID_SecretQuestion], ")
                sql.Append("[dtePasswordExpiration], [blnPasswordAutoExpire], [intPasswordExpireIntervalDay], [intFailedLoginAttempt], ")
                sql.Append("[txtUserRegistrationKey], [lblContactSurveyInformation], [intRecordID_SurveyUserType], [intRecordID_SurveyLoginType], ")
                sql.Append("[txtSurveyUserNetworkDomain], [lblContactHRInformation], [txtAccountGLReferenceCode], [txtOtherNamesUsed], ")
                sql.Append("[intRecordID_Contact_Union], [intRecordID_HREmployeeUnionType], [intRecordID_HREmployeeStatus], [lbmWorkCenterMustBeAssignedForCorrectLaborReporting], ")
                sql.Append("[intRecordID_WorkCenter], [intRecordID_HRShift], [intRecordID_Language], [lbmDiversityInformation], ")
                sql.Append("[intRecordID_HREthnicOrigin], [intRecordID_HRGender], [intRecordID_HREmployeePayCheckDeliveryMethod], [intRecordID_HRMilitaryService], ")
                sql.Append("[intRecordID_Contact_Supervisor], [lblContactExtendedHRInformation], [intRecordID_ContactHRInformation], [lblMemberOtherMedicalInsurance], ")
                sql.Append("[blnMedicare], [blnCOB], [dteCOBLetterReceivedDate], [lblMemberBenefitPlanInformation], ")
                sql.Append("[dteRTWDate], [dteTerminationDate], [intRecordID_HRBenefitPlanEmployeeContribution], [dteDateStart], ")
                sql.Append("[dteEffectiveStartDate], [dteFullTimePromotionDate], [dteFullTimeEffectiveDate], [dtePartTimeDemotionDate], ")
                sql.Append("[dtePartTimeEffectiveDate], [dteRetirementDate], [intRecordID_HRBenefitCoverageTerminationReason], [blnReportMemberAsSubscriber], ")
                sql.Append("[lblCustomerInformation], [intRecordID_ContactCustomerInformation], [lblBenefitInformation], [intRecordID_ContactBenefitInformation], ")
                sql.Append("[lblContactCreditInformation], [intRecordID_ContactCreditInformation], [lblContactPromotionInformation], [intTargetGP], ")
                sql.Append("[blnQualifiesForRebate], [blnProductPromotion], [intRecordID_ContactDiscount], [intRecordID_Contact_BuyingGroup], ")
                sql.Append("[dteBuyingGroupStartDate], [decRebatePercent], [lblContactAccountingInformation], [intRecordID_GLChart_APExpense], ")
                sql.Append("[intRecordID_GLChartDivision_APExpense], [intRecordID_GLChartDepartment_APExpense], [clcPremiumCost], [clcPremiumMemberPrice], ")
                sql.Append("[clcEmployerContribution], [clcEmployeeDeduction], [lblContactRecordInformation], [blnMakePrivate], ")
                sql.Append("[blnActive], [txtRecordCreationUser], [dteRecordCreationDate], [dteRecordUpdateDate], ")
                sql.Append("[blnCursor], [txtJoBSeekerID], [txtSearchProviderResumeID], [intRecordID], ")
                sql.Append("[txtGUID], [txtEmployeeSSN], [intRecordID_Company], [intRecordID_Division], ")
                sql.Append("[intRecordID_Company_Ecommerce], [intRecordID_Division_Ecommerce], [intRecordID_DatabaseID_Ecommerce], [intRecordID_User_Ecommerce], ")
                sql.Append("[txtTableName_Ecommerce], [intRecordIDTable_Ecommerce], [intRecordID_MarketingSalesSize], [intRecordID_APFinanceCharge], ")
                sql.Append("[intRecordID_ARFinanceCharge], [blnPayroll], [intRecordID_ContactCommerce], [intRecordID_Contact_CustomerServiceRep], ")
                sql.Append("[blnReceiveInspectionRequired], [blnPayHold], [intRecordID_Currency], [intRecordID_ShipRoute], ")
                sql.Append("[intRecordID_ContactPricingMethod], [intRecordID_ProductPriceList], [intRecordID_HRContactSecurityClearance], [intRecordID_User_Creation], ")
                sql.Append("[blnMemo], [blnAttachment], [blnDeleted], [blnHighlight], ")
                sql.Append("[blnProcess], [blnProject], [txtHold01], [txtHold02], ")
                sql.Append("[txtHold03], [txtHold04], [txtHold05], [txtHold06], ")
                sql.Append("[txtHold07], [txtHold08], [txtHold09], [txtHold10], ")
                sql.Append("[decHold01], [decHold02], [decHold03], [decHold04], ")
                sql.Append("[decHold05], [intHold01], [intHold02], [intHold03], ")
                sql.Append("[intHold04], [intHold05], [dteHold01], [dteHold02], ")
                sql.Append("[dteHold03], [dteHold04], [dteHold05], [intRecordID_ErrorLog], ")
                sql.Append("[intRecordID_Status], [blnPrint], [txtRecordUpdateUser], [blnWebSearch], ")
                sql.Append("[blnEcommerceTransmit], [blnSecurity], [dteRecordSynchronization], [blnErrorLog], ")
                sql.Append("[txtFieldValueGenerator], [blnSystemRecord], [blnAuditTrail], [lblCalendarReminder], ")
                sql.Append("[dteFollowUpDate], [txtEventStartTime], [txtEventEndTime], [blnFavorite])")
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
                sql.Append("?, ?, ?, ?, ")
                sql.Append("?, ?, ?, ?, ")
                sql.Append("?, ?, ?, ?, ")
                sql.Append("?, ?, ?, ?)")

                Using cm As OleDbCommand = cn.CreateCommand()

                    cm.CommandType = CommandType.Text
                    cm.CommandText = sql.ToString()

                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intRecordID_DatabaseID))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.lblContactInformation))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.ixtCode))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.txtDescription))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.txtProviderIdentificationNumber))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intRecordID_Document_Picture))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intRecordID_Account))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intRecordID_ContactSalutation))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.txtFirstName))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.txtMiddleName))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.txtMiddleInitial))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.txtLastName))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.txtBestTime))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.txtSuffix))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.txtCompanyName))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.txtDBA))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intRecordID_ContactTitle))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.txtAddress1))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.txtAddress2))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.txtAddress3))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.txtCity))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intRecordID_State))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.txtPostalCode))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intRecordID_County))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intRecordID_Country))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.lblContactAccessInformation))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.txtSkypeID))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.txtPhoneNumberOffice))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.txtPhoneNumberMobile))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intRecordID_MailSMSCarriers))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.txtPhoneNumberHome))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.txtFaxNumber))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.txtPager))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.txtEmailAddress))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.blnMailReturned))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.txtWebsiteTitle))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.lblContactPersonalInformation))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.dteDateOfBirth)).OleDbType = OleDbType.Date
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.clcContactAge))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.txtDriversLicense))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.txtSSN))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.txtEmergencyContactName))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.txtEmergencyContactPhone))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.lblContactPreferences))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.txtBillingDay))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.blnBackOrder))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.blnProductCatalog))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.blnConfirmSalesOrder))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.blnPrintPriceList))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.blnSubscribeToNewsletter))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.lblContactDetails))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intRecordID_Campaign))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intRecordID_ContactCategory))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intRecordID_Industry))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intRecordID_Region))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intRecordID_ContactStatus))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intRecordID_ContactProcessStatus))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.lblContactBillingAndShippingInformation))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intRecordID_ContactBillTo))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intRecordID_ContactShipTo))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intRecordID_ShipMethod))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intRecordID_Contact_ShipVia))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.txtFOB))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.lblContactManagementDetails))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intRecordID_Contact_SalesRep))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intRecordID_MarketingSource))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.blnInspectionRequired))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.lblContactWebAccessInformation))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.lbmUserInformation))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.txtUserName))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.txtPassword))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.txtSecretQuestionAnswer))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intRecordID_SecretQuestion))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.dtePasswordExpiration))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.blnPasswordAutoExpire))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intPasswordExpireIntervalDay))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intFailedLoginAttempt))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.txtUserRegistrationKey))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.lblContactSurveyInformation))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intRecordID_SurveyUserType))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intRecordID_SurveyLoginType))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.txtSurveyUserNetworkDomain))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.lblContactHRInformation))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.txtAccountGLReferenceCode))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.txtOtherNamesUsed))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intRecordID_Contact_Union))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intRecordID_HREmployeeUnionType))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intRecordID_HREmployeeStatus))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.lbmWorkCenterMustBeAssignedForCorrectLaborReporting))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intRecordID_WorkCenter))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intRecordID_HRShift))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intRecordID_Language))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.lbmDiversityInformation))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intRecordID_HREthnicOrigin))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intRecordID_HRGender))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intRecordID_HREmployeePayCheckDeliveryMethod))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intRecordID_HRMilitaryService))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intRecordID_Contact_Supervisor))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.lblContactExtendedHRInformation))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intRecordID_ContactHRInformation))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.lblMemberOtherMedicalInsurance))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.blnMedicare))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.blnCOB))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.dteCOBLetterReceivedDate))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.lblMemberBenefitPlanInformation))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.dteRTWDate))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.dteTerminationDate))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intRecordID_HRBenefitPlanEmployeeContribution))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.dteDateStart)).OleDbType = OleDbType.Date
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.dteEffectiveStartDate)).OleDbType = OleDbType.Date
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.dteFullTimePromotionDate)).OleDbType = OleDbType.Date
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.dteFullTimeEffectiveDate)).OleDbType = OleDbType.Date
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.dtePartTimeDemotionDate)).OleDbType = OleDbType.Date
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.dtePartTimeEffectiveDate)).OleDbType = OleDbType.Date
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.dteRetirementDate)).OleDbType = OleDbType.Date
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intRecordID_HRBenefitCoverageTerminationReason))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.blnReportMemberAsSubscriber))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.lblCustomerInformation))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intRecordID_ContactCustomerInformation))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.lblBenefitInformation))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intRecordID_ContactBenefitInformation))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.lblContactCreditInformation))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intRecordID_ContactCreditInformation))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.lblContactPromotionInformation))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intTargetGP))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.blnQualifiesForRebate))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.blnProductPromotion))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intRecordID_ContactDiscount))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intRecordID_Contact_BuyingGroup))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.dteBuyingGroupStartDate))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.decRebatePercent))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.lblContactAccountingInformation))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intRecordID_GLChart_APExpense))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intRecordID_GLChartDivision_APExpense))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intRecordID_GLChartDepartment_APExpense))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.clcPremiumCost))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.clcPremiumMemberPrice))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.clcEmployerContribution))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.clcEmployeeDeduction))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.lblContactRecordInformation))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.blnMakePrivate))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.blnActive))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.txtRecordCreationUser))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.dteRecordCreationDate))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.dteRecordUpdateDate))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.blnCursor))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.txtJoBSeekerID))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.txtSearchProviderResumeID))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intRecordID))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.txtGUID))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.txtEmployeeSSN))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intRecordID_Company))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intRecordID_Division))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intRecordID_Company_Ecommerce))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intRecordID_Division_Ecommerce))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intRecordID_DatabaseID_Ecommerce))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intRecordID_User_Ecommerce))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.txtTableName_Ecommerce))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intRecordIDTable_Ecommerce))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intRecordID_MarketingSalesSize))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intRecordID_APFinanceCharge))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intRecordID_ARFinanceCharge))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.blnPayroll))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intRecordID_ContactCommerce))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intRecordID_Contact_CustomerServiceRep))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.blnReceiveInspectionRequired))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.blnPayHold))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intRecordID_Currency))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intRecordID_ShipRoute))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intRecordID_ContactPricingMethod))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intRecordID_ProductPriceList))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intRecordID_HRContactSecurityClearance))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intRecordID_User_Creation))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.blnMemo))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.blnAttachment))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.blnDeleted))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.blnHighlight))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.blnProcess))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.blnProject))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.txtHold01))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.txtHold02))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.txtHold03))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.txtHold04))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.txtHold05))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.txtHold06))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.txtHold07))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.txtHold08))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.txtHold09))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.txtHold10))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.decHold01))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.decHold02))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.decHold03))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.decHold04))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.decHold05))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intHold01))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intHold02))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intHold03))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intHold04))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intHold05))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.dteHold01))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.dteHold02))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.dteHold03))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.dteHold04))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.dteHold05))
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
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.lblCalendarReminder))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.dteFollowUpDate)).OleDbType = OleDbType.Date
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.txtEventStartTime))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.txtEventEndTime))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.blnFavorite))

                    cn.Open()

                    Dim rowsAffected As Integer = cm.ExecuteNonQuery()

                    If rowsAffected > 0 Then

                        obj.AddKeywords(My.Application.Info.AssemblyName)

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
    Public Shared Function Update(ByVal obj As tblContact) As Boolean

        If obj Is Nothing OrElse obj.intRecordID <= 0 OrElse obj.intRecordID >= Int32.MaxValue Then
            Return False
        End If

        obj.txtRecordUpdateUser = My.Application.Info.AssemblyName
        obj.dteRecordUpdateDate = Date.Now

        Try

            Using cn As New OleDbConnection(DbApplication.Context.ConnString)

                Dim sql As New StringBuilder()

                sql.Append("UPDATE [dbo].[tblContact] SET ")
                sql.Append("[intRecordID_DatabaseID] = ?, ")
                sql.Append("[lblContactInformation] = ?, ")
                sql.Append("[ixtCode] = ?, ")
                sql.Append("[txtDescription] = ?, ")
                sql.Append("[txtProviderIdentificationNumber] = ?, ")
                sql.Append("[intRecordID_Document_Picture] = ?, ")
                sql.Append("[intRecordID_Account] = ?, ")
                sql.Append("[intRecordID_ContactSalutation] = ?, ")
                sql.Append("[txtFirstName] = ?, ")
                sql.Append("[txtMiddleName] = ?, ")
                sql.Append("[txtMiddleInitial] = ?, ")
                sql.Append("[txtLastName] = ?, ")
                sql.Append("[txtBestTime] = ?, ")
                sql.Append("[txtSuffix] = ?, ")
                sql.Append("[txtCompanyName] = ?, ")
                sql.Append("[txtDBA] = ?, ")
                sql.Append("[intRecordID_ContactTitle] = ?, ")
                sql.Append("[txtAddress1] = ?, ")
                sql.Append("[txtAddress2] = ?, ")
                sql.Append("[txtAddress3] = ?, ")
                sql.Append("[txtCity] = ?, ")
                sql.Append("[intRecordID_State] = ?, ")
                sql.Append("[txtPostalCode] = ?, ")
                sql.Append("[intRecordID_County] = ?, ")
                sql.Append("[intRecordID_Country] = ?, ")
                sql.Append("[lblContactAccessInformation] = ?, ")
                sql.Append("[txtSkypeID] = ?, ")
                sql.Append("[txtPhoneNumberOffice] = ?, ")
                sql.Append("[txtPhoneNumberMobile] = ?, ")
                sql.Append("[intRecordID_MailSMSCarriers] = ?, ")
                sql.Append("[txtPhoneNumberHome] = ?, ")
                sql.Append("[txtFaxNumber] = ?, ")
                sql.Append("[txtPager] = ?, ")
                sql.Append("[txtEmailAddress] = ?, ")
                sql.Append("[blnMailReturned] = ?, ")
                sql.Append("[txtWebsiteTitle] = ?, ")
                sql.Append("[lblContactPersonalInformation] = ?, ")
                sql.Append("[dteDateOfBirth] = ?, ")
                sql.Append("[clcContactAge] = ?, ")
                sql.Append("[txtDriversLicense] = ?, ")
                sql.Append("[txtSSN] = ?, ")
                sql.Append("[txtEmergencyContactName] = ?, ")
                sql.Append("[txtEmergencyContactPhone] = ?, ")
                sql.Append("[lblContactPreferences] = ?, ")
                sql.Append("[txtBillingDay] = ?, ")
                sql.Append("[blnBackOrder] = ?, ")
                sql.Append("[blnProductCatalog] = ?, ")
                sql.Append("[blnConfirmSalesOrder] = ?, ")
                sql.Append("[blnPrintPriceList] = ?, ")
                sql.Append("[blnSubscribeToNewsletter] = ?, ")
                sql.Append("[lblContactDetails] = ?, ")
                sql.Append("[intRecordID_Campaign] = ?, ")
                sql.Append("[intRecordID_ContactCategory] = ?, ")
                sql.Append("[intRecordID_Industry] = ?, ")
                sql.Append("[intRecordID_Region] = ?, ")
                sql.Append("[intRecordID_ContactStatus] = ?, ")
                sql.Append("[intRecordID_ContactProcessStatus] = ?, ")
                sql.Append("[lblContactBillingAndShippingInformation] = ?, ")
                sql.Append("[intRecordID_ContactBillTo] = ?, ")
                sql.Append("[intRecordID_ContactShipTo] = ?, ")
                sql.Append("[intRecordID_ShipMethod] = ?, ")
                sql.Append("[intRecordID_Contact_ShipVia] = ?, ")
                sql.Append("[txtFOB] = ?, ")
                sql.Append("[lblContactManagementDetails] = ?, ")
                sql.Append("[intRecordID_Contact_SalesRep] = ?, ")
                sql.Append("[intRecordID_MarketingSource] = ?, ")
                sql.Append("[blnInspectionRequired] = ?, ")
                sql.Append("[lblContactWebAccessInformation] = ?, ")
                sql.Append("[lbmUserInformation] = ?, ")
                sql.Append("[txtUserName] = ?, ")
                sql.Append("[txtPassword] = ?, ")
                sql.Append("[txtSecretQuestionAnswer] = ?, ")
                sql.Append("[intRecordID_SecretQuestion] = ?, ")
                sql.Append("[dtePasswordExpiration] = ?, ")
                sql.Append("[blnPasswordAutoExpire] = ?, ")
                sql.Append("[intPasswordExpireIntervalDay] = ?, ")
                sql.Append("[intFailedLoginAttempt] = ?, ")
                sql.Append("[txtUserRegistrationKey] = ?, ")
                sql.Append("[lblContactSurveyInformation] = ?, ")
                sql.Append("[intRecordID_SurveyUserType] = ?, ")
                sql.Append("[intRecordID_SurveyLoginType] = ?, ")
                sql.Append("[txtSurveyUserNetworkDomain] = ?, ")
                sql.Append("[lblContactHRInformation] = ?, ")
                sql.Append("[txtAccountGLReferenceCode] = ?, ")
                sql.Append("[txtOtherNamesUsed] = ?, ")
                sql.Append("[intRecordID_Contact_Union] = ?, ")
                sql.Append("[intRecordID_HREmployeeUnionType] = ?, ")
                sql.Append("[intRecordID_HREmployeeStatus] = ?, ")
                sql.Append("[lbmWorkCenterMustBeAssignedForCorrectLaborReporting] = ?, ")
                sql.Append("[intRecordID_WorkCenter] = ?, ")
                sql.Append("[intRecordID_HRShift] = ?, ")
                sql.Append("[intRecordID_Language] = ?, ")
                sql.Append("[lbmDiversityInformation] = ?, ")
                sql.Append("[intRecordID_HREthnicOrigin] = ?, ")
                sql.Append("[intRecordID_HRGender] = ?, ")
                sql.Append("[intRecordID_HREmployeePayCheckDeliveryMethod] = ?, ")
                sql.Append("[intRecordID_HRMilitaryService] = ?, ")
                sql.Append("[intRecordID_Contact_Supervisor] = ?, ")
                sql.Append("[lblContactExtendedHRInformation] = ?, ")
                sql.Append("[intRecordID_ContactHRInformation] = ?, ")
                sql.Append("[lblMemberOtherMedicalInsurance] = ?, ")
                sql.Append("[blnMedicare] = ?, ")
                sql.Append("[blnCOB] = ?, ")
                sql.Append("[dteCOBLetterReceivedDate] = ?, ")
                sql.Append("[lblMemberBenefitPlanInformation] = ?, ")
                sql.Append("[dteRTWDate] = ?, ")
                sql.Append("[dteTerminationDate] = ?, ")
                sql.Append("[intRecordID_HRBenefitPlanEmployeeContribution] = ?, ")
                sql.Append("[dteDateStart] = ?, ")
                sql.Append("[dteEffectiveStartDate] = ?, ")
                sql.Append("[dteFullTimePromotionDate] = ?, ")
                sql.Append("[dteFullTimeEffectiveDate] = ?, ")
                sql.Append("[dtePartTimeDemotionDate] = ?, ")
                sql.Append("[dtePartTimeEffectiveDate] = ?, ")
                sql.Append("[dteRetirementDate] = ?, ")
                sql.Append("[intRecordID_HRBenefitCoverageTerminationReason] = ?, ")
                sql.Append("[blnReportMemberAsSubscriber] = ?, ")
                sql.Append("[lblCustomerInformation] = ?, ")
                sql.Append("[intRecordID_ContactCustomerInformation] = ?, ")
                sql.Append("[lblBenefitInformation] = ?, ")
                sql.Append("[intRecordID_ContactBenefitInformation] = ?, ")
                sql.Append("[lblContactCreditInformation] = ?, ")
                sql.Append("[intRecordID_ContactCreditInformation] = ?, ")
                sql.Append("[lblContactPromotionInformation] = ?, ")
                sql.Append("[intTargetGP] = ?, ")
                sql.Append("[blnQualifiesForRebate] = ?, ")
                sql.Append("[blnProductPromotion] = ?, ")
                sql.Append("[intRecordID_ContactDiscount] = ?, ")
                sql.Append("[intRecordID_Contact_BuyingGroup] = ?, ")
                sql.Append("[dteBuyingGroupStartDate] = ?, ")
                sql.Append("[decRebatePercent] = ?, ")
                sql.Append("[lblContactAccountingInformation] = ?, ")
                sql.Append("[intRecordID_GLChart_APExpense] = ?, ")
                sql.Append("[intRecordID_GLChartDivision_APExpense] = ?, ")
                sql.Append("[intRecordID_GLChartDepartment_APExpense] = ?, ")
                sql.Append("[clcPremiumCost] = ?, ")
                sql.Append("[clcPremiumMemberPrice] = ?, ")
                sql.Append("[clcEmployerContribution] = ?, ")
                sql.Append("[clcEmployeeDeduction] = ?, ")
                sql.Append("[lblContactRecordInformation] = ?, ")
                sql.Append("[blnMakePrivate] = ?, ")
                sql.Append("[blnActive] = ?, ")
                sql.Append("[txtRecordCreationUser] = ?, ")
                sql.Append("[dteRecordCreationDate] = ?, ")
                sql.Append("[dteRecordUpdateDate] = ?, ")
                sql.Append("[blnCursor] = ?, ")
                sql.Append("[txtJoBSeekerID] = ?, ")
                sql.Append("[txtSearchProviderResumeID] = ?, ")
                sql.Append("[txtGUID] = ?, ")
                sql.Append("[txtEmployeeSSN] = ?, ")
                sql.Append("[intRecordID_Company] = ?, ")
                sql.Append("[intRecordID_Division] = ?, ")
                sql.Append("[intRecordID_Company_Ecommerce] = ?, ")
                sql.Append("[intRecordID_Division_Ecommerce] = ?, ")
                sql.Append("[intRecordID_DatabaseID_Ecommerce] = ?, ")
                sql.Append("[intRecordID_User_Ecommerce] = ?, ")
                sql.Append("[txtTableName_Ecommerce] = ?, ")
                sql.Append("[intRecordIDTable_Ecommerce] = ?, ")
                sql.Append("[intRecordID_MarketingSalesSize] = ?, ")
                sql.Append("[intRecordID_APFinanceCharge] = ?, ")
                sql.Append("[intRecordID_ARFinanceCharge] = ?, ")
                sql.Append("[blnPayroll] = ?, ")
                sql.Append("[intRecordID_ContactCommerce] = ?, ")
                sql.Append("[intRecordID_Contact_CustomerServiceRep] = ?, ")
                sql.Append("[blnReceiveInspectionRequired] = ?, ")
                sql.Append("[blnPayHold] = ?, ")
                sql.Append("[intRecordID_Currency] = ?, ")
                sql.Append("[intRecordID_ShipRoute] = ?, ")
                sql.Append("[intRecordID_ContactPricingMethod] = ?, ")
                sql.Append("[intRecordID_ProductPriceList] = ?, ")
                sql.Append("[intRecordID_HRContactSecurityClearance] = ?, ")
                sql.Append("[intRecordID_User_Creation] = ?, ")
                sql.Append("[blnMemo] = ?, ")
                sql.Append("[blnAttachment] = ?, ")
                sql.Append("[blnDeleted] = ?, ")
                sql.Append("[blnHighlight] = ?, ")
                sql.Append("[blnProcess] = ?, ")
                sql.Append("[blnProject] = ?, ")
                sql.Append("[txtHold01] = ?, ")
                sql.Append("[txtHold02] = ?, ")
                sql.Append("[txtHold03] = ?, ")
                sql.Append("[txtHold04] = ?, ")
                sql.Append("[txtHold05] = ?, ")
                sql.Append("[txtHold06] = ?, ")
                sql.Append("[txtHold07] = ?, ")
                sql.Append("[txtHold08] = ?, ")
                sql.Append("[txtHold09] = ?, ")
                sql.Append("[txtHold10] = ?, ")
                sql.Append("[decHold01] = ?, ")
                sql.Append("[decHold02] = ?, ")
                sql.Append("[decHold03] = ?, ")
                sql.Append("[decHold04] = ?, ")
                sql.Append("[decHold05] = ?, ")
                sql.Append("[intHold01] = ?, ")
                sql.Append("[intHold02] = ?, ")
                sql.Append("[intHold03] = ?, ")
                sql.Append("[intHold04] = ?, ")
                sql.Append("[intHold05] = ?, ")
                sql.Append("[dteHold01] = ?, ")
                sql.Append("[dteHold02] = ?, ")
                sql.Append("[dteHold03] = ?, ")
                sql.Append("[dteHold04] = ?, ")
                sql.Append("[dteHold05] = ?, ")
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
                sql.Append("[lblCalendarReminder] = ?, ")
                sql.Append("[dteFollowUpDate] = ?, ")
                sql.Append("[txtEventStartTime] = ?, ")
                sql.Append("[txtEventEndTime] = ?, ")
                sql.Append("[blnFavorite] = ? ")
                sql.Append("WHERE intRecordID = ?")

                Using cm As OleDbCommand = cn.CreateCommand()

                    cm.CommandType = CommandType.Text
                    cm.CommandText = sql.ToString()

                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intRecordID_DatabaseID))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.lblContactInformation))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.ixtCode))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.txtDescription))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.txtProviderIdentificationNumber))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intRecordID_Document_Picture))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intRecordID_Account))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intRecordID_ContactSalutation))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.txtFirstName))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.txtMiddleName))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.txtMiddleInitial))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.txtLastName))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.txtBestTime))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.txtSuffix))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.txtCompanyName))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.txtDBA))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intRecordID_ContactTitle))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.txtAddress1))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.txtAddress2))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.txtAddress3))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.txtCity))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intRecordID_State))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.txtPostalCode))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intRecordID_County))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intRecordID_Country))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.lblContactAccessInformation))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.txtSkypeID))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.txtPhoneNumberOffice))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.txtPhoneNumberMobile))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intRecordID_MailSMSCarriers))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.txtPhoneNumberHome))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.txtFaxNumber))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.txtPager))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.txtEmailAddress))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.blnMailReturned))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.txtWebsiteTitle))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.lblContactPersonalInformation))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.dteDateOfBirth)).OleDbType = OleDbType.Date
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.clcContactAge))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.txtDriversLicense))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.txtSSN))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.txtEmergencyContactName))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.txtEmergencyContactPhone))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.lblContactPreferences))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.txtBillingDay))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.blnBackOrder))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.blnProductCatalog))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.blnConfirmSalesOrder))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.blnPrintPriceList))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.blnSubscribeToNewsletter))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.lblContactDetails))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intRecordID_Campaign))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intRecordID_ContactCategory))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intRecordID_Industry))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intRecordID_Region))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intRecordID_ContactStatus))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intRecordID_ContactProcessStatus))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.lblContactBillingAndShippingInformation))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intRecordID_ContactBillTo))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intRecordID_ContactShipTo))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intRecordID_ShipMethod))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intRecordID_Contact_ShipVia))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.txtFOB))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.lblContactManagementDetails))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intRecordID_Contact_SalesRep))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intRecordID_MarketingSource))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.blnInspectionRequired))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.lblContactWebAccessInformation))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.lbmUserInformation))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.txtUserName))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.txtPassword))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.txtSecretQuestionAnswer))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intRecordID_SecretQuestion))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.dtePasswordExpiration))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.blnPasswordAutoExpire))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intPasswordExpireIntervalDay))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intFailedLoginAttempt))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.txtUserRegistrationKey))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.lblContactSurveyInformation))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intRecordID_SurveyUserType))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intRecordID_SurveyLoginType))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.txtSurveyUserNetworkDomain))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.lblContactHRInformation))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.txtAccountGLReferenceCode))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.txtOtherNamesUsed))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intRecordID_Contact_Union))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intRecordID_HREmployeeUnionType))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intRecordID_HREmployeeStatus))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.lbmWorkCenterMustBeAssignedForCorrectLaborReporting))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intRecordID_WorkCenter))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intRecordID_HRShift))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intRecordID_Language))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.lbmDiversityInformation))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intRecordID_HREthnicOrigin))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intRecordID_HRGender))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intRecordID_HREmployeePayCheckDeliveryMethod))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intRecordID_HRMilitaryService))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intRecordID_Contact_Supervisor))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.lblContactExtendedHRInformation))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intRecordID_ContactHRInformation))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.lblMemberOtherMedicalInsurance))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.blnMedicare))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.blnCOB))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.dteCOBLetterReceivedDate))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.lblMemberBenefitPlanInformation))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.dteRTWDate))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.dteTerminationDate))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intRecordID_HRBenefitPlanEmployeeContribution))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.dteDateStart)).OleDbType = OleDbType.Date
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.dteEffectiveStartDate)).OleDbType = OleDbType.Date
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.dteFullTimePromotionDate)).OleDbType = OleDbType.Date
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.dteFullTimeEffectiveDate)).OleDbType = OleDbType.Date
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.dtePartTimeDemotionDate)).OleDbType = OleDbType.Date
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.dtePartTimeEffectiveDate)).OleDbType = OleDbType.Date
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.dteRetirementDate)).OleDbType = OleDbType.Date
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intRecordID_HRBenefitCoverageTerminationReason))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.blnReportMemberAsSubscriber))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.lblCustomerInformation))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intRecordID_ContactCustomerInformation))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.lblBenefitInformation))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intRecordID_ContactBenefitInformation))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.lblContactCreditInformation))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intRecordID_ContactCreditInformation))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.lblContactPromotionInformation))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intTargetGP))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.blnQualifiesForRebate))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.blnProductPromotion))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intRecordID_ContactDiscount))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intRecordID_Contact_BuyingGroup))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.dteBuyingGroupStartDate))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.decRebatePercent))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.lblContactAccountingInformation))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intRecordID_GLChart_APExpense))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intRecordID_GLChartDivision_APExpense))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intRecordID_GLChartDepartment_APExpense))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.clcPremiumCost))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.clcPremiumMemberPrice))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.clcEmployerContribution))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.clcEmployeeDeduction))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.lblContactRecordInformation))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.blnMakePrivate))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.blnActive))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.txtRecordCreationUser))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.dteRecordCreationDate))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.dteRecordUpdateDate))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.blnCursor))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.txtJoBSeekerID))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.txtSearchProviderResumeID))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.txtGUID))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.txtEmployeeSSN))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intRecordID_Company))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intRecordID_Division))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intRecordID_Company_Ecommerce))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intRecordID_Division_Ecommerce))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intRecordID_DatabaseID_Ecommerce))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intRecordID_User_Ecommerce))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.txtTableName_Ecommerce))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intRecordIDTable_Ecommerce))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intRecordID_MarketingSalesSize))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intRecordID_APFinanceCharge))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intRecordID_ARFinanceCharge))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.blnPayroll))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intRecordID_ContactCommerce))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intRecordID_Contact_CustomerServiceRep))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.blnReceiveInspectionRequired))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.blnPayHold))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intRecordID_Currency))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intRecordID_ShipRoute))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intRecordID_ContactPricingMethod))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intRecordID_ProductPriceList))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intRecordID_HRContactSecurityClearance))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intRecordID_User_Creation))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.blnMemo))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.blnAttachment))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.blnDeleted))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.blnHighlight))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.blnProcess))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.blnProject))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.txtHold01))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.txtHold02))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.txtHold03))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.txtHold04))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.txtHold05))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.txtHold06))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.txtHold07))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.txtHold08))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.txtHold09))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.txtHold10))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.decHold01))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.decHold02))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.decHold03))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.decHold04))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.decHold05))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intHold01))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intHold02))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intHold03))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intHold04))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intHold05))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.dteHold01))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.dteHold02))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.dteHold03))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.dteHold04))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.dteHold05))
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
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.lblCalendarReminder))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.dteFollowUpDate)).OleDbType = OleDbType.Date
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.txtEventStartTime))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.txtEventEndTime))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.blnFavorite))
                    cm.Parameters.AddWithValue("", SqlHelper.GetValueIfAny(obj.intRecordID))

                    cn.Open()

                    Dim rowsAffected As Integer = cm.ExecuteNonQuery()

                    If rowsAffected > 0 Then

                        obj.AddKeywords(My.Application.Info.AssemblyName)

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
    Public Shared Function Delete(ByVal obj As tblContact) As Boolean

        If obj Is Nothing OrElse obj.intRecordID <= 0 OrElse obj.intRecordID >= Int32.MaxValue Then
            Return False
        End If

        Try

            Using cn As New OleDbConnection(DbApplication.Context.ConnString)

                Dim sql As New StringBuilder()

                sql.Append("DELETE [dbo].[tblContact] WHERE [intRecordID] = ?")

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