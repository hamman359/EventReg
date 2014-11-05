/// <reference path="../templates/EventDetails.html" />
'use strict';

eventsApp.directive('eventThumbnail', function ($compile) {
    return {
        restrict: 'E',
        replace: true,
        templateUrl: '/scripts/app/templates/directives/eventThumbnail.html',
        scope: {
            event: "="
        }
    };
});