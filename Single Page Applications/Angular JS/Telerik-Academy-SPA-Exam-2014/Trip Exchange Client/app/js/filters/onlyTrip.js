(function(){
	'use strict';
	
	function onlyTrip(trips){
		var output = [];

		angular.forEach(trips, function (trip) {
			if (trip.isMine) {
				output.push(trip)
			}
		})

		return output;
	}
	
	angular.module('tripExchange')
		.filter('onlyTrip', [onlyTrip]);
}());