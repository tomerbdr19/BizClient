namespace BizClient.ViewModel.BusinessViewModel;

public partial class BusinessSubscribersPageViewModel : BaseViewModel
{

    public BusinessSubscribersPageViewModel()
    {
    }

    private SubscriptionService subscriptionService = Store.ServicesStore.SubscriptionService;

    public ObservableCollection<Subscription> Subscriptions { get; } = new();

    private List<IFilter> filters = new();

    [ObservableProperty]
    public OptionsFilter<string> cityFilter;

    [ObservableProperty]
    public RangeFilter<DateTime> subscriptionDateFilter;

    [ObservableProperty]
    public RangeFilter<Nullable<int>> ageFilter;

    async public void OnAppearing()
    {
        Subscriptions.Clear();
        resetFilters();
        await OnApplyFilters();
    }

    private void resetFilters()
    {
        CityFilter = new() { Key = "city", Options = new List<string> { "Tel Aviv", "Modiin", "Rishon" } };
        SubscriptionDateFilter = new() { Key = "createdAt", From = DateTime.Today, To = DateTime.Today };
        AgeFilter = new() { Key = "age" };

        filters.Add(CityFilter);
        filters.Add(AgeFilter);
        filters.Add(SubscriptionDateFilter);

        filters.ForEach((_) => _.IsChecked = false);
    }

    [ICommand]
    public async Task OnApplyFilters()
    {
        Subscriptions.Clear();

        IsLoading = true;
        var subscriptions = await this.subscriptionService.GetFilteredSubscriptions("62dea60742831efed2e07c7a", filters.FindAll((_) => _.IsChecked == true));
        subscriptions.ForEach((_) => Subscriptions.Add(_));
        IsLoading = false;

    }

    [ICommand]
    public async Task OnResetClick()
    {
        resetFilters();
        await OnApplyFilters();
    }

    protected override void OnPropertyChanged(PropertyChangedEventArgs e)
    {
        base.OnPropertyChanged(e);
    }

}