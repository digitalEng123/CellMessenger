'use strict';

var express = require('express');
//var node_mssql = require('node-mssql');
//var Promise = require('promise');
var dateFormat = require('dateformat');
var uuidv1 = require('uuid/v1');

var commonApp = require('../../commonApp');
var sqlHelper = require('../../Utils/sqlHelper');
var utilities = require('../../Utils/utilities');

function getMMSEventRoute(app) {

    var route = express.Router();

    // Mount route as "/v1/messages"
    app.use(commonApp.messageRoute, route);

    /* GET users phone numbers. */
    route.get('/mmsEvent', function (request, response, next) {

        response.end("GET Not Supported!");
    });
};

function postMMSEventRoute(app) {

    var route = express.Router();

    // Mount route as "/v1/messages"
    app.use(commonApp.messageRoute, route);

    /* GET users phone numbers. */
    route.post('/mmsEvent', function (request, response, next) {

        var eventType = '';
        var direction = '';
        var from = '';
        var to = '';
        var messageId = '';
        var messageUri = '';
        var text = '';
        var applicationId = '';
        var time = '';
        var state = '';
        var media = '';
        var deliveryState = void (0);
        var deliveryCode = void (0);
        var deliveryDescription = void (0);

        var intRecordID = '';
        var ixtCode = '';
        var txtDescription = '';
        var intRecordID_DatabaseID = null;
        var intRecordID_Company = null;
        var intRecordID_Division = null;
        var intRecordID_Mail = null;
        var intRecordID_MailDetail = null;
        var intRecordID_MessengerConfiguration = null;
        var intRecordID_MessengerDeliveryState = null;
        var intRecordID_MessengerDeliveryCode = null;
        var mmoTransaction = '';

        if (request.method === 'POST') {

            var jsonBody = request.body;

            if (jsonBody['eventType'])
                eventType = jsonBody['eventType'];
            if (jsonBody['direction'])
                direction = jsonBody['direction'];
            if (jsonBody['from'])
                from = jsonBody['from'];
            if (jsonBody['to'])
                to = jsonBody['to'];
            if (jsonBody['messageId'])
                messageId = jsonBody['messageId'];
            if (jsonBody['messageUri'])
                messageUri = jsonBody['messageUri'];
            if (jsonBody['text'])
                text = jsonBody['text'];
            if (jsonBody['applicationId'])
                applicationId = jsonBody['applicationId'];
            if (jsonBody['time'])
                time = jsonBody['time'];
            if (jsonBody['state'])
                state = jsonBody['state'];
            if (jsonBody['media'])
                media = jsonBody['media'];
            if (jsonBody['deliveryState'])
                deliveryState = jsonBody['deliveryState'];
            if (jsonBody['deliveryCode'])
                deliveryCode = jsonBody['deliveryCode'];
            if (jsonBody['deliveryDescription'])
                deliveryDescription = jsonBody['deliveryDescription'];

            if (!utilities.IsUndefined(state)) {
                state = utilities.ApplySentenceCase(state);
            }

            if (utilities.IsUndefined(deliveryState)) {
                deliveryState = state;
            }

            if (!utilities.IsUndefined(deliveryState)) {
                deliveryState = utilities.ApplySentenceCase(deliveryState);
            }

            //if (utilities.IsUndefined(deliveryState)) {
            //    deliveryState = state;
            //}
            //else {
            //    deliveryState = utilities.ApplySentenceCase(deliveryState);
            //}

            console.log("");
            console.log("MMS Event Request: ");
            console.log("Post Data: " + JSON.stringify(jsonBody));
            //console.log("");
            //console.log("Request.jsonBody" + jsonBody);
            ////console.log("args " + args);
            ////console.log("Request Json Body: " + params);
            //console.log("");

            //utilities.AppendToFile("SMSEvents.txt", JSON.stringify(jsonBody));

            var date = new Date();

            sqlHelper.GetMSSQLSelectQuery('telligent',
                "select top 1 * from [dbo].[tblMail] where [txtMessageID] = '" + messageId + "'", function (error, mailRecordSet) {

                    if (error) return next(error);

                    if (!utilities.IsUndefined(mailRecordSet) && mailRecordSet.length > 0) {

                        intRecordID_Mail = mailRecordSet[0]['intRecordID'];

                        console.log("Found record in tblMail: intRecordID=" + intRecordID_Mail);

                        sqlHelper.GetMSSQLSelectQuery('telligent',
                            "select top 1 * from dbo.tblMailDetail where intRecordID_Mail = " + intRecordID_Mail, function (error, mailDetailRecordSet) {

                                if (error) return next(error);

                                if (!utilities.IsUndefined(mailDetailRecordSet) && mailDetailRecordSet.length > 0) {

                                    var intRecordID_MessengerCommunicationProvider = mailDetailRecordSet[0]['intRecordID_MessengerCommunicationProvider'];

                                    intRecordID_MailDetail = mailDetailRecordSet[0]['intRecordID'];
                                    intRecordID_MessengerConfiguration = '';
                                    intRecordID_DatabaseID = mailRecordSet[0]['intRecordID_DatabaseID'];
                                    intRecordID_Company = mailRecordSet[0]['intRecordID_Company'];
                                    intRecordID_Division = mailRecordSet[0]['intRecordID_Division'];

                                    txtDescription = deliveryDescription;
                                    mmoTransaction = JSON.stringify(jsonBody);

                                    console.log("Found record in tblMailDetail: intRecordID=" + intRecordID_MailDetail);

                                    var promises = [];

                                    if (intRecordID_MessengerCommunicationProvider !== null) {

                                        var scalerPromise1 = sqlHelper.GetMSSQLScalerValue('telligent',
                                            "select [intRecordID] from dbo.tblMessengerConfiguration where intRecordID_MessengerCommunicationProvider = "
                                            + intRecordID_MessengerCommunicationProvider).then(function (scalerResult) {

                                                if (!utilities.IsUndefined(scalerResult) && scalerResult.length > 0) {
                                                    intRecordID_MessengerConfiguration = scalerResult[0]["intRecordID"];
                                                }
                                            }).catch(function (e) {
                                                // error handle
                                                console.log(e);
                                                return next(e);
                                            });
                                        promises.push(scalerPromise1);
                                    }

                                    if (!utilities.IsUndefined(deliveryState)) {

                                        var scalerPromise2 = sqlHelper.GetMSSQLScalerValue('telligent',
                                            "select [intRecordID] from dbo.[tblMessengerDeliveryState] where [txtElectronicDataExchangeCode] = '" + deliveryState + "'").then(function (scalerResult) {

                                                if (!utilities.IsUndefined(scalerResult) && scalerResult.length > 0) {
                                                    intRecordID_MessengerDeliveryState = scalerResult[0]["intRecordID"];
                                                }
                                            }).catch(function (e) {
                                                // error handle
                                                console.log(e);
                                                return next(e);
                                            });
                                        promises.push(scalerPromise2);
                                    }
                                    if (!utilities.IsUndefined(deliveryCode)) {

                                        var scalerPromise3 = sqlHelper.GetMSSQLScalerValue('telligent',
                                            "select [intRecordID] from dbo.[tblMessengerDeliveryCode] where [txtElectronicDataExchangeCode] = '" + deliveryCode + "'").then(function (scalerResult) {

                                                if (!utilities.IsUndefined(scalerResult) && scalerResult.length > 0) {
                                                    intRecordID_MessengerDeliveryCode = scalerResult[0]["intRecordID"];
                                                }
                                            }).catch(function (e) {
                                                // error handle
                                                console.log(e);
                                                return next(e);
                                            });
                                        promises.push(scalerPromise3);
                                    }

                                    var maxRecordID = void (0); // undefined value

                                    var scalerPromise4 = sqlHelper.GetMSSQLScalerValue('telligent',
                                        "SELECT ISNULL((select TOP 1 isnull(([intRecordID]), 0) as 'MaxRecordID' from "
                                        + "dbo.[tblMessengerTransaction] ORDER BY intRecordID DESC), 0) as 'MaxRecordID'").then(function (scalerResult) {

                                            if (!utilities.IsUndefined(scalerResult) && scalerResult.length > 0) {
                                                maxRecordID = scalerResult[0]["MaxRecordID"];
                                            }
                                        }).catch(function (e) {
                                            // error handle
                                            console.log(e);
                                            return next(e);
                                        });
                                    promises.push(scalerPromise4);

                                    Promise.all(promises).then(function () {

                                        if (utilities.IsUndefined(maxRecordID))
                                            intRecordID = 1;
                                        else
                                            intRecordID = (maxRecordID + 1);

                                        if (direction === 'in') {
                                            ixtCode = "Inbound MMS Event from " + from;
                                        }
                                        else {
                                            ixtCode = "Outbound MMS Event to " + to;
                                        }

                                        var promises_insertLookups = [];

                                        if (intRecordID_MessengerDeliveryState === null && !utilities.IsUndefined(deliveryState)) {

                                            var promiseLookups_deliveryState = sqlHelper.ExecuteMsSqlInsertAutoID_LookupRecord(
                                                'telligent', '[dbo].[tblMessengerDeliveryState]', deliveryState, deliveryState, deliveryState,
                                                intRecordID_DatabaseID, intRecordID_Company, intRecordID_Division, { 'blnAuditTrail': 'Yes', 'intRecordID_Status': 4 },
                                                { 'blnSecurity': null, 'blnMakePrivate': null, 'blnEcommerceTransmit': null }).then(function (scalerResult) {

                                                    if (!utilities.IsUndefined(scalerResult) && scalerResult.length > 0) {
                                                        intRecordID_MessengerDeliveryState = scalerResult[0]["intRecordID"];

                                                        console.log("Inserted deliveryState=" + deliveryState + ",intRecordID=" + intRecordID_MessengerDeliveryState);
                                                    }
                                                }).catch(function (e) {
                                                    // error handle
                                                    console.log(e);
                                                    return next(e);
                                                });
                                            promises_insertLookups.push(promiseLookups_deliveryState);
                                        }
                                        if (intRecordID_MessengerDeliveryCode === null && !utilities.IsUndefined(deliveryCode)) {

                                            var promiseLookups_deliveryCode = sqlHelper.ExecuteMsSqlInsertAutoID_LookupRecord(
                                                'telligent', '[dbo].[tblMessengerDeliveryCode]', deliveryDescription, deliveryDescription, deliveryCode,
                                                intRecordID_DatabaseID, intRecordID_Company, intRecordID_Division, { 'blnAuditTrail': 'Yes', 'intRecordID_Status': 4 },
                                                { 'blnSecurity': null, 'blnMakePrivate': null, 'blnEcommerceTransmit': null }).then(function (scalerResult) {

                                                    if (!utilities.IsUndefined(scalerResult) && scalerResult.length > 0) {
                                                        intRecordID_MessengerDeliveryCode = scalerResult[0]["intRecordID"];

                                                        console.log("Inserted deliveryCode=" + deliveryCode + ",intRecordID=" + intRecordID_MessengerDeliveryCode);
                                                    }
                                                }).catch(function (e) {
                                                    // error handle
                                                    console.log(e);
                                                    return next(e);
                                                });
                                            promises_insertLookups.push(promiseLookups_deliveryCode);
                                        }

                                        if (promises_insertLookups.length === 0) {

                                            var promise_void = new Promise(function (resolve, reject) {
                                                return resolve(true);
                                            }).then(function (scalerResult) {

                                            });
                                            promises_insertLookups.push(promise_void);
                                        }

                                        Promise.all(promises_insertLookups).then(function () {

                                            var dteRecordCreationDate = dateFormat(date, 'yyyy-mm-dd HH:MM:ss');

                                            /* START: Insert Operation */
                                            /* set required data to be inserted */
                                            var insertData = {
                                                'intRecordID': intRecordID,
                                                'ixtCode': ixtCode,
                                                'txtDescription': txtDescription,
                                                'intRecordID_DatabaseID': intRecordID_DatabaseID,
                                                'intRecordID_Company': intRecordID_Company,
                                                'intRecordID_Division': intRecordID_Division,
                                                'intRecordID_Mail': intRecordID_Mail,
                                                'intRecordID_MailDetail': intRecordID_MailDetail,
                                                'intRecordID_MessengerConfiguration': intRecordID_MessengerConfiguration,
                                                'intRecordID_MessengerCommunicationProvider': intRecordID_MessengerCommunicationProvider,
                                                'intRecordID_MessengerDeliveryState': intRecordID_MessengerDeliveryState,
                                                'intRecordID_MessengerDeliveryCode': intRecordID_MessengerDeliveryCode,
                                                'mmoTransaction': mmoTransaction,
                                                'txtRecordCreationUser': 'SMSEventCallback',
                                                'dteRecordCreationDate': dteRecordCreationDate,
                                                'blnMakePrivate': 'No',
                                                'blnActive': 'Yes',
                                                'blnDeleted': 'No',
                                                'blnAttachment': 'No',
                                                'blnHighlight': 'No',
                                                'blnMemo': 'No',
                                                'blnProcess': 'No',
                                                'blnProject': 'No',
                                                'blnWebSearch': 'No',
                                                'blnEcommerceTransmit': 'No',
                                                'blnSecurity': 'No',
                                                'txtGUID': uuidv1()
                                            };

                                            var sqlInsertQuery_tblMessengerTransaction = sqlHelper.GetSQLInsertTableLockXAutoIDQuery('dbo.tblMessengerTransaction', insertData, 'intRecordID');

                                            var succeeded1 = void (0);
                                            var succeeded2 = void (0);
                                            var succeeded3 = void (0);
                                            var promises_InsUpdates = [];
                                            var insertPromise = sqlHelper.GetMSSQLScalerValue('telligent', sqlInsertQuery_tblMessengerTransaction).then(function (scalarResult) {

                                                if (!utilities.IsUndefined(scalarResult) && scalarResult.length > 0) {

                                                    var myIntRecordID = scalarResult[0]['intRecordID'];

                                                    if (myIntRecordID !== null)
                                                        succeeded1 = true;

                                                    console.log("Inserted tblTransaction: intRecordID=" + myIntRecordID);
                                                }
                                                else {
                                                    succeeded1 = false;
                                                }
                                            }).catch(function (error) {
                                                // error handle
                                                console.log(error);
                                                return next(error);
                                            });
                                            promises_InsUpdates.push(insertPromise);
                                            /* END: Insert Operation */

                                            /* START: Update Operation */
                                            var mailStatus = 1;

                                            if ((deliveryState === 'Waiting') || (deliveryState === 'Queued')
                                                || (deliveryState === 'Sending')) {
                                                mailStatus = 1;
                                            }
                                            else if ((deliveryState === 'Sent') || (deliveryState === 'Delivered')) {
                                                mailStatus = 2;
                                            }
                                            else if ((deliveryState === 'Not-delivered') || (deliveryState === 'Error')) {
                                                mailStatus = 3;
                                            }

                                            var updateMailData = {
                                                'intRecordID_MailStatus': mailStatus
                                            };
                                            var updateMailWhereData = {
                                                'intRecordID': intRecordID_Mail
                                            };

                                            var updateMailDetailData = {
                                                'intRecordID_MessengerDeliveryCode': intRecordID_MessengerDeliveryCode,
                                                'intRecordID_MessengerDeliveryState': intRecordID_MessengerDeliveryState,
                                                'intRecordID_MailStatus': mailStatus
                                            };
                                            var updateMailDetailWhereData = {
                                                'intRecordID': intRecordID_MailDetail
                                            };

                                            var sqlUpdateQuery_Mail = sqlHelper.GetSQLUpdateTableLockXQuery('[dbo].[tblMail]',
                                                updateMailData, updateMailWhereData);

                                            var sqlUpdateQuery_MailDetail = sqlHelper.GetSQLUpdateTableLockXQuery('[dbo].[tblMailDetail]',
                                                updateMailDetailData, updateMailDetailWhereData);

                                            var updateMailPromise = sqlHelper.ExecuteNonMSSQLQuery('telligent', sqlUpdateQuery_Mail).then(function (resultData) {

                                                if (!utilities.IsUndefined(resultData)) {
                                                    var rowsAffected = resultData['rowsAffected'][0];

                                                    if (rowsAffected > 0)
                                                        succeeded2 = true;

                                                    console.log("Updated tblMail, rowsAffected=" + rowsAffected);
                                                }
                                                else {
                                                    response.status(401).end();
                                                }
                                            }).catch(function (error) {
                                                // error handle
                                                console.log(error);
                                                return next(error);
                                            });
                                            promises_InsUpdates.push(updateMailPromise);
                                            var updateMailDetailPromise = sqlHelper.ExecuteNonMSSQLQuery('telligent', sqlUpdateQuery_MailDetail).then(function (resultData) {

                                                if (!utilities.IsUndefined(resultData)) {
                                                    var rowsAffected = resultData['rowsAffected'][0];

                                                    if (rowsAffected > 0)
                                                        succeeded3 = true;

                                                    console.log("Updated tblMailDetail, rowsAffected=" + rowsAffected);
                                                }
                                                else {
                                                    response.status(401).end();
                                                }
                                            }).catch(function (error) {
                                                // error handle
                                                console.log(error);
                                                return next(error);
                                            });
                                            promises_InsUpdates.push(updateMailDetailPromise);
                                            /* END: Update Operation */

                                            Promise.all(promises_InsUpdates).then(function () {

                                                if (!utilities.IsUndefined(succeeded1) && !utilities.IsUndefined(succeeded2)
                                                    && !utilities.IsUndefined(succeeded3)) {

                                                    console.log('{ Result: Success }');
                                                    response.status(200).end("{ Result: Success }")
                                                }
                                                else {

                                                    console.log('{ Result: Failed }');
                                                    response.status(201).end("{ Result: Failed }");
                                                }
                                            });
                                        });
                                    });
                                }

                            });
                    }
                });
        };
    });

};

module.exports = {
    RegisterGetMMSEventRoute: getMMSEventRoute,
    RegisterPostMMSEventRoute: postMMSEventRoute
};