define(['knockout', 'knockout-jqueryui/slider'], function (ko) {

	var ViewModel = function () {
		this.value1 = ko.observable('25');
		this.value2 = ko.observable('50');
		this.value3 = ko.observable('75');
		this.values = ko.computed({
			read: function() {
				return [this.value1(), this.value2(), this.value3()];
			},
			write: function(newValue) {
				this.value1(newValue[0]);
				this.value2(newValue[1]);
				this.value3(newValue[2]);
			},
			owner: this
		});
	};
	
	return ViewModel;
});