
jsConsole.writeLine('-------------------------------------------------------------------------------');
jsConsole.writeLine('Problem 2: Write a script that shows the sign (+ or -) of the product of three real numbers without calculating it. Use a sequence of if operators.');
jsConsole.writeLine('-------------------------------------------------------------------------------');
console.log('-------------------------------------------------------------------------------');
console.log('Problem 2: Write a script that shows the sign (+ or -) of the product of three real numbers without calculating it. Use a sequence of if operators.');
console.log('-------------------------------------------------------------------------------');
function findSign() {
    var firstRealValue, secondRealValue, thirdRealValue, firstRealNumber, secondRealNumber, thirdRealNumber, firstRealSign, secondRealSign, thirdRealSign;
    firstRealValue = document.getElementById('tb-first').value;
    secondRealValue = document.getElementById('tb-second').value;
    thirdRealValue = document.getElementById('tb-third').value;
    firstRealNumber = firstRealValue - 0;
    secondRealNumber = secondRealValue - 0;
    thirdRealNumber = thirdRealValue - 0;

    if (isNaN(firstRealNumber) || isNaN(secondRealNumber) || isNaN(thirdRealNumber)) {
        jsConsole.writeLine('Invalid input numbers');
        console.log('Invalid input numbers');
        return;
    }

    if (firstRealNumber === 0 || secondRealNumber === 0 || thirdRealNumber === 0) {
        jsConsole.writeLine('"0"');
        console.log('"0"');
    }
    if (firstRealNumber < 0 && secondRealNumber < 0 && thirdRealNumber < 0) {
        jsConsole.writeLine('"-"');
        console.log('"-"');
    }
    if((firstRealNumber < 0 && secondRealNumber > 0 && thirdRealNumber > 0) || (secondRealNumber < 0 && firstRealNumber > 0 && thirdRealNumber > 0)
        || (thirdRealNumber < 0 && firstRealNumber > 0 && secondRealNumber > 0)) {
        jsConsole.writeLine('"-"');
        console.log('"-"');
    }
    if((firstRealNumber < 0 && secondRealNumber < 0 && thirdRealNumber > 0) || (firstRealNumber < 0 && thirdRealNumber < 0 && secondRealNumber > 0)
        || (secondRealNumber < 0 && thirdRealNumber < 0 && firstRealNumber > 0)) {
        jsConsole.writeLine('"+"');
        console.log('"+"');
    }
    if (firstRealNumber > 0 && secondRealNumber > 0 && thirdRealNumber > 0) {
        jsConsole.writeLine('"+"');
        console.log('"+"');
    }
}