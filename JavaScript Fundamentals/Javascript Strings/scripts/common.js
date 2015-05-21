String.prototype.htmlEscape = function () {
    return this.replace(/&/g, '&amp;').replace(/</g, '&lt;').replace(/>/g, '&gt;').replace(/"/g, '&quot;').replace(/'/g, "&#39").replace(/ /g, "&nbsp;");
}

function print(text) {
    jsConsole.writeLine('-----------------------------------------------------------');
    jsConsole.writeLine(text.htmlEscape());
    jsConsole.writeLine('-----------------------------------------------------------');
    console.log('-----------------------------------------------------------');
    console.log(text);
    console.log('-----------------------------------------------------------');
}