namespace BizClient.ViewModel;

public partial class BusinessPageViewModel : BaseViewModel
{

    public enum BusinessPageTabs
    {
        Info,
        Posts
    }

    public BusinessPageViewModel(Business business)
    {
        this.Business = business;
        this.postService = Store.ServicesStore.PostService;
        this.businessService = Store.ServicesStore.BusinessService;
    }

    private readonly PostService postService;
    private readonly BusinessService businessService;

    [ObservableProperty]
    public Business business;

    public ObservableCollection<Post> Posts { get; } = new();

    [ObservableProperty]
    [AlsoNotifyChangeFor(nameof(IsPosts))]
    public bool isInfo = true;

    [ObservableProperty]
    [AlsoNotifyChangeFor(nameof(IsInfo))]
    public bool isPosts = false;

    [ICommand]
    public void OnInfoClick()
    {
        IsInfo = true;
        IsPosts = false;

    }

    [ICommand]
    async public void OnPostsClick()
    {
        IsInfo = false;
        IsPosts = true;

        Posts.Clear();

        this.IsLoading = true;
        var posts = await this.postService.GetBusinessPosts(business.Id);
        posts.ForEach(_ => Posts.Add(_));
        this.IsLoading = false;
    }

    [ICommand]
    public async void OnMessageClick()
    {
        await Shell.Current.GoToAsync(Routes.Chat, true, new Dictionary<string, object>
        {
            {"otherId", Business.Id}
        });
    }
}
