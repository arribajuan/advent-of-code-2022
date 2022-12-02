# Day 2 - Rock Paper Scissors

## Create the project skeleton

Use the tempalte from [day 0](../day0/README.md) to get the base project created.


```
dotnet new sln --name AOC2022.Day2

dotnet new console --name AOC2022.Day2.CLI --output CLI --framework net7.0
dotnet new classlib --name AOC2022.Day2.RPS --output RPS --framework net7.0
dotnet new xunit --name AOC2022.Day2.RPS.Tests --output RPS.Tests --project RPS/AOC2022.Day2.RPS.csproj --framework net7.0

dotnet add CLI/AOC2022.Day2.CLI.csproj reference RPS/AOC2022.Day2.RPS.csproj
dotnet add RPS.Tests/AOC2022.Day2.RPS.Tests.csproj reference RPS/AOC2022.Day2.RPS.csproj

dotnet sln add CLI
dotnet sln add RPS
dotnet sln add RPS.Tests

dotnet new gitignore
```

## Running the project

Assuming you aree at the root of the day 2 folder.

``` 
dotnet build
dotnet run --project cli
```

## Executing unit tests

Assuming you aree at the root of the day 2 folder.

```
dotnet test
```
