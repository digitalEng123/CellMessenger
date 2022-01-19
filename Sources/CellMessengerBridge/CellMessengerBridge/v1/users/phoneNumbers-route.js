

'use strict';

var express = require('express');
var Client = require('node-rest-client').Client;

var queryStringUtils = require('querystring');
var utilsGetTokenAndSecret = require('../../utils/authenticationHeaderUtils');

//// This module is incomplete right now, but we can still
//// code and test without it. Hooray!
//var phoneNumbers = require('./phoneNumbers');

function getPhoneNumbers(app) {

    var route = express.Router();

    // Mount route as "/v1/users"
    app.use('/v1/users', route);

    /* GET users phone numbers. */
    route.get('/:userId/phoneNumbers', function (request, response, next) {

        var url = require('url');
        var url_parts = url.parse(request.url, true);
        var queryStringParts = url_parts.query;

        var authHeader = utilsGetTokenAndSecret.getApiAuthHeader(request);
        var arrAuthHeaderItems = utilsGetTokenAndSecret.getTokenAndSecret(request);

        var userId = request.params.userId;
        var apiToken = arrAuthHeaderItems[0];
        var apiSecret = arrAuthHeaderItems[1];
        var size = '';
        var name = '';
        var applicationId = '';
        var state = '';
        var city = '';
        var numberState = '';

        if (queryStringParts['size'])
            size = queryStringParts['size'];
        if (queryStringParts['name'])
            name = queryStringParts['name'];
        if (queryStringParts['applicationId'])
            applicationId = queryStringParts['applicationId'];
        if (queryStringParts['state'])
            state = queryStringParts['state'];
        if (queryStringParts['city'])
            city = queryStringParts['city'];
        if (queryStringParts['numberState'])
            numberState = queryStringParts['numberState'];

        // List of parameters
        var params = {};

        params["size"] = size;

        if (name)
            params["name"] = name;
        if (applicationId)
            params["applicationId"] = applicationId;
        if (state)
            params["state"] = state;
        if (city)
            params["city"] = city;
        if (numberState)
            params["numberState"] = numberState;

        var args = {
            path: { "userId": userId }, // path substitution var
            parameters: params, // this is serialized as URL parameters
            headers: {
                "Accept": "application/json",
                "User-Agent": "csharp-bandwidth/v1.0",
                "Authorization": authHeader
            } // request headers
        };

        var client = new Client();

        // HTTP GET        
        client.get("https://api.catapult.inetwork.com/v1/users/${userId}/phoneNumbers", args, function (data, responseInner)
		{
            //// parsed response body as js object			
			//console.log("getPhoneNumbers Json Response: ");
            //console.log(data);
			//console.log("");
            //// raw response
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

module.exports = {
    RegisterGetPhoneNumbersRoute: getPhoneNumbers
};