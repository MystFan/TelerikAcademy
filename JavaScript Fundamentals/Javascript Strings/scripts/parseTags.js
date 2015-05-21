/// <reference path="js-console.js"/>
//You are given a text. Write a function that changes the text in all regions:

//<upcase>text</upcase> to uppercase.
//<lowcase>text</lowcase> to lowercase
//<mixcase>text</mixcase> to mix casing(random)

//    Example: We are <mixcase>living</mixcase> in a <upcase>yellow submarine</upcase>. We <mixcase>don't</mixcase> have <lowcase>anything</lowcase> else.

//The expected result:
//We are LiVinG in a YELLOW SUBMARINE. We dOn'T have anything else.

//    Note: Regions can be nested.

print('Problem 4: You are given a text. Write a function that changes the text in all regions');
var text = "We are <mixcase>living</mixcase> in a <upcase>yellow submarine</upcase>. We <mixcase>don't</mixcase> have <lowcase>anything</lowcase> else.";


function parseTags(text) {
    var result = [];
    var resultText = text.split(/[<>]/);
    var openMixcaseTags = [];
    var openUpcaseTags = [];
    var openLowcaseTags = [];
    var inMixcase = false;
    var inUpcase = false
    var inLowcase = false;

    for (var i = 0; i < resultText.length; i++) {

        if (openMixcaseTags.length === 0) {
            inMixcase = false;
        }
        if (openUpcaseTags.length === 0) {
            inUpcase = false;
        }
        if (openLowcaseTags.length === 0) {
            inLowcase = false;
        }

        if (resultText[i] === 'mixcase' && !inLowcase && !inUpcase) {
            inMixcase = true;
            openMixcaseTags.push(resultText[i]);
            continue;
        }
        else if (resultText[i] === '/mixcase') {
            openMixcaseTags.pop();
            continue;
        }
        else if (resultText[i] === 'upcase' && !inLowcase && !inMixcase) {
            inUpcase = true;
            openUpcaseTags.push(resultText[i]);
            continue;
        }
        else if (resultText[i] === '/upcase') {
            openUpcaseTags.pop();
            continue;
        }
        else if (resultText[i] === 'lowcase' && !inMixcase && !inUpcase) {
            inLowcase = true;
            openLowcaseTags.push(resultText[i]);
            continue;
        }
        else if (resultText[i] === '/lowcase') {
            openLowcaseTags.pop();
            continue;
        }
        
        if (inMixcase) {
            if (!isKeyword(resultText[i])) {
                result.push(mixWord(resultText[i]));
            }
            continue;
        }
        else if (inUpcase) {
            if (!isKeyword(resultText[i])) {
                result.push(resultText[i].toUpperCase());
            }
            continue;
        }
        else if (inLowcase) {
            if (!isKeyword(resultText[i])) {
                result.push(resultText[i].toLowerCase());
            }
            continue;
        }

        result.push(resultText[i]);

    }

    return result.join('');
}

console.log(parseTags(text));
jsConsole.writeLine(parseTags(text));

function mixWord(word) {
    var result = '';
    for (var j = 0; j < word.length; j++) {
        if (Math.random() > 0.5) {
            result = result + word[j].toLowerCase();
        }
        else {
            result = result + word[j].toUpperCase();
        }
    }
    return result;
}

function isKeyword(word) {
    var keywords = ['mixcase', '/mixcase', 'upcase', '/upcase', 'lowcase', '/lowcase'];
    for (var i = 0; i < keywords.length; i++) {
        if (keywords[i] === word) {
            return true;
        }
    }
    return false;
}