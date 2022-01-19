'use strict'

var sqlHelper = require('./Utils/sqlHelper');
var dateFormat = require('dateformat');
var utilities = require('./Utils/utilities');

function tdsSelectQueryTest() {

    sqlHelper.GetTDSSelectQuery('telligent',
        "select top 1 * from [dbo].[tblMail]", function (error, mailRecordSet) {

            if (error)
                console.log(error);
            else
                console.log(mailRecordSet);
        });
}

function msSqlGetScalerValueTest() {

    var maxRecordID = void (0);

    var scalerPromise = sqlHelper.GetMSSQLScalerValue('telligent',
        "select isnull( max([intRecordID]), 0) as 'MaxRecordID' from dbo.[tblMail]").then(function (scalerResult) {

            if (scalerResult) {
                maxRecordID = scalerResult[0]["MaxRecordID"];
            }
        }).catch(function (error) {
            if (error)
                console.log(error);
        });

    Promise.resolve(scalerPromise);
}

function msSqlSelectQueryTest() {

    sqlHelper.GetMSSQLSelectQuery('telligent',
        "select top 1 * from [dbo].[tblMail]", function (error, mailRecordSet) {

            if (error)
                console.log(error);
            else
                console.log(mailRecordSet);
        });
}

function msSqlExecuteNonQueryTest() {

}

function msSqlQueryBuildTest() {

    var intRecordID = 4;
    var ixtCode = 'Incoming SMS Event from +19415804593';
    var txtDescription = 'Incoming SMS Event from +19415804593';
    var intRecordID_DatabaseID = 1;
    var intRecordID_Company = 5;
    var intRecordID_Division = 13;
    var intRecordID_Mail = 28504;
    var intRecordID_MailDetail = 54390;
    var intRecordID_MessengerConfiguration = 1;
    var intRecordID_MessengerDeliveryState = 1; 'Received=1,Queued=2,Sending=3,Sent=4,Error=5'
    var intRecordID_MessengerDeliveryCode = 1; ' Message delivered to carrier'
    var mmoTransaction = '';

    var date = new Date();
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
        'blnSecurity': 'No'
    };

    var updateData = {
        'mmoBody': 'Hello updated by NodeJs Test Code'
    };

    var updateWhereClauseData = {
        'txtMessageID': 'm-wnbqotddpcm7ijboconi75i'
    };

    var deleteWhereClauseData = {
        'intRecordID': 1
    };

    var sqlInsertQuery = sqlHelper.GetSQLInsertQuery('[dbo].[tblMessengerTransaction]', insertData);
    var sqlUpdateQuery = sqlHelper.GetSQLUpdateQuery('[dbo].[tblMail]', updateData, updateWhereClauseData);
    var sqlDeleteQuery = sqlHelper.GetSQLDeleteQuery('[dbo].[tblMessengerTransaction', deleteWhereClauseData);

    console.log("msSqlQueryBuildTest: ");
    console.log("---------------------");
    console.log("");
    console.log("Insert Query: " + sqlInsertQuery);
    console.log("");
    console.log("Update Query: " + sqlUpdateQuery);
    console.log("");
    console.log("Delete Query: " + sqlDeleteQuery);
    console.log("");
}

function msSqlAutoIncrementQueryTest() {

    var intRecordID = void (0);

    var insertData = {
        'intRecordID': 0,
        'SomeColumn1': 'Some value'
    }

    var sqlQuery = sqlHelper.GetSQLInsertTableLockXAutoIDQuery('dbo.SomeTable', insertData, 'intRecordID');

    var scalerPromise = sqlHelper.GetMSSQLScalerValue('telligent', sqlQuery)
        .then(function (scalerResult) {

            if (!utilities.IsUndefined(scalerResult) && scalerResult.length > 0) {
                intRecordID = scalerResult[0]["intRecordID"];
            }
        }).catch(function (error) {
            if (error)
                console.log(error);
        });

    Promise.all(scalerPromise);
}

function msSqlAutoIncrementExistCheckQueryTest() {

    var intRecordID = void (0);

    var insertData = {
        'intRecordID': 0,
        'SomeColumn1': 'Some value'
    }

    var sqlQuery = sqlHelper.GetSQLInsertTableLockXAutoIDExistCheckQuery('dbo.SomeTable', insertData, 'intRecordID', 'SomeColumn1', insertData['SomeColumn1']);

    var scalerPromise = sqlHelper.GetMSSQLScalerValue('telligent', sqlQuery)
        .then(function (scalerResult) {

            if (!utilities.IsUndefined(scalerResult) && scalerResult.length > 0) {
                intRecordID = scalerResult[0]["intRecordID"];
            }
        }).catch(function (error) {
            if (error)
                console.log(error);
        });

    Promise.all(scalerPromise);
}

module.exports = {
    TDSSelectQueryTest: tdsSelectQueryTest,
    MsSqlGetScalerValueTest: msSqlGetScalerValueTest,
    MsSqlSelectQueryTest: msSqlSelectQueryTest,
    MsSqlExecuteNonQueryTest: msSqlExecuteNonQueryTest,
    MsSqlQueryBuildTest: msSqlQueryBuildTest,
    MsSqlAutoIncrementQueryTest: msSqlAutoIncrementQueryTest,
    MsSqlAutoIncrementExistCheckQueryTest: msSqlAutoIncrementExistCheckQueryTest
};