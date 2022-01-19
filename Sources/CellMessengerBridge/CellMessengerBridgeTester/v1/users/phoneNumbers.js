

var Client = require('node-rest-client').Client;

function getPhoneNumbersTest () {

    var client = new Client();

    var args = {
        path: { "userId": "u-z5xcq76busoph25v4qus4zq" }, // path substitution var
        parameters: { size: 10, numberState: "Enabled" }, // this is serialized as URL parameters
        headers: {
            "Accept": "application/json",
            "User-Agent": "csharp-bandwidth/v1.0",
            "Authorization": "Basic dC1xeHJuY3l5bXp2NmlpYW5iY3hvamVqeTozN2hncG9vZXp5Y3N3aDJtMzNlYXNmdG14YXN5bWo2aGdsZ3U1Mnk="
        } // request headers
    };

    // HTTP GET
    // registering remote methods
    client.registerMethod("jsonMethod", "http://localhost:1337/v1/users/${userId}/phoneNumbers", "Get");

    client.methods.jsonMethod(args, function (data, response) {
        // parsed response body as js object
        console.log(data);
        //// raw response
        //console.log(response);

        //response.render('index', { title: 'PhoneNumbers Json', message: response.json(data) });
    }).on('error', function (err) {
        console.log('something went wrong on the request', err.request.options);
    });

    // handling specific req2 errors
    client.on('error', function (err) {
        console.log('something went wrong on req2!!', err.request.options);
    });

    //// HTTP GET
    //// set content-type header and data as json in args parameter
    //var args = {
    //    data: { test: "hello" },
    //    headers: { "Content-Type": "application/json" }
    //};


    /// registering remote methods
    //client.registerMethod("postMethod", "http://remote.site/rest/json/method", "POST");

    //client.methods.postMethod(args, function (data, response) {
    //    // parsed response body as js object
    //    console.log(data);
    //    // raw response
    //    console.log(response);
    //});
};

module.exports = {
    GetPhoneNumbersTest : getPhoneNumbersTest
};