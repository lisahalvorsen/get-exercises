namespace Exercises;

public class Wallet
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
}