namespace BizClient.View;

public partial class PublishPostView
{
    public PublishPostView()
    {
        InitializeComponent();
    }


    //[ObservableProperty]
    //private ImageSource image;

    public static readonly BindableProperty PostProperty =
    BindableProperty.Create(
        nameof(Post),
        typeof(Post),
        typeof(PublishPostView));

    public Post Post
    {
        get { return (Post)GetValue(PostProperty); }
        set { SetValue(PostProperty, value); }
    }

    async void OnAddPictureClick(System.Object sender, System.EventArgs e)
    {
        //var result = await FilePicker.PickAsync();
        //if (result != null)
        //{
        //    if (result.FileName.EndsWith("jpg", StringComparison.OrdinalIgnoreCase) ||
        //        result.FileName.EndsWith("jpeg", StringComparison.OrdinalIgnoreCase) ||
        //        result.FileName.EndsWith("png", StringComparison.OrdinalIgnoreCase))
        //    {
        //        var stream = await result.OpenReadAsync();
        //        Image = ImageSource.FromStream(() => stream);
        //    }
        //    else
        //    {
        //        //TODO hnadle ERROR 
        //    }
        //}
        //else
        //{
        //    //TODO hnadle ERROR 
        //}
    }


    async void OnPublishClick(System.Object sender, System.EventArgs e)
    {
        //TODO
    }

}