'use strict'

var eventsApp = angular.module('eventsApp', ['ngResource', 'ngCookies', 'ngRoute'])
    .config(function ($routeProvider, $locationProvider) {
        $routeProvider.when('/newEvent',
            {
                templateUrl: '/scripts/app/templates/NewEvent.html',
                controller: 'EditEventController'
            });
        $routeProvider.when('/events',
            {
                templateUrl: '/scripts/app/templates/EventList.html',
                controller: 'EventListController'
            });
        $routeProvider.when('/event/:eventId',
            {
                foo: 'bar',
                //template: 'Hello World',
                templateUrl: '/scripts/app/templates/EventDetails.html',
                controller: 'EventController',
                resolve: {
                    event: function ($route, eventData) {
                        return eventData.getEvent($route.current.pathParams.eventId).$promise;
                    }
                }
            });
        $routeProvider.otherwise({ redirectTo: '/events' });
        $locationProvider.html5Mode(true);
    });
    //.factory('myCache', function($cacheFactory) {
    //    return $cacheFactory('myCache', {capacity:3})
//});