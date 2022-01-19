'use strict'

var tds = require('tedious');
var mssql = require('mssql');
//var node_mssql = require('node-mssql');
var dateFormat = require('dateformat');
var uuidv1 = require('uuid/v1');

var utilities = require('./utilities');

const APPLICATION_NAME = "CellMessengerCallback";

const TDS_VERSION = '2000';
const MSSQL_VERSION = '2008R2';
const NODE_MSSQL_VERSION = '2000';

/* START GET Config Setting */
function getTDSMsSqlConfig(version, databaseName) {

    switch (version) {
        case '2000':
            return getTDSMsSql2000Config(databaseName);
            break;
    }

    return void (0);
}

function getMsSqlConfig(version, databaseName) {

    switch (version) {
        case '2000':
            return getMsSql2000Config(databaseName);
            break;
        case '2008R2':
            return getMsSql2008R2Config(databaseName);
            break;
    }

    return void (0);
}

function getNodeMsSqlConfig(version, databaseName) {
    switch (version) {
        case '2000':
            return getNodeMsSql2000Config(databaseName);
            break;
    }

    return void (0);
}

function getTDSMsSql2000Config(databaseName) {

    var tdsVersions = tds.TDS_VERSION;

    var config = {
        server: 'localhost',
        userName: 'tos',
        password: 'Letmeinforever1',
        options: {
            database: databaseName,
            port: 1433,
            encrypt: false,
            tdsVersion: '7_1',
            appName: APPLICATION_NAME,
            debug: {
                packet: true,
                data: true,
                payload: true,
                token: true,
                log: true
            },
            connectTimeout: 60000,
            requestTimeout: 60000,
            rowCollectionOnRequestCompletion: true
        }
    };

    return config;
}

function getMsSql2000Config(databaseName) {

    var config = {
        server: 'localhost',
        user: 'tos',
        password: 'Letmeinforever1',
        database: databaseName,
        options: {
            encrypt: false,
            tdsVersion: '7_1',
            appName: APPLICATION_NAME,
            debug: {
                packet: true,
                data: true,
                payload: true,
                token: true,
                log: true
            }
        },
        connectTimeout: 60000,
        requestTimeout: 60000
    };

    return config;
}

function getNodeMsSql2000Config(databaseName) {

    var config = {
        host: 'localhost\\SQLEXPRESS2008R2',	 // You can use 'x.x.x.x\\instance' to connect to named instance
        port: 1433,
        username: 'tos',
        password: 'Letmeinforever1',
        db: databaseName,
        options: {
            encrypt: false,
            tdsVersion: '7_1',
            appName: APPLICATION_NAME
        }
    };

    return config;
}

function getMsSql2008R2Config(databaseName) {

    var config = {
        server: 'localhost',
        user: 'tos',
        password: 'Letmeinforever1',
        database: databaseName,
        port: '1433',
        "dialect": "mssql",
        "dialectOptions": {
            "instanceName": "SQLEXPRESS2008R2"
        },
        pool: {
            max: 10,
            min: 0,
            idleTimeoutMillis: 120000
        },
        options: {
            encrypt: false,
            tdsVersion: '7_4',
            appName: APPLICATION_NAME
        }
    };

    return config;
}

function getMsSqlXXXConfig(databaseName) {

    var config = {
        server: 'localhost',
        user: 'tos',
        password: 'Letmeinforever1',
        database: databaseName,
        port: 1433,
        pool: {
            max: 10,
            min: 0,
            idleTimeoutMillis: 120000
        },
        options: {
            useUTC: false,
            encrypt: false,
            tdsVersion: '7_1',
            appName: 'CellMessengerCallback',
            abortTransactionOnError: false,
            debug: {
                packet: true,
                data: true,
                payload: true,
                token: true,
                log: true
            }
        }
    };

    return config;
}
/* END: GET Config Setting */

