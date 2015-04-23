require.config({
	paths: {
		'jquery': '../lib/jquery/jquery-1.11.1.min',
        'jquery-ui': '../lib/jquery-ui',
        'knockout': '../lib/knockout/knockout-3.2.0',
        'knockout-jqueryui': '../lib/knockout-jqueryui'
    }
});

require(['knockout', '../app/viewModel'], function (ko, ViewModel) {
    ko.applyBindings(new ViewModel);
});