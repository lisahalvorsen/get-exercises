namespace Exercises;

public class Board
{
    private Square[] _squares;

    public Board()
    {
        _squares = new Square[9];
        
        for (var i = 0; i < _squares.Length; i++)
        {
            _squares[i] = new Square();
        }
    }

    public void Mark(string position)
    {
        
    }

    public Square GetSquare(int row, int col)
    {
        var index = row * 3 + col;
        return _squares[index];
    }
}