/* START: PREPARE SQL Query */
function getSQLInsertQuery(tableName, insertData) {

    var sql = 'INSERT INTO ' + tableName;
    sql += ' (' + Object.keys(insertData).join(',') + ') VALUES (';
    Object.keys(insertData).forEach(function (key) {
        var fieldValue = insertData[key];

        if ((fieldValue === 'null') || (fieldValue === null)) {
            sql += '' + fieldValue + ', ';
        }
        else if (fieldValue === '') {
            sql += 'null, ';
        }
        else {

            if (utilities.IsNumeric(fieldValue)) {
                sql += '' + fieldValue + ', ';
            }
            else {
                sql += '\'' + fieldValue + '\', ';
            }
        }
    });
    sql = sql.slice(0, -2);
    sql += ')';

    return sql;
}

function getSQLInsertTableLockXQuery(tableName, insertData, primaryColumn) {

    var sql = 'INSERT INTO ' + tableName + ' WITH (TABLOCKX) ';
    sql += ' (' + Object.keys(insertData).join(',') + ') VALUES (';
    Object.keys(insertData).forEach(function (key) {

        var fieldValue = insertData[key];

        if (!utilities.IsUndefined(primaryColumn)) {
            if (key === primaryColumn) {
                fieldValue = '(ISNULL((SELECT TOP 1 [' + primaryColumn + '] FROM '
                    + tableName + ' WITH (TABLOCKX) ORDER BY [' + primaryColumn + '] DESC), 0) + 1)'
            }
        }

        if ((fieldValue === 'null') || (fieldValue === null)) {
            sql += '' + fieldValue + ', ';
        }
        else if (fieldValue === '') {
            sql += 'null, ';
        }
        else {

            if (utilities.IsNumeric(fieldValue)) {
                sql += '' + fieldValue + ', ';
            }
            else {

                if (!utilities.IsUndefined(primaryColumn)) {

                    if (key === primaryColumn) {
                        sql += '' + fieldValue + ', ';
                    }
                    else {
                        sql += '\'' + fieldValue + '\', ';
                    }
                }
                else {
                    sql += '\'' + fieldValue + '\', ';
                }
            }
        }
    });
    sql = sql.slice(0, -2);
    sql += ')';

    return sql;
}

function getSQLInsertTableLockXAutoIDQuery(tableName, insertData, primaryColumn) {

    var sql = '';

    if (!utilities.IsUndefined(primaryColumn)) {
        sql += 'DECLARE @NextRecordID INT ';
        sql += 'SELECT @NextRecordID = (ISNULL((SELECT TOP 1 [' + primaryColumn + '] FROM '
            + tableName + ' WITH (TABLOCKX) ORDER BY [' + primaryColumn + '] DESC), 0) + 1) '
    }

    sql += 'INSERT INTO ' + tableName + ' WITH (TABLOCKX) ';
    sql += ' (' + Object.keys(insertData).join(',') + ') VALUES (';
    Object.keys(insertData).forEach(function (key) {

        var fieldValue = insertData[key];

        if (!utilities.IsUndefined(primaryColumn)) {
            if (key === primaryColumn) {
                fieldValue = '@NextRecordID';
                //fieldValue = '(ISNULL((SELECT TOP 1 [' + primaryColumn + '] FROM '
                //    + tableName + ' WITH (TABLOCKX) ORDER BY [' + primaryColumn + '] DESC), 0) + 1)'
            }
        }

        if ((fieldValue === 'null') || (fieldValue === null)) {
            sql += '' + fieldValue + ', ';
        }
        else if (fieldValue === '') {
            sql += 'null, ';
        }
        else {

            if (utilities.IsNumeric(fieldValue)) {
                sql += '' + fieldValue + ', ';
            }
            else {

                if (!utilities.IsUndefined(primaryColumn)) {

                    if (key === primaryColumn) {
                        sql += '' + fieldValue + ', ';
                    }
                    else {
                        sql += '\'' + fieldValue + '\', ';
                    }
                }
                else {
                    sql += '\'' + fieldValue + '\', ';
                }
            }
        }
    });
    sql = sql.slice(0, -2);
    sql += ')';

    if (!utilities.IsUndefined(primaryColumn)) {
        sql += ' SELECT @NextRecordID AS \'intRecordID\'';
    }

    return sql;
}

