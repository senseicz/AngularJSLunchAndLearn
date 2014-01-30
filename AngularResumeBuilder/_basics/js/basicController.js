(function () {
    'use strict';

    var controllerId = 'basicCtrl';
    angular.module('app').controller(controllerId, ['$scope', basicCtrl]);

    function basicCtrl($scope) {
        var vm = this;

        vm.testObject = {
            title: "Contact Information",
            someDataInArray: ["Text 1", "Text 2", "Text 3"],
            innerObject: {
                innerObjectId: 1,
                innerObjectText: "This is text in inner object"
            },
            innerObjectArray: [
                {
                    innerObjectId: 1,
                    innerObjectText: "Answer to the Ultimate Question of Life, the Universe, and Everything comes next."
                },
                {
                    innerObjectId: 2,
                    innerObjectText: "Erm, not yet, sorry guys."
                }
            ],
            user: {
                name: '',
                email: ''
            }
        };

        vm.buttonClicked = function() {
            alert("something was clicked");
        };

        vm.numberClicked = 0;

        vm.anotherButtonClicked = function(fromView) {
            alert("Hello " + fromView + ' [' + vm.numberClicked + ']');
            vm.numberClicked++;
        };

        vm.addNewObject = function() {
            vm.testObject.innerObjectArray.push(
            {
                innerObjectId: vm.testObject.innerObjectArray.length + 1,
                innerObjectText: 'What do you get if you multiply six by nine?'
            });

            vm.numberClicked++;

            if (vm.numberClicked % 3 == 0) {
                vm.testObject.innerObjectArray.push(
                {
                    innerObjectId: vm.testObject.innerObjectArray.length + 1,
                    innerObjectText: 'Answer is: 42.'
                });
            }
        };
    }


    angular.module('app').directive('partialExample', function () {
        return {
            restrict: 'E',
            templateUrl: 'partial.html'
        };
    });


    var INTEGER_REGEXP = /^\-?\d+$/;
    angular.module('app').directive('integer', function () {
        return {
            require: 'ngModel',
            link: function (scope, elm, attrs, ctrl) {
                ctrl.$parsers.unshift(function (viewValue) {
                    if (INTEGER_REGEXP.test(viewValue)) {
                        // it is valid
                        ctrl.$setValidity('integer', true);
                        return viewValue;
                    } else {
                        // it is invalid, return undefined (no model update)
                        ctrl.$setValidity('integer', false);
                        return undefined;
                    }
                });
            }
        };
    });


})();