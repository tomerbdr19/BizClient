using BizService.Services;

namespace BizClient.ViewModel;

public partial class BusinessesRegistrationViewModel : BaseViewModel
{

    public BusinessesRegistrationViewModel()
    {
        this.authService     = Store.ServicesStore.AuthService;
        this.fileService     = Store.ServicesStore.FileService;
        this.businessService = Store.ServicesStore.BusinessService;
        Business.Info = new();
        Business.Info.Location = new();
        Business.Info.Contact = new();
    }

    private readonly AuthService authService;
    private readonly BusinessService businessService;
    private readonly FileService fileService;
    private Auth auto;

    public Business Business { get; } = new();


    [ObservableProperty]
    private String email = "";

    [ObservableProperty]
    private String password1 = "";

    [ObservableProperty]
    private String password2 = "";


    [ObservableProperty]
    private String imageUrl = "";


    [ObservableProperty]
    private bool isLogoVisible = false;

    [ObservableProperty]
    private Boolean isRegistrationButtonEnabled = false;


    [ICommand]
    async Task OnRegistrationClick()
    {
        try
        {
            IsLoading = true;
            await this.UploadAndSetImage();
            var auth = await authService.Register(Email, Password1, "business");
            Business.Id = auth.Business.Id;
            auth.Business = await businessService.UpdateBusiness(Business);
            IsLoading = false;

            Store.Auth = auth;
            Application.Current.MainPage = new MobileAdminShell();
        }
        catch (Exception err)
        {
            IsLoading = false;
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
                IsLogoVisible = true;
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
        if (ImageUrl == "")
        {
            Business.ImageUrl = imageUrl;
        }
        else
        {
            var url = await fileService.UploadImage(imageUrl);
            Business.ImageUrl = url;
        }
    }

    void Validation()
    {
        isRegistrationButtonEnabled = ((Business.Name != String.Empty) && (Email != String.Empty)
            && (Password1 != String.Empty) && (Password2 != String.Empty) && (Business.Info.Location.Street != String.Empty)
            && (Business.Info.Location.City != String.Empty) && (Business.Info.Description != String.Empty));
    }

    protected override void OnPropertyChanged(PropertyChangedEventArgs e)
    {
        base.OnPropertyChanged(e);
        Validation();
    }
}
