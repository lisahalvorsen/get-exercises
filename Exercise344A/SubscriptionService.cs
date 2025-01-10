namespace Exercise344A;

public class SubscriptionService
{
    private readonly IEmailService _emailService;
    private readonly ISubscriptionRepository _subscriptionRepository;

    public SubscriptionService(
        IEmailService emailService,
        ISubscriptionRepository subscriptionRepository)
    {
        _subscriptionRepository = subscriptionRepository;
        _emailService = emailService;
    }

    public void Subscribe(string emailAddress)
    {
        var subscription = new Subscription("Subscriber", emailAddress);
        _subscriptionRepository.Save(subscription);

        var email = new Email(subscription.Email, "Please confirm your email address",
            $"Your verification code is : {subscription.VerificationCode}");
        _emailService.Send(email);
    }

    public void Verify(string emailAddress, string verificationCode)
    {
        var subscription = _subscriptionRepository.Load(emailAddress);

        if (subscription != null && subscription.VerificationCode == verificationCode)
        {
            var updatedSubscription = new Subscription(
                subscription.Name,
                subscription.Email,
                subscription.VerificationCode)
            {
                IsVerified = true
            };

            _subscriptionRepository.Save(updatedSubscription);

            var email = new Email(subscription.Email,
                "Subscription verified",
                "Your subscription has been successfully verified!");
            _emailService.Send(email);
        }
    }
}