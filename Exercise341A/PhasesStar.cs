namespace Exercise341A;

public sealed class PhasesStar : IStar
{
    private const string PhaseChars = " .x*x.";
    private readonly int _x;
    private readonly int _y;
    private int _phase;

    public PhasesStar(Random random)
    {
        _x = random.Next(1, Console.WindowWidth - 1);
        _y = random.Next(1, Console.WindowHeight - 1);
        _phase = random.Next(0, PhaseChars.Length);
    }

    public void Show()
    {
        Console.CursorLeft = _x;
        Console.CursorTop = _y;
        Console.Write(PhaseChars[_phase]);
    }

    public void Update()
    {
        _phase++;
        if (_phase == PhaseChars.Length) _phase = 0;
    }
}