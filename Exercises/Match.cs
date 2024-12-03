namespace Exercises;

public class Match
{
    public int HomeGoals { get; private set; } = 0;
    public int AwayGoals { get; private set; } = 0;
    private string Result { get; set; } = string.Empty;

    public bool IncreasePoints(Command command)
    {
        switch (command)
        {
            case Command.H:
                HomeGoals++;
                return true;
            case Command.B:
                AwayGoals++;
                return true;
            default:
                return false;
        }
    }

    public string GetMatchResult()
    {
        Result = HomeGoals == AwayGoals ? "U" : HomeGoals > AwayGoals ? "H" : "B";
        return Result;
    }

    public bool IsBetCorrect(string bet, string result)
    {
        return bet.Contains(result);
    }
}