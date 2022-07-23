namespace BizClient.ViewModel;

public partial class HomePageViewModel : BaseViewModel
{

    public HomePageViewModel(PostService postService)
    {
        this.postService = postService;
        initPage();
    }

    private readonly PostService postService;
    public ObservableCollection<Post> Posts { get; } = new();

    async private void initPage()
    {
        var posts = await this.postService.GetUserRecentPosts();
        posts.ForEach(_ => Posts.Add(_));
    }


    protected override void OnPropertyChanged(PropertyChangedEventArgs e)
    {
        base.OnPropertyChanged(e);
    }
}