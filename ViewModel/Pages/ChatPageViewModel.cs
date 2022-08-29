namespace BizClient.ViewModel;

public partial class ChatPageViewModel : BaseViewModel
{
    public ChatPageViewModel(Chat chat)
    {
        this.chatService = Store.ServicesStore.ChatService;
        this.chat = chat;
        initPage();
    }

    private readonly ChatService chatService;
    private Chat chat;

    public ObservableCollection<Message> Messages { get; } = new();

    [ObservableProperty]
    public string inputText;

    [ICommand]
    public void OnSendClick()
    {

    }

    private async void initPage()
    {
        IsLoading = true;
        var messages = await chatService.GetChatMessages(chat);
        messages.ForEach(_ => Messages.Add(_));
        IsLoading = false;
    }

    async public void OnDisappearing(string status) 
    {
        //TODO post new status
    }
}

