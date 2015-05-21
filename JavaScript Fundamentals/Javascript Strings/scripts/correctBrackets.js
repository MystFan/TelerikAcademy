/// <reference path="js-console.js"/>

print('Problem 2: Write a JavaScript function to check if in a given expression the brackets are put correctly.');

var expression1 = '((a + b)/5 - d)';
var expression2 = ')(a + b))';

function isExpressionBracketsCorrectly(expression) {
    var i, openBrackets = [];
    var isValid = false;
    for (i = 0; i < expression.length; i++) {
        if (expression[i] === '(') {
            openBrackets.push(expression[i]);
        }
        else if (expression[i] === ')') {
            if (openBrackets.length === 0) {
                return isValid;
            }
            openBrackets.pop();
        }
    }

    if (openBrackets.length === 0) {
        isValid = true;
    }

    return isValid;
}

jsConsole.writeLine(expression1 + ' --> ' + isExpressionBracketsCorrectly(expression1));
jsConsole.writeLine(expression2 + ' --> ' + isExpressionBracketsCorrectly(expression2));
console.log(expression1 + ' --> ' + isExpressionBracketsCorrectly(expression1));
console.log(expression2 + ' --> ' + isExpressionBracketsCorrectly(expression2));