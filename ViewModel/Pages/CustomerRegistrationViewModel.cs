namespace BizClient.ViewModel;

public partial class CustomerRegistrationViewModel : BaseViewModel
{

    public CustomerRegistrationViewModel()
    {
        this.authServiceService = Store.ServicesStore.AuthService;
    }

    private readonly AuthService authServiceService;
    private Auth auto;
    private User user;

    [ObservableProperty]
    [AlsoNotifyChangeFor(nameof(isRegistrationButtonEnabled))]
    private String firstName = "";

    [ObservableProperty]
    [AlsoNotifyChangeFor(nameof(isRegistrationButtonEnabled))]
    private String lastName = "";

    [ObservableProperty]
    [AlsoNotifyChangeFor(nameof(isRegistrationButtonEnabled))]
    private String email = "";

    [ObservableProperty]
    [AlsoNotifyChangeFor(nameof(isRegistrationButtonEnabled))]
    private String password1 = "";

    [ObservableProperty]
    [AlsoNotifyChangeFor(nameof(isRegistrationButtonEnabled))]
    private String password2 = "";

    [ObservableProperty]
    [AlsoNotifyChangeFor(nameof(isRegistrationButtonEnabled))]
    private String phone = "";

    [ObservableProperty]
    [AlsoNotifyChangeFor(nameof(FirstName))]
    [AlsoNotifyChangeFor(nameof(LastName))]
    [AlsoNotifyChangeFor(nameof(Email))]
    [AlsoNotifyChangeFor(nameof(password1))]
    [AlsoNotifyChangeFor(nameof(password2))]
    [AlsoNotifyChangeFor(nameof(Phone))]
    private Boolean isRegistrationButtonEnabled = false;

    [ICommand]
    async Task OnRegistrationClick()
    {
        // TODO: handle Registration
        auto = new();
        user = new();
        UserInfo userInfo = new();
        userInfo.firstName = FirstName;
        userInfo.lastName = LastName;
        user.info = userInfo;
        auto.User = user;
        authServiceService.Registration(auto, Email, Password1);
    }

    void Validation()
    {
        isRegistrationButtonEnabled = ((FirstName != String.Empty) && (LastName != String.Empty) && (Email != String.Empty) 
            && (Password1 != String.Empty) && (Password2 != String.Empty) && (Password1 != Password2) && (Phone != String.Empty) && (Phone.Length == 10));
    }

    protected override void OnPropertyChanged(PropertyChangedEventArgs e)
    {
        base.OnPropertyChanged(e);

        switch (e.PropertyName)
        {
            case nameof(FirstName):
            case nameof(LastName):
            case nameof(Email):
            case nameof(Password1):
            case nameof(Password2):
            case nameof(Phone):
                Validation();
                break;
        }
    }
}