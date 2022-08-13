namespace BizClient.ViewModel;

public partial class BaseViewModel : ObservableObject
{
    [ObservableProperty]
    bool isLoading;

    public bool IsNotLoading => !IsLoading;

    [ObservableProperty]
    string title;
}