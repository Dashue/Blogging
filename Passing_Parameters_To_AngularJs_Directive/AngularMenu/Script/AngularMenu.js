var module = angular.module('AngularMenu', ['Menu']);

module.controller('AngularMenuCtrl', function ($scope) {

    $scope.items = [
           { Text: 'Menu1', Value: 'Url1' },
           { Text: 'Menu2', Value: 'Url2' }
    ];

    $scope.Click = function(index) {
        alert("Transitioning to " + $scope.items[index].Value);
    };
});