using CommonInterfaces;

namespace Exercise323C;

public class GameConsole : IExercise
{
    private Board _board = new Board();

    public GameConsole(Board board)
    {
        _board = board;
    }

    private void Show(Board board)
    {
        Console.WriteLine("   a   b   c");
        Console.WriteLine(" ┌───┬───┬───┐");

        for (var row = 0; row < 3; row++)
        {
            Console.Write($"{row + 1}│");

            for (var col = 0; col < 3; col++)
            {
                var squareValue = board.GetSquare(row, col).Value;
                var displayValue = squareValue == 0 ? ' ' : (squareValue == 1 ? 'X' : 'O');
                Console.Write($" {displayValue} │");
            }

            Console.WriteLine();
            Console.WriteLine(row < 2 ? " ├───┼───┼───┤" : " └───┴───┴───┘");
        }
    }

    public void Run()
    {
        var board = new Board();
        var gameConsole = new GameConsole(board);

        Console.WriteLine("La oss spille 'Tre på rad' ⭕️❌ !");
        Thread.Sleep(2000);

        var isPlayerOne = board.MarkRandom(false);

        while (true)
        {
            Console.Clear();
            gameConsole.Show(board);

            Console.WriteLine("Skriv inn hvilken rute du vil sette et kryss i, f.eks. a2");
            Console.WriteLine($"Spiller {(isPlayerOne ? "1" : "2")} ⭐️ sin tur ");

            var position = Console.ReadLine();

            try
            {
                if (!board.Mark(position))
                {
                    Console.WriteLine("Ruten er allerede tatt, prøv en annen 🤪");
                }
                else
                {
                    isPlayerOne = !isPlayerOne;
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message);
            }

            var winner = board.HasWinner();

            if (winner != 0)
            {
                Console.Clear();
                Console.WriteLine($"Spiller {(board.IsPlayerOne ? "2" : "1")} har vunnet! 🎉");
                gameConsole.Show(board);
                break;
            }

            if (board.IsDraw())
            {
                Console.Clear();
                Console.WriteLine("Det ble uavgjort! Spillet er over.");
                gameConsole.Show(board);
                break;
            }
        }

        StartNewGame();
    }

    private void StartNewGame()
    {
        Console.WriteLine("Vil du spille på nytt? Tast j/n 🔄");
        var startNewGame = Console.ReadLine()?.ToLower();
        if (startNewGame == "j") Run();
    }
}