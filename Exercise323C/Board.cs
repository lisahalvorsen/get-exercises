namespace Exercise323C;

public class Board
{
    private readonly Square[] _squares;
    private bool _isPlayerOne { get; set; } = true; // true = player 1, false = player 2
    private Random Random  { get; set; } = new Random();
    public bool IsPlayerOne => _isPlayerOne;

    public Board()
    {
        _squares = new Square[9];

        for (var i = 0; i < _squares.Length; i++)
        {
            _squares[i] = new Square();
        }
    }

    public bool Mark(string position)
    {
        if (position.Length != 2) throw new ArgumentException("Ugyldig trekk, prøv igjen 🤓");

        var colChar = position[0];
        var rowChar = position[1];

        if (colChar < 'a' || colChar > 'c' || rowChar < '1' || rowChar > '3')
        {
            throw new ArgumentException("Ugyldig trekk, prøv igjen!");
        }

        var colIndex = colChar - 'a';
        var rowIndex = rowChar - '1';

        var squareIndex = rowIndex * 3 + colIndex;
        var square = _squares[squareIndex];

        if (square.IsEmptySquare())
        {
            square.Value = SwitchPlayers();
            _isPlayerOne = !_isPlayerOne;
            return true;
        }

        return false;
    }

    private int SwitchPlayers()
    {
        return _isPlayerOne ? 1 : 2;
    }

    public Square GetSquare(int row, int col)
    {
        var index = row * 3 + col;
        return _squares[index];
    }

    public bool IsDraw()
    {
        return _squares.All(square => square.Value != 0);
    }

    public int HasWinner()
    {
        var winningCombinations = new int[][]
        {
            [0, 1, 2], // Topp rad
            [3, 4, 5], // Midterste rad
            [6, 7, 8], // Nederste rad
            [0, 3, 6], // Venstre kolonne
            [1, 4, 7], // Midterste kolonne
            [2, 5, 8], // Høyre kolonne
            [0, 4, 8], // Diagonal
            [2, 4, 6] // Diagonal
        };

        foreach (var combination in winningCombinations)
        {
            var a = combination[0];
            var b = combination[1];
            var c = combination[2];

            if (_squares[a].Value != 0 &&
                _squares[a].Value == _squares[b].Value &&
                _squares[b].Value == _squares[c].Value)
            {
                return _squares[a].Value;
            }
        }

        return 0;
    }

    public bool MarkRandom(bool player)
    {
        var randomNumber = Random.Next(0, 2);
        return randomNumber == 1;
    }
}