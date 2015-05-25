
var example1 = [

"(def func 10)",
"(def newFunc (+  func 2))",
"(def sumFunc (+ func func newFunc 0 0 0))",
"(* sumFunc 2)"

]

var example2 = [
'(def func (+ 5 2))',
'(def func2 (/  func 5 2 1 0))',
'(def func3 (/ func 2))',
'(+ func3 func)'

];


var example3 = [
'(def kir4o 100)',
'(def cafeFunc (+ kir4o kir4o 3))',
'(def tabFunc (* cafeFunc 7))',
'(def tabfunc (- kir4o 5 4 3 2 1))',
'(/ tabFunc  tabfunc)',
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
    Array.prototype.removeAt = function (index) {
        var result = [];
        for (var i = 0; i < this.length; i++) {
            if (i !== index) {
                result.push(this[i]);
            }
        }
        return result;
    }
    function removeFirstLastChar(line) {
        var result = '';
        for (var i = 1; i < line.length - 1; i++) {
            result += line[i];
        }
        return result;
    }
    function extraxtBracketString(line) {
        var startIndex = line.indexOf('(');
        var endIndex = line.indexOf(')') + 1;
        var result = line.substring(startIndex, endIndex);
        return result;
    }
    function multiplication(args) {
        var result = 1;
        for (var i = 0; i < args.length; i++) {
            if (stack.hasOwnProperty(args[i])) {
                result *= stack[args[i]];
            }
            else {
                result *= args[i] - 0;
            }
        }
        return result;
    }
    function partition(args) {
        var result, number;
        if (args.length === 1) {
            if (stack.hasOwnProperty(args[0])) {
                return stack[args[0]];
            }
            else {
                return args[0] - 0;
            }
        }
        else {
            if (stack.hasOwnProperty(args[0])) {
                result = stack[args[0]];
            }
            else {
                result = args[0] - 0;
            }
        }

        for (var i = 1; i < args.length; i++) {
            if (stack.hasOwnProperty(args[i])) {
                number = stack[args[i]];
            }
            else {
                number = args[i] - 0;
            }

            if (number === 0) {
                return 'Division by zero! At Line:';
            }

            result = parseInt(result / number);
        }
        return result;
    }
    function sum(args) {
        var sum = 0;
        for (var i = 0; i < args.length; i++) {
            if (stack.hasOwnProperty(args[i])) {
                sum += stack[args[i]];
            }
            else {
                sum += args[i] - 0;
            }
        }
        return sum;
    }
    function subtraction(args) {
        var result = 0;
        if (args.length === 1) {
            if (stack.hasOwnProperty(args[i])) {
                return stack[args[0]];
            }
            else {
                return args[0] - 0;
            }
        }
        result = args[0] - 0 ? args[0] - 0 : stack[args[0]];
        for (var i = 1; i < args.length; i++) {
            if (stack.hasOwnProperty(args[i])) {
                result -= stack[args[i]];
            }
            else {
                result -= args[i] - 0;
            }
        }
        return result;
    }
    var lines, i, expressionParams, stack, defParams,resultParams, operation ,bracketExpression, answer;
    lines = [];
    for (i = 0; i < params.length; i++) {
        lines.push(removeFirstLastChar(params[i]));
    }

    stack = [];
    answer = 0;
    for (i = 0; i < lines.length; i++) {

        if (lines[i].startWith('def')) {

            if (lines[i].indexOf('(') >= 0) {
                bracketExpression = extraxtBracketString(lines[i]);
                defParams = lines[i].replace(bracketExpression, '').split(' ').removeEmptySpaces();
                resultParams = removeFirstLastChar(bracketExpression).split(' ').removeEmptySpaces();
                operation = resultParams[0];
                if (operation === '*') {
                    stack[defParams[1]] = multiplication(resultParams.removeAt(0));
                }
                else if (operation === '/') {
                    stack[defParams[1]] = partition(resultParams.removeAt(0));

                    if (typeof(stack[defParams[1]]) === 'string') {
                        answer = stack[defParams[1]] + (i + 1);
                        break;
                    }
                }
                else if (operation === '+') {
                    stack[defParams[1]] = sum(resultParams.removeAt(0));
                }
                else if (operation === '-') {
                    stack[defParams[1]] = subtraction(resultParams.removeAt(0));
                }
            }
            else {
                defParams = lines[i].split(' ').removeEmptySpaces();
                if (stack.hasOwnProperty(defParams[2])) {
                    stack[defParams[1]] = stack[defParams[2]];
                }
                else {
                    stack[defParams[1]] = defParams[2] - 0;
                }
            }
        }
        else {
            resultParams = lines[i].split(' ').removeEmptySpaces();
            operation = resultParams[0];
            if (operation === '*') {
                answer = multiplication(resultParams.removeAt(0));
            }
            else if (operation === '/') {
                answer = partition(resultParams.removeAt(0));
                if (answer instanceof String) {
                    answer = answer + (i + 1);
                    break;
                }
            }
            else if (operation === '+') {
                answer = sum(resultParams.removeAt(0));
            }
            else if (operation === '-') {
                answer = subtraction(resultParams.removeAt(0));
            }
        }
    }
    return answer;
}
console.log(solve(example1));
console.log(solve(example2));
console.log(solve(example3));