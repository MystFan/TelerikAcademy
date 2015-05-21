
print('Problem 8: Write a JavaScript function that replaces in a HTML document given as string all the tags <a href="…">…</a> with corresponding tags [URL=…]…/URL].');

var html = '<p>Please visit <a href="http://academy.telerik.com">our site</a> to choose a training course. Also visit <a href="www.devbg.org">our forum</a> to discuss the courses.</p>';

function replaceLinks(text) {
    var arr = [];
    var startLink = "<a";
    var endLink = "a>";
    var link = "";
    var indexStart = -1;
    var indexEnd = -1;
    var newStr = "";
    while (true) {
        indexStart = text.indexOf(startLink, indexStart + 1);
        indexEnd = text.indexOf(endLink, indexStart + 1);
        if (indexStart == -1 || indexEnd == -1) {
            break;
        }
        link = text.substring(indexStart, indexEnd + 2);
        newStr = text.replace(link, build(extractURL(link), extractAnchorContent(link)));
        text = newStr;

    }
    return text;
};

function extractURL(anchor) {
    var start = '"';
    var http = '';
    var startIndex = anchor.indexOf('="');
    for (var i = 0; i < anchor.length; i++) {
        if (i >= startIndex + 2) {
            if (anchor[i] == start) {
                break;
            }
            http = http + anchor[i];
        }
    }
    return http;
};

function extractAnchorContent(anchor) {
    var start = anchor.indexOf('>', 0);
    var end = anchor.indexOf('<', 1);
    var content = anchor.substring(start + 1, end);
    return content;
}

function build(protocol, content) {
    var url = '[URL=...]....[/URL]';
    var urlTag = url.replace('...', protocol);
    var urlFinal = urlTag.replace('....', content);
    return urlFinal;
}

jsConsole.writeLine(replaceLinks(html));
console.log(replaceLinks(html));
