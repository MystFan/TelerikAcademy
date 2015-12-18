(function(){
	'use strict';
	
	function DriverDetailsController($scope, identity, driversData, $routeParams, $location, notifier, $filter){
		$scope.userAuth = identity.isAuthenticated();

		var trips;
		driversData.get($routeParams.id)
			.then(function (data) {
				trips = data;
				$scope.driver = data;
			},
				function (err) {
					notifier.error(err.message);
					$location.path('/unauthorized');
				})

		$scope.sortTrips = 'none';
		$scope.getMineTrips = function (type) {
			if (type) {
				$scope.driver.trips = $filter('onlyTrip')($scope.driver.trips);
			}
			else {
				driversData.get($routeParams.id)
					.then(function (data) {
						$scope.driver = data;
					})
			}
		}

		$scope.getDriveTrips = function (type) {
			
		}
	}
	
	angular.module('tripExchange.controllers')
		.controller('DriverDetailsController', ['$scope', 'identity', 'driversData', '$routeParams', '$location', 'notifier', '$filter', DriverDetailsController])
}());