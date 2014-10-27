eventsApp.factory('eventData', function ($http, $resource) {
	var resource = $resource('/api/event/:id', {id : '@id'});
	return {
		getEvent: function () {
			return resource.get({ id: 1 });

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

		}
	};

});