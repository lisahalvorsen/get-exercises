using CommonInterfaces;

namespace Exercise341A;

public class StarManager : IExercise
{
    public void Run()
    {
        var random = new Random();
        var stars = new IStar[]
        {
            new PhasesStar(random),
            new PhasesStar(random),
            new PhasesStar(random),
            new MovableStar(random),
            new MovableStar(random),
            new MovableStar(random),
        };

        while (true)
        {
            Console.Clear();
            foreach (var star in stars)
            {
                star.Show();
                star.Update();
            }

            Console.CursorLeft = 0;
            Console.CursorTop = 0;
            Thread.Sleep(200);
        }
    }
}