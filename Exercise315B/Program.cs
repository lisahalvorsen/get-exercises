namespace Exercise315B;

internal static class Program
{
    private static void Main(string[] args)
    {
        Console.WriteLine(
            "Let's play 'Rock, Paper, Scissors'!\nTo play: type 'r', 'p' or 's'.\nTo exit the game at any point, type 'x'.");
        var game = new RockPaperScissor();
        game.Run();
    }
}