function getSQLInsertTableLockXAutoIDExistCheckQuery(tableName, insertData, primaryColumn, columnNameToCheck, columnValueToCheck) {

    var sql = '';

    if (!utilities.IsUndefined(primaryColumn)) {
        sql += 'DECLARE @NextRecordID INT, @RecordID INT ';
        sql += 'SELECT @RecordID = (select top 1 [' + primaryColumn + '] FROM ' + tableName + ' WITH (TABLOCKX) WHERE [' + columnNameToCheck + '] = \'' + columnValueToCheck + '\') ';
        sql += 'IF @RecordID IS NULL ';
        sql += 'BEGIN ';
        sql += 'SELECT @NextRecordID = (ISNULL((SELECT TOP 1 [' + primaryColumn + '] FROM '
            + tableName + ' WITH (TABLOCKX) ORDER BY [' + primaryColumn + '] DESC), 0) + 1) '
    }

    sql += 'INSERT INTO ' + tableName + ' WITH (TABLOCKX) ';
    sql += ' (' + Object.keys(insertData).join(',') + ') VALUES (';
    Object.keys(insertData).forEach(function (key) {

        var fieldValue = insertData[key];

        if (!utilities.IsUndefined(primaryColumn)) {
            if (key === primaryColumn) {
                fieldValue = '@NextRecordID';
                //fieldValue = '(ISNULL((SELECT TOP 1 [' + primaryColumn + '] FROM '
                //    + tableName + ' WITH (TABLOCKX) ORDER BY [' + primaryColumn + '] DESC), 0) + 1)'
            }
        }

        if ((fieldValue === 'null') || (fieldValue === null)) {
            sql += '' + fieldValue + ', ';
        }
        else if (fieldValue === '') {
            sql += 'null, ';
        }
        else {

            if (utilities.IsNumeric(fieldValue)) {
                sql += '' + fieldValue + ', ';
            }
            else {

                if (!utilities.IsUndefined(primaryColumn)) {

                    if (key === primaryColumn) {
                        sql += '' + fieldValue + ', ';
                    }
                    else {
                        sql += '\'' + fieldValue + '\', ';
                    }
                }
                else {
                    sql += '\'' + fieldValue + '\', ';
                }
            }
        }
    });
    sql = sql.slice(0, -2);
    sql += ') ';

    if (!utilities.IsUndefined(primaryColumn)) {
        sql += 'SELECT @NextRecordID AS \'intRecordID\' ';
        sql += 'END ';
        sql += 'ELSE ';
        sql += 'BEGIN ';
        sql += 'SELECT @RecordID AS \'intRecordID\' ';
        sql += 'END ';
    }

    return sql;
}

function getSQLUpdateQuery(tableName, updateData, whereClauseData) {

    var counter00 = 0;
    var counter01 = 0;

    var sql = 'UPDATE ' + tableName;
    sql += ' SET ';
    Object.keys(updateData).forEach(function (key) {
        var fieldValue = updateData[key];

        if (counter00 > 0)
            sql += ', ';

        if ((fieldValue === 'null') || (fieldValue === null)) {
            sql += '[' + key + '] = ' + fieldValue + '';
        }
        else {
            if (utilities.IsNumeric(fieldValue)) {
                sql += '[' + key + '] = ' + fieldValue + '';
            }
            else {
                sql += '[' + key + '] = \'' + fieldValue + '\'';
            }
        }

        counter00++;
    });
    sql += ' WHERE ';
    Object.keys(whereClauseData).forEach(function (key) {
        var fieldValue = whereClauseData[key];

        if (counter01 > 0)
            sql += ' and ';

        if ((fieldValue === 'null') || (fieldValue === null)) {
            sql += '[' + key + '] = ' + fieldValue + '';
        }
        else {

            if (utilities.IsNumeric(fieldValue)) {
                sql += '[' + key + '] = ' + fieldValue + '';
            }
            else {
                sql += '[' + key + '] = \'' + fieldValue + '\'';
            }
        }

        counter01++;
    });

    return sql;
}

