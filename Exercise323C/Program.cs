namespace Exercise323C;

class Program
{
    static void Main(string[] args)
    {
        var board = new Board();
        var gameConsole = new GameConsole(board);
        gameConsole.Run();
    }
}