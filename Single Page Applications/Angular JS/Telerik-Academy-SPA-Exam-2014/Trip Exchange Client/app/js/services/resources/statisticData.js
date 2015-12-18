(function () {
	'use strict';

	function statisticData(data, baseServiceUrl) {
		return {
			get: function () {		
				var headers = { 'Content-Type': 'application/json' };
				return data.get(baseServiceUrl + 'api/stats', headers);
			}
		}
	}

	angular.module('tripExchange.services')
		.factory('statisticData', ['data', 'baseServiceUrl', statisticData]);
} ());