function getSQLUpdateTableLockXQuery(tableName, updateData, whereClauseData) {

    var counter00 = 0;
    var counter01 = 0;

    var sql = 'UPDATE ' + tableName + ' WITH (TABLOCKX) ';
    sql += ' SET ';
    Object.keys(updateData).forEach(function (key) {
        var fieldValue = updateData[key];

        if (counter00 > 0)
            sql += ', ';

        if ((fieldValue === 'null') || (fieldValue === null)) {
            sql += '[' + key + '] = ' + fieldValue + '';
        }
        else {
            if (utilities.IsNumeric(fieldValue)) {
                sql += '[' + key + '] = ' + fieldValue + '';
            }
            else {
                sql += '[' + key + '] = \'' + fieldValue + '\'';
            }
        }

        counter00++;
    });
    sql += ' WHERE ';
    Object.keys(whereClauseData).forEach(function (key) {
        var fieldValue = whereClauseData[key];

        if (counter01 > 0)
            sql += ' and ';

        if ((fieldValue === 'null') || (fieldValue === null)) {
            sql += '[' + key + '] = ' + fieldValue + '';
        }
        else {

            if (utilities.IsNumeric(fieldValue)) {
                sql += '[' + key + '] = ' + fieldValue + '';
            }
            else {
                sql += '[' + key + '] = \'' + fieldValue + '\'';
            }
        }

        counter01++;
    });

    return sql;
}

function getSQLDeleteQuery(tableName, whereClauseData) {

    var counter00 = 0;

    var sql = 'DELETE ' + tableName;
    sql += ' WHERE ';
    Object.keys(whereClauseData).forEach(function (key) {
        var fieldValue = whereClauseData[key];

        if (counter00 > 0)
            sql += ' and ';

        if ((fieldValue === 'null') || (fieldValue === null)) {
            sql += '[' + key + '] = ' + whereClauseData[key] + '';
        }
        else {

            if (utilities.IsNumeric(fieldValue)) {
                sql += '[' + key + '] = ' + fieldValue + '';
            }
            else {
                sql += '[' + key + '] = \'' + fieldValue + '\'';
            }
        }

        counter00++;
    });

    return sql;

}
/* END: PREPARE SQL Query */

function getTDSSelectQuery(databaseName, sqlQuery, callback) {

    var config = getTDSMsSqlConfig(TDS_VERSION, databaseName);

    var tdsVersions = tds.TDS_VERSION;

    console.log("TDS Versions: " + tdsVersions);

    var dbConn = new tds.Connection(config);

    dbConn.on('debug', function (msg) { console.log(msg) });

    dbConn.on('end', function () {

        console.log("Connection ended!");
    });

    dbConn.on('infoMessage', function (info) {

        var json = JSON.stringify(info);

        console.log("info: " + json);
    });

    dbConn.on('errorMessage', function (error) {

        //var json = JSON.stringify(error);

        console.log("error: " + error);
    });

    dbConn.on('connect', function (error) {

        if (error) {
            console.log(error);
            return callback(error, void (0));
        }

        var request = new tds.Request(sqlQuery, function (error, rowCount, rows) {

            if (error) {
                console.log(error);
                return callback(error, void (0));
            }
            else {
                callback(void (0), rows);
            }

        });

        request.on('row', function (columns) {
            columns.forEach(function (column) {
                console.log("Column " + column['metadata']['colName'] + ': ' + column.value);
            });
        });

        dbConn.execSql(request);
    });
}

