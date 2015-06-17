/* Task Description */
/* 
	Write a function that sums an array of numbers:
		numbers must be always of type Number
		returns `null` if the array is empty
		throws Error if the parameter is not passed (undefined)
		throws if any of the elements is not convertible to Number	

*/

function sum(array) {
	'use strict';
	var numbers, element, index, len, result;
	
	if(array === undefined){
		throw new Error('Parameter is not passed');
	}
	numbers = array;
	if(numbers.length === 0){
		return null;
	}
	
	result = 0;
	for (index = 0, len = numbers.length ; index < len; index+=1) {
		element = parseInt(array[index]);
		if(isNaN(element)){
			throw new Error('Element is not convertible to Number');
		}
		result += element;
	}
	return result;
}

module.exports = sum;