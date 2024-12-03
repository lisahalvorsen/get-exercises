namespace Exercises;

public class Exercise315A : IExercise
{
    public void Run()
    {
        var random = new Random();
        var randomNumber = random.Next(1, 100);
        var count = 0;

        Console.WriteLine("Guess the secret number between 1 and 100 😎");

        while (true)
        {
            var input = int.Parse(Console.ReadLine());
            count++;

            if (input == randomNumber)
            {
                Console.WriteLine("You entered the correct number! 🎉");
                Console.WriteLine($"The secret number was {randomNumber} and you used {count} attempts.");
                break;
            }
            else if (input > randomNumber)
            {
                Console.WriteLine("Your guess was too high ↑ Try again!");
            }
            else if (input < randomNumber)
            {
                Console.WriteLine("Your guess was too low ↓ Try again!");
            }
        }
    }
}