var app = angular.module('Menu', []);

app.directive("menu", function () {
    return {
        restrict: 'E',
        replace: true,
        transclude: false,
        templateUrl: '/Views/Menu.html',
        scope: {
            title: '@',
            items: '=',
            click: '&'
        },
        link: function (scope) {
            scope.Click = function (index) {
                scope.selectedIndex = index;
                scope.click({ index: index });
            };
        }
    };
});