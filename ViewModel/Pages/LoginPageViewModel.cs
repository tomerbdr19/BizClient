namespace BizClient.ViewModel;

public partial class LoginPageViewModel : BaseViewModel
{

    public LoginPageViewModel()
    {
    }

    [ObservableProperty]
    [AlsoNotifyChangeFor(nameof(IsLoginButtonEnabled))]
    private String email = "";

    [ObservableProperty]
    private String password = "";

    [ObservableProperty]
    [AlsoNotifyChangeFor(nameof(Email))]
    [AlsoNotifyChangeFor(nameof(Password))]
    private Boolean isLoginButtonEnabled = false;

    [ICommand]
    async Task OnLoginClick()
    {
        // TODO: handle login
        await Shell.Current.GoToAsync(Routes.Home);
    }

    void Validation()
    {
        IsLoginButtonEnabled = Email != String.Empty && Password != String.Empty;
    }

    protected override void OnPropertyChanged(PropertyChangedEventArgs e)
    {
        base.OnPropertyChanged(e);

        switch (e.PropertyName)
        {
            case nameof(Email):
            case nameof(Password):
                Validation();
                break;
        }
    }
}