namespace BizClient.ViewModel;

public partial class BusinessPageViewModel : BaseViewModel
{
    public BusinessPageViewModel(Business business)
    {
        this.Business = business;
    }

    [ObservableProperty]
    public Business business;
}
