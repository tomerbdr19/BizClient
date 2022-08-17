namespace BizClient.ViewModel.BusinessViewModel;

public partial class BusinessSubscribersPageViewModel : BaseViewModel
{

    public BusinessSubscribersPageViewModel()
    {
    }

    private SubscriptionService subscriptionService = Store.ServicesStore.SubscriptionService;

    public ObservableCollection<Subscription> Subscriptions { get; } = new();

    [ObservableProperty]
    public Filter<string> cityFilter = new Filter<string> { IsChecked = false, Options = new List<string> { "Tel aviv", "modiin", "Rishon" } };

    [ObservableProperty]
    public Filter<FilterRange<DateTime>> subscriptionDateFilter = new() { Value = new() { From = DateTime.Now, To = DateTime.Now } };

    [ObservableProperty]
    public Filter<FilterRange<int>> ageFilter = new() { Value = new() { From = 0, To = 0 } };

    async public void OnAppearing()
    {
        Subscriptions.Clear();

        IsLoading = true;
        await Task.Delay(500);
        var subscriptions = await this.subscriptionService.GetBusinessSubscriptions("62dea60742831efed2e07c7a");
        subscriptions.ForEach((_) => Subscriptions.Add(_));
        IsLoading = false;
    }

    [ICommand]
    public void OnApplyFilters()
    {
        // TODO: implmenet
    }

    protected override void OnPropertyChanged(PropertyChangedEventArgs e)
    {
        base.OnPropertyChanged(e);
    }

}
public class Filter<T>
{
    public bool IsChecked { get; set; } = false;
    public T Value { get; set; }
    public List<T> Options { get; set; } = new();
}

public class FilterRange<T>
{
    public T From { get; set; }
    public T To { get; set; }
}