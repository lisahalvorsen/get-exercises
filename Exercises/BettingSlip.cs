namespace Exercises;

public class BettingSlip
{
    private Match[] _matches;

    public BettingSlip(string betsText)
    {
       var bets = betsText.Split(',');
       _matches = new Match[12];
       
       for (var i = 0; i < _matches.Length; i++)
       {
           _matches[i] = new Match(bets[i]);
       }  
    }

    public void AddGoal(int matchNo, bool isHomeTeam)
    {
        var selectedIndex = matchNo - 1;
        var selectedMatch = _matches[selectedIndex];
        var command = isHomeTeam ? Command.H : Command.B;
        selectedMatch.AddGoal(command);
    }

    public void ShowAllScores()
    {
        for (var j = 0; j< _matches.Length; j++)
        {
            var match = _matches[j];
            var matchNo = j + 1;
            var isBetCorrect = match.IsBetCorrect();
            var isBetCorrectText = isBetCorrect ? "riktig" : "feil";
            Console.WriteLine($"Kamp {matchNo}: {match.GetScore()} - {isBetCorrectText}");
        }
    }

    public void ShowCorrectBets()
    {
        var correctBets = 0;
        foreach (var match in _matches)
        {
            if (match.IsBetCorrect()) correctBets++;
        }
        Console.WriteLine($"Du har {correctBets} rette.");
    }
}