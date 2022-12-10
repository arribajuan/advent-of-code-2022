# Day 10 - Cathode-Ray Tube

## Create the project skeleton

Use the tempalte from [day 0](../day0/README.md) to get the base project created.


```
dotnet new sln --name AOC2022.Day10

dotnet new console --name AOC2022.Day10.CLI --output CLI --framework net7.0
dotnet new classlib --name AOC2022.Day10.CRTube --output CRTube --framework net7.0
dotnet new xunit --name AOC2022.Day10.CRTube.Tests --output CRTube.Tests --project CRTube/AOC2022.Day10.CRTube.csproj --framework net7.0

dotnet add CLI/AOC2022.Day10.CLI.csproj reference CRTube/AOC2022.Day10.CRTube.csproj
dotnet add CRTube.Tests/AOC2022.Day10.CRTube.Tests.csproj reference CRTube/AOC2022.Day10.CRTube.csproj

dotnet sln add CLI
dotnet sln add CRTube
dotnet sln add CRTube.Tests

dotnet new gitignore
```

## Running the project

Assuming you aree at the root of the day 10 folder.

``` 
dotnet build
dotnet run --project cli
```

## Executing unit tests

Assuming you aree at the root of the day 10 folder.

```
dotnet test
```
