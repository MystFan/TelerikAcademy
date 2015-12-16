(function () {
    'use strict';

    function config($routeProvider, $locationProvider) {
        $locationProvider.html5Mode(true);

        $routeProvider
        .when('/home', {
            templateUrl: 'partials/home/home.html',
            controller: 'HomeController'
        })
        .when('/identity/register', {
            templateUrl: 'partials/identity/register.html',
            controller: 'RegisterController'
        })
        .when('/identity/login', {
            templateUrl: 'partials/identity/login.html',
            controller: 'LoginController'
        })
        .when('/identity/profile', {
            templateUrl: 'partials/identity/profile.html',
            controller: 'ProfileController',
            resolve: {
                authenticate: ['$q', 'auth', function ($q, auth) {
                    if (auth.isAuthenticated()) {
                        return true;
                    }

                    return $q.reject('not authorized');
                }]
            }
        })
        .when('/game/details/:id', {
            templateUrl: 'partials/game/game-details.html',
            controller: 'GameDetailsController',
            resolve: {
                authenticate: ['$q', 'auth', function ($q, auth) {
                    if (auth.isAuthenticated()) {
                        return true;
                    }

                    return $q.reject('not authorized');
                }]
            }
        })
        .when('/game/play/:id', {
            templateUrl: 'partials/game/game-play.html',
            controller: 'GamePlayController',
            resolve: {
                authenticate: ['$q', 'auth', function ($q, auth) {
                    if (auth.isAuthenticated()) {
                        return true;
                    }

                    return $q.reject('not authorized');
                }]
            }
        })
       
        .otherwise({ redirectTo: '/home' });
    }

    function run($http, $cookies, $rootScope, $location, auth) {
        $rootScope.$on('$routeChangeError', function (ev, current, previous, rejection) {
            if (rejection === 'not authorized') {
                $location.path('/home');
            }
        });

        if (auth.isAuthenticated()) {
            $http.defaults.headers.common.Authorization = 'Bearer ' + $cookies.get('authentication');
            auth.getIdentity()
                .then(function (identity) {

                });
        }
    };

    angular.module('tic-tac-toe.controllers', ['tic-tac-toe.services']);
    angular.module('tic-tac-toe.services', []);

    angular.module('tic-tac-toe', ['ngRoute', 'ngCookies', 'tic-tac-toe.controllers'])
        .config(['$routeProvider', '$locationProvider', config])
        .run(['$http', '$cookies', '$rootScope', '$location', 'auth', run])
        .value('toastr', toastr)
    .constant('baseUrl', 'http://localhost:33257');

})();