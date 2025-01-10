using System.Text.Json;

namespace Exercise344A;

public class SubscriptionFileRepository : ISubscriptionRepository
{
    public void Save(Subscription subscription) 
    {
        var json = JsonSerializer.Serialize(subscription);
        var fileName = subscription.Email + ".json";
        File.WriteAllText(fileName, json);
    }

    public Subscription Load(string email)
    {
        var fileName = email + ".json";
        var json = File.ReadAllText(fileName);
        return JsonSerializer.Deserialize<Subscription>(json);
    }
}