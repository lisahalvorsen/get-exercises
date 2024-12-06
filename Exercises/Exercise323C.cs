namespace Exercises;

public class Exercise323C : IExercise
{
    public void Run()
    {
        var board = new Board();
        var gameConsole = new GameConsole(board);

        while (true)
        {
            gameConsole.Show(board);
            Console.WriteLine($"Nå er det spiller {(board.IsPlayerOne ? "1" : "2")} sin tur");
            Console.WriteLine("Skriv inn hvilken rute du vil sette et kryss i, f.eks. a2");
            var position = Console.ReadLine();


            try
            {
                if (!board.Mark(position))
                {
                    Console.WriteLine("Ruten er allerede tatt, prøv en annen 🤪");
                }
            }
            catch (ArgumentException ex)
            {
                Console.WriteLine(ex.Message); // Show only the message, not the stack trace
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