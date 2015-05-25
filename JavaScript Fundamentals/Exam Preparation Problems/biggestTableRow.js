/**
 * Created by User on 17.5.2015 ã..
 */

var test1 = [
'<table>',
'<tr><th>Town</th><th>Store1</th><th>Store2</th><th>Store3</th></tr>',
'<tr><td>Sofia</td><td>26.2</td><td>8.20</td><td>-</td></tr>',
'<tr><td>Varna</td><td>11.2</td><td>18.00</td><td>36.10</td></tr>',
'<tr><td>Plovdiv</td><td>17.2</td><td>12.3</td><td>6.4</td></tr>',
'<tr><td>Bourgas</td><td>-</td><td>24.3</td><td>-</td></tr>',
'</table>'
];

var test2 = [
'<table>',
'<tr><th>Town</th><th>Store1</th><th>Store2</th><th>Store3</th></tr>',
'<tr><td>Sofia</td><td>-</td><td>-</td><td>-</td></tr>',
'</table>'
];

var test3 = [
'<table>',
'<tr><th>Town</th><th>Store1</th><th>Store2</th><th>Store3</th></tr>',
'<tr><td>Sofia</td><td>12850</td><td>-560</td><td>20833</td></tr>',
'<tr><td>Rousse</td><td>-</td><td>50000.0</td><td>-</td></tr>',
'<tr><td>Bourgas</td><td>25000</td><td>25000</td><td>-</td></tr>',
'</table>'
];

function solve(params){
    var currentSum, maxSum, rowsData, position, line, splitLine, i, j, row, result;
    Array.prototype.removeEmptySpaces = function () {
        var cleanArray = [];
        for (var i = 0; i < this.length; i++) {
            if (this[i] !== '') {
                cleanArray.push(this[i]);
            }
        }
        return cleanArray;
    }
    function replaceAll(originalString, oldString, newString){
        var index = -1;

        while(true){
            index = originalString.indexOf(oldString, index + 1);
            if(index < 0){
                break;
            }
            originalString = originalString.replace(oldString, newString);
        }
        return originalString;
    }

    rowsData = [];
    for (i = 2; i < params.length - 1; i++) {
        line = params[i];
        line = replaceAll(line, '<tr>',' ');
        line = replaceAll(line, '</tr>', ' ');
        line = replaceAll(line, '<td>',' ');
        line = replaceAll(line, '</td>', ' ');
        splitLine = line.split(' ').removeEmptySpaces();
        rowsData.push(splitLine);
    }
    currentSum = 0;
    maxSum = 0;
    for (i = 0; i < rowsData.length; i++) {
        var row = rowsData[i];
        for (j = 1; j < row.length; j++) {
            if(!isNaN(row[j] - 0)){
                currentSum += (row[j] - 0);
            }
        }

        if(maxSum < currentSum){
            maxSum = currentSum;
            position = i;
        }
        currentSum = 0;
    }

    if(maxSum > 0){
        result = [];
        for (i = 0; i < rowsData[position].length; i++) {
            if(!isNaN(rowsData[position][i] - 0)){
                result.push(rowsData[position][i]);
            }
        }
        return maxSum + ' = ' + result.join(' + ');
    }
    else{
        return 'no data';
    }
}


console.log(solve(test1));
console.log(solve(test2));
console.log(solve(test3));