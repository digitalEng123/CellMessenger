Imports BandwidthSMSAPIConnectorLibrary40
Imports CellModemLibrary.Configuration

Imports BandwidthSMSAPIConnectorLibrary40.BandWidth.Net.API

Public Module ConfigurationUtils

    Public Sub InitializeTheProviderAndTheConfiguration()

        DbApplication.Context.ConnString = System.Configuration.ConfigurationManager.ConnectionStrings("MSSQLCONNSTR1_OLEDB").ConnectionString

        Dim objTheProvider As tblMessengerCommunicationProvider = Nothing ' tblMessengerCommunicationProvider.SelectDefault()
        Dim objTheConfiguration As tblMessengerConfiguration = tblMessengerConfiguration.SelectActive()

        Dim cfgBandwidth_BaseUrl = System.Configuration.ConfigurationManager.AppSettings("BANDWIDTH_API_BASE_URL")
        'Dim cfgTelligent_Domain As String = System.Configuration.ConfigurationManager.AppSettings("TELLIGENT_DOMAIN_NAME")

        'CommonApplication.Telligent_Domain_Name = cfgTelligent_Domain
        CommonApplication.Bandwidth_API_BaseUrl = cfgBandwidth_BaseUrl

        If IsNothing(objTheConfiguration) Then

#If DEBUG Then

            Dim cfgBandWidth_UserId = System.Configuration.ConfigurationManager.AppSettings("BANDWIDTH_USER_ID")
            Dim cfgBandWidth_APIToken = System.Configuration.ConfigurationManager.AppSettings("BANDWIDTH_API_TOKEN")
            Dim cfgBandWidth_APISecret = System.Configuration.ConfigurationManager.AppSettings("BANDWIDTH_API_SECRET")
            Dim cfgBandwidth_Username = System.Configuration.ConfigurationManager.AppSettings("BANDWIDTH_USERNAME")
            Dim cfgBandwidth_Password = System.Configuration.ConfigurationManager.AppSettings("BANDWIDTH_PASSWORD")
            Dim cfgBandwidth_LoginUrl = System.Configuration.ConfigurationManager.AppSettings("BANDWIDTH_LOGIN_URL_WIC")
            Dim cfgBandwidth_CallBackUrl = System.Configuration.ConfigurationManager.AppSettings("BANDWIDTH_CALLBACK_URL")

            CommonApplication.SetBandWidth_USER_ID(cfgBandWidth_UserId)
            CommonApplication.SetBandwidth_API_TOKEN(cfgBandWidth_APIToken)
            CommonApplication.SetBandwidth_API_SECRET(cfgBandWidth_APISecret)

            objTheProvider = New tblMessengerCommunicationProvider() With
            {
            .ixtCode = "HelpDeskEmailAccount",
            .txtDescription = "HelpDeskEmailAccount",
            .txtUserID = cfgBandWidth_UserId,
            .txtAPIToken = cfgBandWidth_APIToken,
            .txtAPISecretKey = cfgBandWidth_APISecret,
            .txtUserName = cfgBandwidth_Username,
            .txtPassword = cfgBandwidth_Password,
            .mmoLoginUrlWIC = cfgBandwidth_LoginUrl,
            .txtAccountID = "",
            .txtSubAccountID = "",
            .mmoProviderAttachmentCallbackURL = cfgBandwidth_CallBackUrl
            }

            objTheProvider.intRecordID = tblMessengerCommunicationProvider.SelectNextID()

            objTheConfiguration = New tblMessengerConfiguration() With
            {
            .ixtCode = "SMS",
            .txtDescription = "SMS",
            .blnUseCommunicationProvider = Constants.DEFAULT_VALUE_YES,
            .intRecordID_MessengerCommunicationProvider = objTheProvider.intRecordID,
            .intNumberOfSecondsToWaitToRun = 30,
            .blnUseModem = Constants.DEFAULT_VALUE_NO,
            .txtModemManufacturer = "",
            .txtModemModel = "",
            .txtPhoneNumberAssigned = "(909) 579-2299",
            .txtPort = "COM5",
            .intBaudRate = 19200,
            .intDataBits = 8,
            .txtParity = "N",
            .decStopBits = 1,
            .txtCellularModemAccessPIN = "",
            .intFailedMessageResendTimeDelayInMinutes = 5,
            .txtReturnErrorCodeForInvalidPhone = "1121611611",
            .blnDeleteReceivedMessagesFromModem = Constants.DEFAULT_VALUE_YES,
            .intIntervalToCheckForNewMessagesInMinutes = 1,
            .blnUseMessengerToSendEmailsViaInternet = "",
            .txtFileAttachmentPath = "",
            .mmoTextReceiptEmailAlertNotificationList = "",
            .mmoTextReceiptEmailMessageToUserList = "<p>Text message received by ROCKET Messenger. Go to Mail Entry Form 12102.</p>"
            }

            objTheConfiguration.intRecordID = tblMessengerConfiguration.SelectNextID()

            Try
                tblMessengerCommunicationProvider.CreateNew(objTheProvider)
                tblMessengerConfiguration.CreateNew(objTheConfiguration)
            Catch
                Throw
            End Try
