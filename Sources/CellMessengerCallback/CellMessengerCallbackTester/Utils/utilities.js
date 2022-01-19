' use strict'

var fs = require("fs");

function getUndefinedValue() {
    return void (0);
}

function isUndefined(value) {
    // Obtain `undefined` value that's
    // guaranteed to not have been re-assigned
    var undefined = void (0);
    return value === undefined;
}

function iskeyValuePairObjectContainsKey(key, keyValuePairObject) {

    return (key in keyValuePairObject);
}

function deleteKeyFromKeyValuePair(key, keyValuePairObject) {

    var rtnValue = false;
    if (iskeyValuePairObjectContainsKey(key, keyValuePairObject)) {

        delete keyValuePairObject[key];

        rtnValue = true;
    }

    return rtnValue;
}

function isNumeric(n) {
    return (typeof n == "number" && !isNaN(n));
}

function applyTitleCase(str) {
    return str.replace(/\S/g, function (t) { return t.toUpperCase() });
}

function applySentenceCase(str) {

    return str.replace(/[a-z]/i, function (letter) {

        return letter.toUpperCase();

    }).trim();
}

function appendToFile(fileName, data, next) {

    try {
        fs.appendFileSync(fileName, data, 'utf8');
    }
    catch (error) {
        console.log("In Catch Block")
        console.log(error);

        if (error && next) return next(error);
    }
}

module.exports = {
    GetUndefinedValue: getUndefinedValue,
    IsUndefined: isUndefined,
    IskeyValuePairObjectContainsKey: iskeyValuePairObjectContainsKey,
    DeleteKeyFromKeyValuePair: deleteKeyFromKeyValuePair,
    IsNumeric: isNumeric,
    ApplyTitleCase: applyTitleCase,
    ApplySentenceCase: applySentenceCase,
    AppendToFile: appendToFile
};
