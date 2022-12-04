# Day 4 - Camp cleanup

## Create the project skeleton

Use the tempalte from [day 0](../day0/README.md) to get the base project created.


```
dotnet new sln --name AOC2022.Day4

dotnet new console --name AOC2022.Day4.CLI --output CLI --framework net7.0
dotnet new classlib --name AOC2022.Day4.CampCleanup --output CampCleanup --framework net7.0
dotnet new xunit --name AOC2022.Day4.CampCleanup.Tests --output CampCleanup.Tests --project CampCleanup/AOC2022.Day4.CampCleanup.csproj --framework net7.0

dotnet add CLI/AOC2022.Day4.CLI.csproj reference CampCleanup/AOC2022.Day4.CampCleanup.csproj
dotnet add CampCleanup.Tests/AOC2022.Day4.CampCleanup.Tests.csproj reference CampCleanup/AOC2022.Day4.CampCleanup.csproj

dotnet sln add CLI
dotnet sln add CampCleanup
dotnet sln add CampCleanup.Tests

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
