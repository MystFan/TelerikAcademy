
print('Problem 10: Write a program that extracts from a given text all palindromes, e.g. "ABBA", "lamal", "exe".');

var loremIpsum = "Legere paosullivan@btinternet.com numquam minimum abba ea mel,adam@whittle-print.co.uk eos minim labitur voluptatibus ex. Te gsphy@czrdeu.com justo mentitum  sapientem duo,ednaddavid@yahoo.com cu usu legimus eligendi. Movet oportere lamal consetetur ut qui, wisdom_uk_1@ymail.com saepe nemore temporibus ex vel. Usu labores indoctum inciderint ea, mei et sensibus suavitate. Cu quaestio constituto eum, cum decore similique no. Ius te tation repudiandae, angie_prince@yahoo.com ea nostrud scribentur consequuntur eam. Vel scaevola cotidieque exe ea.";

function getWords(text) {
    var words = text.split(/[\s.,-]/);
    for (var i = 0; i < words.length; i++) {
        if (words[i] === '') {
            words.splice(i, 1);
        }
    }
    return words;
}

function extractPalindromes(text) {
    var words = getWords(text);
    var palindromes = [];
    var currentWord = '';
    for (var i = 0; i < words.length; i++) {

        for (var j = words[i].length - 1; j >= 0 ; j--) {
            currentWord = currentWord + words[i][j];
        }
        if (currentWord === words[i]) {
            palindromes.push(words[i]);
        }
        currentWord = '';
    }
    return palindromes;
};

jsConsole.writeLine(extractPalindromes(loremIpsum).join(", "));
console.log(extractPalindromes(loremIpsum));