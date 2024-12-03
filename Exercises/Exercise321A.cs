namespace Exercises;

public class Exercise321A : IExercise
{
    public void Run()
    {
        var counter = new CharCounter();
        string text = "something";
        while (!string.IsNullOrEmpty(text))
        {
            text = Console.ReadLine();
            counter.AddText(text);
            counter.ShowCount();
        }
    }

    private class CharCounter
    {
        private static int _range = 250;
        private int[] _counts = new int[_range];

        internal void AddText(string text)
        {
            foreach (var character in text ?? string.Empty)
            {
                _counts[(int)character]++;
            }
        }

        internal void ShowCount()
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
}