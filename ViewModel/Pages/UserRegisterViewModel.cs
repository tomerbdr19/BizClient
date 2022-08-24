using BizService.Services;

namespace BizClient.ViewModel;

public partial class UserRegisterViewModel : BaseViewModel
{

    public UserRegisterViewModel()
    {
        authService = Store.ServicesStore.AuthService;
        userService = Store.ServicesStore.UserService;
        fileService = Store.ServicesStore.FileService;
        IsLoading = false;
    }

    private readonly AuthService authService;
    private readonly UserService userService;
    private readonly FileService fileService;

    public User User { get; } = new();

    [ObservableProperty]
    private string email = "";

    [ObservableProperty]
    private string password = "";

    [ObservableProperty]
    private string confirmPassword = "";

    [ObservableProperty]
    private bool isRegisterButtonEnabled = false;

    [ObservableProperty]
    private String imageUrl = "http://localhost:3000/profile.jpeg";




    [ICommand]
    async Task OnRegisterClick()
    {
        try
        {
            IsLoading = true;
            await this.UploadAndSetImage();
            var auth = await authService.Register(Email, Password, "user");
            User.Id = auth.User.Id;
            auth.User = await userService.UpdateUser(User);
            IsLoading = false;

            Store.Auth = auth;
            Application.Current.MainPage = new MobileCustomerShell();
        }
        catch (Exception err)
        {
            // TODO: handle error
            Console.WriteLine(err);
        }
    }

    [ICommand]
    async Task OnAddPictureClick()
    {
        var result = await FilePicker.PickAsync();
        if (result != null)
        {
            if (result.FileName.EndsWith("jpg", StringComparison.OrdinalIgnoreCase) ||
                result.FileName.EndsWith("jpeg", StringComparison.OrdinalIgnoreCase) ||
                result.FileName.EndsWith("png", StringComparison.OrdinalIgnoreCase))
            {
                ImageUrl = result.FullPath;
            }
            else
            {
                //TODO hnadle ERROR 
            }
        }
        else
        {
            //TODO hnadle ERROR 
        }
    }

    async private Task UploadAndSetImage()
    {
        if(!ImageUrl.StartsWith("http"))
        {
            var url = await fileService.UploadImage(imageUrl);
            User.ImageUrl = url;
        }
        else
        {
            User.ImageUrl = imageUrl;
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