/**
 * Created by User on 25.5.2015 ã..
 */

var test1 = [
    'ZZ Top | London | 2-Aug-2014 | Wembley Stadium',
    'Iron Maiden | London | 28-Jul-2014 | Wembley Stadium',
    'Metallica | Sofia | 11-Aug-2014 | Lokomotiv Stadium',
    'Helloween | Sofia | 1-Nov-2014 | Vassil Levski Stadium',
    'Iron Maiden | Sofia | 20-June-2015 | Vassil Levski Stadium',
    'Helloween | Sofia | 30-July-2015 | Vassil Levski Stadium',
    'Iron Maiden | Sofia | 26-Sep-2014 | Lokomotiv Stadium',
    'Helloween | London | 28-Jul-2014 | Wembley Stadium',
    'Twisted Sister | London | 30-Sep-2014 | Wembley Stadium',
    'Metallica | London | 03-Oct-2014 | Olympic Stadium',
    'Iron Maiden | Sofia | 11-Apr-2016 | Lokomotiv Stadium',
    'Iron Maiden | Buenos Aires | 03-Mar-2014 | River Plate Stadium'
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

    var i, citys, j, line, lineParams, obj, citysKeys, cityKeys, result, venue, currentLine;
    citys = {};
    for (i = 0; i < params.length; i++) {
        line = params[i];
        lineParams = line.split(' | ');

        if(!citys.hasOwnProperty(lineParams[1])){
            citys[lineParams[1]] = {};
        }

        if(!citys[lineParams[1]].hasOwnProperty(lineParams[3])){
            citys[lineParams[1]][lineParams[3]] = [];
        }


        if(!citys[lineParams[1]][lineParams[3]].contains(lineParams[0])){
            citys[lineParams[1]][lineParams[3]].push(lineParams[0]);
        }
    }

    var citysKeys = Object.keys(citys);
    citysKeys.sort();

    result = [];
    currentLine = '';
    for (j = 0; j < citysKeys.length; j++) {
        currentLine = '';
        currentLine += ('"' + citysKeys[j] + '":{');
        obj = citys[citysKeys[j]];
        cityKeys = Object.keys(obj);
        cityKeys.sort();

        venue = [];
        for (i = 0; i < cityKeys.length; i++) {
            obj[cityKeys[i]].sort();
            venue.push('"' + cityKeys[i] + '":' + JSON.stringify(obj[cityKeys[i]]));
        }
        currentLine += venue.join(',') + '}';
        result.push(currentLine);
    }
    return '{' + result.join(',') + '}';
}

console.log(solve(test1));