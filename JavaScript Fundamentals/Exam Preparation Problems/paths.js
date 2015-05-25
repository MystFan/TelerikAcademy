/**
 * Created by User on 25.5.2015 ã..
 */

var args1 =[
    '3 5',
    'dr dl dr ur ul',
    'dr dr ul ur ur',
    'dl dr ur dl ur'
];
var args2 = [
    '3 5',
    'dr dl dl ur ul',
    'dr dr ul ul ur',
    'dl dr ur dl ur'
]

function solve(params) {
    var size = params[0].split(' ');
    var matrix = new Array(parseInt(size[0]));
    var numberMatrix = new Array(parseInt(size[0]));
    var counter = 1;
    var startCounter = 1;
    var cells;
    var sum = 0;
    for (var row = 0; row < matrix.length; row++) {
        matrix[row] = new Array(parseInt(size[1]));
        cells = params[row + 1].split(' ');
        for (var j = 0; j < matrix[row].length; j++) {
            matrix[row][j] = cells[j];
        }
    }

    for (var row = 0; row < numberMatrix.length; row++) {
        numberMatrix[row] = new Array(parseInt(size[1]));
        counter = Math.pow(2, row);
        for (var col = 0; col < numberMatrix[row].length; col++) {
            numberMatrix[row][col] = counter;
            counter++;
        }
    }
    var row = 0;
    var col = 0;
    while (true) {

        if (row >= parseInt(size[0]) || row < 0 || col >= parseInt(size[1]) || col < 0) {
            return 'successed with ' + sum;
        }
        if (matrix[row][col] === 'v') {
            return 'failed at '+ '('+row+', '+col+ ')'
        }

        if (matrix[row][col] === 'dr') {
            matrix[row][col] = 'v';
            sum = sum + numberMatrix[row][col];
            row+=1;
            col+=1;
            if (row >= parseInt(size[0]) || row < 0 || col >= parseInt(size[1]) || col < 0) {
                return 'successed with ' + sum;
            }
        }
        if (matrix[row][col] === 'dl') {
            matrix[row][col] = 'v';
            sum = sum + numberMatrix[row][col];
            row+=1;
            col-=1;
            if (row >= parseInt(size[0]) || row < 0 || col >= parseInt(size[1]) || col < 0) {
                return 'successed with ' + sum;
            }

        }
        if (matrix[row][col] === 'ul') {
            matrix[row][col] = 'v';
            sum = sum + numberMatrix[row][col];
            row-=1;
            col-=1;
            if (row >= parseInt(size[0]) || row < 0 || col >= parseInt(size[1]) || col < 0) {
                return 'successed with ' + sum;
            }


        }
        if (matrix[row][col] === 'ur') {
            matrix[row][col] = 'v';
            sum = sum + numberMatrix[row][col];
            row--;
            col++;
            if (row >= parseInt(size[0]) || row < 0 || col >= parseInt(size[1]) || col < 0) {
                return 'successed with ' + sum;
            }

        }
    }

}


console.log(solve(args1));
console.log(solve(args2));
