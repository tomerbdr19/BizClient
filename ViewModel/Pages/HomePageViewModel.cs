namespace BizClient.ViewModel;

public partial class HomePageViewModel : BaseViewModel
{

    public HomePageViewModel()
    {
        this.postService = Store.ServicesStore.PostService;
    }

    private readonly PostService postService;
    public ObservableCollection<Post> Posts { get; } = new();



    async public void OnAppearing()
    {
        Posts.Clear();
        this.IsLoading = true;
        var posts = await this.postService.GetUserRecentPosts(Store.Auth.User.Id);
        posts.ForEach(_ => Posts.Add(_));
        this.IsLoading = false;
    }


    protected override void OnPropertyChanged(PropertyChangedEventArgs e)
    {
        base.OnPropertyChanged(e);
    }
}