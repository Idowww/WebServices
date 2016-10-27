<%@ page language="java" contentType="text/html; charset=ISO-8859-1"
	pageEncoding="ISO-8859-1"%>
<%@ taglib prefix="c" uri="http://java.sun.com/jsp/jstl/core"%>
<html ng-app="myApp">
<head>
<title>Users via AngularJS</title>


<link rel="stylesheet"
	href="https://maxcdn.bootstrapcdn.com/bootstrap/3.3.5/css/bootstrap.min.css">
</head>
<body ng-controller="UserController as ctrl">
	<h2>Users Management via Spring REST & AngularJS</h2>
	<div class="container">
              <div class="formcontainer">
                  <form ng-submit="ctrl.submit()" name="myForm" class="form-horizontal">
                      <input type="hidden" ng-model="ctrl.user.id" />
                      <div class="row">
                          <div class="form-group col-md-12">
                              <label class="col-md-1 control-lable" for="ulogin">Login</label>
                              <div class="col-md-7">
                                  <input type="text" ng-model="ctrl.user.login" id="ulogin" class="username form-control input-sm" placeholder="Enter your login" required ng-minlength="3"/>
                                  <div class="has-error" ng-show="myForm.$dirty">
                                      <span ng-show="myForm.login.$error.minlength">Minimum length required is 3</span>
                                  </div>
                              </div>
                              <div class="col-md-2">
                              <input type="submit"  value="{{!ctrl.user.id ? 'Add' : 'Update'}}" class="btn btn-primary btn-sm" ng-disabled="myForm.$invalid">
                              </div>
                          </div>
                      </div>
                  </form>
              </div>
              <form>
              
		    <div class="form-group">
		      <div class="input-group">
		        <div class="input-group-addon"><i class="glyphicon glyphicon-search"></i></div>
		
		        <input type="text" class="form-control" placeholder="Search by Login" ng-model="searchLogin">
		
		      </div>      
		    </div>
		  </form>
	
		<table class="table table-striped">
			<thead>
				<tr>
					<th>login</th>
					<th>epam_id</th>
					<th>is_deleted</th>
					<th>upsa_id</th>
					<th width="20%"></th>
				</tr>
			</thead>
			<tbody>
				<tr ng-repeat="user in users | filter:searchLogin">
					<td>{{user.login}}</td>
					<td>{{user.epamId}}</td>
					<td>{{user.deleted}}</td>
					<td>{{user.upsaId}}</td>
					<td><button type="button" ng-click="ctrl.remove(user.id)" class="btn btn-danger">Remove</button></td>
				</tr>
			</tbody>
		</table>
	</div>

	<script
		src="https://ajax.googleapis.com/ajax/libs/angularjs/1.5.5/angular.min.js"></script>
	<script src="<c:url value='/resources/js/app.js' />"></script>
	<script src="<c:url value='/resources/js/service/user_service.js' />"></script>
	<script
		src="<c:url value='/resources/js/controller/user_controller.js' />"></script>
</body>
</html>