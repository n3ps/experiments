
// npm install request

var request = require('request');

var s = request('http://google.com');

// Transfer aka "pipe" it to stdout
s.pipe(process.stdout);