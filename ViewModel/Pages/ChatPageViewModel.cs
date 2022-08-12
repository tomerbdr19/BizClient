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
        chat = await chatService.GetChatByParticipantsIds(Store.UserId, otherId);
        var messagesResponse = await chatService.GetChatMessages(chat.Id);

        messagesResponse.ForEach(_ => Messages.Add(_));
    }

    private async void initPageWithChatId(string chatId)
    {
    }
}

