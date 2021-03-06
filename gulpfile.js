/// <binding AfterBuild='Publish-Solution' />
var gulp = require("gulp");
var msbuild = require("gulp-msbuild");
var debug = require("gulp-debug");
var foreach = require("gulp-foreach");
var runSequence = require("run-sequence");
var config = require("./gulp-config.js")();

module.exports.config = config;

gulp.task("default", function (callback) {
  config.runCleanBuilds = true;
  return runSequence(
    "Publish-Solution",
	callback);
});

gulp.task("Publish-Solution", function () {
	var dest = config.websiteRoot;
	var targets = ["Build"];
	if (config.runCleanBuilds) {
		targets = ["Clean", "Build"];
	}
	var projects = ["./**/Sug*.csproj"];
	console.log("publishing to '" + dest + "' folder");
	return gulp.src(projects)
	  .pipe(foreach(function (stream, file) {
	  	return stream
		  .pipe(debug({ title: "Building project:" }))
		  .pipe(msbuild({
		  	targets: targets,
		  	configuration: config.buildConfiguration,
		  	logCommand: false,
		  	verbosity: "minimal",
		  	maxcpucount: 0,
		  	toolsVersion: 14.0,
		  	properties: {
		  		DeployOnBuild: "true",
		  		DeployDefaultTarget: "WebPublish",
		  		WebPublishMethod: "FileSystem",
		  		DeleteExistingFiles: "false",
		  		publishUrl: dest,
		  		_FindDependencies: "false"
		  	}
		  }));
	  }));
});