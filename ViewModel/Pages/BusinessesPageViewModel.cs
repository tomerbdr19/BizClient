namespace BizClient.ViewModel;

public partial class BusinessesPageViewModel : BaseViewModel
{

    public BusinessesPageViewModel()
    {
        businessService = Store.ServicesStore.BusinessService;
        subscriptionService = Store.ServicesStore.SubscriptionService;

        initPage();
    }

    private readonly BusinessService businessService;
    private readonly SubscriptionService subscriptionService;
    public ObservableCollection<Business> Businesses { get; } = new();

    public async void initPage()
    {
        // TODO: handle error
        var subscriptions = await subscriptionService.GetUserSubscriptions(Store.UserId);
        subscriptions.ForEach(_ => Businesses.Add(_.Business));
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