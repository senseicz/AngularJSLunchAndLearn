var initialMenuSelected = false;

(function () {
    'use strict';

    var app = angular.module('app', ['ngAnimate', 'ngRoute', 'ngSanitize'])
    .factory('appCache', function($cacheFactory) {
            return $cacheFactory('appCache');
        });

    
    app.run(['lookupDataService', 'resumeService', function (lookupDataService, resumeService) {
        lookupDataService.preLoadLookupData();

        resumeService.getResume().then(function (data) {
            //console.log('resume data assigned');
            resumeService.setResume(data);
            //console.log('resume SET');
        }, function (status) { console.log(status); });

    }]);

    angular.module('app').directive('resumeStatus', function () {
        return {
            restrict: 'E',
            templateUrl: 'ResumeBuilderApp/partials/resumeStatus.html'
        };
    });

})();