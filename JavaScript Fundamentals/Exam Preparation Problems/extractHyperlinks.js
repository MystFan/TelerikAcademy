/**
 * Created by User on 25.5.2015 ã..
 */

var test1 = [
    '<a href="http://softuni.bg" class="new"></a>'
];

var test2 = [
    '<p>This text has no links</p>'
];

var test3 = [
'<!DOCTYPE html>',
'<html>',
'<head>',
'<title>Hyperlinks</title>',
'<link href="theme.css" rel="stylesheet" />',
'    </head>',
'    <body>',
'    <ul><li><a   href="/"  id="home">Home</a></li><li><a',
' class="selected" href=/courses>Courses</a>',
'</li><li><a href =',
' "/forum" >Forum</a></li><li><a class="href"',
'onclick="go()" href= "#">Forum</a></li>',
'<li><a id="js" href =',
'"javascript:alert(\'hi yo\')" class="new">click</a></li>',
'<li><a id="nakov" href =',
'http://www.nakov.com class="new">nak</a></li></ul>',
'<a href="#empty"></a>',
'<a id="href">href="fake"<img src="http://abv.bg/i.gif"',
'alt="abv"/></a><a href="#">&lt;a href="hello"&gt;</a>',
'<!-- This code is commented:',
'    <a href="#commented">commentex hyperlink</a> -->',
'</body>'

];
// 100 points
function solve(params){
    String.prototype.startWith = function (value, caseSensitive) {

        var i, j, valueLowerCase, thisLowerCase;
        if (value === undefined) {
            throw 'Value parameter in startWith function is undifine';
        }
        if (typeof (value) !== 'string') {
            throw 'Value parameter in startWith function must be string';
        }
        caseSensitive = typeof (caseSensitive) === 'undefined' ? true : caseSensitive;
        value = value === undefined ? '' : value;
        var isCaseSensitive = caseSensitive;
        var isStartWith = false;

        if (this.length < value.length) {
            return isStartWith;
        }

        isStartWith = true;
        if (isCaseSensitive) {
            for (i = 0; i < value.length; i++) {
                if (value[i] !== this[i]) {
                    isStartWith = false;
                    break;
                }
            }
        }
        else {
            valueLowerCase = value.toLowerCase();
            thisLowerCase = this.toLowerCase();
            for (j = 0; j < valueLowerCase.length; j++) {
                if (valueLowerCase[i] !== thisLowerCase[i]) {
                    isStartWith = false;
                    break;
                }
            }
        }
        return isStartWith;
    }
    var line, i, j, k, subLine, hrefIndex, end;
    var links = extractLinks(params.join(''));


    for (i = 0; i < links.length; i++) {
        hrefIndex = -1;
        while(true){
            hrefIndex = links[i].indexOf('href', hrefIndex + 1);
            if(hrefIndex < 0){
                break;
            }
            for (k = hrefIndex + 4; k < links[i].length; k++) {
                if(links[i][k] !== ' '){
                    if(links[i][k] === '='){

                        line = links[i].substr(k + 1).trim();
                        if(line.startWith('"')){
                            end = line.indexOf('"', 1);
                            console.log(line.substring(1, end));
                            break;
                        }
                        else if(line.startWith("'")){
                            end = line.indexOf("'", 1);
                            console.log(line.substring(1, end));
                            break;
                        }
                        else{
                            subLine = '';
                            for (j = 0; j < line.length; j++) {
                                if(line[j] === ' ' || line[j] === '>'){
                                    break;
                                }
                                subLine += line[j];
                            }
                            console.log(subLine);
                            break;}
                    }
                    else{
                        break;
                    }
                }
            }
        }
    }
    function extractLinks(html){
        var result = [];
        var startLinkIndex = -1;
        var endLinkIndex = -1;
        var endIndex;
        while(true){
            startLinkIndex = html.indexOf('<a', startLinkIndex + 1);
            endLinkIndex = html.indexOf('</a>', endLinkIndex + 1);
            if(startLinkIndex < 0 || endLinkIndex < 0){
                break;
            }

            if(endLinkIndex > startLinkIndex){
                endIndex = (html.substring(startLinkIndex, endLinkIndex + '</a>'.length)).indexOf('>');
                result.push(html.substring(startLinkIndex,startLinkIndex + endIndex + 1));
            }
        }
        return result;
    }
}
solve(test1);
solve(test2);
solve(test3);