namespace BizClient.ViewModel;

public partial class BusinessesRegistrationViewModel : BaseViewModel
{

    public BusinessesRegistrationViewModel(SubscriptionService subscriptionService)
    {
        this.sessionService = sessionService;
    }

    private readonly SessionService sessionService;

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
    [AlsoNotifyChangeFor(nameof(isRegistrationButtonEnabled))]
    private String ownerPhone = "";

    [ObservableProperty]
    [AlsoNotifyChangeFor(nameof(isRegistrationButtonEnabled))]
    private String street = "";

    [ObservableProperty]
    [AlsoNotifyChangeFor(nameof(isRegistrationButtonEnabled))]
    private String number = "";

    [ObservableProperty]
    [AlsoNotifyChangeFor(nameof(isRegistrationButtonEnabled))]
    private String city = "";

    [ObservableProperty]
    [AlsoNotifyChangeFor(nameof(isRegistrationButtonEnabled))]
    private String description = "";

    [ObservableProperty]
    [AlsoNotifyChangeFor(nameof(isRegistrationButtonEnabled))]
    private String logoUrl = "";

    [ObservableProperty]
    [AlsoNotifyChangeFor(nameof(FirstName))]
    [AlsoNotifyChangeFor(nameof(LastName))]
    [AlsoNotifyChangeFor(nameof(Email))]
    [AlsoNotifyChangeFor(nameof(password1))]
    [AlsoNotifyChangeFor(nameof(password2))]
    [AlsoNotifyChangeFor(nameof(Phone))]
    [AlsoNotifyChangeFor(nameof(OwnerPhone))]
    [AlsoNotifyChangeFor(nameof(Street))]
    [AlsoNotifyChangeFor(nameof(City))]
    [AlsoNotifyChangeFor(nameof(Description))]
    [AlsoNotifyChangeFor(nameof(LogoUrl))]
    private Boolean isRegistrationButtonEnabled = false;

    [ICommand]
    async Task OnRegistrationClick()
    {
        // TODO: handle Registration
    }


    [ICommand]
    async Task OnBackClick()
    {
        Application.Current.MainPage = new BootstrapShell();
    }

    void Validation()
    {
        isRegistrationButtonEnabled = ((FirstName != String.Empty) && (LastName != String.Empty) && (Email != String.Empty)
            && (Password1 != String.Empty) && (Password2 != String.Empty) && (Password1 != Password2) && (Phone != String.Empty) && (Phone.Length == 10)
            && (Street != String.Empty) && (City != String.Empty) && (Description != String.Empty));
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