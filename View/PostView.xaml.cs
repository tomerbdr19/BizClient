namespace BizClient.View;

public partial class PostView
{

    public PostView()
    {
        InitializeComponent();
    }

    public static readonly BindableProperty PostProperty =
        BindableProperty.Create(nameof(Post), typeof(Post), typeof(PostView), default(Post));

    public Post Post
    {
        get { return (Post)GetValue(PostProperty); }
        set { SetValue(PostProperty, value); }
    }
}
