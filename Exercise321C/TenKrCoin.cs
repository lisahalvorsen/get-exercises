namespace Exercise321C;

public class TenKrCoin : Wallet
{
    public override int Value => 10;

    public TenKrCoin(int count)
    {
        Count = count;
    }
}