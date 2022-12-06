# Day 5 - Supply stacks

## Create the project skeleton

Use the tempalte from [day 0](../day0/README.md) to get the base project created.


```
dotnet new sln --name AOC2022.Day5

dotnet new console --name AOC2022.Day5.CLI --output CLI --framework net7.0
dotnet new classlib --name AOC2022.Day5.SupplyStack --output SupplyStack --framework net7.0
dotnet new xunit --name AOC2022.Day5.SupplyStack.Tests --output SupplyStack.Tests --project SupplyStack/AOC2022.Day5.SupplyStack.csproj --framework net7.0

dotnet add CLI/AOC2022.Day5.CLI.csproj reference SupplyStack/AOC2022.Day5.SupplyStack.csproj
dotnet add SupplyStack.Tests/AOC2022.Day5.SupplyStack.Tests.csproj reference SupplyStack/AOC2022.Day5.SupplyStack.csproj

dotnet sln add CLI
dotnet sln add SupplyStack
dotnet sln add SupplyStack.Tests

dotnet new gitignore
```

## Running the project

Assuming you aree at the root of the day 5 folder.

``` 
dotnet build
dotnet run --project cli
```

## Executing unit tests

Assuming you aree at the root of the day 5 folder.

```
dotnet test
```
