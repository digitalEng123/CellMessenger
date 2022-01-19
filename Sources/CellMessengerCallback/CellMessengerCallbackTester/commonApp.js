'use strict'

var sqlHelper = require("./Utils/sqlHelper")
var utilities = require('./Utils/utilities');
var deasync = require('deasync');

global.messageRoute = void (0);

function getServerRootUrl() {

    var rtnServerRoute = void (0);

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
                    rtnServerRoute = 'http://teknicaitg.com:1339';
                else {

                    var url = require('url');
                    var url_parts = url.parse(scalerValue_CallbackUrl, true);
                    var fullServerRoute = '';

                    fullServerRoute = url_parts.protocol + "\/\/" + url_parts.host;

                    rtnServerRoute = fullServerRoute;
                }
            }
            else {
                rtnServerRoute = "http://teknicaitg.com:1339"
            }
        });

    }, 6000);
    while (utilities.IsUndefined(rtnServerRoute)) {
        deasync.runLoopOnce();
    }

    return rtnServerRoute;
}

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

function getLocalServerRootUrl(port) {

    return 'http://localhost' + ':' + port;
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

function getCallbackRootUri(route) {

    return 'http://TEKNICAitg.com:1339/' + route;
    //return "http://TEKNICAitg.com:1339/telligent/SoftwareApplicationServer/ROCKETMessenger/Bandwidth/Callback/" + route;
}

function getServerRootUri(route) {

    return 'http://localhost:1339/' + route;
    //return "http://TEKNICAitg.com:1339/" + route;
}

function getServerAttachmentUri(route) {

    return 'http://TEKNICAitg.com/Telligent/Attachment/' + route;
}

function getBandwidthRouteUri(route) {

    return 'https://api.catapult.inetwork.com/' + route;
}

function getBandwidthMediaUri(userId, mediaFileName) {

    return 'https://api.catapult.inetwork.com/v1/users/' + userId + '/media/' + mediaFileName;
}

module.exports = {
    GetServerRootUrl: getServerRootUrl,
    GetServerPort: getServerPort,
    GetLocalServerRootUrl: getLocalServerRootUrl,
    GetMessagesRoute: getMessagesRoute,
    GetCallbackRootUri: getCallbackRootUri,
    GetServerRootUri: getServerRootUri,
    GetServerAttachmentUri: getServerAttachmentUri,
    GetBandwidthRouteUri: getBandwidthRouteUri,
    GetBandwidthMediaUri: getBandwidthMediaUri
};