

var Client = require('node-rest-client').Client;

function getMessagesTest () {

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

    // HTTP GET
    // registering remote methods
    client.registerMethod("jsonMethod", "http://localhost:1337/v1/users/${userId}/messages", "Get");

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

    var args = {
        path: { "userId": "u-z5xcq76busoph25v4qus4zq" }, // path substitution var
        parameters: { from: "19095792299", to: "19415804593", text: "Hello from NodeJs tester!" }, // this is serialized as URL parameters
        headers: {
            "Accept": "application/json",
            "User-Agent": "csharp-bandwidth/v1.0",
            "Authorization": "Basic dC1xeHJuY3l5bXp2NmlpYW5iY3hvamVqeTozN2hncG9vZXp5Y3N3aDJtMzNlYXNmdG14YXN5bWo2aGdsZ3U1Mnk="
        } // request headers
    };

    // HTTP GET
    // registering remote methods
    client.registerMethod("jsonMethod", "http://localhost:1337/v1/users/${userId}/messages", "Post");

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
    GetMessagesTest: getMessagesTest,
    SendSingleMessagesTest: sendSingleMessagesTest
};