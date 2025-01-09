using CommonInterfaces;

namespace Exercise315B;

public class RockPaperScissor : IExercise
{
    public void Run()
    {
        var playerPoints = 0;
        var computerPoints = 0;

        while (true)
        {
            var computer = GetRandomNumber();
            var input = Console.ReadLine();

            if (input == "r" && computer == 1 || input == "p" && computer == 2 || input == "s" && computer == 3)
            {
                Console.WriteLine("Nobody gets a point 🧐");
            }
            else if (input == "r" && computer == 3 || input == "p" && computer == 1 || input == "s" && computer == 2)
            {
                Console.WriteLine("You get a point 🎉");
                playerPoints++;
            }
            else if (input == "r" && computer == 2 || input == "p" && computer == 3 || input == "s" && computer == 1)
            {
                Console.WriteLine("The computer gets a point 🫣");
                computerPoints++;
            }
            else if (input == "x")
            {
                Console.WriteLine("Thanks for playing!");
                break;
            }
            else
            {
                Console.WriteLine("Not valid input. Try again!");
            }

            Console.WriteLine($"The score is now {playerPoints} (you) - {computerPoints} (the computer)");
        }
    }

    private static int GetRandomNumber()
    {
        var random = new Random();
        var randomNumber = random.Next(1, 4); // 1 = Rock, 2 = Paper, 3 = Scissors
        return randomNumber;
    }
}