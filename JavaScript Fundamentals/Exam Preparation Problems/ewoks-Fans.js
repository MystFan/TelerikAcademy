var example1 = [
	'22.03.2014',
	'17.05.1933',
	'10.10.1954',
];
var example2 = [
	'22.03.2000'
];
var example3 = [
	'22.03.1700',
	'01.07.2020'
];
var example4 = [
	'22.03.   2014',
	'17.05.1933',
	'10.10.1954',
		'12.04.2001',
	'17.05.1972',
	'09.10.1974',
];

function solve(params) {
	var index, j, dates, day, month, year, element, dateParams, borderDate, downDate, upDate, currentDate, beforeDates, afterDates;
	borderDate = new Date(1973, 4, 25, 0, 0, 0, 0);
	downDate = new Date(1900, 0, 1, 0, 0, 0, 0);
	upDate = new Date(2015, 0, 1, 0, 0, 0, 0);
	dates = [];
	for (index = 0; index < params.length; index++) {
		element = params[index];
		dateParams = element.split('.');
		day = dateParams[0].trim() - 0;
		month = dateParams[1].trim() - 0;
		year = dateParams[2].trim() - 0;
		currentDate = new Date(year, month - 1, day, 0, 0, 0, 0);
		if (currentDate > downDate && currentDate < upDate) {
			dates.push(currentDate);
		}
	}

	beforeDates = [];
	afterDates = [];
	for (j = 0; j < dates.length; j++) {
		if (dates[j] < borderDate) {
			beforeDates.push(dates[j]);
		}
		else if (dates[j] >= borderDate) {
			afterDates.push(dates[j]);
		}
	}

	afterDates.sort(function (a, b) {
		return a.getFullYear() - b.getFullYear() || a.getMonth() - b.getMonth() || a.getDate() - b.getDate();
	});
	beforeDates.sort(function (a, b) {
		return a.getFullYear() - b.getFullYear() || a.getMonth() - b.getMonth() || a.getDate() - b.getDate();
	});

	if (afterDates.length > 0) {
		console.log('The biggest fan of ewoks was born on ' + (afterDates[afterDates.length - 1].toDateString()));
	}
	if (beforeDates.length > 0) {
		console.log('The biggest hater of ewoks was born on ' + (beforeDates[0].toDateString()));
	}
	if (afterDates.length === 0 && beforeDates.length === 0) {
		console.log('No result');
	}
}
solve(example1);
solve(example2);
solve(example3);
solve(example4);
