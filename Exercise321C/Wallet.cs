using CommonInterfaces;

namespace Exercise321C;

public class Wallet : IExercise
{
    public virtual int Value { get; }
    protected int Count { get; init; }

    public static int CalculateTotalBalance(Wallet[] wallet)
    {
        return wallet?.Sum(coin => coin.Value * coin.Count) ?? 0;
    }

    public static void DisplayTotalAmount(int value)
    {
        Console.WriteLine($"Totalt har du {value} kr 💰");
    }

    public static void DisplayBalance(Wallet[] wallet)
    {
        if (wallet == null || wallet.Length == 0)
        {
            Console.WriteLine("Du har ingen penger, aka du er blakk 🙃");
            return;
        }

        Console.WriteLine("I pengeboka har du:");
        foreach (var coin in wallet)
        {
            Console.WriteLine($"{coin.Count} x {coin.Value}-kroninger 🪙");
        }
    }

    public void Run()
    {
        var wallet = new Wallet[]
        {
            new OneKrCoin(1),
            new FiveKrCoin(1),
            new TenKrCoin(1),
            new TwentyKrCoin(1),
        };

        var totalBalance = Wallet.CalculateTotalBalance(wallet);
        Wallet.DisplayBalance(wallet);
        Wallet.DisplayTotalAmount(totalBalance);
    }
}