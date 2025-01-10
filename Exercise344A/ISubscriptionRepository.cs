namespace Exercise344A;

public interface ISubscriptionRepository
{
    void Save(Subscription subscription);
    Subscription Load(string email);
}