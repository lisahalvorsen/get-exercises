using CommonInterfaces;

namespace Exercise315C;

public class ReverseText : IExercise
{
    public void Run()
    {
        Console.WriteLine("Enter a text to see what happens 😎");
        var text = Console.ReadLine();
        Console.WriteLine(Reverse(text));
    }

    private static string Reverse(string text)
    {
        var characters = text.ToCharArray().Reverse();
        return new string(characters.ToArray());
        // return string.Join("", characters);
    }
}