# Day 56- Tuning Trouble

## Create the project skeleton

Use the tempalte from [day 0](../day0/README.md) to get the base project created.


```
dotnet new sln --name AOC2022.Day6

dotnet new console --name AOC2022.Day6.CLI --output CLI --framework net7.0
dotnet new classlib --name AOC2022.Day6.TuningTrouble --output TuningTrouble --framework net7.0
dotnet new xunit --name AOC2022.Day6.TuningTrouble.Tests --output TuningTrouble.Tests --project TuningTrouble/AOC2022.Day6.TuningTrouble.csproj --framework net7.0

dotnet add CLI/AOC2022.Day6.CLI.csproj reference TuningTrouble/AOC2022.Day6.TuningTrouble.csproj
dotnet add TuningTrouble.Tests/AOC2022.Day6.TuningTrouble.Tests.csproj reference TuningTrouble/AOC2022.Day6.TuningTrouble.csproj

dotnet sln add CLI
dotnet sln add TuningTrouble
dotnet sln add TuningTrouble.Tests

dotnet new gitignore
```

## Running the project

Assuming you aree at the root of the day 6 folder.

``` 
dotnet build
dotnet run --project cli
```

## Executing unit tests

Assuming you aree at the root of the day 6 folder.

```
dotnet test
```
