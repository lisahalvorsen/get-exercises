using System.Diagnostics;

namespace Exercises;

public class Exercise323C : IExercise
{
    public void Run()
    {
        var board = new Board();
        var gameConsole = new GameConsole(board);

        Console.WriteLine("La oss spille 'Tre på rad' ⭕️❌ !");
        Thread.Sleep(2000);

        var isPlayerOne = board.MarkRandom(false);
        Console.WriteLine(isPlayerOne ? "Spiller 1 starter 🎮" : "Spiller 2 starter 🎮");

        while (true)
        {
            gameConsole.Show(board);

            Console.WriteLine("Skriv inn hvilken rute du vil sette et kryss i, f.eks. a2");
            Console.WriteLine($"Spiller {(isPlayerOne ? "1" : "2")} sin tur!");

            var position = Console.ReadLine();
            Console.Clear();

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
                Console.WriteLine($"Spiller {(board.IsPlayerOne ? "2" : "1")} har vunnet! 🎉");
                gameConsole.Show(board);
                break;
            }

            if (board.IsDraw())
            {
                Console.WriteLine("Det ble uavgjort! Spillet er over.");
                gameConsole.Show(board);
                break;
            }
        }
    }
}