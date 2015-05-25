/**
 * Created by User on 18.5.2015 ã..
 */

var test1 = [
    'Rotate(90)',
    'hello',
    'softuni',
    'exam'
];

var test2 = [
    'Rotate(180)',
    'hello',
    'softuni',
    'exam'
];

var test3 = [
    'Rotate(270)',
    'hello',
    'softuni',
    'exam'
];

var test4 = [
    'Rotate(720)',
    'js',
    'exam'
];

var test5 = [
    'Rotate(810)',
    'js',
    'exam'
];

var test6 = [
    'Rotate(0)',
    'js',
    'exam'
];
// 100 Points
function solve(params){
   var matrix, width, whiteSpacesCount, i, rotate;
    width = getLongestWordLength(params);
    matrix = [];
    for (i = 1; i < params.length; i++) {
        matrix[i - 1] = params[i].split('');
        whiteSpacesCount = width - matrix[i - 1].length;
        matrix[i - 1] = matrix[i - 1].concat(createString(' ', whiteSpacesCount).split(''));
    }

    rotate = getRotateValue(params[0]);

    switch(rotate){
        case 0: printResult(matrix); break;
        case 1: printResult(rotateMatrixOneTime(matrix));break;
        case 2: printResult(rotateMatrixTwoTimes(matrix));break;
        case 3: printResult(rotateMatrixThreeTimes(matrix));break;
    }

    function rotateMatrixOneTime(array){
        var i, j, k;
        var height = array[0].length;
        var width = array.length;
        var resultMatrix = [];
        for (i = 0; i < height; i++) {
            resultMatrix[i] = new Array(array.length);
        }
        for (j = 0; j < resultMatrix[0].length; j++) {
            for (k = 0; k < resultMatrix.length; k++) {
                resultMatrix[k][j] = array[(width - j) - 1][k];
            }
        }
        return resultMatrix;
    }
    function rotateMatrixTwoTimes(array){
        var resultMatrix = array.reverse();
        for (var j = 0; j < resultMatrix.length; j++) {
            resultMatrix[j] = resultMatrix[j].reverse();
        }
        return resultMatrix;
    }
    function rotateMatrixThreeTimes(array){
        var resultMatrix = rotateMatrixTwoTimes(array);
        resultMatrix = rotateMatrixOneTime(resultMatrix);
        return resultMatrix;
    }
    function printResult(array){
        for (var j = 0; j < array.length; j++) {
            console.log(array[j].join(''));
        }
    }
    function getLongestWordLength(words){
        var len, maxLen, position, i;
        maxLen = 0;
        len = 0;
        for (i = 1; i < words.length; i++) {
            len = words[i].length;
            if(len > maxLen){
                maxLen = len;
                position = i;
            }
        }
        return words[position].length;
    }
    function createString(char, length){
        var str = '';
        for (var i = 0; i < length; i++) {
            str += char;
        }
        return str;
    }
    function getRotateValue(str){
        var startBraketIndex = str.indexOf('(');
        var endBraketIndex = str.indexOf(')');
        var number = str.substring(startBraketIndex + 1, endBraketIndex) - 0;
        var result = 0;
        if(number / 90 < 4){
            result = number / 90;
        }
        else if(number / 90 === 4){
            result = 0;
        }
        else if(number / 90 > 4){
            var precision = (parseFloat((number / 90) / 4) + "").split(".")[1] - 0;
            if(precision === 25){
                result = 1;
            }
            else if(precision === 5){
                result = 2;
            }
            else if(precision === 75){
                result = 3;
            }
        }
        return result;
    }
}


solve(test1);
console.log('-----------------');
solve(test2);
console.log('-----------------');
solve(test3);
console.log('-----------------');
solve(test4);
console.log('-----------------');
solve(test5);
console.log('-----------------');
solve(test6);
