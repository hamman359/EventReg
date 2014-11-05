'use strict';

eventsApp.directive('mySample', function ($compile) {
    return {
        restrict: 'C',
        template: "<input type='Text' ng-model='sampleData' /> {{sampleData}}<br />", // Doesn't need to be compiled
        //link: function ($scope, element, attrs, controller) {
        //    var markup = "<input type='Text' ng-model='sampleData' /> {{sampleData}}<br />";
        //    angular.element(element).html($compile(markup)($scope));
        //},
        scope: {

        }
    };
});