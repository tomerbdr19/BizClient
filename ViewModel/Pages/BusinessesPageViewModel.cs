namespace BizClient.ViewModel;

public partial class BusinessesPageViewModel : BaseViewModel
{

    public BusinessesPageViewModel(BusinessService businessService, SubscriptionService subscriptionService)
    {
        this.subscriptionService = subscriptionService;
        this.businessService = businessService;
        initPage();
    }

    private readonly BusinessService businessService;
    private readonly SubscriptionService subscriptionService;
    public ObservableCollection<Business> Businesses { get; } = new();

    public async void initPage()
    {
        var subscriptions = await subscriptionService.GetUserSubscriptions();
        var businesses = await businessService.GetBusinessesByIds(subscriptions.Select(_ => _.BusinessId).ToArray());

        businesses.ForEach(_ => Businesses.Add(_));
    }

    [ICommand]
    async Task GoToBusiness(Business business)
    {
        if (business == null)
            return;

        await Shell.Current.GoToAsync(Routes.Business, true, new Dictionary<string, object>
        {
            {"Business", business}
        });
    }

    protected override void OnPropertyChanged(PropertyChangedEventArgs e)
    {
        base.OnPropertyChanged(e);
    }
}