/* 
 Create a function that:
 *   **Takes** a collection of books
 *   Each book has propeties `title` and `author`
 **  `author` is an object that has properties `firstName` and `lastName`
 *   **finds** the most popular author (the author with biggest number of books)
 *   **prints** the author to the console
 *	if there is more than one author print them all sorted in ascending order by fullname
 *   fullname is the concatenation of `firstName`, ' ' (empty space) and `lastName`
 *   **Use underscore.js for all operations**
 */
function solve() {
    var validator = {
        validateIfUndefined: function (val, name) {
            name = name || 'Value';
            if (val === undefined) {
                throw new Error(name + ' cannot be undefined');
            }
        },
        validateIfObject: function (val, name) {
            name = name || 'Value';
            if (typeof val !== 'object') {
                throw new Error(name + ' must be an object');
            }
        },
        validateIfNumber: function (val, name) {
            name = name || 'Value';
            if (typeof val !== 'number') {
                throw new Error(name + ' must be a number');
            }
        },
        validateString: function (val, minLength, maxLength, name) {
            name = name || 'Value';
            this.validateIfUndefined(val, name);

            if (typeof val !== 'string') {
                throw new Error(name + ' must be a string');
            }

            if (val.length < minLength || maxLength < val.length) {
                throw new Error(name + ' must be between ' + minLength + ' and ' + maxLength + ' symbols');
            }
        },
        validatePositiveNumber: function (val, name) {
            name = name || 'Value';
            this.validateIfUndefined(val, name);
            this.validateIfNumber(val, name);

            if (val <= 0) {
                throw new Error(name + ' must be positive number');
            }
        },
        validateIfArray: function (val, name) {
            name = name || 'Value';
            this.validateIfUndefined(val, name);
            this.validateIfObject(val, name);

            if (!Array.isArray(val)) {
                throw new Error(name + ' must be array');
            }
        }
    };
    return function (books) {
        var result, sortedByAuthorBooksCount, maxBooksCount;
        validator.validateIfArray(books, 'Books');
        _.each(books, function (book) {
            validator.validateIfUndefined(book, 'Book');
            validator.validateIfUndefined(book.author, 'Book author');
            validator.validateString(book.title, 0, Number.MAX_VALUE, 'Book title');
            validator.validateString(book.author.firstName, 0, Number.MAX_VALUE, 'Author first name');
            validator.validateString(book.author.lastName, 0, Number.MAX_VALUE, 'Author last name');
        });

        sortedByAuthorBooksCount = _.chain(books)
            .groupBy(function (book) {
                return book.author.firstName + ' ' + book.author.lastName;
            })
            .map(function (authorBooks) {
                var group = {
                    authorName: authorBooks[0].author.firstName + ' ' + authorBooks[0].author.lastName,
                    books: authorBooks
                };
                return group;
            })
            .sortBy(function (author) {
                return -1 * author.books.length;
            }).value();

        maxBooksCount = sortedByAuthorBooksCount[0].books.length;

        _.chain(sortedByAuthorBooksCount)
            .filter(function (author) {
                return author.books.length === maxBooksCount;
            })
            .sortBy('authorName')
            .each(function (author) {
                console.log(author.authorName)
            });
    };
}

module.exports = solve;