function getMSSQLScalerValueVIACallback(databaseName, sqlQuery, callback) {

    var config = getMsSqlConfig(MSSQL_VERSION, databaseName);

    var dbConn = new mssql.ConnectionPool(config);

    dbConn.on('debug', function (msg) { console.log(msg) });

    dbConn.connect().then(function (conn) {

        var request = new mssql.Request(conn);

        request.query(sqlQuery).then(function (resultObject) {

            //console.log(resultObject);
            dbConn.close();

            return callback(void (0), resultObject['recordset']);
        }).catch(function (error) {

            console.log(error);
            dbConn.close();

            return callback(error, void (0));
        });
    }).catch(function (error) {

        console.log(error);

        return callback(error, void (0));
    });
}

function getMSSQLScalerValue(databaseName, sqlQuery) {

    var config = getMsSqlConfig(MSSQL_VERSION, databaseName);

    return new Promise(function (resolve, reject) {

        var dbConn = new mssql.ConnectionPool(config);

        dbConn.on('debug', function (msg) { console.log(msg) });

        dbConn.connect().then(function (conn) {

            var request = new mssql.Request(conn);

            request.query(sqlQuery).then(function (resultObject) {

                //console.log(resultObject);
                dbConn.close();

                return resolve(resultObject['recordset']);
            }).catch(function (error) {

                console.log(error);
                dbConn.close();

                return reject(error);
            });
        }).catch(function (error) {

            console.log(error);

            return reject(error);
        });
    });
}

function getMSSQLSelectQuery(databaseName, sqlQuery, callback) {

    var config = getMsSqlConfig(MSSQL_VERSION, databaseName);

    var dbConn = new mssql.ConnectionPool(config);

    dbConn.on('debug', function (msg) { console.log(msg) });

    dbConn.connect().then(function (conn) {

        var request = new mssql.Request(conn);

        request.query(sqlQuery).then(function (resultObject) {

            //console.log(resultObject);
            dbConn.close();

            return callback(void (0), resultObject['recordset']);
        }).catch(function (error) {

            console.log(error);
            dbConn.close();

            return callback(error, void (0));
        });
    }).catch(function (error) {

        console.log(error);

        return callback(error, void (0));
    });
}

function executeNonMSSQLQuery(databaseName, sqlQuery) {

    var config = getMsSqlConfig(MSSQL_VERSION, databaseName);

    return new Promise(function (resolve, reject) {

        var dbConn = new mssql.ConnectionPool(config);

        dbConn.on('debug', function (msg) { console.log(msg) });

        dbConn.connect().then(function (conn) {

            var request = new mssql.Request(conn);

            request.query(sqlQuery).then(function (resultObject) {

                //console.log(resultObject);
                dbConn.close();

                return resolve(resultObject);
            }).catch(function (error) {

                console.log(error);
                dbConn.close();

                return reject(error);
            });
        }).catch(function (error) {

            console.log(error);

            return reject(error);
        });
    });
}

function executeNodeMsSqlinsertQuery(databaseName, tableName, insertData) {

    /* add configuration to query object */
    var config = getNodeMsSqlConfig(NODE_MSSQL_VERSION, databaseName);
    var queryObj = new node_mssql.Query(config);

    /* START Insert Operation: */
    /* set table name to operate */
    queryObj.table(tableName);
    //queryObj['tableName'] = tableName;

    /* set required data to be inserted */
    queryObj.data(insertData);

    /* run insert query and fetch response */
    queryObj.insert(function (results) {
        //  success callback
        console.log(results);
        return results;
    }, function (error, sql) {
        //  failed callback
        if (error)
            console.log(error);

        console.log(sql);
        return error;
    });
}

function executeMsSqlInsert_LookupRecord1(databaseName, tableName, ixtCode,
    txtDescription, txtElectronicDataExchangeCode, intRecordID_DatabaseID, intRecordID_Company,
    intRecordID_Division) {

    return new Promise(function (resolve, reject) {

        var insertData = {};

        var returnData = {
            intRecordID: null
        };

        var returnValue = new Array(0);

        returnValue.push(returnData);

        return resolve(returnValue);

    });
}

