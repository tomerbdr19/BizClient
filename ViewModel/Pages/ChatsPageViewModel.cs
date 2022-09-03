namespace BizClient.ViewModel;

public partial class ChatsPageViewModel : BaseViewModel
{
    public ChatsPageViewModel()
    {
        this.chatService = Store.ServicesStore.ChatService;
    }

    private readonly ChatService chatService;
    public ObservableCollection<Chat> Chats { get; } = new();

    private List<IFilter> filters = new();

    [ObservableProperty]
    public OptionsFilter<string> statusFilter;

    [ObservableProperty]
    public RangeFilter<DateTime> updateDateFilter;


    async public void OnAppearing()
    {
        Chats.Clear();
        resetFilters();
        await OnApplyFilters();
        this.IsLoading = true;
        List<Chat> chats = new();
        if (Store.IsBusiness)
        {
            chats = await this.chatService.GetAllChats(Store.Auth.Business);
        }
        else
        {
            chats = await this.chatService.GetAllChats(Store.Auth.User);
        }
        chats.ForEach(_ => Chats.Add(_));
        this.IsLoading = false;
    }

    [ICommand]
    async Task GoToChat(Chat chat)
    {
        if (chat == null)
            return;

        await Shell.Current.GoToAsync(Routes.Chat, true, new Dictionary<string, object>
        {
            {"Chat", chat}
        });
    }

    private void resetFilters()
    {
        statusFilter = new() { Key = "status", Options = new List<string> { "new", "in-progress", "resolved" } };
        updateDateFilter = new() { Key = "createdAt", From = DateTime.Today, To = DateTime.Today };

        filters.Add(StatusFilter);
        filters.Add(UpdateDateFilter);

        filters.ForEach((_) => _.IsChecked = false);
    }

    [ICommand]
    public async Task OnApplyFilters()
    {
        Chats.Clear();

        //IsLoading = true;
        //List<Chat> chats = new();
        //if (Store.IsBusiness)
        //{
        //    chats = await this.chatService.GetAllChats(Store.Auth.Business);
        //}
        //else
        //{
        //    chats = await this.chatService.GetAllChats(Store.Auth.User);
        //}
        //var subscriptions = await this.subscriptionService.GetFilteredSubscriptions("62dea60742831efed2e07c7a", filters.FindAll((_) => _.IsChecked == true));
        //subscriptions.ForEach((_) => Subscriptions.Add(_));
        //IsLoading = false;

    }

    [ICommand]
    public async Task OnResetClick()
    {
        resetFilters();
        await OnApplyFilters();
    }


    protected override void OnPropertyChanged(PropertyChangedEventArgs e)
    {
        base.OnPropertyChanged(e);
    }
}
