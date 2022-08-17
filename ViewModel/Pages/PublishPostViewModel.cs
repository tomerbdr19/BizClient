namespace BizClient.ViewModel;

public partial class PublishPostViewModel : BaseViewModel
{
    public PublishPostViewModel()
    {
        postService = Store.ServicesStore.PostService;
        publishPost = new();
        publishPost.Business = new();
        publishPost.Business.Id = Store.Auth.Business.Id;
    }

    [ObservableProperty]
    private Post publishPost;

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



    [ICommand]
    async Task OnPublishClick()
    {
        PublishPost.CreatedAt = DateTime.Now;
        // PublishPost.Business = Store.Auth.Business;
        if (ImageUrl != null)
        {
            //TODO add image to the post
        }
        var post = await postService.PublishPost(PublishPost);
    }
}
