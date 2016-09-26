'use strict';
var myApp = angular.module('myApp', []);


// create the controller and inject Angular's $scope
//myApp.controller('mainController', function ($scope) {

//    // create a message to display in our view
//    $scope.message = 'Everyone come and see how good I look!';
//});

var myApp = angular.module('myApp', ['ngRoute']);
// configure our routes
myApp.config(function ($routeProvider) {
    $routeProvider

        // route for the home page
        .when('/', {
            templateUrl: 'partials/home.html',
            controller: 'mainController'
        })
        .when('product/', {
            templateUrl: 'partials/product.html',
            controller: 'mainController'
        })

        // route for the produayct page
        .when('/product', {
            templateUrl: 'partials/product.html',
            controller: 'listController'
        })
        .when('/productlistnorw', {
            templateUrl: 'partials/product.html',
            controller: 'listController'
        })

        // route for the details page
        .when('/product/:id', {
            templateUrl: 'partials/details.html',
            controller: 'detailsController'
        })
        //route for norwegianCategory
        .when('/norway', {
            templateUrl: 'partials/norway.html',
            controller: 'norwegianCategoryController'
        })

         .when('/denmark', {
            templateUrl: 'partials/denmark.html',
            controller: 'danishCategoryController'
        })
        .when('/categorynorway/:id', {
            templateUrl: 'partials/categorynorway.html',
            controller: 'prodNorwayController'
        })
         .when('/categorydenmark/:id', {
             templateUrl: 'partials/categorydenmark.html',
             controller: 'prodDenmarkController'
         })

        
        .when('/category/:id', {
            templateUrl: 'partials/category.html',
            controller: 'prodFilterController'
        })
        .when('/cart', {
            templateUrl: 'partials/cart.html',
            controller: 'cartController'
        })
        .when('/details', {
        templateUrl: 'partials/details.html',
        controller: 'CartForm'
    });
        
});

myApp.controller('mainController', function ($scope, $http) {

    // create a message to display in our view
    $scope.message = 'Everyone come and see how good I look!';


});

myApp.controller('listController', function ($scope) {
    $scope.message = 'Look! I am an Product Page';
});

myApp.controller('contactController', function ($scope) {
    $scope.message = 'Contact us! JK. This is just a demo.';
});

