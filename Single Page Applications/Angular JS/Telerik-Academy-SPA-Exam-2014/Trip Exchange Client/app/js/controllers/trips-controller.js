(function () {
	'use strict';

	function TripsController($scope, $location, identity, notifier, tripsData, citiesData) {
		$scope.userAuth = identity.isAuthenticated();
		$scope.sortTrip = 'none';
		$scope.currentPage = 0;
		$scope.pageSize = 10;

		$scope.nextPage = function () {
			$scope.currentPage = $scope.currentPage + 1;
			tripsData.getAll($scope.currentPage)
				.then(function (data) {
					$scope.trips = data;
				});
		}

		$scope.prevPage = function () {
			$scope.currentPage = $scope.currentPage - 1;
			tripsData.getAll($scope.currentPage)
				.then(function (data) {
					$scope.trips = data;
				});
		}

		$scope.nextPage();

		citiesData.getAll()
			.then(function (data) {
				$scope.cities = data;
			})

		$scope.saveTrip = function (tripToSave, form) {
			if (form.$valid) {

				tripsData.create(tripToSave)
					.then(function (data) {
						notifier.success('Trip created!');
						$location.path('/trip-details/' + data.id);
					},
						function (err) {
							var currentDate = new Date();
							var requestDate = new Date(tripToSave.departureTime);
							if (currentDate > requestDate) {
								notifier.error(err.message);
								$location.path('/trips-create');
							}
							else {
								notifier.error(err.message);
								$location.path('/unauthorized');
							}
						});
			}

			$location.path('#/trips');
		}


	}

	angular.module('tripExchange.controllers')
		.controller('TripsController', ['$scope', '$location', 'identity', 'notifier', 'tripsData', 'citiesData', TripsController]);
} ());