namespace BizClient.ViewModel;

public partial class PublishPostViewModel : BaseViewModel
{
    public PublishPostViewModel()
    {
        postService = Store.ServicesStore.PostService;
    }

    [ObservableProperty]
    private Post publishPost = new();

    [ObservableProperty]
    private String imageUrl;

    [ObservableProperty]
    private bool isVisible = false;

    private readonly PostService postService;


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
        // TODO: implement
        return;
    }

    public Action<Post> OnPublishSuccess { get; set; }

    [ICommand]
    async Task OnPublishClick()
    {
        this.IsLoading = true;
        await this.UploadAndSetImage();
        PublishPost.Business = Store.Auth.Business;
        var post = await postService.PublishPost(PublishPost);
        OnPublishSuccess.Invoke(post);
        PublishPost = new();
        this.IsLoading = false;
    }
}
