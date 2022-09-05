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




    async public void OnAppearing()
    {
        Chats.Clear();
        resetFilters();
        await OnApplyFilters();
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
        StatusFilter = new() { Key = "status", Options = new List<string> { "new", "in-progress", "resolved" } , Value = null };

        filters.Add(StatusFilter);

        filters.ForEach((_) => _.IsChecked = false);
    }

    [ICommand]
    public async Task OnApplyFilters()
    {
        Chats.Clear();
        this.IsLoading = true;
        List<Chat> chats = new();
        string status = StatusFilter.IsChecked ? StatusFilter.Value : null;
        if (Store.IsBusiness)
        {
            chats = await this.chatService.GetAllChats(Store.Auth.Business, status);
        }
        else
        {
            chats = await this.chatService.GetAllChats(Store.Auth.User, status);
        }
        chats.ForEach(_ => Chats.Add(_));
        this.IsLoading = false;
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
