(function () {
    'use strict';

    function gamesService($http, $q, baseUrl) {
        return {
            all: function all(){
                var defered = $q.defer();

                $http.get(baseUrl + '/api/games/all')
                .success(function (res) {
                    defered.resolve(res);
                })
                .error(function (err) {
                    defered.reject(err);
                });

                return defered.promise;
            },
            create: function create() {
                var defered = $q.defer();

                $http.post(baseUrl + '/api/games/create')
                .success(function (res) {
                    defered.resolve(res);
                })
                .error(function (err) {
                    defered.reject(err);
                });

                return defered.promise;
            },
            details: function details(gameId) {
                var defered = $q.defer();

                $http.get(baseUrl + '/api/games/status?gameId=' + gameId)
                .success(function (res) {
                    defered.resolve(res);
                })
                .error(function (err) {
                    defered.reject(err);
                });

                return defered.promise;
            },
            join: function join() {
                var defered = $q.defer();

                $http.post(baseUrl + '/api/games/join')
                .success(function (res) {
                    defered.resolve(res);
                })
                .error(function (err) {
                    defered.reject(err);
                });

                return defered.promise;
            },
            play: function play(gameModel) {
                var defered = $q.defer();

                $http.post(baseUrl + '/api/games/play', gameModel)
                .success(function (res) {
                    defered.resolve(res);
                })
                .error(function (err) {
                    defered.reject(err);
                });

                return defered.promise;
            }
        }
    }

    angular.module('tic-tac-toe.services')
    .factory('games', ['$http', '$q', 'baseUrl', gamesService])
})();