var app = angular.module('TodoApp', []);
app.service('itemStore', function ($http) {

    this.todoItems = [];

    var apiUrl = '/api/todoitem/';
  
    this.add = function (item, successCallback, errorCallback) {
        var that = this;
        $http.post(apiUrl, item).then(function success(resp) {
            item.id = resp.data;
            that.todoItems[item.id] = item;
        }, errorCallback);
    };

    this.getAll = function (successCallback, errorCallback) {
        var that = this;
        $http.get(apiUrl).then(function success(data) {          
            angular.copy(data.data, that.todoItems);
            successCallback(data.data);
        }, errorCallback);
    };

    this.update = function (item, successCallback, errorCallback) {
        $http.put(apiUrl + item.id, item).then(function success() {
            todoItems[item.id] = item;
        }, errorCallback);
    };
});

app.controller('TodoListController', function ($scope, itemStore) {

    var initDataRequest = function() {
        itemStore.getAll(function (data) {
            $scope.todoItems = data;
        });
    };

    $scope.addItem = function (title) {
        itemStore.add({ title: title, completed: false });
        $scope.todoItems = itemStore.todoItems;
    };

    $scope.toggleCompleteItem = function(item) {
       itemStore.update(item, function success() {
        }, function error() {
            item.completed = !item.completed;
        });
    };


    initDataRequest();
});
