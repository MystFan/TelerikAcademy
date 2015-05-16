
jsConsole.writeLine('-------------------------------------------------------------------------------');
jsConsole.writeLine('Problem 3: Write a script that finds the biggest of three numbers. Use nested if statements.');
jsConsole.writeLine('-------------------------------------------------------------------------------');
console.log('-------------------------------------------------------------------------------');
console.log('Problem 3: Write a script that finds the biggest of three numbers. Use nested if statements.');
console.log('-------------------------------------------------------------------------------');


function findBiggestNumber() {
    var firstValue, secondValue, thirdValue, firstNumber, secondNumber, thirdNumber, biggest;
    firstValue = document.getElementById("tb-first").value;
    secondValue = document.getElementById("tb-second").value;
    thirdValue = document.getElementById("tb-third").value;
    firstNumber = firstValue - 0;
    secondNumber = secondValue - 0;
    thirdNumber = thirdValue - 0;

    if (isNaN(firstNumber) || isNaN(secondNumber) || isNaN(thirdNumber)) {
        jsConsole.writeLine('Invalid input numbers');
        return;
    }

    biggest = firstNumber;
    if (secondNumber > biggest) {
        if (secondNumber > thirdNumber) {
            biggest = secondNumber;
        }
    }
    if (thirdNumber > biggest) {
        if (thirdNumber > secondNumber) {
            biggest = thirdNumber;
        }
    }
    jsConsole.writeLine(biggest);
    console.log(biggest);
}