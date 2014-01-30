(function () {
    'use strict';

    var controllerId = 'layout';
    angular.module('app').controller(controllerId, ['$rootScope', '$timeout', 'resumeService', layout]);

    function layout($rootScope, $timeout, resumeService) {
        var vm = this;

        vm.IsResumeChanged = false;
        vm.ResumeJustUpdated = false;

        $rootScope.$on('resumeDataChanged',
            function(event, args) {
                vm.IsResumeChanged = args.status;
            }
        );

        vm.updateResume = function () {
            resumeService.updateResume();
            this.ResumeJustUpdated = true;
            $timeout(function() {}, 2000).then(function() {
                vm.ResumeJustUpdated = false;
            });
        };
    };
})();