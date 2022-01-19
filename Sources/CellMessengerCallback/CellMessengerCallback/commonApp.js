'use strict'

var sqlHelper = require("./Utils/sqlHelper")
var utilities = require('./Utils/utilities');
var deasync = require('deasync');

global.messageRoute = void (0);

function getServerPort() {

    var rtnServerPort = void (0);

    setTimeout(function () {

        var sqlQuery = 'select top 1 p.[mmoProviderAttachmentCallbackURL] as "CallbackUrl" '
            + 'from dbo.tblMessengerConfiguration c '
            + 'inner join dbo.tblMessengerCommunicationProvider p '
            + 'on c.[intRecordID_MessengerCommunicationProvider] '
            + '= p.[intRecordID]';

        var scalerValue_CallbackUrl = void (0);

        sqlHelper.GetMSSQLScalerValueVIACallback("telligent", sqlQuery, function (error, scalerResult) {

            if (!utilities.IsUndefined(scalerResult) && scalerResult.length > 0) {

                scalerValue_CallbackUrl = scalerResult[0]["CallbackUrl"];

                if (utilities.IsUndefined(scalerValue_CallbackUrl))
                    rtnServerPort = 1339;
                else {

                    var url = require('url');
                    var url_parts = url.parse(scalerValue_CallbackUrl, true);
                    var fullServerPort = 0;

                    if (!utilities.IsUndefined(url_parts.port))
                        fullServerPort = url_parts.port;
                    else
                        fullServerPort = 1339;

                    rtnServerPort = fullServerPort;
                }
            }
            else {
                rtnServerPort = 1339;
            }
        });

    }, 6000);
    while (utilities.IsUndefined(rtnServerPort)) {
        deasync.runLoopOnce();
    }

    return rtnServerPort;
}

function getMessagesRoute() {

    var rtnMessageRoute = void (0);

    setTimeout(function () {

        var sqlQuery = 'select top 1 p.[mmoProviderAttachmentCallbackURL] as "CallbackUrl" '
            + 'from dbo.tblMessengerConfiguration c '
            + 'inner join dbo.tblMessengerCommunicationProvider p '
            + 'on c.[intRecordID_MessengerCommunicationProvider] '
            + '= p.[intRecordID]';

        var scalerValue_CallbackUrl = void (0);

        sqlHelper.GetMSSQLScalerValueVIACallback("telligent", sqlQuery, function (error, scalerResult) {

            if (!utilities.IsUndefined(scalerResult) && scalerResult.length > 0) {

                scalerValue_CallbackUrl = scalerResult[0]["CallbackUrl"];

                if (utilities.IsUndefined(scalerValue_CallbackUrl))
                    rtnMessageRoute = '/v1/messages';
                else {

                    var url = require('url');
                    var url_parts = url.parse(scalerValue_CallbackUrl, true);
                    var fullMessageRoute = '';

                    if (url_parts.path.endsWith("\/"))
                        fullMessageRoute = url_parts.path + "v1/messages";
                    else
                        fullMessageRoute = url_parts.path + "/v1/messages";

                    rtnMessageRoute = fullMessageRoute;
                }
            }
            else {
                rtnMessageRoute = '/telligent/SoftwareApplicationServer/ROCKETMessenger/Bandwidth/Callback/v1/messages'; // "/v1/Messages"
            }
        });

    }, 6000);
    while (utilities.IsUndefined(rtnMessageRoute)) {
        deasync.runLoopOnce();
    }

    return rtnMessageRoute;
}

module.exports = {
    GetServerPort: getServerPort,
    GetMessagesRoute: getMessagesRoute
};