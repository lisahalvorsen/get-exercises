namespace Exercise323C;

public class Square
{
    public int Value { get; set; } // 0 = empty, 1 = player 1, 2 = player 2
    
    public bool IsEmptySquare()
    {
        return Value == 0;
    }

    public bool PlayerOnePresent()
    {
        return Value == 1;
    }

    public bool ClaimSquare(bool player)
    {
        if (IsEmptySquare())
        {
            Value = player ? 1 : 2; // if player = true, _value = 1, if player = false, _value = 2 
            return true;
        }

        return false;
    }
}