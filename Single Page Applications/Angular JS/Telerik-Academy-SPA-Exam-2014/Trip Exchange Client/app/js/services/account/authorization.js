(function () {
    'use strict';

    function authorization(identity) {
        return {
            getAuthorizationHeader: function () {
                return {
                    'Authorization': 'Bearer ' + identity.getCurrentUser()['access_token']
                }
            }
        }
    }

    angular.module('tripExchange.services')
        .factory('authorization', ['identity', authorization]);
} ());