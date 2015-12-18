(function () {
	'use strict';

	function citiesData(data, baseServiceUrl) {
		return {
			getAll: function () {
				return data.get(baseServiceUrl + 'api/cities', {
					headers: {
						'Content-Type': 'application/json'
					}
				})
			}
		}
	}

	angular.module('tripExchange.services')
		.factory('citiesData', ['data', 'baseServiceUrl', citiesData]);
} ());