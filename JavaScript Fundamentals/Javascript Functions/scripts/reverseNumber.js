jsConsole.writeLine('----------------------------------------------------------');
jsConsole.writeLine('Problem 2: Write a function that reverses the digits of given decimal number.');
jsConsole.writeLine('----------------------------------------------------------');
console.log('----------------------------------------------------------');
console.log('Problem 2: Write a function that reverses the digits of given decimal number.');
console.log('----------------------------------------------------------');



function reverseNumber(number) {
    var numberAsString = number.toString();
    var reversedNumber = numberAsString.split('').reverse().join('');
    var result = reversedNumber - 0;
    jsConsole.writeLine(result);
    console.log(result);
}

reverseNumber(256);
reverseNumber(123.45);