
var example = [
'def func sum[5, 3, 7, 2, 6, 3]',
'def func2 [5, 3, 7, 2, 6, 3]',
'def func3 min[func2]',
'def func4 max[5, 3, 7, 2, 6, 3]',
'def func5 avg[5, 3, 7, 2, 6, func]',
'def func6 sum[func2, func3, func4 ]',
'sum[func6, func4]'
];

var example1 = [
'def func sum[1, 2, 3, -6]',
'def newList [func, 10, 1]',
'def newFunc sum[func, 100, newList]',
'[newFunc]'
];
var example2 = [
'def var1[1, 2, 3 ,4]',
'def var2 sum[var1, 20, 70]',
'def var3 min[var1]',
'avg[var2, var3] '
];

function solve(params) {
    Array.prototype.removeEmptySpaces = function () {
        var cleanArray = [];
        for (var i = 0; i < this.length; i++) {
            if (this[i] !== '') {
                cleanArray.push(this[i]);
            }
        }
        return cleanArray;
    }
    String.prototype.startWith = function (value, caseSensitive) {

        var i, j, valueLowerCase, thisLowerCase;
        if (value === undefined) {
            throw 'Value parameter in startWith function is undifine';
        }
        if (typeof (value) !== 'string') {
            throw 'Value parameter in startWith function must be string';
        }
        caseSensitive = typeof (caseSensitive) === 'undefined' ? true : caseSensitive;
        value = value === undefined ? '' : value;
        var isCaseSensitive = caseSensitive;
        var isStartWith = false;

        if (this.length < value.length) {
            return isStartWith;
        }

        isStartWith = true;
        if (isCaseSensitive) {
            for (i = 0; i < value.length; i++) {
                if (value[i] !== this[i]) {
                    isStartWith = false;
                    break;
                }
            }
        }
        else {
            valueLowerCase = value.toLowerCase();
            thisLowerCase = this.toLowerCase();
            for (j = 0; j < valueLowerCase.length; j++) {
                if (valueLowerCase[i] !== thisLowerCase[i]) {
                    isStartWith = false;
                    break;
                }
            }
        }
        return isStartWith;
    }
    String.prototype.replaceAllChars = function (oldValue, newValue) {
        var result = '';
        for (var i = 0; i < this.length; i++) {
            if (this[i] === oldValue) {
                result += newValue;
            }
            else {
                result += this[i];
            }
        }
        return result;
    }

    var lines, l, i, answer, stack, definitionValue, definitionResult, definitionString, definitionParameters;
    lines = [];
    for (var l = 0; l < params.length; l++) {
        lines.push(params[l]);
    }

    function extraxtBracketString(line) {
        var startIndex = line.indexOf('[');
        var endIndex = line.indexOf(']') + 1;
        var result = line.substring(startIndex, endIndex);
        return result;
    }


    function buildArray(line) {
        var arrayString = line.replaceAllChars(',', ' ').replaceAllChars(']', '').replaceAllChars('[', '');
        var array = arrayString.split(' ').removeEmptySpaces();
        var arrayValidValues = [];
        for (var i = 0; i < array.length; i++) {
            if (array[i] !== '-') {
                arrayValidValues.push(array[i]);
            }
        }
        var result = [];
        for (var i = 0; i < arrayValidValues.length; i++) {
            if (stack.hasOwnProperty(arrayValidValues[i])) {
                result.push(stack[arrayValidValues[i]]);
            }
            else {
                result.push(arrayValidValues[i] - 0);
            }
        }
        return result;
    }
    function asignValue(line) {
        var str = line.replace(']', '').replace('[', '').trim();
        if (stack.hasOwnProperty(str)) {
            return stack[str];
        }
        else {
            return str - 0;
        }
    }
    function sum(values) {
        var sum = 0;
        for (var i = 0; i < values.length; i++) {
            if (Array.isArray(values[i])) {
                for (var j = 0; j < values[i].length; j++) {
                    sum += values[i][j];
                }
            }
            else {
                sum += values[i];
            }
        }
        return sum;
    }
    function max(values) {
        var max = values[0];
        if (Array.isArray(values[0])) {
            max = values[0][0];
            for (var j = 1; j < values[0].length; j++) {
                if (values[0] > max) {
                    max = values[0][j];
                }
            }
        }
        for (var i = 1; i < values.length; i++) {
            if (Array.isArray(values[i])) {
                for (var j = 0; j < values[i].length; j++) {
                    if (values[i][j] > max) {
                        max = values[i][j];
                    }
                }
            }
            else {
                if (values[i] > max) {
                    max = values[i];
                }
            }
        }
        return max;
    }
    function min(values) {
        var min = values[0];
        if (Array.isArray(values[0])) {
            min = values[0][0];
            for (var j = 1; j < values[0].length; j++) {
                if (values[0][j] < min) {
                    min = values[0][j];
                }
            }
        }
        for (var i = 1; i < values.length; i++) {
            if (Array.isArray(values[i])) {
                for (var j = 0; j < values[i].length; j++) {
                    if (values[i][j] < min) {
                        min = values[i][j];
                    }
                }
            }
            else {
                if (values[i] < min) {
                    min = values[i];
                }
            }
        }
        return min;
    }
    function avg(values) {
        var count = values.length;
        var sum = 0;
        for (var i = 0; i < values.length; i++) {
            if (Array.isArray(values[i])) {
                count--;
                count += values[i].length;
                for (var j = 0; j < values[i].length; j++) {
                    sum += values[i][j];
                }
            }
            else {
                sum += values[i];
            }
        }
        return parseInt(sum / count);
    }
    stack = [];

    for (i = 0; i < lines.length; i++) {

        if (lines[i].startWith('def')) {
            definitionValue = extraxtBracketString(lines[i]);
            definitionString = lines[i].replace(definitionValue, '').trim();
            definitionParameters = definitionString.split(' ').removeEmptySpaces();

            if (definitionParameters.length === 2) {
                if (definitionValue.indexOf(',') < 0) {
                    stack[definitionParameters[1]] = asignValue(definitionValue);
                }
                else {
                    stack[definitionParameters[1]] = buildArray(definitionValue);
                }
            }
            else if (definitionParameters.length === 3) {
                if (definitionParameters[2] === 'sum') {
                    stack[definitionParameters[1]] = sum(buildArray(definitionValue));
                }
                else if (definitionParameters[2] === 'max') {
                    stack[definitionParameters[1]] = max(buildArray(definitionValue));
                }
                else if (definitionParameters[2] === 'min') {
                    stack[definitionParameters[1]] = min(buildArray(definitionValue));
                }
                else if (definitionParameters[2] === 'avg') {
                    stack[definitionParameters[1]] = avg(buildArray(definitionValue));
                }
            }
        }
        else {
            definitionValue = extraxtBracketString(lines[i]);
            definitionString = lines[i].replace(definitionValue, '').trim();
            if (definitionString === '') {
                answer = stack[definitionValue.replace('[', '').replace(']', '')];
            }
            else {
                if (definitionString === 'sum') {
                    answer = sum(buildArray(definitionValue));
                }
                else if (definitionString === 'max') {
                    answer = max(buildArray(definitionValue));
                }
                else if (definitionString === 'min') {
                    answer = min(buildArray(definitionValue));
                }
                else if (definitionString === 'avg') {
                    answer = avg(buildArray(definitionValue));
                }
            }
        }
    }
    return answer;
}

console.log(solve(example));
console.log(solve(example1));
console.log(solve(example2));
console.log(solve(example3));
