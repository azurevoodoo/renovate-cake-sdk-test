#:sdk Cake.Sdk@6.0.0
#:package Cake.Git@5.0.1

Information("Hello world");

InstallTool("dotnet:?package=Cake.Tool&version=6.0.0");


InstallTools(
    "dotnet:https://api.nuget.org/v3/index.json?package=GitVersion.Tool&version=6.6.0",
    "dotnet:https://api.nuget.org/v3/index.json?package=GitReleaseManager.Tool&version=0.20.0",
    "dotnet:?package=DPI&version=2026.2.11.364"
);
