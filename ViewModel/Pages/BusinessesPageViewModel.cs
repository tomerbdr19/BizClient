namespace BizClient.ViewModel;

public partial class BusinessesPageViewModel : BaseViewModel
{

    public BusinessesPageViewModel()
    {
        foreach (Business business in Mocks.businesses)
        {
            Businesses.Add(business);
        }
    }

    public ObservableCollection<Business> Businesses { get; } = new();

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