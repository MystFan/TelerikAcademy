//Problem 6. Extract text from HTML

//Write a function that extracts the content of a html page given as text.
//The function should return anything that is in a tag, without the tags.

print('Problem 6: Write a function that extracts the content of a html page given as text.The function should return anything that is in a tag, without the tags.');

var html = [ 
'<html>',
'  <head>',
'    <title>Sample site</title>',
'  </head>',
'  <body>',
'    <div>text',
'      <div>more text</div>',
'      and more...',
'    </div>',
'    in body',
'  </body>',
'</html>'
];

// First Way
function extractInnerText(text) {
    var i, j, html, inTag, innerText, currentText;

    for (j = 0; j < text.length; j++) {
        text[j] = text[j].trim();
    }

    html = text.join('');
    innerText = '';
    currentText = '';
    inTag = false;
  
    for (i = 0; i < html.length; i++) {

        if (html[i] === '>') {
            inTag = true;
            continue;
        }
        else if (html[i] === '<') {
            inTag = false;
            innerText += currentText;
            currentText = '';
            continue;
        }

        if (inTag) {
            currentText += html[i];
        }
    }
    return innerText;
}

// Second Way
function getInnerText(text) {
    var element = document.createElement('div');
    element.innerHTML = text.join('');
    var innerText = element.innerText;
    return innerText;
}

jsConsole.writeLine(extractInnerText(html));
jsConsole.writeLine(getInnerText(html));
console.log(extractInnerText(html));
console.log(getInnerText(html));