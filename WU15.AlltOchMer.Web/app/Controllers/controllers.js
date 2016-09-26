myApp.controller("appController",
    function($scope, $http) {
        $http({
            method: "GET",
            url: "http://localhost:53591/api/category/SE"
        }).then(function success(response) {
            $scope.categories = response.data;
            
        });
    });
// Controller for home page 
//Random 3 products
myApp.controller("productRandomSwedenController",
    function ($scope, $http) {

        $http({
            method: "GET",
            url: "http://localhost:53591/api/Product/SE/Random"
        }).then(function success(response) {
            $scope.products = response.data;
        });
    });
myApp.controller("productSwedenController",
    function($scope, $http,$filter) {
       
        $http({
            method: "GET",
            url: "http://localhost:53591/api/Product/SE/"
        }).then(function success(response) {
            $scope.products = response.data;
        
        
            $scope.query = '';
            $scope.filteredProd= [];

            $scope.$watch('query', function (newVal, oldVal) {
                $scope.filtredproducts = $filter('filter')($scope.products, $scope.query);
            });
        });
    });
myApp.controller("swedenSubcategoryController",
    function ($scope, $http) {
        $http({
            method: "GET",
            url: "http://localhost:53591/api/Category/SE" 
        }).then(function success(response) {
            $scope.subcategories = response.data;
        });
    });
myApp.controller("productNorwayController",
    function ($scope, $http) {
        $http({
            method: "GET",
            url: "http://localhost:53591/api/Product/NO"
        }).then(function success(response) {
            $scope.products = response.data;
        });
    });

myApp.controller("productDenmarkController",
    function ($scope, $http) {
        $http({
            method: "GET",
            url: "http://localhost:53591/api/Product/DK"
        }).then(function success(response) {
            $scope.products = response.data;
        });
    });

myApp.controller("listController",
    function($scope, $routeParams, $http,$rootScope) {
        $scope.id = $routeParams.id;
        $http({
            method: "GET",
            url: "http://localhost:53591/api/Product/SE"
        }).then(function success(response) {
            $scope.products = response.data;
           
        });
     
    });

myApp.controller("listnorwayController",
    function ($scope, $routeParams, $http, $rootScope) {
        $scope.id = $routeParams.id;
        $http({
            method: "GET",
            url: "http://localhost:53591/api/Product/NO"
        }).then(function success(response) {
            $scope.products = response.data;
        });
    });


myApp.controller("norwegianCategoryController",
    function ($scope, $http) {       
        $http({
            method: "GET",
            url: "http://localhost:53591/api/category/NO" 
        }).then(function success(response) {
            $scope.categories = response.data;
        });

    });

myApp.controller("danishCategoryController",
    function ($scope, $http) {
        $http({
            method: "GET",
            url: "http://localhost:53591/api/category/DK"
        }).then(function success(response) {
            $scope.categories = response.data;
        });

    });

myApp.controller("detailsController",
    function($scope, $routeParams, $http, $rootScope) {
        $scope.id = $routeParams.id;
        $http({
            method: "GET",
            url: "http://localhost:53591/api/Product/SE/" + $scope.id
        }).then(function success(response) {
            $scope.productDetails = response.data;

        });
    });
            myApp.controller("detailsNorwayController",
                function($scope, $routeParams, $http, $rootScope) {
                    $scope.id = $routeParams.id;
                    $http({
                        method: "GET",
                        url: "http://localhost:53591/api/Product/NO/" + $scope.id
                    }).then(function success(response) {
                        $scope.productDetails = response.data;
                        
                         });


        });
       
           
       
        myApp.controller("prodFilterController",
    function ($scope, $routeParams, $http) {
        $scope.id = $routeParams.id;
        $http({
            method: "GET",
            url: "http://localhost:53591/api/category/SE/Prod/" + $scope.id            
        }).then(function success(response) {
            $scope.productsCategory = response.data;
        });

    });

myApp.controller("prodNorwayController",
    function ($scope, $routeParams, $http) {
        $scope.id = $routeParams.id;
        $http({
            method: "GET",
            url: "http://localhost:53591/api/category/NO/Prod/" + $scope.id            
        }).then(function success(response) {
            $scope.productsCategoryNorway = response.data;
        });

    });

myApp.controller("prodDenmarkController",
    function ($scope, $routeParams, $http) {
        $scope.id = $routeParams.id;
        $http({
            method: "GET",
            url: "http://localhost:53591/api/category/DK/Prod/" + $scope.id
        }).then(function success(response) {
            $scope.productsDanmark = response.data;
        });

    });

myApp.controller("cartSwedenController",
    function ($scope, $http) {
        $http({
            method: "GET",
            url: "http://localhost:53591/api/cartProduct/SE" 
        }).then(function success(response) {
            $scope.items = response.data;
       

        $scope.getTotal = function () {
            var total = 0;
           
            for (var i = 0; i <$scope.items.length; i++) {
               var product=$scope.items[i];

                total += (product.pris * product.quantity);
            }
            return total;
        }
       
        });
 });
myApp.controller("deleteItemController", function ($scope, $http) {
          $scope.deleteItem = function(id,index) {
              console.log(id);
              $scope.items.splice(index, 1);   
              $http({
                  method: "Delete", url: "http://localhost:53591/api/cartproduct/SE/" + id

              }).then(function success(response) {

                  console.log(response);
        });

    }
});

myApp.controller("cartController", function($scope,$http) {
    $scope.toCart = function (product) {
        
        var Quantity = 1;
       
   
        $http({
            method: "GET" ,url: "http://localhost:53591/api/cartproduct/SE/" + product.id+ "/" + Quantity+ "/" + product.price

        }).then(function success(response) {
            console.log(response);

        });


    }
});

myApp.controller('countItemController', function ($scope) {
    $scope.count = 0;
});



    
