/**
 * Adapted from: http://stackoverflow.com/questions/650022/how-do-i-split-a-string-with-multiple-separators-in-javascript
*/
var StringUtils = {

	/**
     * Flatten a list of strings
     * http://rosettacode.org/wiki/Flatten_a_list
     */
	flatten: function (arr) {
		var self = this;
		return arr.reduce(function (acc, val) {
			return acc.concat(val.constructor === Array ? self.flatten(val) : val);
		}, []);
	},

	/**
     * Recursively Traverse a list and apply a function to each item
     * @param list array
     * @param expression Expression to use in func
     * @param func function of (item,expression) to apply expression to item
     *
     */
	traverseListFunc: function (list, expression, index, func) {
		var self = this;
		if (list[index]) {
			if ((list.constructor !== String) && (list[index].constructor === String))
				(list[index] != func(list[index], expression)) ? list[index] = func(list[index], expression) : null;
			(list[index].constructor === Array) ? self.traverseListFunc(list[index], expression, 0, func) : null;
			(list.constructor === Array) ? self.traverseListFunc(list, expression, index + 1, func) : null;
		}
	},

	/**
     * Recursively map function to string
     * @param string
     * @param expression Expression to apply to func
     * @param function of (item, expressions[i])
     */
	mapFuncToString: function (string, expressions, func) {
		var self = this;
		var list = [string];
		for (var i = 0, len = expressions.length; i < len; i++) {
			self.traverseListFunc(list, expressions[i], 0, func);
		}
		return self.flatten(list);
	},

	/**
     * Split a string
     * @param splitters Array of characters to apply the split
     */
	splitString: function (string, splitters) {
		return this.mapFuncToString(string, splitters, function (item, expression) {
			return item.split(expression);
		})
	},

}