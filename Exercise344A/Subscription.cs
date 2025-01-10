namespace Exercise344A;

public class Subscription
{
    public string Name { get; init; }
    public string Email { get; init; }
    public string VerificationCode { get; init; }
    public bool IsVerified { get; init; }

    public Subscription(string name, string email, string verificationCode = null)
    {
        Name = name;
        Email = email;
        VerificationCode = verificationCode ?? Guid.NewGuid().ToString();
    }

    public override string ToString()
    {
        return $"Navn: {Name}, E-post: {Email}, Verifisert: {IsVerified}, Kode: {VerificationCode}";
    }
}