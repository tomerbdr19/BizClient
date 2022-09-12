namespace BizClient.ViewModel;

public partial class PublishDiscountDesktopViewModel : BaseViewModel
{
    public PublishDiscountDesktopViewModel()
    {

        fileService = Store.ServicesStore.FileService;
        discountService = Store.ServicesStore.DiscountService;
    }

    [ObservableProperty]
    private Discount publishDiscount = new() { ExpiredAt = DateTime.Now.AddMonths(3) };

    [ObservableProperty]
    private String imageUrl;

    [ObservableProperty]
    private bool isVisible = false;

    [ObservableProperty]
    private bool sendToAllSubscribers;

    [ObservableProperty]
    private DateTime minDate = DateTime.Today;

    private readonly DiscountService discountService;
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
            PublishDiscount.ImageUrl = url;
        }
    }

    public Action<Discount> OnPublishSuccess { get; set; }


    [ICommand]
    async Task OnPublishClick()
    {
        this.IsLoading = true;
        await this.UploadAndSetImage();
        PublishDiscount.Business = Store.Auth.Business;
        var discount = await discountService.CreateDiscount(PublishDiscount, SendToAllSubscribers);
        OnPublishSuccess?.Invoke(discount);
        PublishDiscount = new();
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

