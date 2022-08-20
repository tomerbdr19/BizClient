namespace BizClient.ViewModel;

public partial class BaseViewModel : ObservableObject
{
    [ObservableProperty]
    [AlsoNotifyChangeFor(nameof(IsNotLoading))]
    bool isLoading;

    public bool IsNotLoading => !IsLoading;

    [ObservableProperty]
    string title;
}