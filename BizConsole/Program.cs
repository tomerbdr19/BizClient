using BizModels.Model;
using BizService;
using BizService.Services;

public partial class Program
{
    public static void Main2()
    {
        new Fetcher();
        Console.ReadKey();
    }
}

public class Fetcher
{
    ServicesStore services = new();
    private readonly string USER_ID = "625adab7160343ce385f654f";
    private readonly string BUSINESS_ID = "62dea63942831efed2e07c7c";

    public Fetcher()
    {
        PrintResult();
    }

    public Task<User> GetUser()
    {
        Console.WriteLine("GetUser");
        return services.UserService.GetUserById(USER_ID);
    }

    public Task<List<Business>> GetBusinessesByIds()
    {
        Console.WriteLine("GetBusinesses");
        return services.BusinessService.GetBusinessesByIds(new[] { BUSINESS_ID });
    }

    public Task<Business> GetBusiness()
    {
        Console.WriteLine("GetBusiness");
        return services.BusinessService.GetBusinessById(BUSINESS_ID);
    }

    public Task<List<Subscription>> GetSubscriptions()
    {
        Console.WriteLine("GetSubscriptions");
        return services.SubscriptionService.GetUserSubscriptions(USER_ID);
    }

    public Task<Auth> Login()
    {
        return services.AuthService.Login("tomerbdr3@gmail.com", "123");
    }

    public async void PrintResult()
    {
        var auth = await Login();
        var user = await GetUser();
        var businesses = await GetBusinessesByIds();
        var business = await GetBusiness();
        var subscriptions = await GetSubscriptions();

        Console.WriteLine("Press any key to exit");
    }
}

