# Day 12 - Hillclimb

## Create the project skeleton

Use the tempalte from [day 0](../day0/README.md) to get the base project created.


```
dotnet new sln --name AOC2022.Day12

dotnet new console --name AOC2022.Day12.CLI --output CLI --framework net7.0
dotnet new classlib --name AOC2022.Day12.Hillclimb --output Hillclimb --framework net7.0
dotnet new xunit --name AOC2022.Day12.Hillclimb.Tests --output Hillclimb.Tests --project Hillclimb/AOC2022.Day12.Hillclimb.csproj --framework net7.0

dotnet add CLI/AOC2022.Day12.CLI.csproj reference Hillclimb/AOC2022.Day12.Hillclimb.csproj
dotnet add Hillclimb.Tests/AOC2022.Day12.Hillclimb.Tests.csproj reference Hillclimb/AOC2022.Day12.Hillclimb.csproj

dotnet sln add CLI
dotnet sln add Hillclimb
dotnet sln add Hillclimb.Tests

dotnet new gitignore
```

## Running the project

Assuming you aree at the root of the day 12 folder.

``` 
dotnet build
dotnet run --project cli
```

## Executing unit tests

Assuming you aree at the root of the day 12 folder.

```
dotnet test
```
