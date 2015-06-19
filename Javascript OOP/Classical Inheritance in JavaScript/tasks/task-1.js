/* Task Description */
/* 
	Create a function constructor for Person. Each Person must have:
	*	properties `firstname`, `lastname` and `age`
		*	firstname and lastname must always be strings between 3 and 20 characters, containing only Latin letters
		*	age must always be a number in the range 0 150
			*	the setter of age can receive a convertible-to-number value
		*	if any of the above is not met, throw Error 		
	*	property `fullname`
		*	the getter returns a string in the format 'FIRST_NAME LAST_NAME'
		*	the setter receives a string is the format 'FIRST_NAME LAST_NAME'
			*	it must parse it and set `firstname` and `lastname`
	*	method `introduce()` that returns a string in the format 'Hello! My name is FULL_NAME and I am AGE-years-old'
	*	all methods and properties must be attached to the prototype of the Person
	*	all methods and property setters must return this, if they are not supposed to return other value
		*	enables method-chaining
*/
function solve() {
	var Person = (function () {
		var NAME_MIN_LENGTH = 3,
			NAME_MAX_LENGTH = 20,
			MIN_AGE = 0,
			MAX_AGE = 150,
			fullnamePattern = /[A-z]* [A-z]*/g,
			latinLettersPattern = /[A-z]*/g;
		
		function Person(firstname, lastname, age) {
			if (!(this instanceof arguments.callee)) {
				return (new Person(firstname, lastname, age));
			}
			this.firstname = firstname;
			this.lastname = lastname;
			this.age = age;
			this.fullname = firstname + ' ' + lastname;
		}

		Object.defineProperty(Person.prototype, 'firstname', {
		    get: function() {
		      return this._firstname;
		    },
		 	set: function(value) {
				this._firstname = validateName(value);
				return this;
		    }
		  });
		  
		 Object.defineProperty(Person.prototype, 'lastname', {
		    get: function() {
		      return this._lastname;
		    },
		 	set: function(value) {
				this._lastname = validateName(value);
				return this;
		    }
		 });
		 
		 Object.defineProperty(Person.prototype, 'age', {
		    get: function() {
		      return this._age;
		    },
		 	set: function(value) {
				this._age = validateAge(value);
				return this;
		    }
		 });
		 
		 Object.defineProperty(Person.prototype, 'fullname', {
		    get: function() {
		      return this._fullname;
		    },
		 	set: function(value) {
				this._fullname = validateFullname(value);
				var names = value.split(' ').filter(function (str) {
					return !!str;
				});
				this.firstname = names[0];
				this.lastname = names[1];
				return this;
		    }
		 });
		 
		 Person.prototype.introduce = function introduce() {
			 return 'Hello! My name is ' + this.fullname + ' and I am ' + this.age + '-years-old';
		 };
		 		 
		function validateFullname(name) {
			var names;
			if(name.match(fullnamePattern)[0] !== name){
				throw new Error('Full name should consist of two words separated by a space');
			}
			names = name.split(' ').filter(function (str) {
				return !!str;
			});
			names.forEach(function (str) {
				validateName(str);
			});
			return names.join(' ');	 
		}
			 
        function validateName(name) {
			var isLatinLetters = false;
			if(name === undefined){
				throw new Error('Parameter firstname or lastname not passed');
			}
			if(!(typeof name === 'string')){
				throw new Error('Parameter firstname or lastname must be of type String');
			}
			if(name.length < NAME_MIN_LENGTH || name.length > NAME_MAX_LENGTH){
				throw new Error('Parameter firstname or lastname must be between ' + NAME_MIN_LENGTH + ' and ' + NAME_MAX_LENGTH);
			}
			isLatinLetters = name.match(latinLettersPattern)[0] === name;
			if(!isLatinLetters){
				throw new Error('First name or last name should contain only Latin letters');
			}
			return name;
		}
		    
		function validateAge(ageValue) {
			if(ageValue === undefined){
				throw new Error('Parameter age not passed');
			}
			if(!(typeof ageValue === 'number')){
				throw new Error('Parameter age must be of type Number');
			}
			if(ageValue < MIN_AGE || ageValue > MAX_AGE){
				throw new Error('Parameter age must be between ' + MIN_AGE + ' and ' + MAX_AGE);
			}
			return ageValue;			
		} 

		return Person;
	} ());
	return Person;
}

module.exports = solve;