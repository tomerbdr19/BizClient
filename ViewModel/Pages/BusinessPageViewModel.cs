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

        initPage();
    }
    private readonly PostService postService;
    private readonly BusinessService businessService;

    private async void initPage()
    {
        this.Business = await businessService.GetBusinessById(this.Business.Id);
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
