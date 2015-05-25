
var args1 = [
 "3 4",
 "1 3",
 "lrrd",
 "dlll",
 "rddd"];

var args2 = [
 "5 8",
 "0 0",
 "rrrrrrrd",
 "rludulrd",
 "durlddud",
 "urrrldud",
 "ulllllll"];

var args3 = [
 "5 8",
 "0 0",
 "rrrrrrrd",
 "rludulrd",
 "lurlddud",
 "urrrldud",
 "ulllllll"];

function solve(params) {
    var result, matrixRows, matrixCols, directionsMatrix, numbersMatrix, counter, i, j, currentRow, startPosition,
    startRow, startCol, line, row, col, sum, isOut, numberCells;
    var matrixSizes = params[0].split(' ');
    matrixRows = matrixSizes[0] - 0;
    matrixCols = matrixSizes[1] - 0;

    counter = 0;
    numbersMatrix = [];
    for (i = 0; i < matrixRows; i++) {
        currentRow = new Array(matrixCols);
        numbersMatrix.push(currentRow);
        for (j = 0; j < numbersMatrix[i].length; j++) {
            counter++;
            numbersMatrix[i][j] = counter;
        }
    }

    startPosition = params[1].split(' ');
    startRow = startPosition[0] - 0;
    startCol = startPosition[1] - 0;

    directionsMatrix = [];
    for (i = 0; i < matrixRows; i++) {
        currentRow = new Array(matrixCols);
        directionsMatrix.push(currentRow);
        line = params[i + 2];
        for (j = 0; j < directionsMatrix[i].length; j++) {
            directionsMatrix[i][j] = line[j];
        }
    }

    sum = 0;
    numberCells = 0;
    row = startRow;
    col = startCol;
    while (true) {
        if (row > matrixRows - 1 || row < 0 || col > matrixCols - 1 || col < 0) {
            isOut = true;
            break;
        }
        if (directionsMatrix[row][col] === '-') {
            break;
        }
        numberCells++;
        sum += numbersMatrix[row][col];

        if (directionsMatrix[row][col] === 'l') {
            directionsMatrix[row][col] = '-';
            col--;
        }
        else if (directionsMatrix[row][col] === 'r') {
            directionsMatrix[row][col] = '-';
            col++;
        }
        else if (directionsMatrix[row][col] === 'u') {
            directionsMatrix[row][col] = '-';
            row--;
        }
        else if (directionsMatrix[row][col] === 'd') {
            directionsMatrix[row][col] = '-';
            row++;
        }
    }

    if (isOut) {
        return 'out ' + sum;
    }
    else {
        return 'lost ' + numberCells;
    }
}

console.log(solve(args1));
console.log(solve(args2));
console.log(solve(args3));