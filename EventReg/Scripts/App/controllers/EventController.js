'use strict';

eventsApp.controller("EventController",
    function EventController($scope, eventData, $anchorScroll) {

        $scope.sortorder = 'name';
        //eventData.getEvent().then(
		//	function (event) { $scope.event = event; },
		//	function (statusCode) { console.log(statusCode); }
		//);

        $scope.event = eventData.getEvent();

        $scope.upVoteSession = function (session) {
            session.upVoteCount++;
        };

        $scope.downVoteSession = function (session) {
            session.upVoteCount--;
        };

        $scope.scrollToSession = function () {
            $anchorScroll();
        }
    }
);