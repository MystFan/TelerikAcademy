//Problem 2. HTML binding

//Write a function that puts the value of an object into the content/attributes of HTML tags.
//    Add the function to the String.prototype

if (!String.prototype.bind) {
    String.prototype.bind = function (str, options) {
        if (typeof(str) !== 'string') {
            throw 'First parameter must be of type string';
        }
        if ((!(options instanceof Object)) || Array.isArray(options)) {
            throw 'Second parameter must be of type object';
        }

        var i,j, length, len, attributePattern, valuePattern, keyPattern, attributeValueString, keyValueString, currentTagString, tagsRegex, tags, attributes,
            result = this,
            keys = Object.keys(options);

        attributePattern = /data-bind-[A-z]*="[A-z]*"/g;
        valuePattern = /"[A-z]*"/g;
        keyPattern = /-[A-z]*=/g;
        tagsRegex = /<([a-z]+)*[^/]*?><\/(.?)>|<[A-z]*[^/]*?><\/[A-z]*>/g ;
        tags = result.match(tagsRegex);

        for (j = 0, length = tags.length; j < length; j += 1) {
            attributes = tags[j].match(attributePattern);
            currentTagString = tags[j];

            for (i = 0, len = attributes.length; i < len; i += 1) {
                attributeValueString = attributes[i].match(valuePattern)[0];
                attributeValueString = attributeValueString.substring(1, attributeValueString.length - 1);

                keyValueString = attributes[i].match(keyPattern)[0];
                keyValueString = keyValueString.substring(1, keyValueString.length - 1);

                if (options.hasOwnProperty(attributeValueString)) {
                    switch (keyValueString) {
                        case 'content': tags[j] = tags[j].replace(/>/, '>' + options[attributeValueString]);
                            break;
                        case 'href': tags[j] = tags[j].replace(/>/, ' href="' + options[attributeValueString] + '">');
                            break;
                        case 'class': tags[j] = tags[j].replace(/>/, ' class="' + options[attributeValueString] + '">');
                            break;
                    }
                }
            }

            result = result.replace(currentTagString, tags[j]);
        }
        


        return result;
    }
}

console.log('Problem 2:')
var example1 = '<div data-bind-content="name"></div>';
console.log(example1.bind('', { name: 'Steven' }));

var example2 = '<a data-bind-content="name" data-bind-href="link" data-bind-class="name"></а>'
console.log(example2.bind('', { name: 'Elena', link: 'http://telerikacademy.com' }));