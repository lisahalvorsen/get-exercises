namespace Exercises;

public class GameConsole
{
    private Board _board = new Board();

    public GameConsole(Board board)
    {
        _board = board;
    }

    public void Show(Board board)
    {
        Console.WriteLine("   a   b   c"); 
        Console.WriteLine(" ┌───┬───┬───┐");
        
        for (var row = 0; row < 3; row++)
        {
            Console.Write($"{row + 1}│");

            for (var col = 0; col < 3; col++)
            {
                var squareValue = ' ';
                Console.Write($" {squareValue} │");
            }

            Console.WriteLine();

            if (row < 2)
            {
                Console.WriteLine(" ├───┼───┼───┤");
            }
            else
            {
                Console.WriteLine(" └───┴───┴───┘");
            }
        }
    }
}