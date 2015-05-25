/**
 * Created by Димитрови on 22.5.2015 г..
 */

var test1 = [
'<table>',
'<tr><th>Product</th><th>Price</th><th>Votes</th></tr>',
'<tr><td>Vodka Finlandia 1 l</td><td>19.35</td><td>+12</td></tr>',
'<tr><td>Ariana Radler 0.5 l</td><td>1.19</td><td>+33</td></tr>',
'<tr><td>Laptop HP 250 G2</td><td>629</td><td>+1</td></tr>',
'<tr><td>Kamenitza Grapefruit 1 l</td><td>1.85</td><td>+7</td></tr>',
'<tr><td>Ariana Grapefruit 1.5 l</td><td>1.85</td><td>+7</td></tr>',
'<tr><td>Coffee Davidoff 250 gr.</td><td>11.99</td><td>+11</td></tr>',
'</table>'
];
//100 points
function solve(params){
    var table, k, i, tableRow, lines, line;
    table = [];
    table.push(params[0]);
    table.push(params[1]);

    lines = [];
    for (k = 2; k < params.length - 1; k++) {
        line = {};
        tableRow = params[k].split('<td>').join('').split('</td>');
        line.price = tableRow[1] - 0;
        line.productName = tableRow[0].substring(4);
        line.content = params[k];
        lines.push(line);
    }

    lines.sort(function(row1, row2){
        return row1.price - row2.price || row1.productName - row2.productName;
    })

    for (i = 0; i < lines.length; i++) {
        table.push(lines[i].content);
    }
    table.push('</table>');

    for (i = 0; i < table.length; i++) {
        console.log(table[i]);
    }
}

solve(test1);