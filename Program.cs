using System;

namespace puzzle {
class Program
{
    static void Main(string[] args)
    {
        var filename = "test.txt"; // update to "input.txt"
        var input = GetPuzzleInput(filename);
        var game = new AdventOfCode();
        Console.WriteLine(game.Solution1(input));
        Console.WriteLine(game.Solution2(input));
    }

    private static string GetPuzzleInput(string filename)
    {
        return System.IO.File.ReadAllText(filename);
    }
}
}