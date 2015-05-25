/**
 * Created by User on 24.5.2015 ã..
 */

var test1 = [
    '2',
    '6'
];

var test2 = [
    '55',
    '56'
];
// 100 points
function solve(params){
    Array.prototype.contains = function(obj){
        for (var i = 0; i < this.length; i++) {
            if(this[i] === obj){
                return true;
            }
        }
        return false;
    }
    function isFib(val){
        var prev = 0;
        var curr = 1;
        while(prev<=val){
            if(prev === val){
                return true;
            }
            curr = prev + curr;
            prev = curr - prev;
        }
        return false;
    }
    var start = params[0] - 0;
    var end = params[1] - 0;

    var table = [];
    table.push('<table>');
    table.push('<tr><th>Num</th><th>Square</th><th>Fib</th></tr>');
    for (var i = start; i <= end; i++) {
        var line = '<tr><td>' + i + '</td><td>' + (i * i) + '</td><td>';
        if(isFib(i)){
            line += 'yes';
        }
        else{
            line += 'no';
        }
        line += '</td></tr>';
        table.push(line);
    }
    table.push('</table>');

    for (var i = 0; i < table.length; i++) {
        console.log(table[i]);
    }
}

solve(test1);
solve(test2);