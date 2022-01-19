

'use strict';

var express = require('express');
var Client = require('node-rest-client').Client;

var queryStringUtils = require('querystring');
var utilsGetTokenAndSecret = require('../../utils/authenticationHeaderUtils');

//// This module is incomplete right now, but we can still
//// code and test without it. Hooray!
//var messages = require('./messages');

function getMessages(app) {

    var route = express.Router();

    // Mount route as "/v1/users"
    app.use('/v1/users', route);

    /* GET users phone numbers. */
    route.get('/:userId/messages', function (request, response, next) {

        var url = require('url');
        var url_parts = url.parse(request.url, true);
        var queryStringParts = url_parts.query;

        var authHeader = utilsGetTokenAndSecret.getApiAuthHeader(request);
        var arrAuthHeaderItems = utilsGetTokenAndSecret.getTokenAndSecret(request);

        var userId = request.params.userId;
        var apiToken = arrAuthHeaderItems[0];
        var apiSecret = arrAuthHeaderItems[1];
        var from = '';
        var to = '';
        var fromDateTime = '';
        var toDateTime = '';
        var size = '';
        var direction = '';
        var state = '';
        var deliveryState = '';
        var sortOrder = '';

        if (queryStringParts['from'])
            from = queryStringParts['from'];
        if (queryStringParts['to'])
            to = queryStringParts['to'];
        if (queryStringParts['fromDateTime'])
            fromDateTime = queryStringParts['fromDateTime'];
        if (queryStringParts['toDateTime'])
            toDateTime = queryStringParts['toDateTime'];
        if (queryStringParts['size'])
            size = queryStringParts['size'];
        if (queryStringParts['direction'])
            direction = queryStringParts['direction'];
        if (queryStringParts['state'])
            state = queryStringParts['state'];
        if (queryStringParts['deliveryState'])
            deliveryState = queryStringParts['deliveryState'];
        if (queryStringParts['sortOrder'])
            sortOrder = queryStringParts['sortOrder'];

        // List of parameters
        var params = {};

        if (from)
            params["from"] = from;
        if (to)
            params["to"] = to;
        if (fromDateTime)
            params["fromDateTime"] = fromDateTime;
        if (toDateTime)
            params["toDateTime"] = toDateTime;
        if (size)
            params["size"] = size;
        if (direction)
            params["direction"] = direction;
        if (state)
            params["state"] = state;
        if (deliveryState)
            params["deliveryState"] = deliveryState;
        if (sortOrder)
            params["sortOrder"] = sortOrder;

        var args = {
            path: { "userId": userId }, // path substitution var
            parameters: params, // this is serialized as URL parameters
            headers: {
                "Accept": "application/json",
                "User-Agent": "csharp-bandwidth/v1.0",
                "Authorization": authHeader
            } // request headers
        };

        //console.log("From Dtm: " + params["fromDateTime"]);
        //console.log("");

        var client = new Client();

        // HTTP GET
        client.get("https://api.catapult.inetwork.com/v1/users/${userId}/messages", args, function (data, responseInner) {

            //// parsed response body as js object
            //console.log("getMessages Json Response: ");
            //console.log(data);
            //console.log("");
            ////// raw response
            ////console.log(response);

            return response.json(data);
        }).on('error', function (error) {
            console.log('something went wrong on the request', error.request.options);
            if (error) return next(error);
        });

        // handling specific req2 errors
        client.on('error', function (error) {
            console.log('something went wrong on req2!!', error.request.options);
            if (error) return next(error);
        });
    });
};