#Else


#End If
        Else


            objTheProvider = tblMessengerCommunicationProvider.SelectByConfigurationID(objTheConfiguration.intRecordID)

            If Not IsNothing(objTheProvider) Then

                If String.IsNullOrWhiteSpace(objTheProvider.txtUserID) Then

                    Dim cfgBandWidth_UserId = System.Configuration.ConfigurationManager.AppSettings("BANDWIDTH_USER_ID")
                    Dim cfgBandWidth_APIToken = System.Configuration.ConfigurationManager.AppSettings("BANDWIDTH_API_TOKEN")
                    Dim cfgBandWidth_APISecret = System.Configuration.ConfigurationManager.AppSettings("BANDWIDTH_API_SECRET")
                    Dim cfgBandwidth_Username = System.Configuration.ConfigurationManager.AppSettings("BANDWIDTH_USERNAME")
                    Dim cfgBandwidth_Password = System.Configuration.ConfigurationManager.AppSettings("BANDWIDTH_PASSWORD")
                    Dim cfgBandwidth_LoginUrl = System.Configuration.ConfigurationManager.AppSettings("BANDWIDTH_LOGIN_URL_WIC")
                    Dim cfgBandwidth_CallBackUrl = System.Configuration.ConfigurationManager.AppSettings("BANDWIDTH_CALLBACK_URL")

                    Try

                        With objTheProvider
                            '.ixtCode = "HelpDeskEmailAccount"
                            '.txtDescription = "HelpDeskEmailAccount"
                            .txtUserID = cfgBandWidth_UserId
                            .txtAPIToken = cfgBandWidth_APIToken
                            .txtAPISecretKey = cfgBandWidth_APISecret
                            .txtUserName = cfgBandwidth_Username
                            .txtPassword = cfgBandwidth_Username
                            .mmoLoginUrlWIC = cfgBandwidth_LoginUrl
                            .mmoProviderAttachmentCallbackURL = cfgBandwidth_CallBackUrl
                            '.txtAccountID = ""
                            '.txtSubAccountID = ""
                        End With

                        tblMessengerCommunicationProvider.Update(objTheProvider)
                        'tblMessengerConfiguration.Update(objTheConfiguration)
                    Catch
                        Throw
                    End Try
                End If

                CommonApplication.SetBandWidth_USER_ID(objTheProvider.txtUserID)
                CommonApplication.SetBandwidth_API_TOKEN(objTheProvider.txtAPIToken)
                CommonApplication.SetBandwidth_API_SECRET(objTheProvider.txtAPISecretKey)

                'objTheConfiguration = tblMessengerConfiguration.SelectByProviderID(objTheProvider.intRecordID)

                If Not IsNothing(objTheConfiguration) Then

                    If String.IsNullOrWhiteSpace(objTheConfiguration.txtPhoneNumberAssigned) And objTheConfiguration.blnUseModem = Constants.DEFAULT_VALUE_NO Then

                        If System.Diagnostics.Debugger.IsAttached Then

                            Dim getListOfPhoneNumbersTask = AwaitExtensions.GetAwaiter(APIHelper.GetListOfPhoneNumbers(10, Nothing, Nothing, Nothing, Nothing, PhoneNumberState.Enabled))

                            Dim getListOfPhoneNumbersResults = getListOfPhoneNumbersTask.GetResult()

                            If getListOfPhoneNumbersResults.Any() Then

                                Dim firstPhoneNumber = getListOfPhoneNumbersResults.FirstOrDefault()

                                objTheConfiguration.txtPhoneNumberAssigned = firstPhoneNumber.Number

                                Try

                                    tblMessengerConfiguration.Update(objTheConfiguration)
                                Catch
                                    Throw
                                End Try
                            Else
                                Throw New ArgumentOutOfRangeException("Check Bandwidth Account Settings. No Phone Number assigned to account!")
                            End If
                        Else

                            Dim getListOfPhoneNumbersTask = AwaitExtensions.GetAwaiter(APIHelper.GetListOfPhoneNumbers(10, Nothing, Nothing, Nothing, Nothing, PhoneNumberState.Enabled))

                            Dim getListOfPhoneNumbersResults = getListOfPhoneNumbersTask.GetResult()

                            If Not getListOfPhoneNumbersResults.Any() Then

                                Throw New ArgumentOutOfRangeException("Check Bandwidth Account Settings. No Active Phone Number assigned to your account!")
                            End If

                            Throw New ArgumentOutOfRangeException("Couldn't find record within the tblMessengerConfiguration table. The 'Bandwidth Phone Number', Column: txtPhoneNumberAssigned.")
                        End If
                    End If
                End If
            End If
        End If

        If Not IsNothing(objTheConfiguration) And Not IsNothing(objTheProvider) Then

            If String.IsNullOrWhiteSpace(objTheProvider.mmoProviderAttachmentCallbackURL) Then
                Throw New ArgumentNullException("Couldn't find record within the tblMessengerCommunicationProvider table. The 'CallbackUrl', Column: mmoProviderAttachmentCallbackURL.")
            End If
            'If String.IsNullOrWhiteSpace(objTheProvider.mmoProviderAttachmentCallbackURL) And objTheConfiguration.blnUseModem = Constants.DEFAULT_VALUE_NO Then
            '    Throw New ArgumentNullException("Couldn't find record within the tblMessengerCommunicationProvider table. The 'CallbackUrl', Column: mmoProviderAttachmentCallbackURL.")
            'End If

            Dim cfgTelligent_Domain As String = ""

            Dim callBackUri As New System.Uri(objTheProvider.mmoProviderAttachmentCallbackURL)

            If System.Diagnostics.Debugger.IsAttached Then
                cfgTelligent_Domain = System.Configuration.ConfigurationManager.AppSettings("TELLIGENT_DOMAIN_NAME")
            Else
                cfgTelligent_Domain = String.Format("{0}://{1}", callBackUri.Scheme, callBackUri.Host)
            End If

            CommonApplication.Telligent_Domain_Name = cfgTelligent_Domain
        End If

        If IsNothing(objTheConfiguration) Then
            Throw New NullReferenceException("Couldn't find record within the tblMessengerConfiguration table.")
        End If

        If IsNothing(objTheProvider) Then
            Throw New NullReferenceException(String.Format("Couldn't find record within the tblMessengerProviderConfiguration table for tblMessengerConfiguration record {0} ({1}).",
                objTheConfiguration.intRecordID,
                objTheConfiguration.ixtCode))
        End If

        DbApplication.Context.TheProvider = objTheProvider
        DbApplication.Context.TheConfiguration = objTheConfiguration
    End Sub

End Module
