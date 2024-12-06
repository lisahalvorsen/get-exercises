namespace Exercises;

public class Square
{
    public int _value { get; set; } // 0 = empty, 1 = player 1, 2 = player 2

    public Square()
    {
        _value = 0;
    }

    private bool IsEmptySquare()
    {
        return _value == 0;
    }

    public bool PlayerOnePresent()
    {
        return _value == 1;
    }

    public bool ClaimSquare(bool player)
    {
        if (IsEmptySquare())
        {
            _value = player ? 1 : 2; // if player = true, _value = 1, if player = false, _value = 2 
            return true;
        }

        return false;
    }
}