function sendSingleMessage(app) {

    var route = express.Router();

    // Mount route as "/v1/users"
    app.use('/v1/users', route);

    /* GET users phone numbers. */
    route.post('/:userId/messages', function (request, response, next) {

        var url = require('url');
        var url_parts = url.parse(request.url, true);
        var queryStringParts = url_parts.query;

        var authHeader = utilsGetTokenAndSecret.getApiAuthHeader(request);
        var arrAuthHeaderItems = utilsGetTokenAndSecret.getTokenAndSecret(request);

        var userId = request.params.userId;
        var apiToken = arrAuthHeaderItems[0];
        var apiSecret = arrAuthHeaderItems[1];
        var from = '';
        var to = '';
        var text = '';
        var media = '';
        var receiptRequested = '';
        var callbackUrl = '';
        var callbackHttpMethod = '';
        var callbackTimeout = '';
        var fallbackUrl = '';
        var tag = '';

        if (request.method === 'POST') {

            var jsonBody = request.body;

            if (jsonBody['from'])
                from = jsonBody['from'];
            if (jsonBody['to'])
                to = jsonBody['to'];
            if (jsonBody['text'])
                text = jsonBody['text'];
            if (jsonBody['media'])
                media = jsonBody['media'];
            if (jsonBody['receiptRequested'])
                receiptRequested = jsonBody['receiptRequested'];
            if (jsonBody['callbackUrl'])
                callbackUrl = jsonBody['callbackUrl'];
            if (jsonBody['callbackHttpMethod'])
                callbackHttpMethod = jsonBody['callbackHttpMethod'];
            if (jsonBody['callbackTimeout'])
                callbackTimeout = jsonBody['callbackTimeout'];
            if (jsonBody['fallbackUrl'])
                fallbackUrl = jsonBody['fallbackUrl'];
            if (jsonBody['tag'])
                tag = jsonBody['tag'];

            // List of parameters
            var params = {};

            if (from)
                params["from"] = from;
            if (to)
                params["to"] = to;
            if (text)
                params["text"] = text;
            if (media)
                params["media"] = media;
            if (receiptRequested)
                params["receiptRequested"] = receiptRequested;
            if (callbackUrl)
                params["callbackUrl"] = callbackUrl;
            if (callbackHttpMethod)
                params["callbackHttpMethod"] = callbackHttpMethod;
            if (callbackTimeout)
                params["callbackTimeout"] = callbackTimeout;
            if (fallbackUrl)
                params["fallbackUrl"] = fallbackUrl;
            if (tag)
                params["tag"] = tag;

            var args = {
                path: { "userId": userId }, // path substitution var
                //parameters: {}, // this is serialized as URL parameters
                data: params,
                headers: {
                    "Accept": "application/json",
                    "User-Agent": "csharp-bandwidth/v1.0",
                    "Authorization": authHeader,
                    "Content-Type": "application/json; charset=utf-8"
                } // request headers
            };

            console.log("");
            console.log("sendSingleMessage: ");
            console.log("Request: ");
            //console.log("Request.jsonBody" + jsonBody);
            //console.log("args " + args);
            //console.log("Request Json Body: " + params);
            //console.log("");
            console.log("Paramater: " + JSON.stringify(params));
            //console.log("");

            var client = new Client();

            // HTTP POST
            client.post("https://api.catapult.inetwork.com/v1/users/${userId}/messages", args, function (data, responseInner) {

                console.log("Response: ");
                //console.log("Headers: " + responseInner.headers);
                //console.log("RawHeaders: " + responseInner.rawHeaders);
                //console.log("typeof RawHeaders: ", typeof responseInner.rawHeaders);
                console.log("StatusCode: " + responseInner.statusCode);
                console.log("StatusMessage: " + responseInner.statusMessage);
                //console.log("");

                if (responseInner.statusCode === '400')
                    responseInner.status(400).end();

                var location = null;
                var locationParts = null;

                var headers = responseInner.headers;
                var rawHeaders = new String(responseInner.rawHeaders);
                var rawHeadersParts = rawHeaders.split(',');

                //console.log("rawHeadersParts: ", rawHeadersParts);
                //console.log("");

                if (headers['location']) {
                    location = new String(headers['location']);
                    locationParts = location.split('/');
                }
                else {
                    location = new String(rawHeadersParts[21]);
                    locationParts = location.split('/');
                }

                //console.log("location: " + location);
                //console.log("locationParts: " + locationParts);
                //console.log("");

                if (locationParts === 'undefined')
                    response.status(404).end();

                var messageId = locationParts[(locationParts.length - 1)];

                //// parsed response body as js object
                //console.log("sendSingleMessage Json Response: ");
                console.log("MessageId: " + messageId);
                console.log("");
                //// raw response
                //console.log(response);

                response.setHeader('location', location);
                response.end();
            }).on('error', function (error) {
                console.log('something went wrong on the request', error.request.options);
                if (error) return next(error);
            });

            // handling specific req2 errors
            client.on('error', function (error) {
                console.log('something went wrong on req2!!', error.request.options);
                if (error) return next(error);
            });
        }
        else {
            var emptyArray = new Array(0);

            return response.status(404).json(emptyArray);
        }
    });
};

module.exports = {
    RegisterGetMessagesRoute: getMessages,
    RegisterSendSingleMessageRoute: sendSingleMessage
};