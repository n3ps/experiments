var maxTime = 1000;

var evenDoubler = function(v, callback) {
    
    var waitTime = Math.floor( (Math.random() * maxTime) + 1);
    
    if (v % 2) {
        setTimeout(function() {
            callback(new Error("odd number"));
        }, waitTime);
    } else {
        setTimeout(function() {
            callback(null, v * 2, waitTime);
        }, waitTime);
    }
};

for (var i = 0; i < 10; i++) {
    console.log("Now running: " + i);
    
    evenDoubler(i, function(err, results, time) {
        if (err) {
            console.log("Error: " + err.message);
        } else {
            console.log('Result is ' + results + ', time: ' + time); // Note that printing "i" will not get desired result
        }
    });
}

// Prints For loop counter in order
// Then prints results in random