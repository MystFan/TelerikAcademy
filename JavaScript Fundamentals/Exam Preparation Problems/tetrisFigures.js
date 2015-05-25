/**
 * Created by User on 17.5.2015 ã..
 */

var test1 = [
    '--o--o-',
    '--oo-oo',
    'ooo-oo-',
    '-ooooo-',
    '---oo--'
];

var test2 = [
    '-oo',
    'ooo',
    'ooo'
];

function solve(params){
    var rows, cols, matrix, i, j, iFigureCount, lFigureCount, jFigureCount, oFigureCount, zFigureCount, sFigureCount, tFigureCount, result;
    rows = params.length;
    cols = params[0].length;
    matrix = [];
    for (i = 0; i < rows; i++) {
        matrix[i] = new Array(cols);
        for (j = 0; j < cols; j++) {
            matrix[i][j] = params[i][j];
        }
    }
    iFigureCount = iCount(matrix);
    lFigureCount = lCount(matrix);
    jFigureCount = jCount(matrix);
    oFigureCount = oCount(matrix);
    zFigureCount = zCount(matrix);
    sFigureCount = sCount(matrix);
    tFigureCount = tCount(matrix);
    result = {"I":iFigureCount,"L":lFigureCount,"J":jFigureCount,"O":oFigureCount,"Z":zFigureCount,"S":sFigureCount,"T":tFigureCount};

    function iCount(arr){
        var counter = 0;
        for (var i = 0; i < arr.length - 3; i++) {
            for (var j = 0; j < arr[i].length; j++) {
                if(arr[i][j] === 'o' && arr[i + 1][j] === 'o' && arr[i + 2][j] === 'o' && arr[i + 3][j] === 'o'){
                    counter++;
                }
            }
        }
        return counter;
    }
    function lCount(arr){
        var counter = 0;
        for (var i = 0; i < arr.length - 2; i++) {
            for (var j = 0; j < arr[i].length - 1; j++) {
                if(arr[i][j] === 'o' && arr[i + 1][j] === 'o' && arr[i + 2][j] === 'o' && arr[i + 2][j + 1] === 'o'){
                    counter++;
                }
            }
        }
        return counter;
    }

    function jCount(arr){
        var counter = 0;
        for (var i = 0; i < arr.length - 2; i++) {
            for (var j = 1; j < arr[i].length; j++) {
                if(arr[i][j] === 'o' && arr[i + 1][j] === 'o' && arr[i + 2][j] === 'o' && arr[i + 2][j - 1] === 'o'){
                    counter++;
                }
            }
        }
        return counter;
    }

    function oCount(arr){
        var counter = 0;
        for (var i = 0; i < arr.length - 1; i++) {
            for (var j = 0; j < arr[i].length - 1; j++) {
                if(arr[i][j] === 'o' && arr[i + 1][j] === 'o' && arr[i][j + 1] === 'o' && arr[i + 1][j + 1] === 'o'){
                    counter++;
                }
            }
        }
        return counter;
    }

    function zCount(arr){
        var counter = 0;
        for (var i = 0; i < arr.length - 1; i++) {
            for (var j = 0; j < arr[i].length - 2; j++) {
                if(arr[i][j] === 'o' && arr[i][j + 1] === 'o' && arr[i + 1][j + 1] === 'o' && arr[i + 1][j + 2] === 'o'){
                    counter++;
                }
            }
        }
        return counter;
    }
    function sCount(arr){
        var counter = 0;
        for (var i = 0; i < arr.length - 1; i++) {
            for (var j = 0; j < arr[i].length - 2; j++) {
                if(arr[i][j + 1] === 'o' && arr[i][j + 2] === 'o' && arr[i + 1][j] === 'o' && arr[i + 1][j + 1] === 'o'){
                    counter++;
                }
            }
        }
        return counter;
    }
    function tCount(arr){
        var counter = 0;
        for (var i = 0; i < arr.length - 1; i++) {
            for (var j = 0; j < arr[i].length - 2; j++) {
                if(arr[i][j] === 'o' && arr[i][j + 1] === 'o' && arr[i][j + 2] === 'o' && arr[i + 1][j + 1] === 'o'){
                    counter++;
                }
            }
        }
        return counter;
    }

    return JSON.stringify(result);
}
console.log(solve(test1));
console.log(solve(test2));
