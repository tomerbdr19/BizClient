namespace BizClient.ViewModel;

public partial class UserRegisterViewModel : BaseViewModel
{

    public UserRegisterViewModel()
    {
        authService = Store.ServicesStore.AuthService;
        userService = Store.ServicesStore.UserService;
    }

    private readonly AuthService authService;
    private readonly UserService userService;

    public User User { get; } = new();

    [ObservableProperty]
    private string email = "";

    [ObservableProperty]
    private string password = "";

    [ObservableProperty]
    private string confirmPassword = "";

    [ObservableProperty]
    private bool isRegisterButtonEnabled = false;


    [ICommand]
    async Task OnRegisterClick()
    {
        try
        {
            var auth = await authService.Register(Email, Password);
            User.Id = auth.User.Id;
            auth.User = await userService.UpdateUser(User);

            Store.Auth = auth;
            Application.Current.MainPage = new MobileCustomerShell();
        }
        catch (Exception err)
        {
            // TODO: handle error
            Console.WriteLine(err);
        }
    }


    void Validation()
    {
        IsRegisterButtonEnabled = (User.Info.FirstName != string.Empty) && (User.Info.LastName != string.Empty) && (Email != string.Empty)
            && (Password != string.Empty) && (ConfirmPassword != string.Empty) && (User.Info.City != string.Empty);
    }

    protected override void OnPropertyChanged(PropertyChangedEventArgs e)
    {
        base.OnPropertyChanged(e);
        Validation();
    }
}