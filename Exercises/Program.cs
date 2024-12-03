namespace Exercises;

internal static class Program
{
    private static void Main(string[] args)
    {
        IExercise exerciseToRun;
        // exerciseToRun = new Exercise315A();
        // exerciseToRun = new Exercise315B();
        // exerciseToRun = new Exercise315C();
        // exerciseToRun = new Exercise321A();
        // exerciseToRun = new Exercise321B();
        // exerciseToRun = new Exercise321C();
        exerciseToRun = new Exercise323A();
        
        exerciseToRun.Run();
    }
}