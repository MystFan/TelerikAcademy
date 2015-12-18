(function () {
	'use strict';

	function driversData(data, authorization, identity, baseServiceUrl) {
		return {
			getAll: function () {
				var headers = { 'Content-Type': 'application/json' };
				if (identity.isAuthenticated()) {
					headers = {
						'Authorization': authorization.getAuthorizationHeader().Authorization,
						'Content-Type': 'application/json'
					}
				}

				return data.get(baseServiceUrl + 'api/drivers', headers);
			},
			get: function (id) {
				var headers = { 'Content-Type': 'application/json' };
				if (identity.isAuthenticated()) {
					headers = {
						'Authorization': authorization.getAuthorizationHeader().Authorization,
						'Content-Type': 'application/json'
					}
				}
				
				return data.get(baseServiceUrl + 'api/drivers/' + id, headers);
			}
		}
	}

	angular.module('tripExchange.services')
		.factory('driversData', ['data', 'authorization', 'identity', 'baseServiceUrl', driversData]);
} ());