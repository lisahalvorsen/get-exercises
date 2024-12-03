namespace Exercises;

public class Exercise323A : IExercise
{
    public void Run()
    {
        var match = new Match();

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

                match.IncreasePoints(command);
                Console.WriteLine($"Stillingen er {match.HomeGoals}-{match.AwayGoals}.");
            }
            else
            {
                Console.WriteLine("Ugyldig kommando, prøv igjen 😄");
            }
        }

        var result = match.GetMatchResult();
        var isBetCorrect = match.IsBetCorrect(bet, result);

        Console.WriteLine(isBetCorrect
            ? "Gratulerer, du tippet riktig 🥳"
            : "Sorry, men du tippet feil. Bedre lykke neste gang 🫣");
    }
}