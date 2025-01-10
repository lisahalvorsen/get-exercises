namespace Exercise344A;

public class SubscriptionService
{
    private readonly IEmailService _emailService;
    private ISubscriptionRepository _subscriptionRepository;

    public SubscriptionService(
        IEmailService emailService,
        ISubscriptionRepository subscriptionRepository)
    {
        _subscriptionRepository = subscriptionRepository;
        _emailService = emailService;
    }

    public void Subscribe(string emailAddress)
    {
    }

    public void Verify(string emailAddress, string verificationCode)
    {
    }
}