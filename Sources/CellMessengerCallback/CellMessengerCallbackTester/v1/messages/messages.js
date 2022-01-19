'use strict'

var Client = require('node-rest-client').Client;

var commonApp = require('../../commonApp');

function getMessagesTest() {

    var client = new Client();

    var daysToAdd = 20;
    var dt24HoursAgo = new Date();
    var dt24HoursAgoString = '';

    dt24HoursAgo.setDate(dt24HoursAgo.getDate() - daysToAdd);

    dt24dt24HoursAgoString = dt24HoursAgo.toISOString();

    var args = {
        path: { "userId": "u-z5xcq76busoph25v4qus4zq" }, // path substitution var
        parameters: { to: "19095792299", direction: "In", fromDateTimeUTC: dt24dt24HoursAgoString }, // this is serialized as URL parameters
        headers: {
            "Accept": "application/json",
            "User-Agent": "csharp-bandwidth/v1.0",
            "Authorization": "Basic dC1xeHJuY3l5bXp2NmlpYW5iY3hvamVqeTozN2hncG9vZXp5Y3N3aDJtMzNlYXNmdG14YXN5bWo2aGdsZ3U1Mnk="
        } // request headers
    };

    //// HTTP GET
    //// registering remote methods
    //client.registerMethod("jsonMethod", "http://localhost:1337/v1/users/${userId}/messages", "Get");
    //client.registerMethod("jsonMethod", "https://api.catapult.inetwork.com/v1/users/${userId}/messages", "Get");

    //client.registerMethod("jsonMethod", commonApp.GetServerRootUri('v1/users/${userId}/messages'), "Get");
    client.registerMethod("jsonMethod", commonApp.GetBandwidthRouteUri('v1/users/${userId}/messages'), "Get");

    client.methods.jsonMethod(args, function (data, response) {
        // parsed response body as js object
        console.log(data);
        //// raw response
        //console.log(response);

        //response.render('index', { title: 'Messages Json', message: response.json(data) });
    }).on('error', function (err) {
        console.log('something went wrong on the request', err.request.options);
    });

    // handling specific req2 errors
    client.on('error', function (err) {
        console.log('something went wrong on req2!!', err.request.options);
    });
};

function sendSingleMessagesTest() {

    var client = new Client();

    var smsMessage = {
        from: "19095792299",
        to: "19415804593",
        text: "Hello from NodeJs tester!"
    };

    // http://www.TEKNICAitg.com:1339/telligent/SoftwareApplicationServer/ROCKETMessenger/Bandwidth/Callback/v1/messages/smsevent
    var mmsMessage = {
        from: "19095792299",
        to: "19415804593",
        text: "Hello from NodeJs tester!",
        media: [
            "http://TEKNICAitg.com/Telligent/Attachment/PersonSmall.jpg",
            "http://TEKNICAitg.com/Telligent/images/StyleGunmetal/Icon/Audit.gif"
        ],
        callbackUrl: "http://TEKNICAitg.com:1339/telligent/SoftwareApplicationServer/ROCKETMessenger/Bandwidth/Callback/v1/messages/smsevent"
    };

    var args = {
        path: { "userId": "u-z5xcq76busoph25v4qus4zq" }, // path substitution var
        data: { from: "19095792299", to: "19415804593", text: "Hello from NodeJs tester!" }, // this is serialized as URL parameters
        headers: {
            "Accept": "application/json",
            "User-Agent": "csharp-bandwidth/v1.0",
            "Authorization": "Basic dC1xeHJuY3l5bXp2NmlpYW5iY3hvamVqeTozN2hncG9vZXp5Y3N3aDJtMzNlYXNmdG14YXN5bWo2aGdsZ3U1Mnk=",
            "Content-Type": "application/json; charset=utf-8"
        } // request headers
    };

    //// HTTP POST
    //// registering remote methods
    //client.registerMethod("jsonMethod", "http://localhost:1337/v1/users/${userId}/messages", "Post");
    //client.registerMethod("jsonMethod", "https://api.catapult.inetwork.com/v1/users/${userId}/messages", "Post");

    //client.registerMethod("jsonMethod", commonApp.GetServerRootUri('v1/users/${userId}/messages'), "Post");
    client.registerMethod("jsonMethod", commonApp.GetBandwidthRouteUri('v1/users/${userId}/messages'), "Post");

    client.methods.jsonMethod(args, function (data, response) {
        console.log("");
        console.log("sendSingleMessage Response Object: ");
        console.log("Headers: " + response.headers);
        console.log("RawHeaders: " + response.rawHeaders);
        console.log("typeof RawHeaders: ", typeof response.rawHeaders);
        console.log("StatusCode: " + response.statusCode);
        console.log("StatusMessage: " + response.statusMessage);
        console.log("");

        var location = null;
        var locationParts = null;

        var headers = response.headers;
        var rawHeaders = new String(response.rawHeaders);
        var rawHeadersParts = rawHeaders.split(',');

        //console.log("rawHeadersParts: ", rawHeadersParts);
        //console.log("");

        if (headers["location"]) {
            location = new String(headers["location"]);
            locationParts = location.split('/');
        }
        else {
            location = new String(rawHeadersParts[21]);
            locationParts = location.split('/');
        }

        console.log("location: " + location);
        console.log("locationParts: " + locationParts);
        console.log("");

        if (locationParts === 'undefined')
            response.status(400).end();

        var messageId = locationParts[(locationParts.length - 1)];

        // parsed response body as js object
        console.log("MessageId: " + messageId);
        console.log("");
        //// raw response
        //console.log(response);		
    }).on('error', function (err) {
        console.log('something went wrong on the request', err.request.options);
    });

    // handling specific req2 errors
    client.on('error', function (err) {
        console.log('something went wrong on req2!!', err.request.options);
    });
};

module.exports = {
    GetMessagesTest: getMessagesTest,
    SendSingleMessagesTest: sendSingleMessagesTest
};