/* Task Description */
/* 
	*	Create a module for working with books
		*	The module must provide the following functionalities:
			*	Add a new book to category
				*	Each book has unique title, author and ISBN
				*	It must return the newly created book with assigned ID
				*	If the category is missing, it must be automatically created
			*	List all books
				*	Books are sorted by ID
				*	This can be done by author, by category or all
			*	List all categories
				*	Categories are sorted by ID
		*	Each book/catagory has a unique identifier (ID) that is a number greater than 1
			*	When adding a book/category, the ID is generated automatically
		*	Add validation everywhere, where possible
			*	Book title and category name must be between 2 and 100 characters, including letters, digits and special characters ('!', ',', '.', etc)
			*	Author is any non-empty string
			*	Unique params are Book title and Book ISBN
			*	Book ISBN is an unique code that contains either 10 or 13 digits
			*	If something is not valid - throw Error
*/
function solve() {
	var library = (function () {
		var TITLE_CATEGORY_MIN_LENGTH = 2,
			TITLE_CATEGORY_MAX_LENGTH = 100,
			ISBN_FIRST_VALID_LENGTH = 10,
			ISBN_SECOND_VALID_LENGTH = 13,
			hasCategory,
		    categories = [],
			books = [],
			bookLastID = 1;
		
		function isValidateISBN(isbn) {
			var digits = isbn.split('').map(Number);
			return (isbn.length === ISBN_FIRST_VALID_LENGTH || isbn.length === ISBN_SECOND_VALID_LENGTH) && digits.every(function (num) {
				return !isNaN(num);
			});
		}
		
		function hasSameBook(book) {
			var hasBook = books.every(function (b) {
				return b.title !== book.title && b.isbn !== book.isbn;
			});
			return !hasBook;
		}
		
		function hasCategory(book) {
			var result = categories.some(function (category) {
				return category === book.category;
			});
			return result;
		}
		
		function listBooks() {
			var listOfBooks, 
				arg = arguments[0];
			
			if(arg === undefined){
				listOfBooks = books.slice();
			}else{

				if(typeof arg !== 'object'){
					throw new Error('Parameter should be object type');
				}
				
				if(arg.hasOwnProperty('category')){
					listOfBooks = books.slice().filter(function (b) {
						return b.category === arg.category;
					});
				}else if(arg.hasOwnProperty('author')){
					listOfBooks = books.slice().filter(function (b) {
						return b.author === arg.author;
					});
				}else{
					throw new Error('Invalid parameter. Missing require propertie');
				}
			}
			return listOfBooks;
		}

		function addBook(book) {
			var index,
			    isValidBook = true,
			    validProps = ['title', 'isbn', 'author', 'category'];

			if(book === undefined){
				throw new Error('Book you try to add is undefined');
			}
			if(typeof book !== 'object'){
				throw new Error('Parameter should be object type');
			}

			for (index = 0; index < validProps.length; index+=1) {
				if(!book.hasOwnProperty(validProps[index])){
					isValidBook = false;
				}
			}
			
			if(!isValidBook){
				throw new Error('Book object is invalid. Missing require properties');
			}
			
			if(book.title.length < TITLE_CATEGORY_MIN_LENGTH || book.title.length > TITLE_CATEGORY_MAX_LENGTH){
				throw new Error('Invalid book title length');
			}
			if(book.category.length < TITLE_CATEGORY_MIN_LENGTH || book.category.length > TITLE_CATEGORY_MAX_LENGTH){
				throw new Error('Invalid book category length');
			}
			if(!isValidateISBN(book.isbn)){
				throw new Error('Invalid book isbn number');
			}
			if(hasSameBook(book)){
				throw new Error('Book with same title or ISBN already exist in library');
			}
			
			bookLastID += 1;
			book.ID = bookLastID;
			if(!hasCategory(book)){
				categories.push(book.category);
			}
			
			books.push(book);
			return book;
		}

		function listCategories() {
			var listOfCategories = categories.slice();
			return listOfCategories;
		}

		return {
			books: {
				list: listBooks,
				add: addBook
			},
			categories: {
				list: listCategories
			}
		};
	} ());
	return library;
}
module.exports = solve;
