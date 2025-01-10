namespace Exercise344A;

public class Email
{
    private string To { get; set; }
    private string From { get; set; }
    private string Subject { get; set; }
    private string Text { get; set; }

    public Email(string to, string from, string subject, string text = null)
    {
        To = to;
        From = from;
        Subject = subject;
        Text = text;
    }

    public override string ToString()
    {
        return $"Epost fra {From} til {To}: {Subject}\n{Text}";
    }
}