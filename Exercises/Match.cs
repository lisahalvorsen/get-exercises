namespace Exercises;

internal class Match
{
    private int HomeGoals { get; set; }
    private int AwayGoals { get; set; }
    private string Bet { get; set; }

    public Match(string bet)
    {
        Bet = bet;
    }

    internal void AddGoal(Command team)
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

    internal bool IsBetCorrect()
    {
        var result = HomeGoals == AwayGoals ? "U" : HomeGoals > AwayGoals ? "H" : "B";
        return Bet.Contains(result);
    }

    internal string GetScore()
    {
        return HomeGoals + "-" + AwayGoals;
    }
}