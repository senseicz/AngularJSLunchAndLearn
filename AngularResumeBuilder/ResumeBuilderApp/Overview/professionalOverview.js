(function () {
    'use strict';

    var controllerId = 'professionalOverview';
    angular.module('app').controller(controllerId, ['$scope', 'resumeService', 'lookupDataService', overview]);

    function overview($scope, resumeService, lookupDataService) {
        var resumeSet = false;
        var shouldBroadcastResumeChange = resumeService.getResumeChangedStatus();
        var vm = this;
        
        /*Lookup data*/
        lookupDataService.getLookupData('Occupations').then(function (data) {
            vm.Occupations = data;
        }, function (status) { console.log(status); });

        /*Lookup data /ends*/


        resumeService.getResume().then(function (data) {
            vm.Resume = data;
            resumeSet = true;
        }, function (status) { console.log(status); });

        $scope.$watch('vm.Resume', function (newVal, oldVal) {
            resumeService.setResumeChanged(shouldBroadcastResumeChange, '$watch');
            if (resumeSet && !shouldBroadcastResumeChange) {
                shouldBroadcastResumeChange = true;
            }
        }, true);

        vm.updateResume = function () {
            resumeService.updateResume();
        };

        vm.addOccupation = function() {
            vm.Resume.Summary.Occupations.push({});
        };

        vm.removeOccupation = function (index) {
            vm.Resume.Summary.Occupations.splice(index, 1);
        };
    };
})();