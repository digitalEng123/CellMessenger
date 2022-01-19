

'use strict';

var utilsBase64EncodeDecoder = require('./base64EncodeDecoderUtils');

function GetApiAuthHeader(request) {

    var authHeader = request.headers['authorization'];

    return authHeader;
};

function GetApiTokenAndApiSecretFromAuthHeader(request) {

    var rtnValue = ['', ''];

    // get the header
    var authHeader = request.headers['authorization'];

    // and the encoded auth token
    var authToken = authHeader.split(/\s+/).pop();

    // convert from base64
    var textFromBase64 = utilsBase64EncodeDecoder.decodeBase64String(authToken);

    // split on colon
    var parts = textFromBase64.split(/:/);

    rtnValue[0] = parts[0];
    rtnValue[1] = parts[1];

    return rtnValue;
};

module.exports = {
    getApiAuthHeader: GetApiAuthHeader,
    getTokenAndSecret: GetApiTokenAndApiSecretFromAuthHeader
};
