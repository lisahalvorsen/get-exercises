namespace Exercises;

public class Exercise321C : IExercise
{
    public void Run()
    {
        var wallet = new Wallet[]
        {
            new OneKrCoin(7),
            new FiveKrCoin(3),
            new TenKrCoin(2),
            new TwentyKrCoin(11),
        };

        var totalBalance = Wallet.CalculateTotalBalance(wallet);
        Wallet.DisplayBalance(wallet);
        Wallet.DisplayTotalAmount(totalBalance);
    }
}