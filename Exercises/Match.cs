namespace Exercises;

public class Match
{
    private int HomeGoals { get; set; }
    private int AwayGoals { get; set; }
    private string Bet { get; set; }

    public Match(string bet)
    {
        Bet = bet;
    }

    public void AddGoal(Command team)
    {
        switch (team)
        {
            case Command.H:
                HomeGoals++;
                break;
            case Command.B:
                AwayGoals++;
                break;
        }
    }

    public bool IsBetCorrect()
    {
        var result = HomeGoals == AwayGoals ? "U" : HomeGoals > AwayGoals ? "H" : "B";
        return Bet.Contains(result);
    }

    public string GetScore()
    {
        return HomeGoals + "-" + AwayGoals;
    }
}