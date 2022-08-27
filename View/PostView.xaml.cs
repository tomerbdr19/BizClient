namespace BizClient.View;

public partial class PostView
{

    public PostView()
    {
        InitializeComponent();
        postService = Store.ServicesStore.PostService;
        deleteButton.IsVisible = Store.IsBusiness;
    }

    private readonly PostService postService;

    public static readonly BindableProperty PostProperty =
        BindableProperty.Create(nameof(Post), typeof(Post), typeof(PostView), default(Post));

    public Post Post
    {
        get { return (Post)GetValue(PostProperty); }
        set { SetValue(PostProperty, value); }
    }

    [ICommand]
    async Task OnDeleteClick()
    {
        var IsConfirmed = await Shell.Current.DisplayAlert("Delete confirmation", "Please confirm the delete", "Confirm", "Cancel");
        if(IsConfirmed)
        {
            await postService.DeletePost(Post.Id);
        }
    }
}
