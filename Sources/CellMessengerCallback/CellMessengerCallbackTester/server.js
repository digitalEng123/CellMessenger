'use strict';

var debug = require('debug');
var express = require('express');
//var path = require('path');
//var favicon = require('serve-favicon');
var logger = require('morgan');
//var cookieParser = require('cookie-parser');
//var bodyParser = require('body-parser');

var messages = require('./v1/messages/messages')
var smsEvent = require('./v1/messages/smsEvent');
var mmsEvent = require('./v1/messages/mmsEvent');
var dbConn = require('./DbConnection')
var utilities = require('./Utils/utilities');
var commonApp = require('./commonApp');

var app = express();

//// uncomment after placing your favicon in /public
//app.use(favicon(__dirname + '/public/favicon.ico'));
app.use(logger('dev'));
//app.use(bodyParser.json());
//app.use(bodyParser.urlencoded({ extended: false }));
//app.use(cookieParser());
//app.use(express.static(path.join(__dirname, 'public')));

if (commonApp.messageRoute === void (0)) {

    commonApp.messageRoute = commonApp.GetMessagesRoute();

    console.log("App Message Route: " + commonApp.messageRoute);
    console.log("");
}


app.set('view engine', 'pug');

app.get('/', function (request, response) {
    response.render('index', { title: 'Bandwidth-Api-Callback', message: 'Bandwidth-Api-Callback Tester!' })
})

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
        console.log('Development Error: ' + error);
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
    console.log('Production Error: ' + error);
    response.status(err.status || 500);
    response.render('error', {
        message: err.message,
        error: {}
    });
});

process.on('uncaughtException', function (error) {
    console.error('UncaughtException' + error.stack);
    console.log("Node NOT Exiting...");
});

// http://www.TEKNICAitg.com:1339/telligent/SoftwareApplicationServer/ROCKETMessenger/Bandwidth/Callback/v1/messages/smsevent

console.log("NodeJs Version: " + process.version);

//messages.GetMessagesTest();
//messages.PostSMSEventTest();
//messages.PostMMSEventTest();

//smsEvent.GetSMSEventTest();
//smsEvent.PostSMSEventTest();

//mmsEvent.GetMMSEventTest();
//mmsEvent.PostMMSEventTest();

//dbConn.TDSSelectQueryTest();
//dbConn.MsSqlGetScalerValueTest();
//dbConn.MsSqlSelectQueryTest();
//dbConn.MsSqlExecuteNonQueryTest();
//dbConn.MsSqlQueryBuildTest();
//dbConn.MsSqlAutoIncrementQueryTest();
dbConn.MsSqlAutoIncrementExistCheckQueryTest();

//var insertData = {
//    'intRecordID': null
//};

//insertData['2nd'] = '2nd';

//var containsKey = utilities.IskeyValuePairObjectContainsKey('intRecordID', insertData);

//if (containsKey) {

//    var deleted = utilities.DeleteKeyFromKeyValuePair('intRecordID', insertData);

//    if (deleted) {

//    }
//}


//app.set('port', process.env.PORT || 3000);

//var server = app.listen(app.get('port'), function () {
//    debug('Express server listening on port ' + server.address().port);
//});
