(function(){
    'use strict';
    
    function config($routeProvider){
        $routeProvider
            .when('/register', {
                templateUrl: 'views/partials/register.html',
                controller: 'RegisterController'
            })
            .when('/home', {
                templateUrl: 'views/partials/home.html',
                controller: 'HomeController'
            })
            .when('/trips', {
                templateUrl: 'views/partials/trips.html',
                controller: 'TripsController'
            })
            .when('/trip-details/:id', {
                templateUrl: 'views/partials/trip-details.html',
                controller:'TripDetailsController'
            })
            .when('/trips-create', {
                templateUrl: 'views/partials/trips-create.html',
                controller: 'TripsController'
            })
            .when('/drivers', {
                templateUrl: 'views/partials/drivers.html',
                controller: 'DriversController'
            })
            .when('/driver-details/:id', {
                templateUrl: 'views/partials/driver-details.html',
                controller:'DriverDetailsController'
            })
            .when('/unauthorized', {
                templateUrl: 'views/partials/unauthorized.html'
            })
            .otherwise({ redirectTo: '/home' });
    }
    
    angular.module('tripExchange.services', []);
    angular.module('tripExchange.controllers', ['tripExchange.services']);
    
    angular.module('tripExchange', ['ngRoute', 'ngResource', 'ngCookies', 'tripExchange.controllers'])
        .config(['$routeProvider', config])
        .value('toastr', toastr)
        .constant('baseServiceUrl', 'http://localhost:1337/');
}());