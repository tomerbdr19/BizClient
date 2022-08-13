namespace BizClient.ViewModel;

public partial class BaseViewModel : ObservableObject
{
    [ObservableProperty]
    [AlsoNotifyChangeFor(nameof(IsNotLoading))]
    bool isLoading;

    [ObservableProperty]
    bool isNotLoading;

    [ObservableProperty]
    string title;

    protected override void OnPropertyChanged(PropertyChangedEventArgs e)
    {
        base.OnPropertyChanged(e);

        switch (e.PropertyName)
        {
            case nameof(IsNotLoading):
                IsNotLoading = !isLoading;
                break;
        }
    }
}