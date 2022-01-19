'use strict'

var Client = require('node-rest-client').Client;

var commonApp = require('../../commonApp');

function getMMSEventTest() {

    var client = new Client();

    var daysToAdd = 20;
    var dt24HoursAgo = new Date();
    var dt24HoursAgoString = '';

    dt24HoursAgo.setDate(dt24HoursAgo.getDate() - daysToAdd);

    dt24dt24HoursAgoString = dt24HoursAgo.toISOString();

    var args = {
        headers: {
            "Content-Type": "application/json",
            "User-Agent": "BandwidthAPI/v1"
        } // request headers
    };

    //// HTTP GET
    //// registering remote methods
    // client.registerMethod("jsonMethod", "http://localhost:1339/v1/messages/mmsEvent", "Get");
    //client.registerMethod("jsonMethod", "http://TEKNICAitg.com:1339/v1/messages/mmsEvent", "Get");

    var serverPort = commonApp.GetServerPort();

    var serverAndMessageRoute = commonApp.GetLocalServerRootUrl(serverPort) + commonApp.GetMessagesRoute();
    //var serverAndMessageRoute = commonApp.GetServerRootUrl() + commonApp.GetMessagesRoute();
    var serverAndMessageRouteAndMethod = serverAndMessageRoute + '/mmsEvent';

    client.registerMethod("jsonMethod", serverAndMessageRouteAndMethod, "Get");
    //client.registerMethod("jsonMethod", commonApp.GetServerRootUri('v1/messages/mmsEvent'), "Get");

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

function postMMSEventTest() {

    var client = new Client();

    // Example: Incoming SMS Event
    var params_inBoundMMSEvent = {
        "eventType": "mms",
        "to": "+19095792299",
        "from": "+19415804593",
        "time": "2012-11-14T16:13:06.076Z",
        "text": "Example",
        "direction": "in",
        "applicationId": "a-rj7jf3fz7teaqupveqpug3i",
        "state": "received",
        "messageId": "m-wnbqotddpcm7ijboconi75i",        
        "media": [
            "https://api.catapult.inetwork.com/v1/users/{user-id}/media/A3087419-73C2-4A03-BB39-06BF3B1C240F-m-dr4mcch2wfb6frcls677glq.jpg",
            "https://api.catapult.inetwork.com/v1/users/{user-id}/media/123_1-m-dr4mcch2wfb6frcls677glq.smil"
        ],
        "messageUri": "https://api.catapult.inetwork.com/v1/users/{userId}/messages/{messageId}"        
    };

    // Example: Outgoing SMS with Delivery Request Event
    var params_outgoingMMSEvent = {
        "eventType": "mms",                
        "to": "+19415804593",
        "from": "+19095792299",
        "time": "2012-11-14T16:13:06.076Z",
        "text": "Example",
        "direction": "out",
        "applicationId": "a-rj7jf3fz7teaqupveqpug3i",
        "state": "sent",
        "messageId": "m-wnbqotddpcm7ijboconi75i",
        "media": [
            "https://api.catapult.inetwork.com/v1/users/{user-id}/media/A3087419-73C2-4A03-BB39-06BF3B1C240F-m-dr4mcch2wfb6frcls677glq.jpg",
            "https://api.catapult.inetwork.com/v1/users/{user-id}/media/123_1-m-dr4mcch2wfb6frcls677glq.smil"
        ],
        "messageUri": "https://api.catapult.inetwork.com/v1/users/{userId}/messages/{messageId}",
    };

    // Example: Outgoing MMS with Delivery Request Event
    var params_outBoundMMSEvent_DeliveryRequestReceipt = {
        "eventType": "sms",
        "to": "+19095792299",
        "from": "+19415804593",
        "time": "2012-11-14T16:13:06.076Z",
        "text": "Example",
        "direction": "out",
        "applicationId": "a-rj7jf3fz7teaqupveqpug3i",        
        "state": "received",
        "messageId": "m-wnbqotddpcm7ijboconi75i",
        "media": [
            "https://api.catapult.inetwork.com/v1/users/{user-id}/media/A3087419-73C2-4A03-BB39-06BF3B1C240F-m-dr4mcch2wfb6frcls677glq.jpg",
            "https://api.catapult.inetwork.com/v1/users/{user-id}/media/123_1-m-dr4mcch2wfb6frcls677glq.smil"
        ],
        "messageUri": "https://api.catapult.inetwork.com/v1/users/{userId}/messages/{messageId}",
    };

    var args = {
        data: params_outBoundMMSEvent_DeliveryRequestReceipt,
        headers: {
            "Content-Type": "application/json",
            "User-Agent": "BandwidthAPI/v1",
        } // request headers
    };

    //// HTTP GET
    //// registering remote methods
    //client.registerMethod("jsonMethod", "http://localhost:1339/v1/messages/mmsEvent", "Post");
    //client.registerMethod("jsonMethod", "http://TEKNICAitg.com:1339/v1/messages/mmsEvent", "Post");
    //client.registerMethod("jsonMethod", "http://TEKRocketVMSSD:1339/v1/messages/mmsEvent", "Post");

    var serverPort = commonApp.GetServerPort();

    var serverAndMessageRoute = commonApp.GetLocalServerRootUrl(serverPort) + commonApp.GetMessagesRoute();
    //var serverAndMessageRoute = commonApp.GetServerRootUrl() + commonApp.GetMessagesRoute();
    var serverAndMessageRouteAndMethod = serverAndMessageRoute + '/mmsEvent';

    client.registerMethod("jsonMethod", serverAndMessageRouteAndMethod, "Post");
    //client.registerMethod("jsonMethod", commonApp.GetServerRootUri('v1/messages/mmsEvent'), "Post");

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

module.exports = {
    GetMMSEventTest: getMMSEventTest,
    PostMMSEventTest: postMMSEventTest
};