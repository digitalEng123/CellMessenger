'use strict'

var Client = require('node-rest-client').Client;

var commonApp = require('../../commonApp');

function getSMSEventTest() {

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
    // client.registerMethod("jsonMethod", "http://localhost:1339/v1/messages/smsEvent", "Get");
    //client.registerMethod("jsonMethod", "http://TEKNICAitg.com:1339/v1/messages/smsEvent", "Get");

    var serverPort = commonApp.GetServerPort();

    var serverAndMessageRoute = commonApp.GetLocalServerRootUrl(serverPort) + commonApp.GetMessagesRoute();
    //var serverAndMessageRoute = commonApp.GetServerRootUrl() + commonApp.GetMessagesRoute();
    var serverAndMessageRouteAndMethod = serverAndMessageRoute + '/smsEvent';

    client.registerMethod("jsonMethod", serverAndMessageRouteAndMethod, "Get");
    //client.registerMethod("jsonMethod", commonApp.GetServerRootUri('v1/messages/smsEvent'), "Get");

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

function postSMSEventTest() {

    var client = new Client();

    var incomingSMSEvent = getPostSMSEventData(1);

    incomingSMSEvent['messageId'] = 'm-wnbqotddpcm7ijboconi75i';

    var args = {
        data: incomingSMSEvent,
        headers: {
            "Content-Type": "application/json",
            "User-Agent": "BandwidthAPI/v1",
        } // request headers
    };

    //// HTTP GET
    //// registering remote methods
    //client.registerMethod("jsonMethod", "http://localhost:1339/v1/messages/smsEvent", "Post");
    //client.registerMethod("jsonMethod", "http://TEKNICAitg.com:1339/v1/messages/smsEvent", "Post");
    //client.registerMethod("jsonMethod", "http://TEKRocketVMSSD:1339/v1/messages/smsEvent", "Post");

    var serverPort = commonApp.GetServerPort();
        
    var serverAndMessageRoute = commonApp.GetLocalServerRootUrl(serverPort) + commonApp.GetMessagesRoute();
    //var serverAndMessageRoute = commonApp.GetServerRootUrl() + commonApp.GetMessagesRoute();
    var serverAndMessageRouteAndMethod = serverAndMessageRoute + '/smsEvent';

    client.registerMethod("jsonMethod", serverAndMessageRouteAndMethod, "Post");
    //client.registerMethod("jsonMethod", commonApp.GetServerRootUri('v1/messages/smsEvent'), "Post");

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

function getPostSMSEventData(smsEventNumber) {

    var smsEventPostData = [
        { "deliveryState": "waiting", "messageId": "m-di2jq5xvi66qd37lsvpx5cy", "from": "+19095792299", "eventType": "sms", "text": "TEST 2018-09-25 6:41 PM", "time": "2018-09-26T01:44:05Z", "to": "+18186424351", "state": "sent", "messageUri": "https://api.catapult.inetwork.com/v1/users/u-z5xcq76busoph25v4qus4zq/messages/m-di2jq5xvi66qd37lsvpx5cy", "direction": "out" },
        { "deliveryDescription": "Message delivered to carrier", "messageId": "m-di2jq5xvi66qd37lsvpx5cy", "eventType": "sms", "deliveryState": "delivered", "from": "+19095792299", "text": "TEST 2018-09-25 6:41 PM", "time": "2018-09-26T01:44:05Z", "to": "+18186424351", "state": "sent", "messageUri": "https://api.catapult.inetwork.com/v1/users/u-z5xcq76busoph25v4qus4zq/messages/m-di2jq5xvi66qd37lsvpx5cy", "direction": "out", "deliveryCode": "0" },
        { "deliveryState": "waiting", "messageId": "m-di2jq5xvi66qd37lsvpx5cy", "from": "+19095792299", "eventType": "sms", "text": "TEST 2018-09-25 6:41 PM", "time": "2018-09-26T01:44:05Z", "to": "+18186424351", "state": "sent", "messageUri": "https://api.catapult.inetwork.com/v1/users/u-z5xcq76busoph25v4qus4zq/messages/m-di2jq5xvi66qd37lsvpx5cy", "direction": "out" },
        { "deliveryDescription": "Message delivered to carrier", "messageId": "m-di2jq5xvi66qd37lsvpx5cy", "eventType": "sms", "deliveryState": "delivered", "from": "+19095792299", "text": "TEST 2018-09-25 6:41 PM", "time": "2018-09-26T01:44:05Z", "to": "+18186424351", "state": "sent", "messageUri": "https://api.catapult.inetwork.com/v1/users/u-z5xcq76busoph25v4qus4zq/messages/m-di2jq5xvi66qd37lsvpx5cy", "direction": "out", "deliveryCode": "0" },
        { "deliveryState": "waiting", "messageId": "m-54nqmqoo3pwlt7wlxaap2pi", "from": "+19095792299", "eventType": "sms", "text": "TEST 2018-09-25 6:54 PM", "time": "2018-09-26T01:55:46Z", "to": "+18186424351", "state": "sent", "messageUri": "https://api.catapult.inetwork.com/v1/users/u-z5xcq76busoph25v4qus4zq/messages/m-54nqmqoo3pwlt7wlxaap2pi", "direction": "out" },
        { "deliveryDescription": "Message delivered to carrier", "messageId": "m-54nqmqoo3pwlt7wlxaap2pi", "eventType": "sms", "deliveryState": "delivered", "from": "+19095792299", "text": "TEST 2018-09-25 6:54 PM", "time": "2018-09-26T01:55:46Z", "to": "+18186424351", "state": "sent", "messageUri": "https://api.catapult.inetwork.com/v1/users/u-z5xcq76busoph25v4qus4zq/messages/m-54nqmqoo3pwlt7wlxaap2pi", "direction": "out", "deliveryCode": "0" },
        { "deliveryState": "waiting", "messageId": "m-54nqmqoo3pwlt7wlxaap2pi", "from": "+19095792299", "eventType": "sms", "text": "TEST 2018-09-25 6:54 PM", "time": "2018-09-26T01:55:46Z", "to": "+18186424351", "state": "sent", "messageUri": "https://api.catapult.inetwork.com/v1/users/u-z5xcq76busoph25v4qus4zq/messages/m-54nqmqoo3pwlt7wlxaap2pi", "direction": "out" },
        { "deliveryDescription": "Message delivered to carrier", "messageId": "m-54nqmqoo3pwlt7wlxaap2pi", "eventType": "sms", "deliveryState": "delivered", "from": "+19095792299", "text": "TEST 2018-09-25 6:54 PM", "time": "2018-09-26T01:55:46Z", "to": "+18186424351", "state": "sent", "messageUri": "https://api.catapult.inetwork.com/v1/users/u-z5xcq76busoph25v4qus4zq/messages/m-54nqmqoo3pwlt7wlxaap2pi", "direction": "out", "deliveryCode": "0" }
    ];

    return smsEventPostData[smsEventNumber];
}

module.exports = {
    GetSMSEventTest: getSMSEventTest,
    PostSMSEventTest: postSMSEventTest
};