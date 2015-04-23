var gulp = require('gulp');
var coffee = require('gulp-coffee');  // npm install gulp-coffee

// 1. Basic
// gulp.task('default', function() {
// 	console.log('hello gulp');
//});

// 2. Better
gulp.task('default', ['scripts', 'watch']);

// Sample task copies from SRC to DEST
// Example: test.coffee > test.js
gulp.task('scripts', function() {

	gulp.src('src/*.coffee')
		.pipe(coffee())
		.pipe(gulp.dest('./'));
});

// Sample WATCH task, that takes in other tasks
gulp.task('watch', function() {

	gulp.watch('src/*.coffee', ['scripts']);
})