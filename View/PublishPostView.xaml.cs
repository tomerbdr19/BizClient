namespace BizClient.View;

public partial class PublishPostView
{
	public PublishPostView()
	{
		InitializeComponent();

        this.postService = Store.ServicesStore.PostService;
    }

    private ImageSource image = null;
    public Post PublishPost { get; } = new();

    private readonly PostService postService;

    async void OnAddPictureClick(System.Object sender, System.EventArgs e)
    {
        var result = await FilePicker.PickAsync();
        if (result != null)
        {
            if (result.FileName.EndsWith("jpg", StringComparison.OrdinalIgnoreCase) ||
                result.FileName.EndsWith("jpeg", StringComparison.OrdinalIgnoreCase) ||
                result.FileName.EndsWith("png", StringComparison.OrdinalIgnoreCase))
            {
                var stream = await result.OpenReadAsync();
                image = ImageSource.FromStream(() => stream);
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

    async void OnPublishClick(System.Object sender, System.EventArgs e)
    {
        PublishPost.CreatedAt = DateTime.Now;
       // PublishPost.Business = Store.Auth.Business;
       if(image != null)
        {
            //TODO add image to the post
        }
        var post = await postService.PublishPost(PublishPost);
    }
}