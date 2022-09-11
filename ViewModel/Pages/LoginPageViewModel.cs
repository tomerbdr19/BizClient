using BizClient.Shells;
using Firebase.Installations;
using Firebase.Messaging;

namespace BizClient.ViewModel;

public partial class LoginPageViewModel : BaseViewModel
{

    public LoginPageViewModel()
    {
        this.authService = Store.ServicesStore.AuthService;
    }

    private readonly AuthService authService;

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
        var auth = await this.authService.Login(email, password);
        Store.Auth = auth;
        if(Device.RuntimePlatform == Device.Android)
        {
            Store.NewDeviceToken = FirebaseMessaging.Instance.GetToken().GetResult(Java.Lang.Class.FromType(typeof(InstallationTokenResult))).ToString();
            if (Store.NewDeviceToken != Store.Auth.DeviceToken)
            {
                //if(Store.IsBusiness)
                //{
                //    await this.authService.PostToken(Store.Auth.Business, Store.NewDeviceToken);
                //}
                //else
                //{
                //    await this.authService.PostToken(Store.Auth.Business, Store.NewDeviceToken);
                //}
            }
        }
        // Application.Current.MainPage = Store.IsUser ? new MobileCustomerShell() : new DesktopBusinessShell();
        Application.Current.MainPage = Store.IsUser ? new MobileCustomerShell() : new MobileAdminShell();
    }

    [ICommand]
    async Task OnUserRegisterClick()
    {
        await Shell.Current.GoToAsync(Routes.UserRegister, true);
    }

    [ICommand]
    async Task OnBusinessesRegistrationClick()
    {
        await Shell.Current.GoToAsync(Routes.BusinessesRegistration, true);
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