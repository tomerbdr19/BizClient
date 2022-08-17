namespace BizClient.ViewModel;

public partial class AdminHomePageViewModel : BaseViewModel
{
    public AdminHomePageViewModel()
    {
        this.postService = Store.ServicesStore.PostService;
    }

    private readonly PostService postService;
    public ObservableCollection<Post> Posts { get; } = new();



    async public void OnAppearing()
    {
        Posts.Clear();
        this.IsLoading = true;
        //var posts = await this.postService.GetBusinessPosts(Store.Auth.Business.Id);
        var posts = await this.postService.GetBusinessPosts("62dea60742831efed2e07c7a");
        posts.ForEach(_ => Posts.Add(_));
        this.IsLoading = false;
    }


    protected override void OnPropertyChanged(PropertyChangedEventArgs e)
    {
        base.OnPropertyChanged(e);
    }
}

