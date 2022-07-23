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
        this.posts = new Collection<Post>();
        foreach (Post post in Mocks.posts)
        {
            if (post.BusinessName == business.Name)
                this.posts.Add(post);
        }
    }

    [ObservableProperty]
    public Business business;

    [ObservableProperty]
    public Collection<Post> posts;

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
