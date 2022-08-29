namespace BizClient.ViewModel.BusinessViewModel;

public partial class BusinessHomePageViewModel : BaseViewModel
{

    public BusinessHomePageViewModel()
    {
    }

    async public void OnAppearing()
    {
        IsLoading = true;

        this.SubscriptionsActivity = await subscriptionService.GetSubscribtionActivity(Store.BusinessId, this.ActivityPeriod);
        this.CouponsActivity = await couponService.GetCouponsActivity(Store.BusinessId, this.ActivityPeriod);

        IsLoading = false;
    }

    private readonly SubscriptionService subscriptionService = Store.ServicesStore.SubscriptionService;
    private readonly CouponService couponService = Store.ServicesStore.CouponService;

    [ObservableProperty]
    public List<ChartData> subscriptionsActivity = new();

    [ObservableProperty]
    public List<ChartData> couponsActivity = new();

    [ObservableProperty]
    public string activityPeriod = "week";

    protected override void OnPropertyChanged(PropertyChangedEventArgs e)
    {
        base.OnPropertyChanged(e);
    }
}