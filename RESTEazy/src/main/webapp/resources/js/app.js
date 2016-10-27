(function() {
	var app = angular.module("app", []);

	app.controller("UserCtrl", function($scope, $http) {

		var response = $http.get('/RESTEazy/rest/users/');

		response.success(function(data) {
			$scope.users = data;
		});

		response.error(function(data, status, headers, config) {
			alert("AJAX failed to get data, status=" + status);
		});

	});
})();