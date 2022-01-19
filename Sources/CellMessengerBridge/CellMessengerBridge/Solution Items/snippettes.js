
/*
 * 
 *
function(req, res) {
    var header = req.headers['authorization'] || '',        // get the header
        token = header.split(/\s+/).pop() || '',            // and the encoded auth token
        auth = new Buffer.from(token, 'base64').toString(),    // convert from base64
        parts = auth.split(/:/),                          // split on colon
        username = parts[0],
        password = parts[1];

    res.writeHead(200, { 'Content-Type': 'text/plain' });
    res.end('username is "' + username + '" and password is "' + password + '"');
    */

/*
 * 
 * //client.Message.send({
    //    from: "+12345678901", // This must be a Catapult number on your account
    //    to: "+12345678902",
    //    text: "Hello world."
    //})
    //    .then(function (message) {
    //        console.log("Message sent with ID " + message.id);
    //    })
    //    .catch(function (err) {
    //        console.log(err.message);
    //    });

*/