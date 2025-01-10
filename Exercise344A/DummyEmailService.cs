namespace Exercise344A;

public class DummyEmailService : IEmailService
{
    public void Send(Email email)
    {
        Console.WriteLine(email);
    }
}