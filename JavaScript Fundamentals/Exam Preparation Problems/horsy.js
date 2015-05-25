var args1 = [
  '3 5',
  '54561',
  '43328',
  '52388',
];
var args2 = [
  '3 5',
  '54361',
  '43326',
  '52188',
];
var args3 = [
'3 170',
'65256624788315872547146742545371652845427473747267157662731442588248254733848315117257871124376782841157534346443612618725181711166757567365663638423518322167414635742267',
'45455813336725247538881424621676377742372315377756873812547467266271517642434424316613753727845166781146278516761172147847651254585283744475617153481423232871713755726637',
'61554736574112247245452874872314627642462447345828387664685574613831561533388314718463335155846275353167535228183566874387343281726347481161154526852575881675721325662347'
];
function solve(params) {
    var rows, cols, matrixSize, sum, jumps, matrix, i, j, matrixRow, field, fieldRow, firstCellValue, direction, row, col;
    matrixSize = params[0].split(' ');
    rows = matrixSize[0] - 0;
    cols = matrixSize[1] - 0;
    matrix = [];

    for (i = 0; i < rows; i++) {
        matrixRow = new Array(cols);
        for (j = 0; j < cols; j++) {
            matrixRow[j] = params[i + 1][j] - 0;
        }
        matrix.push(matrixRow);
    }

    field = [];
    for (i = 0; i < rows; i++) {
        fieldRow = new Array(cols);
        firstCellValue = parseInt(Math.pow(2, i));
        fieldRow[0] = firstCellValue;
        for (j = 1; j < cols; j++) {
            fieldRow[j] = firstCellValue - 1;
            firstCellValue--;
        }
        field.push(fieldRow);
    }

    row = rows - 1;
    col = cols - 1;
    sum = 0;
    jumps = 0;

    while (true) {

        if (row > rows - 1 || row < 0 || col > cols - 1 || col < 0) {
            break;
        }
        if (field[row][col] === 'v') {
            return "Sadly the horse is doomed in " + jumps + " jumps";
        }
        sum += (field[row][col]);
        field[row][col] = 'v';
        jumps++;

        direction = matrix[row][col];
        switch (direction) {
            case 1: row -= 2; col++; break;
            case 2: row--; col += 2; break;
            case 3: row++; col += 2; break;
            case 4: row += 2; col++; break;
            case 5: row += 2; col--; break;
            case 6: row++; col -= 2; break;
            case 7: row--; col -= 2; break;
            case 8: row -= 2; col--; break;
        }
    }

    return 'Go go Horsy! Collected ' + sum + ' weeds';
}
console.log(solve(args1));
console.log(solve(args2));
console.log(solve(args3));