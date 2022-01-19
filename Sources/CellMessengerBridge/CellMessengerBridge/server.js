'use strict';
var debug = require('debug');
var express = require('express');
//var path = require('path');
//var favicon = require('serve-favicon');
var logger = require('morgan');
//var cookieParser = require('cookie-parser');
var bodyParser = require('body-parser');

var phoneNumbersRoutes = require('./v1/users/phoneNumbers-route');
var messagesRoutes = require('./v1/users/messages-route');

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

// POST /api/users gets JSON bodies
app.post('/v1/users', jsonParser, function (req, res) {
  if (!req.body) return res.sendStatus(400)
  // create user in req.body
});

app.use(logger('dev'));
app.use(bodyParser.json());
app.use(bodyParser.urlencoded({ extended: false }));
//app.use(cookieParser());

app.set('view engine', 'pug');

app.get('/', function (req, res) {
    res.render('index', { title: 'Bandwidth-Api-Restful-Bridge', message: 'Bandwidth-Api-Restful-Bridge' })
})

// Bind routes to our application
// Have user route mount itself to the express application, we could pass
// other parameters too, such as middleware, or the mount path
phoneNumbersRoutes.RegisterGetPhoneNumbersRoute(app);
messagesRoutes.RegisterGetMessagesRoute(app);
messagesRoutes.RegisterSendSingleMessageRoute(app);

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
    app.use(function (err, request, response, next) {
        response.status(err.status || 500);
        response.render('error', {
            message: err.message,
            error: err
        });
    });
}

// production error handler
// no stacktraces leaked to user
app.use(function (err, request, response, next) {
    response.status(err.status || 500);
    response.render('error', {
        message: err.message,
        error: {}
    });
});

app.set('port', process.env.PORT || 1337); // 8081, 3000

var server = app.listen(app.get('port'), function () {

    var host = server.address().address
    var port = server.address().port

    debug('Express server listening on port ' + port);

    console.log("Example app listening at http://%s:%s", host, port)
});

