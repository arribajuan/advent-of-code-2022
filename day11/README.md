# Day 11 - Mondkey in the middle

## Create the project skeleton

Use the tempalte from [day 0](../day0/README.md) to get the base project created.


```
dotnet new sln --name AOC2022.Day11

dotnet new console --name AOC2022.Day11.CLI --output CLI --framework net7.0
dotnet new classlib --name AOC2022.Day11.MITM --output MITM --framework net7.0
dotnet new xunit --name AOC2022.Day11.MITM.Tests --output MITM.Tests --project MITM/AOC2022.Day11.MITM.csproj --framework net7.0

dotnet add CLI/AOC2022.Day11.CLI.csproj reference MITM/AOC2022.Day11.MITM.csproj
dotnet add MITM.Tests/AOC2022.Day11.MITM.Tests.csproj reference MITM/AOC2022.Day11.MITM.csproj

dotnet sln add CLI
dotnet sln add MITM
dotnet sln add MITM.Tests

dotnet new gitignore
```

## Running the project

Assuming you aree at the root of the day 11 folder.

``` 
dotnet build
dotnet run --project cli
```

## Executing unit tests

Assuming you aree at the root of the day 11 folder.

```
dotnet test
```
