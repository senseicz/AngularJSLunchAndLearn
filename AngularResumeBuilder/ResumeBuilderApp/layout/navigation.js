(function () {
    'use strict';

    var controllerId = 'navigation';
    angular.module('app').controller(controllerId, ['$route', 'routes', 'resumeService', navigation]);

    function navigation($route, routes, resumeService) {
        var vm = this;

        resumeService.getResume().then(function (data) {
            vm.Resume = data;
        }, function (status) { console.log(status); });

        vm.isCurrent = isCurrent;
        var navRoutes = getNavRoutes();

        vm.navRoutes = navRoutes;

        function getNavRoutes() {
            return routes.filter(function (r) {
                return r.config.settings && r.config.settings.nav;
            }).sort(function (r1, r2) {
                return r1.config.settings.nav > r2.config.settings.nav;
            });
        }

        function isCurrent(route) {
            if (!route.config.title || !$route.current || !$route.current.title) {
                $route.current = route;
                $route.current.title = route.config.title;
                return 'active';
            }
            var menuName = route.config.title;
            return $route.current.title.substr(0, menuName.length) === menuName ? 'active' : '';
        }
    };
})();