/**
 * Created by User on 14.5.2015 ã..
 */
var test1 = [
    '50',
    '60'
];

var test2 = [
    '36.333',
    '36.5',
    '37.019',
    '35.4',
    '35',
    '35.001',
    '36.225'
];

function solve(params){
    var table, previousPrice, currentPrice, line, numbers, i;
    table = [];
    table.push('<table>');
    table.push('<tr><th>Price</th><th>Trend</th></tr>');

    line = '';
    numbers = [];
    for (i = 0; i < params.length; i++) {
        numbers.push((params[i] - 0).toFixed(2) - 0);
    }
    table.push('<tr><td>' + numbers[0].toFixed(2) + '</td><td><img src="fixed.png"/></td></td>');
    for (i = 1; i < numbers.length; i++) {
        previousPrice = numbers[i - 1];
        currentPrice = numbers[i];
        line += '<tr><td>';
        line += currentPrice.toFixed(2);
        line += '</td><td><img src="';
        if(currentPrice > previousPrice){
            line += 'up';
        }
        else if(currentPrice < previousPrice){
            line += 'down';
        }
        else{
            line += 'fixed';
        }
        line += '.png"/></td></td>';
        table.push(line);
        line = '';
    }
    table.push('</table>');
    for (var i = 0; i < table.length; i++) {
        console.log(table[i]);

    }
}
solve(test1);
solve(test2);