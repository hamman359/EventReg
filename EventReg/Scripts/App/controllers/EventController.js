'use strict';

eventsApp.controller("EventController",
    function EventController($scope, eventData, $anchorScroll, $routeParams, $route) {

        $scope.sortorder = 'name';
        //eventData.getEvent().then(
		//	function (event) { $scope.event = event; },
		//	function (statusCode) { console.log(statusCode); }
		//);

        $scope.event = $route.current.locals.event;//eventData.getEvent($routeParams.eventId);
        console.log($route.current.foo);
        console.log($route.current.params.baz);


        $scope.upVoteSession = function (session) {
            session.upVoteCount++;
        };

        $scope.downVoteSession = function (session) {
            session.upVoteCount--;
        };

        $scope.scrollToSession = function () {
            $anchorScroll();
        };

        $scope.reload = function() {
            $route.reload();
        }
    }
);