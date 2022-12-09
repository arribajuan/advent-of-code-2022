# Day 8- Treetop

## Create the project skeleton

Use the tempalte from [day 0](../day0/README.md) to get the base project created.


```
dotnet new sln --name AOC2022.Day8

dotnet new console --name AOC2022.Day8.CLI --output CLI --framework net7.0
dotnet new classlib --name AOC2022.Day8.Treetop --output Treetop --framework net7.0
dotnet new xunit --name AOC2022.Day8.Treetop.Tests --output Treetop.Tests --project Treetop/AOC2022.Day8.Treetop.csproj --framework net7.0

dotnet add CLI/AOC2022.Day8.CLI.csproj reference Treetop/AOC2022.Day8.Treetop.csproj
dotnet add Treetop.Tests/AOC2022.Day8.Treetop.Tests.csproj reference Treetop/AOC2022.Day8.Treetop.csproj

dotnet sln add CLI
dotnet sln add Treetop
dotnet sln add Treetop.Tests

dotnet new gitignore
```

## Running the project

Assuming you aree at the root of the day 8 folder.

``` 
dotnet build
dotnet run --project cli
```

## Executing unit tests

Assuming you aree at the root of the day 8 folder.

```
dotnet test
```
