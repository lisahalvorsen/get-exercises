namespace Exercise321C;

public class TwentyKrCoin : Wallet
{
    public override int Value => 20;

    public TwentyKrCoin(int count)
    {
        Count = count;
    }
}