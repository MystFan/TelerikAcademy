(function () {
	'use strict';

	function TripDetailsController($scope, $routeParams, $location, identity, tripsData, notifier) {
		$scope.userAuth = identity.isAuthenticated();

		tripsData.get($routeParams.id)
			.then(function (data) {
				data.passengers = data.passengers.join(', ');
				$scope.trip = data;
			}, function (err) {
				notifier.error(err.message);
				$location.path('/unauthorized');
			})

		$scope.joinTrip = function joinTrip() {
			tripsData.join($routeParams.id)
				.then(function (data) {
					data.passengers = data.passengers.join(', ');
					$scope.trip = data;
				}, function (err) {
					notifier.error(err.message);
					$location.path('/unauthorized');
				})
		}
	}

	angular.module('tripExchange.controllers')
		.controller('TripDetailsController', ['$scope', '$routeParams', '$location', 'identity', 'tripsData', 'notifier', TripDetailsController]);
} ());