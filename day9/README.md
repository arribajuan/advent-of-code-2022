# Day 9 - Ropebridge

## Create the project skeleton

Use the tempalte from [day 0](../day0/README.md) to get the base project created.


```
dotnet new sln --name AOC2022.Day9

dotnet new console --name AOC2022.Day9.CLI --output CLI --framework net7.0
dotnet new classlib --name AOC2022.Day9.Ropebridge --output Ropebridge --framework net7.0
dotnet new xunit --name AOC2022.Day9.Ropebridge.Tests --output Ropebridge.Tests --project Ropebridge/AOC2022.Day9.Ropebridge.csproj --framework net7.0

dotnet add CLI/AOC2022.Day9.CLI.csproj reference Ropebridge/AOC2022.Day9.Ropebridge.csproj
dotnet add Ropebridge.Tests/AOC2022.Day9.Ropebridge.Tests.csproj reference Ropebridge/AOC2022.Day9.Ropebridge.csproj

dotnet sln add CLI
dotnet sln add Ropebridge
dotnet sln add Ropebridge.Tests

dotnet new gitignore
```

## Running the project

Assuming you aree at the root of the day 9 folder.

``` 
dotnet build
dotnet run --project cli
```

## Executing unit tests

Assuming you aree at the root of the day 9 folder.

```
dotnet test
```
