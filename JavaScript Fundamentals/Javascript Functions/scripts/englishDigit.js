jsConsole.writeLine('----------------------------------------------------------');
jsConsole.writeLine('Problem 1: Write a function that returns the last digit of given integer as an English word.');
jsConsole.writeLine('----------------------------------------------------------');
console.log('----------------------------------------------------------');
console.log('Problem 1: Write a function that returns the last digit of given integer as an English word.');
console.log('----------------------------------------------------------');

function printLastDigitAsEnglishWord(number) {
    var num = number % 10;
    switch (num) {
        case 0: console.log(number + " => " + '"zero"');
            jsConsole.writeLine(number + " => " + '"zero"'); break;
        case 1: console.log(number + " => " + '"one"');
            jsConsole.writeLine(number + " => " + '"one"'); break;
        case 2: console.log(number + " => " + '"two"');
            jsConsole.writeLine(number + " => " + '"two"'); break;
        case 3: console.log(number + " => " + '"three"');
            jsConsole.writeLine(number + " => " + '"three"'); break;
        case 4: console.log(number + " => " + '"four"');
            jsConsole.writeLine(number + " => " + '"four"'); break;
        case 5: console.log(number + " => " + '"five"');
            jsConsole.writeLine(number + " => " + '"five"'); break;
        case 6: console.log(number + " => " + '"six"');
            jsConsole.writeLine(number + " => " + '"six"'); break;
        case 7: console.log(number + " => " + '"seven"');
            jsConsole.writeLine(number + " => " + '"seven"'); break;
        case 8: console.log(number + " => " + '"eight"');
            jsConsole.writeLine(number + " => " + '"eight"'); break;
        case 9: console.log(number + " => " + '"nine"');
            jsConsole.writeLine(number + " => " + '"nine"'); break;
        default: jsConsole.writeLine("Error"); break;
    }
}

printLastDigitAsEnglishWord(512);
printLastDigitAsEnglishWord(1024);
printLastDigitAsEnglishWord(12309);