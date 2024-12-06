namespace Exercises;

public class Exercise323C : IExercise
{
    public void Run()
    {
        var board = new Board();
        var gameConsole = new GameConsole(board);

        // while (true)
        // {
            gameConsole.Show(board);
            // Console.WriteLine("Skriv inn hvilken rute du vil sette et kryss i, f.eks. a2");
            // var position = Console.ReadLine();
            // board.Mark(position);
        // }
    }
}