# advent-of-code-2022
Solutions for the advent of code 2022 puzzles



https://learn.microsoft.com/en-us/dotnet/core/tools/dotnet-sln

cd A0C2022.Day0

dotnet new sln --name AOC2022.Day0

dotnet new console --name AOC2022.Day0.CLI --output CLI --framework net7.0

dotnet new classlib --name AOC2022.Day0.MessageGenerator --output MessageGenerator --framework net7.0

dotnet new xunit --name AOC2022.Day0.MessageGenerator.Tests --output MessageGenerator.Tests --project MessageGenerator/AOC2022.Day0.MessageGenerator.csproj --framework net7.0

dotnet sln add CLI
dotnet sln add MessageGenerator
dotnet sln add MessageGenerator.Tests

dotnet add CLI/AOC2022.Day0.CLI.csproj reference MessageGenerator/AOC2022.Day0.MessageGenerator.csproj

dotnet add MessageGenerator.Tests/AOC2022.Day0.MessageGenerator.Tests.csproj reference MessageGenerator/AOC2022.Day0.MessageGenerator.csproj


# Create new gitignore for dotnet projects
`dotnet new gitignore --force`
