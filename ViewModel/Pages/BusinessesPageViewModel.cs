namespace BizClient.ViewModel;

public partial class BusinessesPageViewModel : BaseViewModel
{

    public BusinessesPageViewModel()
    {
        businessService = Store.ServicesStore.BusinessService;
        subscriptionService = Store.ServicesStore.SubscriptionService;
    }

    private readonly BusinessService businessService;
    private readonly SubscriptionService subscriptionService;
    public ObservableCollection<Business> Businesses { get; } = new();

    public async void OnAppearing(List<Business> InjectedBusinessesList)
    {
        // TODO: handle error
        Businesses.Clear();

        if (InjectedBusinessesList == null)
        {
            this.Title = "Subscriptions";
            IsLoading = true;
            var subscriptions = await subscriptionService.GetUserSubscriptions(Store.UserId);
            subscriptions.ForEach(_ => Businesses.Add(_.Business));
            IsLoading = false;
        }
        else
        {
            this.Title = "Search Result";
            InjectedBusinessesList.ForEach(_ => Businesses.Add(_));
        }
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