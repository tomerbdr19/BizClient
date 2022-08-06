namespace BizClient.ViewModel;

public partial class SubscribesListPageViewModel : BaseViewModel
{
    public SubscribesListPageViewModel()
    {
        this.subscriptionService = Store.ServicesStore.SubscriptionService;
    }

    private readonly SubscriptionService subscriptionService;
    public ObservableCollection<Subscription> Subscribes { get; } = new();

    async public void OnAppearing()
    {
        Subscribes.Clear();

        this.IsLoading = true;
        var subscriptionService = await this.subscriptionService.GetBusinessSubscriptions(Store.Auth.Business.Id);
        subscriptionService.ForEach(_ => Subscribes.Add(_));
        this.IsLoading = false;
    }

}

