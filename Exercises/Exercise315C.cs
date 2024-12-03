namespace Exercises;

public class Exercise315C : IExercise
{
    public void Run()
    {
        Console.WriteLine("Enter a text to see what happens 😎");
        var text = Console.ReadLine();
        Console.WriteLine(ReverseText(text));
    }

    private string ReverseText(string text)
    {
        var characters = text.ToCharArray().Reverse();
        return new string(characters.ToArray());
        // return string.Join("", characters);
    }
}