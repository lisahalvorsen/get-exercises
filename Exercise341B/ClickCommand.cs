namespace Exercise341B;

public class ClickCommand : ICommand
{
    private readonly ClickerGame _game;
    public char Character { get; set; } = ' ';

    public ClickCommand(ClickerGame game)
    {
        _game = game;
    }

    public void Run()
    {
        _game.Click();
    }
}