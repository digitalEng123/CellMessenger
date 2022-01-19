'use strict';
var debug = require('debug');
var express = require('express');
//var path = require('path');
//var favicon = require('serve-favicon');
var logger = require('morgan');
//var cookieParser = require('cookie-parser');
var bodyParser = require('body-parser');

var commonApp = require('./commonApp');

var smsEventRoutes = require('./v1/messages/smsEvent-route');
var mmsEventRoutes = require('./v1/messages/mmsEvent-route');

var app = express();

// create application/json parser
var jsonParser = bodyParser.json();

/*
// create application/x-www-form-urlencoded parser
var urlencodedParser = bodyParser.urlencoded({ extended: false });

// POST /login gets urlencoded bodies
app.post('/login', urlencodedParser, function (req, res) {
  if (!req.body) return res.sendStatus(400)
  res.send('welcome, ' + req.body.username)
});
*/

if (commonApp.messageRoute === void (0)) {

    commonApp.messageRoute = commonApp.GetMessagesRoute();

    console.log("App Message Route: " + commonApp.messageRoute);
    console.log("");
}

// POST /api/users gets JSON bodies
app.post(commonApp.messageRoute, jsonParser, function (request, response) {
    if (!request.body) return response.sendStatus(400)
    // create user in req.body
});

app.use(logger('dev'));
app.use(bodyParser.json());
app.use(bodyParser.urlencoded({ extended: false }));
//app.use(cookieParser());

app.set('view engine', 'pug');

app.get('/', function (request, response) {
    response.render('index', { title: 'Bandwidth-Api-Restful-Callback', message: 'Bandwidth-Api-Restful-Callback' })
});

// Bind routes to our application
// Have user route mount itself to the express application, we could pass
// other parameters too, such as middleware, or the mount path
smsEventRoutes.RegisterGetSMSEventRoute(app);
smsEventRoutes.RegisterPostSMSEventRoute(app);

mmsEventRoutes.RegisterGetMMSEventRoute(app);
mmsEventRoutes.RegisterPostMMSEventRoute(app);

// catch 404 and forward to error handler
app.use(function (request, response, next) {
    var err = new Error('Not Found');
    err.status = 404;
    next(err);
});

// error handlers

// development error handler
// will print stacktrace
if (app.get('env') === 'development') {
    app.use(function (error, request, response, next) {
        console.log('Development Error: ' + error);
        response.status(error.status || 500);
        response.render('error', {
            message: error.message,
            error: error
        });
    });
}

// production error handler
// no stacktraces leaked to user
app.use(function (error, request, response, next) {
    console.log('Production Error: ' + error);
    response.status(error.status || 500);
    response.render('error', {
        message: error.message,
        error: {}
    });
});

process.on('uncaughtException', function (error) {
    console.error('UncaughtException' + error.stack);
    console.log("Node NOT Exiting...");
});

var serverPort = commonApp.GetServerPort();

app.set('port', serverPort);
//app.set('port', process.env.PORT || 1341); // 8081, 3000

var server = app.listen(app.get('port'), function () {

    var host = server.address().address
    var port = server.address().port

    debug('Express server listening on port ' + port);

    console.log('NodeJs Version: ' + process.version);
    console.log("App listening at http://%s:%s", host, port)
});
