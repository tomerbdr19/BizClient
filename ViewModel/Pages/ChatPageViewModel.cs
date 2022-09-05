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

    public async void sendMessage(string messageContent)
    {
        IsLoading = true;
        if(Store.IsBusiness)
        {
            await chatService.PostChatMessages(Store.Auth.Business.Id, "business", chat.Id, messageContent);
        }
        else
        {
            await chatService.PostChatMessages(Store.Auth.User.Id, "user", chat.Id, messageContent);
        }
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

