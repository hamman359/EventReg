eventsApp.factory('eventData', function ($http, $resource) {
    var resource = $resource('/api/event/:id', { id: '@id' }, { "getAll": { method: "GET", isArray: true } });
	return {
		getEvent: function (eventId) {
			return resource.get({ id:eventId });

			//var deferred = $q.defer();
			//$http({method: 'GET', url: '/api/event/1'})
			//	.success(function (data, status, headers, config) {
			//		deferred.resolve(data);
			//	})
			//	.error(function(data, status, headers, config) {
			//		deferred.reject(status);
			//	});

			//return deferred.promise;
		},
		save: function (event) {
			return resource.save(event);

		},
		getAllEvents: function () {
		    return resource.query();
		}
	};

});