namespace Exercise341B;

public class UpgradeCommand : ICommand
{
    private readonly ClickerGame _game;
    public char Character { get; } = 'K';

    public UpgradeCommand(ClickerGame game)
    {
        _game = game;
    }
    
    public void Run()
    {
        _game.Upgrade();
    }
}