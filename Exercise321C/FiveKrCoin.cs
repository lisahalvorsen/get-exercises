namespace Exercise321C;

public class FiveKrCoin : Wallet
{
    public override int Value => 5;

    public FiveKrCoin(int count)
    {
        Count = count;
    }
}