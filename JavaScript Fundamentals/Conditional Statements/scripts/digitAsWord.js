
jsConsole.writeLine('-------------------------------------------------------------------------------');
jsConsole.writeLine('Problem 5: Write script that asks for a digit and depending on the input shows the name of that digit (in English).Print “not a digit” in case of invalid input. Use a switch statement.');
jsConsole.writeLine('-------------------------------------------------------------------------------');
console.log('-------------------------------------------------------------------------------');
console.log('Problem 5: Write script that asks for a digit and depending on the input shows the name of that digit (in English).Print “not a digit” in case of invalid input. Use a switch statement.');
console.log('-------------------------------------------------------------------------------');

function digitName() {
    var digit = document.getElementById('tb-first').value - 0;

    if (isNaN(didit)) {
        jsConsole.writeLine('Invalid input number.');
        console.log('Invalid input number.');
        return;
    }

    if (digit < 0) {
        digit = digit * (-1);
    }
    switch (digit) {
        case 0: jsConsole.writeLine('Zero'); console.log('Zero'); break;
        case 1: jsConsole.writeLine('One'); console.log('One'); break;
        case 2: jsConsole.writeLine('Two'); console.log('Two'); break;
        case 3: jsConsole.writeLine('Three'); console.log('Three'); break;
        case 4: jsConsole.writeLine('Four'); console.log('Four'); break;
        case 5: jsConsole.writeLine('Five'); console.log('Five'); break;
        case 6: jsConsole.writeLine('Six'); console.log('Six'); break;
        case 7: jsConsole.writeLine('Seven'); console.log('Seven'); break;
        case 8: jsConsole.writeLine('Eight'); console.log('Eight'); break;
        case 9: jsConsole.writeLine('Nine'); console.log('Nine'); break;
        default:
            jsConsole.writeLine('not a digit');
            console.log('not a digit');
            break;
    }
}