# Day 0 - Create a template project

The goal is to create a template project with a class library, unit tests and a CLI to run it.

We will build an overengineerid hello world application.

This would serve as the bare minimum app.

## Dotnet template application

* dotnet framework 7.0
* c# language
* xunit for unit testing

### Steps to create the dotnet template app

Create the new solution

```
dotnet new sln --name AOC2022.Day0
```

Create new projects

```
dotnet new console --name AOC2022.Day0.CLI --output CLI --framework net7.0

dotnet new classlib --name AOC2022.Day0.MessageGenerator --output MessageGenerator --framework net7.0

dotnet new xunit --name AOC2022.Day0.MessageGenerator.Tests --output MessageGenerator.Tests --project MessageGenerator/AOC2022.Day0.MessageGenerator.csproj --framework net7.0
```

Add oroject references

```
dotnet add CLI/AOC2022.Day0.CLI.csproj reference MessageGenerator/AOC2022.Day0.MessageGenerator.csproj

dotnet add MessageGenerator.Tests/AOC2022.Day0.MessageGenerator.Tests.csproj reference MessageGenerator/AOC2022.Day0.MessageGenerator.csproj
```

Add projects to solution

```
dotnet sln add CLI

dotnet sln add MessageGenerator

dotnet sln add MessageGenerator.Tests
```

### Create new gitignore for dotnet projects

```
dotnet new gitignore
```

### Build the solution

```
dotnet build
```

![Project build](/day0/assets/images/project-build.png "Project build")

### Test the solution (Unit tests)

```
dotnet test
```

![Project test](/day0/assets/images/project-test.png "Project test")

### Run the solution (CLI)

```
dotnet run
```

![Project run](/day0/assets/images/project-run.png "Project run")

### References

* https://learn.microsoft.com/en-us/dotnet/core/tools/

* https://learn.microsoft.com/en-us/dotnet/core/testing/unit-testing-with-dotnet-test


