using System.Diagnostics;
using System.IO;

using AOC2022.Day2.RPS;


string inputDataPath = AppDomain.CurrentDomain.BaseDirectory + "input-data.txt";

List<string> inputData = FileLoader.LoadInput(inputDataPath);
List<Round> decryptedElfStrategyGuide = ElfStrategyGuide.Decrypt(inputData);

TournamentResult result = Tournament.PlayTournament(decryptedElfStrategyGuide);


// Works in terminal
Console.WriteLine("Advent of code - Day 2 - console");
Console.WriteLine("");
Console.WriteLine($"Player score {result.PlayerTotalPoints}");
Console.WriteLine("");

// Works in VS
System.Diagnostics.Debug.WriteLine("Advent of code - Day 2 - debug");
System.Diagnostics.Debug.WriteLine("");
System.Diagnostics.Debug.WriteLine($"Player score {result.PlayerTotalPoints}");
System.Diagnostics.Debug.WriteLine("");
