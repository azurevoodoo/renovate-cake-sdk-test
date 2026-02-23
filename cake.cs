#:sdk Cake.Sdk@5.1.25296.94-beta
#:package Cake.Git@4.0.0

Information("Hello world");

InstallTool("dotnet:?package=Cake.Tool&version=6.0.0");


InstallTools(
    "dotnet:https://api.nuget.org/v3/index.json?package=GitVersion.Tool&version=6.6.0",
    "dotnet:https://api.nuget.org/v3/index.json?package=GitReleaseManager.Tool&version=0.20.0",
    "dotnet:?package=DPI&version=2025.12.17.349"
);
