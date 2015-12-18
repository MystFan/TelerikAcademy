(function () {
	'use strict';

	function tripsData(data, authorization, identity, baseServiceUrl) {
		return {
			getAll: function (count) {
				count = count || 1;

				var headers = { 'Content-Type': 'application/json' };
				if (identity.isAuthenticated()) {
					headers = {
						'Authorization': authorization.getAuthorizationHeader().Authorization,
						'Content-Type': 'application/json'
					}
				}

				return data.get(baseServiceUrl + 'api/trips?page=' + count, headers);
			},
			create: function (trip) {

				var headers = {
					'Authorization': authorization.getAuthorizationHeader().Authorization,
					'Content-Type': 'application/json'
				}

				return data.post(baseServiceUrl + 'api/trips', trip, headers);
			},
			get: function (id) {

				var headers = { 'Content-Type': 'application/json' };
				if (identity.isAuthenticated()) {
					headers = {
						'Authorization': authorization.getAuthorizationHeader().Authorization,
						'Content-Type': 'application/json'
					}
				}

				return data.get(baseServiceUrl + 'api/trips/' + id, headers);
			},
			join: function join(id) {

				var headers = { 'Content-Type': 'application/json' };
				if (identity.isAuthenticated()) {
					headers = {
						'Authorization': authorization.getAuthorizationHeader().Authorization,
						'Content-Type': 'application/json'
					}
				}

				return data.put(baseServiceUrl + 'api/trips/' + id, undefined, headers);
			}
		}
	}

	angular.module('tripExchange.services')
		.factory('tripsData', ['data', 'authorization', 'identity', 'baseServiceUrl', tripsData]);
} ());