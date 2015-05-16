
jsConsole.writeLine('-------------------------------------------------------------------------------');
jsConsole.writeLine('Problem 7: Write a script that finds the greatest of given 5 variables.Use nested if statements.');
jsConsole.writeLine('-------------------------------------------------------------------------------');
console.log('-------------------------------------------------------------------------------');
console.log('Problem 7: Write a script that finds the greatest of given 5 variables.Use nested if statements.');
console.log('-------------------------------------------------------------------------------');

function graetestNumber() {
    var firstNumber = document.getElementById('tb-first').value - 0;
    var secondNumber = document.getElementById('tb-second').value - 0;
    var thirdNumber = document.getElementById('tb-third').value - 0;
    var fourNumber = document.getElementById('tb-four').value - 0;
    var fiveNumber = document.getElementById('tb-five').value - 0;

    if (isNaN(firstNumber) || isNaN(secondNumber) || isNaN(thirdNumber) || isNaN(fourNumber) || isNaN(fiveNumber)) {
        jsConsole.writeLine('Invalid input number.');
        console.log('Invalid input number.');
        return;
    }

    var greater = firstNumber;
    if (secondNumber > greater) {
        if (secondNumber > thirdNumber) {
            if (secondNumber > fourNumber) {
                if (secondNumber > fiveNumber) {
                    greater = secondNumber;
                    jsConsole.writeLine(greater);
                    console.log(greater);
                }
            }
        }
    }
    if (thirdNumber > greater) {
        if (thirdNumber > secondNumber) {
            if (thirdNumber > fourNumber) {
                if (thirdNumber > fiveNumber) {
                    greater = thirdNumber;
                    jsConsole.writeLine(greater);
                    console.log(greater);
                }
            }
        }
    }
    if (fourNumber > greater) {
        if (fourNumber > secondNumber) {
            if (fourNumber > thirdNumber) {
                if (fourNumber > fiveNumber) {
                    greater = fourNumber;
                    jsConsole.writeLine(greater);
                    console.log(greater);
                }
            }
        }
    }
    if (fiveNumber > greater) {
        if (fiveNumber > secondNumber) {
            if (fiveNumber > thirdNumber) {
                if (fiveNumber > fourNumber) {
                    greater = fiveNumber;
                    jsConsole.writeLine(greater);
                    console.log(greater);
                }
            }
        }
    }
    if (firstNumber === greater) {
        jsConsole.writeLine(greater);
        console.log(greater);
    }
}