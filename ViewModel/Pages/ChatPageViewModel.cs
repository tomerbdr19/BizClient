namespace BizClient.ViewModel;

public partial class ChatPageViewModel : BaseViewModel
{
    public ChatPageViewModel(string otherParticipantId, ChatService chatService)
    {
        this.chatService = chatService;
        initPageWithOtherParticipantId(otherParticipantId);
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

    private async void initPageWithOtherParticipantId(string otherId)
    {
        chat = await chatService.GetChatByParticipateId(otherId);
        var messagesResponse = await chatService.GetChatMessages(chat.Id);

        messagesResponse.ForEach(_ => Messages.Add(_));
    }

    private async void initPageWithChatId(string chatId)
    {
        chat = await chatService.GetChatById(chatId);
        var messagesResponse = await chatService.GetChatMessages(chat.Id);

        messagesResponse.ForEach(_ => Messages.Add(_));
    }
}

