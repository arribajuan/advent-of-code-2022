# Day 1 - Calorie counter

## Create the project skeleton

Use the tempalte from [day 0](../day0/README.md) to get the base project created.


```
dotnet new sln --name AOC2022.Day1

dotnet new console --name AOC2022.Day1.CLI --output CLI --framework net7.0
dotnet new classlib --name AOC2022.Day1.CalorieCounter --output CalorieCounter --framework net7.0

dotnet new xunit --name AOC2022.Day1.CalorieCounter.Tests --output CalorieCounter.Tests --project CalorieCounter/AOC2022.Day1.CalorieCounter.csproj --framework net7.0

dotnet add CLI/AOC2022.Day1.CLI.csproj reference CalorieCounter/AOC2022.Day1.CalorieCounter.csproj
dotnet add CalorieCounter.Tests/AOC2022.Day1.CalorieCounter.Tests.csproj reference CalorieCounter/AOC2022.Day1.CalorieCounter.csproj

dotnet sln add CLI
dotnet sln add CalorieCounter
dotnet sln add CalorieCounter.Tests

dotnet new gitignore
```

## Running the project

Assuming you aree at the root of the day 1 folder.

``` 
dotnet build
dotnet run --project cli
```

## Executing unit tests

Assuming you aree at the root of the day 1 folder.

```
dotnet test
```
