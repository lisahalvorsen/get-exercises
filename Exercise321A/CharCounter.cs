using CommonInterfaces;

namespace Exercise321A;

public class CharCounter : IExercise
{
    private static int _range = 250;
    private int[] _counts = new int[_range];

    public void Run()
    {
        var counter = new CharCounter();
        var text = "something";

        while (!string.IsNullOrEmpty(text))
        {
            text = Console.ReadLine();
            counter.AddText(text);
            counter.ShowCounts();
        }
    }

    private void AddText(string text)
    {
        foreach (var character in text ?? string.Empty)
        {
            _counts[(int)character]++;
        }
    }

    private void ShowCounts()
    {
        for (var i = 0; i < _range; i++)
        {
            if (_counts[i] > 0)
            {
                var character = (char)i;
                Console.WriteLine(character + " - " + _counts[i]);
            }
        }
    }
}