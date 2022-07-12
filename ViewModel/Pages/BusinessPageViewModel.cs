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
        this.posts = new[] { new Post(new PostResponse()), new Post(new PostResponse()), new Post(new PostResponse()), new Post(new PostResponse()) };
    }

    [ObservableProperty]
    public Business business;

    [ObservableProperty]
    public Post[] posts;

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
}
