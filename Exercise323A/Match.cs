using CommonInterfaces;

namespace Exercise323A;

public class Match : IExercise
{
    private int HomeGoals { get; set; }
    private int AwayGoals { get; set; }
    private string Bet { get; set; }

    public Match(string bet)
    {
        Bet = bet;
    }

    public Match()
    {
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

    public void Run()
    {
        var match = new Match("H");

        Console.Write("Gyldig tips: \n" +
                      " - H, U, B\n" +
                      " - Halvgardering: HU, HB, UB\n" +
                      " - Helgardering: HUB\n" +
                      "Hva har du tippet for denne kampen? ");

        var bet = Console.ReadLine()?.ToUpper();

        while (true)
        {
            Console.Write("Kommandoer: \n" +
                          " - H = scoring hjemmelag\n" +
                          " - B = scoring bortelag\n" +
                          " - X = kampen er ferdig\n" +
                          "Angi kommando: ");

            var input = Console.ReadLine()?.ToUpper();

            if (Enum.TryParse<Command>(input.ToUpper(), out var command))
            {
                if (command == Command.X) break;

                match.AddGoal(command);
                Console.WriteLine($"Stillingen er: {match.GetScore()} ⚽️");
            }
            else
            {
                Console.WriteLine("Ugyldig kommando, prøv igjen 😄");
            }
        }

        var isBetCorrect = match.IsBetCorrect();

        Console.WriteLine(isBetCorrect
            ? "Gratulerer, du tippet riktig 🥳"
            : "Sorry, men du tippet feil. Bedre lykke neste gang 🫣");
    }

    // public void Run()
    // {
    //     Console.WriteLine("Gyldig tips: \n" +
    //                       " - H, U, B\n" +
    //                       " - hHlvgardering: HU, HB, UB\n" +
    //                       " - Helgardering: HUB\n" +
    //                       "Skriv inn dine 12 tips med komma mellom: ");
    //
    //     var userBets = Console.ReadLine();
    //     var bettingSlip = new BettingSlip(userBets);
    //
    //     while (true)
    //     {
    //         Console.Write("Skriv kampnr. 1-12 for scoring eller X for alle kampene er ferdige\r\nAngi kommando: ");
    //         var command = Console.ReadLine()?.ToUpper();
    //
    //         if (command == "X") break;
    //         var matchNo = Convert.ToInt32(command);
    //         Console.WriteLine($"Scoring i kamp {matchNo}. \r\nSkriv H for hjemmelag eller B for bortelag: ");
    //         var team = Console.ReadLine()?.ToUpper();
    //         bettingSlip.AddGoal(matchNo, team == "H");
    //         bettingSlip.ShowAllScores();
    //         bettingSlip.ShowCorrectBets();
    //     }
    // }
}