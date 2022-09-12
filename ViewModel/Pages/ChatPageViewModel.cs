namespace BizClient.ViewModel;

public partial class ChatPageViewModel : BaseViewModel
{
    public ChatPageViewModel(Chat chat)
    {
        this.chatService = Store.ServicesStore.ChatService;
        this.chat = chat;
        initPage();

        MessagingCenter.Subscribe<SignalRConnector, Message>(this, "newMessage", (sender, _) => Messages.Add(_));
    }

    private readonly ChatService chatService;
    private Chat chat;

    public ObservableCollection<Message> Messages { get; } = new();

    [ObservableProperty]
    public string inputText;

    [ObservableProperty]
    public bool isBusiness = Store.IsBusiness;

    [ICommand]
    public async void SendMessage(string messageContent)
    {
        IsLoading = true;
        Message message;
        var sendToId = Store.IsUser ? chat.Business.Id : chat.User.Id;

        InputText = String.Empty;

        if (Store.IsBusiness)
        {
            message = await chatService.PostChatMessages(Store.Auth.Business.Id, "business", chat.Id, messageContent);
        }
        else
        {
            message = await chatService.PostChatMessages(Store.Auth.User.Id, "user", chat.Id, messageContent);
        }
        Messages.Add(message);
        IsLoading = false;
    }

    public async void SetStatus(string status)
    {
        IsLoading = true;
        chat.Status = status;
        await chatService.UpdateChat(chat);
        IsLoading = false;
    }

    private async void initPage()
    {
        IsLoading = true;
        var messages = await chatService.GetChatMessages(chat);
        messages.ForEach(_ => Messages.Add(_));
        IsLoading = false;
    }
}

