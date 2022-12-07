# Day 7 - No space left

## Create the project skeleton

Use the tempalte from [day 0](../day0/README.md) to get the base project created.


```
dotnet new sln --name AOC2022.Day7

dotnet new console --name AOC2022.Day7.CLI --output CLI --framework net7.0
dotnet new classlib --name AOC2022.Day7.SpaceOnDevice --output SpaceOnDevice --framework net7.0
dotnet new xunit --name AOC2022.Day7.SpaceOnDevice.Tests --output SpaceOnDevice.Tests --project SpaceOnDevice/AOC2022.Day7.SpaceOnDevice.csproj --framework net7.0

dotnet add CLI/AOC2022.Day7.CLI.csproj reference SpaceOnDevice/AOC2022.Day7.SpaceOnDevice.csproj
dotnet add SpaceOnDevice.Tests/AOC2022.Day7.SpaceOnDevice.Tests.csproj reference SpaceOnDevice/AOC2022.Day7.SpaceOnDevice.csproj

dotnet sln add CLI
dotnet sln add SpaceOnDevice
dotnet sln add SpaceOnDevice.Tests

dotnet new gitignore
```

## Running the project

Assuming you aree at the root of the day 7 folder.

``` 
dotnet build
dotnet run --project cli
```

## Executing unit tests

Assuming you aree at the root of the day 7 folder.

```
dotnet test
```
