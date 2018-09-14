[![Build Status](https://fuselabs.visualstudio.com/SDK_v4/_apis/build/status/experimental/(Scratch)%20Leaning%20how%20to%20Build%20and%20Sign)](https://fuselabs.visualstudio.com/SDK_v4/_build/latest?definitionId=305)

#CI/CD Builds
The VSO Build system drops NuGet packages to MyGet [MyGet Semver Package Feed](https://botbuilder.myget.org/feed/Packages/semvertesting)
Note: This is a private feed for testing, that only I have access to. 

# SemverTesting
Experiments with Semver, C#, Visual Studio Online CI/CD, MyGet, and NuGet deployments

This repo is a playspace for learning how Semver works with the VSO CI/CD build tasks. This includes concerns around:
* [Semantic Versioning](https://semver.org/)
* The [Semver Nuget Package](https://www.nuget.org/packages/semver/)
* .Net Core 2
* Visual Studio Online CI/DI against GitHub
* Publishing correctly versioned packags to MyGet (and Nuget)
