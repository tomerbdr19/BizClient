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
        this.subscriptionService = Store.ServicesStore.SubscriptionService;
        this.chatService = Store.ServicesStore.ChatService;
        initPage();
    }

    async public void initPage()
    {
        IsLoading = true;
        this.subscription = await this.subscriptionService.getSubscription(Store.UserId, Business.Id);
        this.IsSubscribed = this.subscription != null;
        IsLoading = false;
    }

    private readonly PostService postService;
    private readonly BusinessService businessService;
    private readonly SubscriptionService subscriptionService;
    private readonly ChatService chatService;
    public Subscription subscription;

    [ObservableProperty]
    public Business business;

    [ObservableProperty]
    public bool isSubscribed;

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
        var chat = await chatService.GetChatByParticipants(Store.Auth.User, Business);
        await Shell.Current.GoToAsync(Routes.Chat, true, new Dictionary<string, object>
        {
            {"Chat", chat}
        });
    }

    [ICommand]
    public async void OnSubscriptionClick()
    {
        if (IsSubscribed)
        {
            await this.subscriptionService.Unsubscribe(this.subscription);
            this.IsSubscribed = false;
        }
        else
        {
            subscription = await this.subscriptionService.Subscribe(new Subscription { Business = this.Business, User = Store.Auth.User });
            this.IsSubscribed = true;
        }
    }
}
