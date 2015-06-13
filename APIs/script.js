// Requires jQuery

// Instagram
// Request a client ID and access token to use more features
// such as showing images by user
(function () {

    var HTML_PLACEHOLDER = '#instagram';
    var NUMBER_OF_IMAGES = 5;

    var instagram_clientId = '1aef0d1326d044d192a1f2c0f34eaec7';
    var instagram_api = 'https://api.instagram.com/v1/media/popular?callback=?&client_id=' + instagram_clientId;

    function fetchImages () {
        $.getJSON(instagram_api)
            .done(function (resp) {
                $(HTML_PLACEHOLDER).empty();
                resp.data.slice(0, NUMBER_OF_IMAGES).forEach(function (o) {
                    $(HTML_PLACEHOLDER).append($('<img>').attr('src', o.images.thumbnail.url));
                });
            });
    }

    fetchImages();

    setInterval(function () {
        fetchImages()
    }, 30000); // 1000 = 1sec

})();


// Clock
(function () {

    var HTML_PLACEHOLDER = '#clock';

    function updateClock () {
        var today = new Date();
        var h = today.getHours();
        var m = format(today.getMinutes());
        var s = format(today.getSeconds());

        $(HTML_PLACEHOLDER).text(h + ':' + m + ':' + s);
    }

    function format (num) {
        return (num < 10) ? '0' + num : num;
    }

    updateClock();

    setInterval(function () {
        updateClock();    
    }, 1000);
    
})();
