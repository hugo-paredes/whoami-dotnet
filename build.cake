#addin nuget:?package=Cake.Docker&version=1.1.2

var target = Argument("target", "Build");
var configuration = Argument("configuration", "Release");

Task("Clean")
    .WithCriteria(c => HasArgument("rebuild"))
    .Does(() =>
{
    CleanDirectory($"./src/HostApp/bin/{configuration}");
});

Task("Build")
    .IsDependentOn("Clean")
    .Does(() =>
{
    DotNetBuild("./Whoami.sln", new DotNetBuildSettings
    {
        Configuration = configuration,
    });
});


RunTarget(target);
