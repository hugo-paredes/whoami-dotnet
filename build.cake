#addin nuget:?package=Cake.Docker&version=1.1.2
// #addin nuget:?package=Cake.Git&version=2.0.0
#tool "dotnet:?package=GitVersion.Tool"

var target = Argument("target", "Default");
var tag = "v0.0.0";

Task("Tag")
    .Does(() =>
{
    // tag = describe --tags;
    Console.WriteLine("Hello");
    var settings = new GitVersionSettings {
        OutputType = GitVersionOutput.BuildServer
    };
    // DockerRun()
    Console.WriteLine("Git: " + tag);
});
Task("DockerBuild")
    .Does(() =>
{
    Console.WriteLine("World");
    var settings = new DockerImageBuildSettings { Tag = new[] { "whoami-dotnet:0.0.0" }};
    DockerBuild(settings, "./");
});

Task("Default")
    .IsDependentOn("Tag")
    .IsDependentOn("DockerBuild");

RunTarget(target);
