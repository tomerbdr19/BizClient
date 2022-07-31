namespace BizClient.ViewModel;

public partial class ChatPageViewModel : BaseViewModel
{
    public ChatPageViewModel(string otherId, ChatService chatService)
    {
        this.chatService = chatService;
        initChat(otherId);
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

    private async void initChat(string otherId) {
        chat = chatService.GetChatByParticipateId(otherId);
        var messagesResponse = await chatService.GetChatMessages(chat.Id);

        messagesResponse.ForEach(_ => Messages.Add(_));
    }
}

