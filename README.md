# PostBuildProjectTemplate

A template to create a C# post build project for a .NET (6.0+) solution

FunFact: This project has its own post build project which is used to install the template after build.

The "post-build project" allows you to have a solution wide post build event and is used to move things from build targets to a readable, debuggable location that uses a well-known language. 

The stuf in a project file: 

`<Target Name="PostBuild" AfterTargets="PostBuildEvent">`

is moved to 

`void PostBuildEvent() {}`

To be precise, you have to move it yourself, the template only provides the location where you can move it.

FunFact: You could use this template to create a pre build project too ;-) 

What needs to be done?

- create your solution with your projects as usual
- create a post-build project using this template
- edit the project dependency/ project build order  
  so that .postbuild depends on all other projects
