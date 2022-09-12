using BizService.Services;

namespace BizClient.ViewModel;


public partial class PublishProductViewModel : BaseViewModel
{
    public PublishProductViewModel()
    {
        this.businessService = Store.ServicesStore.BusinessService;
        fileService = Store.ServicesStore.FileService;
    }

    [ObservableProperty]
    private Product publishProduct = new();

    [ObservableProperty]
    private String imageUrl;

    [ObservableProperty]
    private bool isVisible = false;

    private readonly BusinessService businessService;
    private readonly FileService fileService;

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
                IsVisible = true;
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
        if (imageUrl != String.Empty && imageUrl != null)
        {
            var url = await fileService.UploadImage(imageUrl);
            publishProduct.ImageUrl = url;
        }
    }

    [ICommand]
    async Task OnPublishClick()
    {
        this.IsLoading = true;
        await this.UploadAndSetImage();
        var product = await businessService.AddProduct(Store.BusinessId, publishProduct.Name, publishProduct.ImageUrl, publishProduct.Price);
        publishProduct = new();
        ImageUrl = "";
        IsVisible = false;
        this.IsLoading = false;
    }

    [ICommand]
    public void OnCancelEdit()
    {
        ImageUrl = "";
        IsVisible = false;
    }

}

