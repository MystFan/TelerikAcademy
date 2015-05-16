
jsConsole.writeLine('-------------------------------------------------------------------------------');
jsConsole.writeLine('Problem 1: Write an if statement that examines two integer variables and exchanges their values if the first one is greater than the second one.As a result print the values a and b, separated by a space.');
jsConsole.writeLine('-------------------------------------------------------------------------------');
console.log('-------------------------------------------------------------------------------');
console.log('Problem 1: Write an if statement that examines two integer variables and exchanges their values if the first one is greater than the second one.As a result print the values a and b, separated by a space.');
console.log('-------------------------------------------------------------------------------');

function compareNumbers() {
    var firstValue, secondValue, firstNumber, secondNumber, max;
    firstValue = document.getElementById('tb-first').value;
    secondValue = document.getElementById('tb-second').value;
    firstNumber = firstValue - 0;
    secondNumber = secondValue - 0;
    
    if (isNaN(firstNumber) || isNaN(secondNumber)) {
        jsConsole.writeLine('Invalid input numbers');
        return;
    }

    if (firstNumber !== secondNumber) {
        max = firstNumber;
        if (max < secondNumber) {
            max = secondNumber;
            jsConsole.writeLine(firstNumber + ' ' + max);
            console.log(firstNumber + ' ' + max);
        }
        else {
            jsConsole.writeLine('First number is greater, exchange values');
            console.log('First number is greater, exchange values');
            firstNumber = secondNumber;
            secondNumber = max;
            jsConsole.writeLine(firstNumber + ' ' + max);
            console.log(firstNumber + ' ' + max);
        }
    }
    else {
        jsConsole.writeLine('Numbers are equal');
        console.log('Numbers are equal');
    }

}