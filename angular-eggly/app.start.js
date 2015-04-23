angular
	.module('Eggly', [])
	.controller('MainController', MainController);

// TODO: IIF to hide this from the global scope

function MainController() {
	var vm = this;

	vm.hello = 'world';

	vm.categories = [
		{"id": 0, "name": "Development"},
		{"id": 1, "name": "Design"},
		{"id": 2, "name": "Exercise"},
		{"id": 3, "name": "Humor"},
	];

	vm.bookmarks = [
		{"id": 0, "title": "AngularJS", "url": "http://angularjs.org", "category": "Development"},
		{"id": 1, "title": "A List Apart", "url": "http://alistapart.com", "category": "Design"},
		{"id": 2, "title": "9 Gag", "url": "http://9gag.com", "category": "Humor"},
	];

	var currentCategory = null;

	function setCurrentCategory(category) {
		currentCategory = category;
	}

	function getCurrentCategory() {
		return currentCategory;
	}

	function isCurrentCategory(category) {
		return currentCategory == category;
	}

	vm.setCurrentCategory = setCurrentCategory;
	vm.getCurrentCategory = getCurrentCategory;
	vm.isCurrentCategory = isCurrentCategory;
}