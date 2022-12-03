# Day 3 - Rocksack reorganization

## Create the project skeleton

Use the tempalte from [day 0](../day0/README.md) to get the base project created.


```
dotnet new sln --name AOC2022.Day3

dotnet new console --name AOC2022.Day3.CLI --output CLI --framework net7.0
dotnet new classlib --name AOC2022.Day3.Rocksack --output Rocksack --framework net7.0
dotnet new xunit --name AOC2022.Day3.Rocksack.Tests --output Rocksack.Tests --project Rocksack/AOC2022.Day3.Rocksack.csproj --framework net7.0

dotnet add CLI/AOC2022.Day3.CLI.csproj reference Rocksack/AOC2022.Day3.Rocksack.csproj
dotnet add Rocksack.Tests/AOC2022.Day3.Rocksack.Tests.csproj reference Rocksack/AOC2022.Day3.Rocksack.csproj

dotnet sln add CLI
dotnet sln add Rocksack
dotnet sln add Rocksack.Tests

dotnet new gitignore
```

## Running the project

Assuming you aree at the root of the day 3 folder.

``` 
dotnet build
dotnet run --project cli
```

## Executing unit tests

Assuming you aree at the root of the day 3 folder.

```
dotnet test
```
