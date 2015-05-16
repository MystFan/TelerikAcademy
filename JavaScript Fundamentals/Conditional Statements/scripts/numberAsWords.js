
jsConsole.writeLine('-------------------------------------------------------------------------------');
jsConsole.writeLine('Problem 8: Write a script that converts a number in the range [0...999] to a text corresponding to its English pronunciation.');
jsConsole.writeLine('-------------------------------------------------------------------------------');
console.log('-------------------------------------------------------------------------------');
console.log('Problem 8: Write a script that converts a number in the range [0...999] to a text corresponding to its English pronunciation.');
console.log('-------------------------------------------------------------------------------');

function numberName() {
    var number = document.getElementById('tb-number').value;
    var num = parseInt(number);

    if (isNaN(num)) {
        jsConsole.writeLine('Invalid input number.');
        console.log('Invalid input number.');
        return;
    }
    else if (num > 999 || num < 0) {
        jsConsole.writeLine('Number must be between 0 and 999');
        console.log('Number must be between 0 and 999');
        return;
    }

    var currentNum = 0;
    var count = 0;
    do {
        currentNum = num % 10;
        num = num - currentNum;
        num = num / 10;
        count++;
    } while (num !== 0);

    if (count === 1) {
        num = number;
        switch (num) {
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
            default: jsConsole.writeLine('Not digit'); break;

        }

    }
    currentNum = 0;
    num = parseInt(number);
    if (count === 2) {
        if (number <= 20) {
            switch (number) {
                case 10: jsConsole.writeLine('Ten '); console.log('Ten '); break;
                case 11: jsConsole.writeLine('Eleven '); console.log('Eleven '); break;
                case 12: jsConsole.writeLine('Twelve '); console.log('Twelve '); break;
                case 13: jsConsole.writeLine('Thirteen'); console.log('Thirteen'); break;
                case 14: jsConsole.writeLine('Fourteen'); console.log('Fourteen'); break;
                case 15: jsConsole.writeLine('Fifteen'); console.log('Fifteen'); break;
                case 16: jsConsole.writeLine('Sixteen'); console.log('Sixteen'); break;
                case 17: jsConsole.writeLine('Seventeen'); console.log('Seventeen'); break;
                case 18: jsConsole.writeLine('Eighteen'); console.log('Eighteen'); break;
                case 19: jsConsole.writeLine('Nineteen'); console.log('Nineteen'); break;
                case 20: jsConsole.writeLine('Twenty'); console.log('Twenty'); break;
                default: jsConsole.writeLine('Not digit'); console.log('Not digit'); break;
            }
        }
        if (number > 20) {
            currentNum = num % 10;
            num = num - currentNum;
            num = num / 10;
            switch (num) {
                case 2: jsConsole.write('Twenty '); console.log('Twenty '); break;
                case 3: jsConsole.write('Thirty '); console.log('Thirty '); break;
                case 4: jsConsole.write('Forty '); console.log('Forty '); break;
                case 5: jsConsole.write('Fifty '); console.log('Fifty '); break;
                case 6: jsConsole.write('Sixty '); console.log('Sixty '); break;
                case 7: jsConsole.write('Seventy '); console.log('Seventy '); break;
                case 8: jsConsole.write('Eighty '); console.log('Eighty '); break;
                case 9: jsConsole.write('Ninety '); console.log('Ninety '); break;
                default: jsConsole.write('Not digit'); console.log('Not digit'); break;
            }
            num = number;
            currentNum = 0;
            currentNum = num % 10;
            if (currentNum !== 0) {
                switch (currentNum) {
                    case 1: jsConsole.writeLine('One'); console.log('One'); break;
                    case 2: jsConsole.writeLine('Two'); console.log('Two'); break;
                    case 3: jsConsole.writeLine('Three'); console.log('Three'); break;
                    case 4: jsConsole.writeLine('Four'); console.log('Four'); break;
                    case 5: jsConsole.writeLine('Five'); console.log('Five'); break;
                    case 6: jsConsole.writeLine('Six'); console.log('Six'); break;
                    case 7: jsConsole.writeLine('Seven'); console.log('Seven'); break;
                    case 8: jsConsole.writeLine('Eight'); console.log('Eight'); break;
                    case 9: jsConsole.writeLine('Nine'); console.log('Nine'); break;
                    default: jsConsole.writeLine('Not digit'); console.log('Not digit'); break;

                }
            }
        }
    }
    if (count === 3) {
        num = number;
        currentNum = 0;
        currentNum = num % 100;
        num = num - currentNum;
        num = num / 100;
        switch (num) {
            case 1: jsConsole.write('One Hundred '); console.log('One Hundred '); break;
            case 2: jsConsole.write('Two Hundred '); console.log('Two Hundred '); break;
            case 3: jsConsole.write('Three Hundred '); console.log('Three Hundred '); break;
            case 4: jsConsole.write('Four Hundred '); console.log('Four Hundred '); break;
            case 5: jsConsole.write('Five Hundred '); console.log('Five Hundred '); break;
            case 6: jsConsole.write('Six Hundred '); console.log('Six Hundred '); break;
            case 7: jsConsole.write('Seven Hundred '); console.log('Seven Hundred '); break;
            case 8: jsConsole.write('Eight Hundred '); console.log('Eight Hundred '); break;
            case 9: jsConsole.write('Nine Hundred '); console.log('Nine Hundred '); break;
            default: jsConsole.write('Not digit'); console.log('Not digit'); break;
        }

        if (currentNum !== 0) {
            jsConsole.write(' and ');

            if (currentNum < 10) {
                switch (currentNum) {
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
                    default: jsConsole.writeLine('Not digit'); console.log('Not digit'); break;
                }
            }
            if (currentNum >= 10) {
                if (currentNum <= 20) {
                    switch (currentNum) {
                        case 10: jsConsole.writeLine('Ten '); console.log('Ten '); break;
                        case 11: jsConsole.writeLine('Eleven '); console.log('Eleven '); break;
                        case 12: jsConsole.writeLine('Twelve '); console.log('Twelve '); break;
                        case 13: jsConsole.writeLine('Thirteen'); console.log('Thirteen'); break;
                        case 14: jsConsole.writeLine('Fourteen'); console.log('Fourteen'); break;
                        case 15: jsConsole.writeLine('Fifteen'); console.log('Fifteen'); break;
                        case 16: jsConsole.writeLine('Sixteen'); console.log('Sixteen'); break;
                        case 17: jsConsole.writeLine('Seventeen'); console.log('Seventeen'); break;
                        case 18: jsConsole.writeLine('Eighteen'); console.log('Eighteen'); break;
                        case 19: jsConsole.writeLine('Nineteen'); console.log('Nineteen'); break;
                        case 20: jsConsole.writeLine('Twenty'); console.log('Twenty'); break;
                        default: jsConsole.writeLine('Not digit'); console.log('Not digit'); break;
                    }
                }
                if (currentNum > 20) {
                    var digit = currentNum;
                    digit = currentNum % 10;
                    num = currentNum - digit;
                    num = num / 10;
                    switch (num) {
                        case 2: jsConsole.write('Twenty '); console.log('Twenty '); break;
                        case 3: jsConsole.write('Thirty '); console.log('Thirty '); break;
                        case 4: jsConsole.write('Forty '); console.log('Forty '); break;
                        case 5: jsConsole.write('Fifty '); console.log('Fifty '); break;
                        case 6: jsConsole.write('Sixty '); console.log('Sixty '); break;
                        case 7: jsConsole.write('Seventy '); console.log('Seventy '); break;
                        case 8: jsConsole.write('Eighty '); console.log('Eighty '); break;
                        case 9: jsConsole.write('Ninety '); console.log('Ninety '); break;
                        default: jsConsole.write('Not digit'); console.log('Not digit'); break;
                    }

                    digit = currentNum;
                    num = digit % 10;

                    if (num !== 0) {

                        switch (num) {
                            case 1: jsConsole.writeLine('One'); console.log('One'); break;
                            case 2: jsConsole.writeLine('Two'); console.log('Two'); break;
                            case 3: jsConsole.writeLine('Three'); console.log('Three'); break;
                            case 4: jsConsole.writeLine('Four'); console.log('Four'); break;
                            case 5: jsConsole.writeLine('Five'); console.log('Five'); break;
                            case 6: jsConsole.writeLine('Six'); console.log('Six'); break;
                            case 7: jsConsole.writeLine('Seven'); console.log('Seven'); break;
                            case 8: jsConsole.writeLine('Eight'); console.log('Eight'); break;
                            case 9: jsConsole.writeLine('Nine'); console.log('Nine'); break;
                            default: jsConsole.writeLine('Not digit'); console.log('Not digit'); break;
                        }
                    }
                }
            }
        }
    }
}