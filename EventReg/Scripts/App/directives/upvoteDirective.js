'use strict';

eventsApp.directive('upvote', function ($compile) {
    return {
        restrict: 'E',
        replace: true,
        templateUrl: '/scripts/app/templates/directives/upvote.html',
        scope: {
            upvote: "&", //"&" represents a method
            downvote: "&",
            count: "=" //"=" represents a property
        }
    };
});