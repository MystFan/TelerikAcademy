/* Task description */
/*
	Write a function that finds all the prime numbers in a range
		1) it should return the prime numbers in an array
		2) it must throw an Error if any on the range params is not convertible to `Number`
		3) it must throw an Error if any of the range params is missing
*/

function findPrimes(from, to) {
	'use strict';
	var primeNumbers, index, j, maxDivider, isPrime;
	
	if(from === undefined || to === undefined){
		throw new Error('Some of the range params is missing');
	}
	if(isNaN(parseInt(from)) || isNaN(parseInt(to))){
		throw new Error('Some of the range params is not convertible to `Number`');
	}

	if(from < 2){
		from = 2;
	}
    primeNumbers = [];
	isPrime = true;
	for (index = from; index <= to; index+=1) {
		maxDivider = Math.sqrt(index);
		for (j = 2; j <= maxDivider; j+=1) {
		    if(index % j == 0){
				isPrime = false;
				break;
			}
		}
		
		if(isPrime){
			primeNumbers.push(index);
		}else{
			isPrime = true;
		}
	}
	
	return primeNumbers;
}

module.exports = findPrimes;
