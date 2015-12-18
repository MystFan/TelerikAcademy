(function () {
	'use strict';

	function data($http, $q, baseServiceUrl) {
		return {
			get: function (url, headers) {
				var deferred = $q.defer();

				$http.get(url, {
					headers: headers,
					cache: true
				})
					.success(function (data) {
						deferred.resolve(data);
					})
					.error(function (err) {
						deferred.reject(err);
					});

				return deferred.promise;
			},
			post: function (url, data, headers) {
				var deferred = $q.defer();

				$http.post(url, data, {
					headers: headers,
					cache: true
				})
					.success(function (data) {
						deferred.resolve(data);
					})
					.error(function (err) {
						deferred.reject(err);
					});

				return deferred.promise;
			},
			put: function (url, data, headers) {
				var deferred = $q.defer();

				$http.put(url, data, {
					headers: headers,
					cache: true
				})
					.success(function (data) {
						deferred.resolve(data);
					})
					.error(function (err) {
						deferred.reject(err);
					});

				return deferred.promise;
			}
		}
	}

	angular.module('tripExchange.services')
		.factory('data', ['$http', '$q', 'baseServiceUrl', data]);
} ());