'use strict';

function Base64Encoder(normalString) {

    let buff = new Buffer(normalString);
    let base64data = buff.toString('base64');

    //console.log('"' + normalString + '" converted to Base64 is "' + base64data + '"'); 

    return base64data
};

function Base64Decoder (base64String) {

    let buff = new Buffer(base64String, 'base64');
    let text = buff.toString('ascii');

    //console.log('"' + base64String + '" converted from Base64 to ASCII is "' + text + '"'); 

    return text;
};

module.exports = {
    encodeBase64String: Base64Encoder,
    decodeBase64String: Base64Decoder
};