//Problem 9. Extract e-mails

//Write a function for extracting all email addresses from given text.
//All sub-strings that match the format @… should be recognized as emails.
//Return the emails as array of strings.

print('Problem 9: Write a function for extracting all email addresses from given text.All sub-strings that match the format @… should be recognized as emails.Return the emails as array of strings.');

var loremIpsum = "Legere paosullivan@btinternet.com numquam minimum ea mel,adam@whittle-print.co.uk eos minim labitur voluptatibus ex. Te gsphy@czrdeu.com justo mentitum  sapientem duo,ednaddavid@yahoo.com cu usu legimus eligendi. Movet oportere consetetur ut qui, wisdom_uk_1@ymail.com saepe nemore temporibus ex vel. Usu labores indoctum inciderint ea, mei et sensibus suavitate. Cu quaestio constituto eum, cum decore similique no. Ius te tation repudiandae, angie_prince@yahoo.com ea nostrud scribentur consequuntur eam. Vel scaevola cotidieque ea.";

function getWords(text) {
    var words = text.split(/[\s,]/);
    for (var i = 0; i < words.length; i++) {
        if (words[i] === '') {
            words.splice(i, 1);
        }
    }
    return words;
}

function extractEmails(article) {
    var pattern = /^(([^<>()[\]\\.,;:\s@\"]+(\.[^<>()[\]\\.,;:\s@\"]+)*)|(\".+\"))@((\[[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\.[0-9]{1,3}\])|(([a-zA-Z\-0-9]+\.)+[a-zA-Z]{2,}))$/;
    var words = getWords(article);
    var emails = [];
    for (var i = 0; i < words.length; i++) {
        if (pattern.test(words[i]) === true) {
            emails.push(words[i]);
        }
    }
    return emails;
}

jsConsole.writeLine(extractEmails(loremIpsum).join(", "));
console.log(extractEmails(loremIpsum));