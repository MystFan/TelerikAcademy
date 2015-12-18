(function(){
	'use strict';
	
	function HomeController($scope, notifier, driversData, tripsData, statisticData){
		tripsData.getAll()
			.then(function (data) {
				$scope.trips = data;
			});

		driversData.getAll()
			.then(function (data) {
				$scope.drivers = data;
			})

		statisticData.get()
			.then(function (data) {
				$scope.statistic = data; 
			})
	}
	
	angular.module('tripExchange.controllers')
		.controller('HomeController', ['$scope', 'notifier', 'driversData', 'tripsData', 'statisticData', HomeController]);
}());