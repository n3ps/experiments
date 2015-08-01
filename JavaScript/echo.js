onmessage = function(e) {
	setTimeout(function() {
		postMessage(e.data.message + '(timeout: ' + e.data.timeout + ')');
	}, e.data.timeout * 1000);
}