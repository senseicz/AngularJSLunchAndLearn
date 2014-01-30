(function () {
    'use strict';

    var controllerId = 'contactInfo';
    angular.module('app').controller(controllerId, ['$scope', 'lookupDataService', 'resumeService', contactInfo]);

    function contactInfo($scope, lookupDataService, resumeService) {
        var resumeSet = false;
        var shouldBroadcastResumeChange = resumeService.getResumeChangedStatus();
        var vm = this;

        /*Lookup data*/
        lookupDataService.getLookupData('PhoneNumberTypes').then(function (data) {
            vm.PhoneNumberTypes = data;
        }, function(status) { console.log(status); });

        lookupDataService.getLookupData('Countries').then(function (data) {
            vm.Countries = data;
        }, function (status) { console.log(status); });

        lookupDataService.getLookupData('AddressTypes').then(function (data) {
            vm.AddressTypes = data;
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

        vm.removePhoneNumber = function(index) {
            vm.Resume.BasicUserInfo.PhoneNumbers.splice(index, 1);
        };

        vm.addNewPhoneNumber = function() {
            //vm.Resume.BasicUserInfo.PhoneNumbers.push({ "PhoneNumberTypeId": 1, "Number": "" });
            vm.Resume.BasicUserInfo.PhoneNumbers.push({});
        };

        vm.removeAddress = function(index) {
            vm.Resume.BasicUserInfo.Addresses.splice(index, 1);
        };

        vm.addNewAddress = function() {
            vm.Resume.BasicUserInfo.Addresses.push( {} );
        };
    };

    angular.module('app').directive('phoneNumbers', function() {
        return {
            restrict: 'E',
            templateUrl: 'ResumeBuilderApp/partials/phoneNumbers.html'
        };
    });

})();