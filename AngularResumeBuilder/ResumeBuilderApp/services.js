(function() {
    'use strict';

    angular.module('app').factory('lookupDataService', ['$http', '$q', 'cacheService', lookupDataService]);
    angular.module('app').factory('resumeService', ['$http', '$q', '$rootScope', resumeService]);
    angular.module('app').factory('cacheService', ['appCache', cacheService]);


    function lookupDataService($http, $q, appCacheService) {
        return {
            preLoadLookupData: function() {
                this.getLookupData('PhoneNumberTypes', true);
                this.getLookupData('Countries', true);
                this.getLookupData('AddressTypes', true);
            },

            getLookupData: function (lookupDataType, forceRefresh) {
                if (appCacheService.isInCache(lookupDataType) && !forceRefresh) {
                    return $q.when(appCacheService.getFromCache(lookupDataType));
                }

                return getResourceFromServer($http, $q, '/api/' + lookupDataType)
                    .then(function(data) {
                        if (data != undefined) {
                            appCacheService.addToCache(lookupDataType, data);
                        }
                        return $q.when(data);
                    });
            }
        };
    };

    function resumeService($http, $q, $rootScope) {
        var _resume = null;
        var _resumePromise = null;
        var _resumeChanged = false;

        return {
            setResumeChanged: function(resumeChangeStatus, origin) {
                if ((!resumeChangeStatus && origin === 'service') || resumeChangeStatus) {
                    _resumeChanged = resumeChangeStatus;
                }
                
                $rootScope.$broadcast('resumeDataChanged', {status: _resumeChanged});
            },

            getResumeChangedStatus: function() {
                return _resumeChanged;
            },

            setResume: function (resume) {
                _resume = resume;
            },

            getResume: function (resumeId) {
                if (_resume == null) {
                    if (_resumePromise == null) {
                        _resumePromise = getResourceFromServer($http, $q, '/api/resume/1');
                    }
                    return _resumePromise;
                }

                return $q.when(_resume);
            },

            saveResume: function() {
                $http({
                    method: 'PUT',
                    url: '/api/resume',
                    data: _resume
                }).success(function(data, status, headers, config) {
                    return data;
                }).error(function(data, status, headers, config) {
                    console.log(status);
                });
            },

            updateResume: function() {
                $http({
                    method: 'POST',
                    url: '/api/resume',
                    data: _resume
                }).success(function (data, status, headers, config) {
                    console.log("Resume updated");
                    _resumeChanged = false;
                    $rootScope.$broadcast('resumeDataChanged', { status: _resumeChanged });
                    return data;
                }).error(function (data, status, headers, config) {
                    console.log(status);
                });
            }
        };
    }

    function getResourceFromServer($http, $q, url) {
        var deffered = $q.defer();
        $http({
            method: 'GET',
            url: url
        }).success(function (data, status, headers, config) {
            deffered.resolve(data);
        }).error(function (data, status, headers, config) {
            deffered.reject(status);
        });

        return deffered.promise;
    }

    function cacheService(appCache) {
        return {
            isInCache: function(key) {
                var isThere = appCache.get(key);
                return isThere != undefined;
            },
            getFromCache: function(key) {
                return appCache.get(key);
            },
            addToCache: function(key, value) {
                appCache.put(key, value);
            }
        };
    }
})();
