namespace Exercises;

public class Exercise323B 
{
    public void Run()
    {
        Console.WriteLine("Gyldig tips: \n" +
                          " - H, U, B\n" +
                          " - hHlvgardering: HU, HB, UB\n" +
                          " - Helgardering: HUB\n" +
                          "Skriv inn dine 12 tips med komma mellom: ");

        var userBets = Console.ReadLine();
        var bettingSlip = new BettingSlip(userBets);

        while (true)
        {
            Console.Write("Skriv kampnr. 1-12 for scoring eller X for alle kampene er ferdige\r\nAngi kommando: ");
            var command = Console.ReadLine()?.ToUpper();
            
            if (command == "X") break;
            var matchNo = Convert.ToInt32(command);
            Console.WriteLine($"Scoring i kamp {matchNo}. \r\nSkriv H for hjemmelag eller B for bortelag: ");
            var team = Console.ReadLine()?.ToUpper();
            bettingSlip.AddGoal(matchNo, team == "H");
            bettingSlip.ShowAllScores();
            bettingSlip.ShowCorrectBets();

        }
    }
}
