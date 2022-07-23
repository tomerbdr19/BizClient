namespace BizClient.ViewModel;

public partial class BusinessPageViewModel : BaseViewModel
{

    public enum BusinessPageTabs
    {
        Info,
        Posts
    }

    public BusinessPageViewModel(Business business, PostService postService)
    {
        this.Business = business;
        this.postService = postService;

        initPage();
    }
    private readonly PostService postService;

    private async void initPage()
    {
        var businessPosts = await postService.GetBusinessPosts(Business.Id);
        businessPosts.ForEach(_ => Posts.Add(_));
    }

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
    public void OnPostsClick()
    {
        IsInfo = false;
        IsPosts = true;
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