function executeMsSqlInsert_LookupRecord(databaseName, tableName, ixtCode,
    txtDescription, txtElectronicDataExchangeCode, intRecordID_DatabaseID, intRecordID_Company,
    intRecordID_Division, optInsertFields, optRemoveFields) {

    return new Promise(function (resolve, reject) {

        var insertData = {};

        var returnData = {
            intRecordID: null
        };

        var returnValue = new Array(0);

        returnValue.push(returnData);

        var intRecordID = null;
        var date = new Date();
        var dteRecordCreationDate = dateFormat(date, 'yyyy-mm-dd HH:MM:ss');

        var promises_scalar = [];

        var maxRecordID = null;
        var scalerPromise = getMSSQLScalerValue(databaseName,
            "SELECT ISNULL((select TOP 1 isnull(([intRecordID]), 0) as 'MaxRecordID' from "
            + tableName + " ORDER BY intRecordID DESC), 0) as 'MaxRecordID'").then(function (scalerResult) {

                if (!utilities.IsUndefined(scalerResult) && scalerResult.length > 0) {
                    maxRecordID = scalerResult[0]["MaxRecordID"];
                }
            }).catch(function (error) {
                // error handle
                console.log(error);

                resolve(returnValue);
                return reject(error);
            });
        promises_scalar.push(scalerPromise);

        Promise.all(promises_scalar).then(function () {

            if (maxRecordID === 0)
                intRecordID = 1;

            if (maxRecordID === null)
                return resolve(returnValue);

            intRecordID = (maxRecordID + 1);

            if (!utilities.IsUndefined(txtElectronicDataExchangeCode)) {

                insertData = {
                    'intRecordID': intRecordID,
                    'ixtCode': ixtCode,
                    'txtDescription': txtDescription,
                    'txtElectronicDataExchangeCode': txtElectronicDataExchangeCode,
                    'intRecordID_DatabaseID': intRecordID_DatabaseID,
                    'intRecordID_Company': intRecordID_Company,
                    'intRecordID_Division': intRecordID_Division,
                    'txtRecordCreationUser': 'SMSEventCallback',
                    'dteRecordCreationDate': dteRecordCreationDate,
                    'blnMakePrivate': null,
                    'blnActive': 'Yes',
                    'blnDeleted': 'No',
                    'blnAttachment': 'No',
                    'blnHighlight': 'No',
                    'blnMemo': 'No',
                    'blnProcess': 'No',
                    'blnProject': 'No',
                    'blnWebSearch': 'No',
                    'blnEcommerceTransmit': null,
                    'blnSecurity': null,
                    'blnSystemRecord': 'Yes',
                    'txtGUID': uuidv1()
                };
            }
            else {

                insertData = {
                    'intRecordID': intRecordID,
                    'ixtCode': ixtCode,
                    'txtDescription': txtDescription,
                    'intRecordID_DatabaseID': intRecordID_DatabaseID,
                    'intRecordID_Company': intRecordID_Company,
                    'intRecordID_Division': intRecordID_Division,
                    'txtRecordCreationUser': 'SMSEventCallback',
                    'dteRecordCreationDate': dteRecordCreationDate,
                    'blnMakePrivate': null,
                    'blnActive': 'Yes',
                    'blnDeleted': 'No',
                    'blnAttachment': 'No',
                    'blnHighlight': 'No',
                    'blnMemo': 'No',
                    'blnProcess': 'No',
                    'blnProject': 'No',
                    'blnWebSearch': 'No',
                    'blnEcommerceTransmit': null,
                    'blnSecurity': null,
                    'blnSystemRecord': 'Yes',
                    'txtGUID': uuidv1()
                };
            }

            // add addtional fields if any.
            if (!utilities.IsUndefined(optInsertFields)) {

                Object.keys(optInsertFields).forEach(function (key) {

                    var fieldValue = optInsertFields[key];

                    if (utilities.IskeyValuePairObjectContainsKey(key, insertData))
                        insertData[key] = fieldValue;
                    else
                        insertData[key] = fieldValue;
                });
            }
            // remove fields if any exist.
            if (!utilities.IsUndefined(optRemoveFields)) {

                Object.keys(optRemoveFields).forEach(function (key) {

                    if (utilities.IskeyValuePairObjectContainsKey(key, insertData)) {

                        var deleted = utilities.DeleteKeyFromKeyValuePair(key, insertData);
                    }
                });
            }

            var sqlInsertQuery = getSQLInsertTableLockXQuery(tableName, insertData);

            var succeeded = void (0);
            var promises_inserts = [];
            var insertPromise = executeNonMSSQLQuery(databaseName, sqlInsertQuery).then(function (resultData) {

                if (!utilities.IsUndefined(resultData)) {

                    var rowsAffected = resultData['rowsAffected'][0];

                    if (rowsAffected > 0) {

                        returnValue[0]['intRecordID'] = intRecordID;

                        succeeded = true;
                    }
                }
                else {
                    return resolve(returnValue);
                }
            }).catch(function (e) {
                // error handle
                resolve(returnValue);
                return reject(e);
            });
            promises_inserts.push(insertPromise);

            Promise.all(promises_inserts).then(function () {

                return resolve(returnValue);
            })
        });
    });
}

