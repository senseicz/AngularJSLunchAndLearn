(function () {
    'use strict';

    var app = angular.module('app');

    // Collect the routes
    app.constant('routes', getRoutes());

    // Configure the routes and route resolvers
    app.config(['$routeProvider', 'routes', routeConfigurator]);

    function routeConfigurator($routeProvider, routes) {
        routes.forEach(function (r) {
            $routeProvider.when(r.url, r.config);
        });
        $routeProvider.otherwise({ redirectTo: '/' });
    }

    // Define the routes 
    function getRoutes() {
        return [
            {
                url: '/',
                config: {
                    templateUrl: 'ResumeBuilderApp/ContactInfo/contactInfo.html',
                    title: 'Contact Information',
                    settings: {
                        nav: 1,
                        content: '<i class="iconContactInformation"></i>Contact Information',

                    }
                }
            }, {
                url: '/editOverview',
                config: {
                    title: 'Professional Overview',
                    templateUrl: 'ResumeBuilderApp/Overview/professionalOverview.html',
                    settings: {
                        nav: 2,
                        content: '<i class="iconSummary"></i>Professional Overview'
                    }
                }
            }
        ];
    }
})();