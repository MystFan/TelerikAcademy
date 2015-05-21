
print('Problem 5: Write a function that replaces non breaking white-spaces in a text with &nbsp;');

var text = "Legere    paosullivan@btinternet.com     numquam minimum     abba ea mel,adam@whittle-print.co.uk eos minim labitur voluptatibus ex. Te gsphy@czrdeu.com justo mentitum  sapientem duo,ednaddavid@yahoo.com cu usu legimus eligendi. Movet oportere lamal consetetur ut qui, wisdom_uk_1@ymail.com saepe nemore temporibus ex vel.";
function replaceNonBreakingWhiteSpaces(text, symbol) {
    var result = '';
    for (var i = 0; i < text.length; i++) {
        if (text[i] === ' ') {
            result += symbol;
            continue;
        }

        result += text[i];
    }
    return result;
}
console.log(replaceNonBreakingWhiteSpaces(text, '&nbsp'));
jsConsole.writeLine(replaceNonBreakingWhiteSpaces(text, '&nbsp'));


