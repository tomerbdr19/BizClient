namespace BizClient.ViewModel;

public partial class BaseViewModel : ObservableObject
{
    [ObservableProperty]
    bool isLoading;

    [ObservableProperty]
    string title;
}