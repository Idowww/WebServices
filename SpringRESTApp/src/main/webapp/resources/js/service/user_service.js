'use strict';

App.factory('UserService', ['$http', '$q', function($http, $q){

	return {
		
			fetchAllUsers: function() {
					return $http.get('http://localhost:8080/SpringRESTApp/api/users')
							.then(
									function(response){
										return response.data;
									}, 
									function(errResponse){
										console.error('Error while fetching users');
										return $q.reject(errResponse);
									}
							);
			},
			createUser: function(user){
                return $http.post('http://localhost:8080/SpringRESTApp/api/users', user)
                        .then(
                                function(response){
                                    return response.data;
                                }, 
                                function(errResponse){
                                    console.error('Error while creating user');
                                    return $q.reject(errResponse);
                                }
                        );
        },
        deleteUser: function(id){
            return $http.delete('http://localhost:8080/SpringRESTApp/api/users/'+id)
                    .then(
                            function(response){
                                return response.data;
                            }, 
                            function(errResponse){
                                console.error('Error while deleting user');
                                return $q.reject(errResponse);
                            }
                    );
    }
		    
		    
		
	};

}]);
