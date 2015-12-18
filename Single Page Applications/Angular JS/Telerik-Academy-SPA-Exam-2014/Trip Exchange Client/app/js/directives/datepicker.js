(function () {
	'use strict';

	function datepicker() {
		return {
			restrict: 'A',
			link: function (scope, element, attr) {
				element.datepicker();
			}
		}
	}

	angular.module('tripExchange')
		.directive('datepicker', [datepicker]);
} ());