namespace Exercise341B;

public class SuperUpgradeCommand : ICommand
{
    private readonly ClickerGame _game;
    public char Character { get; } = 'S';

    public SuperUpgradeCommand(ClickerGame game)
    {
        _game = game;
    }

    public void Run()
    {
        _game.SuperUpgrade();
    }

}