function executeMsSqlInsertAutoID_LookupRecord(databaseName, tableName, ixtCode,
    txtDescription, txtElectronicDataExchangeCode, intRecordID_DatabaseID, intRecordID_Company,
    intRecordID_Division, optInsertFields, optRemoveFields) {

    return new Promise(function (resolve, reject) {

        var insertData = {};

        var returnData = {
            intRecordID: null
        };

        var returnValue = new Array(0);

        returnValue.push(returnData);

        var intRecordID = null;
        var date = new Date();
        var dteRecordCreationDate = dateFormat(date, 'yyyy-mm-dd HH:MM:ss');

        var promises_scalar = [];

        var scalerPromise = new Promise(function (resolve, reject) {
            return resolve(true);
        }).then(function (scalerResult) {

        });
        promises_scalar.push(scalerPromise);

        Promise.all(promises_scalar).then(function () {

            intRecordID = 0;

            var columnNameToCheck = '';

            if (!utilities.IsUndefined(txtElectronicDataExchangeCode)) {

                columnNameToCheck = 'txtElectronicDataExchangeCode';

                insertData = {
                    'intRecordID': intRecordID,
                    'ixtCode': ixtCode,
                    'txtDescription': txtDescription,
                    'txtElectronicDataExchangeCode': txtElectronicDataExchangeCode,
                    'intRecordID_DatabaseID': intRecordID_DatabaseID,
                    'intRecordID_Company': intRecordID_Company,
                    'intRecordID_Division': intRecordID_Division,
                    'txtRecordCreationUser': 'SMSEventCallback',
                    'dteRecordCreationDate': dteRecordCreationDate,
                    'blnMakePrivate': null,
                    'blnActive': 'Yes',
                    'blnDeleted': 'No',
                    'blnAttachment': 'No',
                    'blnHighlight': 'No',
                    'blnMemo': 'No',
                    'blnProcess': 'No',
                    'blnProject': 'No',
                    'blnWebSearch': 'No',
                    'blnEcommerceTransmit': null,
                    'blnSecurity': null,
                    'blnSystemRecord': 'Yes',
                    'txtGUID': uuidv1()
                };
            }
            else {

                columnNameToCheck = 'ixtCode';

                insertData = {
                    'intRecordID': intRecordID,
                    'ixtCode': ixtCode,
                    'txtDescription': txtDescription,
                    'intRecordID_DatabaseID': intRecordID_DatabaseID,
                    'intRecordID_Company': intRecordID_Company,
                    'intRecordID_Division': intRecordID_Division,
                    'txtRecordCreationUser': 'SMSEventCallback',
                    'dteRecordCreationDate': dteRecordCreationDate,
                    'blnMakePrivate': null,
                    'blnActive': 'Yes',
                    'blnDeleted': 'No',
                    'blnAttachment': 'No',
                    'blnHighlight': 'No',
                    'blnMemo': 'No',
                    'blnProcess': 'No',
                    'blnProject': 'No',
                    'blnWebSearch': 'No',
                    'blnEcommerceTransmit': null,
                    'blnSecurity': null,
                    'blnSystemRecord': 'Yes',
                    'txtGUID': uuidv1()
                };
            }

            // add addtional fields if any.
            if (!utilities.IsUndefined(optInsertFields)) {

                Object.keys(optInsertFields).forEach(function (key) {

                    var fieldValue = optInsertFields[key];

                    if (utilities.IskeyValuePairObjectContainsKey(key, insertData))
                        insertData[key] = fieldValue;
                    else
                        insertData[key] = fieldValue;
                });
            }
            // remove fields if any exist.
            if (!utilities.IsUndefined(optRemoveFields)) {

                Object.keys(optRemoveFields).forEach(function (key) {

                    if (utilities.IskeyValuePairObjectContainsKey(key, insertData)) {

                        var deleted = utilities.DeleteKeyFromKeyValuePair(key, insertData);
                    }
                });
            }

            var sqlInsertQuery = getSQLInsertTableLockXAutoIDExistCheckQuery(
                tableName, insertData, 'intRecordID', columnNameToCheck, insertData[columnNameToCheck]);

            var succeeded = void (0);
            var promises_inserts = [];
            var insertPromise = getMSSQLScalerValue(databaseName, sqlInsertQuery).then(function (scalarResult) {

                if (!utilities.IsUndefined(scalarResult) && scalarResult.length > 0) {

                    returnValue[0]['intRecordID'] = scalarResult[0]['intRecordID'];

                    succeeded = true;
                }
                else {
                    return resolve(returnValue);
                }
            }).catch(function (e) {
                // error handle
                resolve(returnValue);
                return reject(e);
            });
            promises_inserts.push(insertPromise);

            Promise.all(promises_inserts).then(function () {

                return resolve(returnValue);
            })
        });
    });
}

