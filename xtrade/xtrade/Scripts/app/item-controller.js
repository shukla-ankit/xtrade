app = angular.module('XTradeApp');
app.controller('ItemController', ['$scope', function ($scope) {
    $scope.images = [{
        name: "UploadImage1"
    }];


    $scope.addImage = function () {

        let length = $scope.images.length;
        $scope.images.push({
            name: "UploadImage" + length
        });
    };

    $scope.removeImage = function (name) {
        let index = _.findIndex($scope.images, {
            name: name
        });

        $scope.images.splice(index, 1);
    };

    $scope.MarkForDeletion = {};

    $scope.toggleDeletionMark = function (image, id) {
        console.log(image, id);
        $scope.DoNotDisplayImages = "";
        for (var key in image) {
            // skip loop if the property is from prototype
            if (!image.hasOwnProperty(key)) continue;

            var result = image[key];
            if (result == 'YES') {
                $scope.DoNotDisplayImages += key.substr(1) + ",";
            }            
        }

        $scope.DoNotDisplayImages = $scope.DoNotDisplayImages.substring(0, $scope.DoNotDisplayImages.length - 1);
        console.log("DoNotDisplayImages : " + DoNotDisplayImages);
    };
}]);