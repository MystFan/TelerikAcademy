(function(){
	'use strict';
	
	function DriversController($scope, identity, driversData, $routeParams, $location, notifier){
		$scope.userAuth = identity.isAuthenticated();

		driversData.getAll()
			.then(function (data) {
				$scope.drivers = data;
			},
				function (err) {
					notifier.error(err.message);
					$location.path('/unauthorized');
				})
	}
	
	angular.module('tripExchange.controllers')
		.controller('DriversController', ['$scope', 'identity', 'driversData', '$routeParams', '$location', 'notifier', DriversController]);
}());