module.exports = {
    GetTDSMsSqlConfig: getTDSMsSqlConfig,
    GetMsSqlConfig: getMsSqlConfig,
    GetNodeMsSqlConfig: getNodeMsSqlConfig,
    GetSQLInsertQuery: getSQLInsertQuery,
    GetSQLInsertTableLockXQuery: getSQLInsertTableLockXQuery,
    GetSQLInsertTableLockXAutoIDQuery: getSQLInsertTableLockXAutoIDQuery,
    GetSQLInsertTableLockXAutoIDExistCheckQuery: getSQLInsertTableLockXAutoIDExistCheckQuery,
    GetSQLUpdateQuery: getSQLUpdateQuery,
    getSQLUpdateTableLockXQuery: getSQLUpdateTableLockXQuery,
    GetSQLDeleteQuery: getSQLDeleteQuery,
    GetTDSSelectQuery: getTDSSelectQuery,
    GetMSSQLScalerValueVIACallback: getMSSQLScalerValueVIACallback,
    GetMSSQLScalerValue: getMSSQLScalerValue,
    GetMSSQLSelectQuery: getMSSQLSelectQuery,
    ExecuteNonMSSQLQuery: executeNonMSSQLQuery,
    ExecuteMsSqlInsert_LookupRecord: executeMsSqlInsert_LookupRecord,
    ExecuteMsSqlInsertAutoID_LookupRecord: executeMsSqlInsertAutoID_LookupRecord
};