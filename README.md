# PostBuildProjectTemplate

A template to create a C# post build project for a .NET (6.0+) solution

FunFact: This project has its own post build project which is used to install the template after build.

The "post-build project" allows you to have a solution wide post build event and is used to move things from build targets to a readable, debuggable location that uses a well-known language. 

The stuff in a project file: 

`<Target Name="PostBuild" AfterTargets="PostBuildEvent">`

is moved to 

`void PostBuild() {}`

To be precise, you have to move it yourself, the template only provides the location where you can move it.

FunFact: You could use this template to create a pre build project too ;-) 

## Install the template

### Methode A

- Clone this repository locally
- build the solution  
  the post-build will install the template as `PostBuild Project (KsWare)`

### Methode B

- copy the files from [PostBuildProjectTemplate](https://github.com/KsWare/PostBuildProjectTemplate/tree/develop/src/PostBuildProjectTemplate) to a local folder
- call `dotnet new install <your local folder> --force`

## How is it used?

- create your solution with your projects as usual
- add a new project using the template `PostBuild Project (KsWare)`
    - chose the project name e.g. "postbuild"  
      *this is used for the project folder name,  
      the project file itself will always be named `.postbuild.csproj`¹.*
    - chose a framework target  
      *.NET 6.0, 7.0, 8.0 are supported¹*
- edit the project dependency/ project build order  
  so that .postbuild depends on all other projects

¹) in general you can change it afterwards
