
/// <reference path="js-console.js" />
jsConsole.writeLine('---------------------------------------------------------------------------');
jsConsole.writeLine('Problem 7: Write an expression that checks if given positive integer number n (n ≤ 100) is prime.');
jsConsole.writeLine('---------------------------------------------------------------------------');
console.log('---------------------------------------------------------------------------');
console.log('Problem 7: Write an expression that checks if given positive integer number n (n ≤ 100) is prime.');
console.log('---------------------------------------------------------------------------');

var numbers = [1, 2, 3, 4, 9, 37, 97, 51, -3, 0];
for (var i = 0; i < numbers.length; i++) {
    jsConsole.writeLine('Number: ' + numbers[i]);
    console.log('Number: ' + numbers[i]);

    if (((numbers[i] % 2 === 0) || (numbers[i] % 3 === 0) || (numbers[i] % 5 === 0) || (numbers[i] % 7 === 0) || (numbers[i] % 9 === 0) || (numbers[i] === 1))
        && (numbers[i] !== 2) && (numbers[i] !== 3) && (numbers[i] !== 5) && (numbers[i] !== 7)) {
        jsConsole.writeLine('Not Prime');
        console.log('Not Prime');
    }
    else {
        jsConsole.writeLine('Prime');
        console.log('Prime');
    }
}



function isPrime(n) {
    if (n < 2) return false;
    var q = parseInt(Math.sqrt(n));

    for (var i = 2; i <= q; i++) {
        if (n % i == 0) {
            return false;
        }
    }
    return true;
}

var primeNumbers = [];
for (var i = 0; i < 100; i++) {
    if (isPrime(i)) {
        primeNumbers.push(i);
    }
}

jsConsole.writeLine(primeNumbers.join(', '));
console.log(primeNumbers.join(', '));