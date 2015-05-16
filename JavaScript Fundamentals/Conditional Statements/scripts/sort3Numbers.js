
jsConsole.writeLine('-------------------------------------------------------------------------------');
jsConsole.writeLine('Problem 4: Sort 3 real values in descending order. Use nested if statements.');
jsConsole.writeLine('-------------------------------------------------------------------------------');
console.log('-------------------------------------------------------------------------------');
console.log('Problem 4: Sort 3 real values in descending order. Use nested if statements.');
console.log('-------------------------------------------------------------------------------');

function sortDescendingOrder() {
    var firstValue, secondValue, thirdValue, firstNumber, secondNumber, thirdNumber, biggest;
    firstValue = document.getElementById('tb-first').value;
    secondValue = document.getElementById('tb-second').value;
    thirdValue = document.getElementById('tb-third').value;
    firstNumber = firstValue - 0;
    secondNumber = secondValue - 0;
    thirdNumber = thirdValue - 0;

    if (isNaN(firstNumber) || isNaN(secondNumber) || isNaN(thirdNumber)) {
        jsConsole.writeLine('Invalid input numbers');
        console.log('Invalid input numbers');
        return;
    }

    var biggest = firstNumber;
    if (secondNumber > biggest) {
        if (secondValue > thirdNumber) {
            biggest = secondNumber;
            if (firstNumber > thirdNumber) {
                jsConsole.writeLine(biggest + ', ' + firstNumber + ', ' + thirdNumber);
                console.log(biggest + ', ' + firstNumber + ', ' + thirdNumber);
            }
            else {
                jsConsole.writeLine(biggest + ', ' + thirdNumber + ', ' + firstNumber);
                console.log(biggest + ', ' + thirdNumber + ', ' + firstNumber);
            }
        }
    }
    if (thirdNumber > biggest) {
        if (thirdNumber > secondNumber) {
            biggest = thirdNumber;
            if (secondNumber > firstNumber) {
                jsConsole.writeLine(biggest + ', ' + secondNumber + ', ' + firstNumber);
                console.log(biggest + ', ' + secondNumber + ', ' + firstNumber);
            }
            else {
                jsConsole.writeLine(biggest + ', ' + firstNumber + ', ' + secondNumber);
                console.log(biggest + ', ' + firstNumber + ', ' + secondNumber);
            }
        }
    }
    if (secondNumber > thirdNumber && firstNumber === biggest) {
        jsConsole.writeLine(biggest + ', ' + secondNumber + ', ' + thirdNumber);
        console.log(biggest + ', ' + secondNumber + ', ' + thirdNumber);
    }
    if (thirdNumber > secondNumber && firstNumber === biggest) {
        jsConsole.writeLine(biggest + ', ' + thirdNumber + ', ' + secondNumber);
        console.log(biggest + ', ' + thirdNumber + ', ' + secondNumber);
    }
}