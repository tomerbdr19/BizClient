namespace BizClient.ViewModel;

public partial class ChatPageViewModel : BaseViewModel
{
    public ChatPageViewModel(string otherParticipantId)
    {
        this.chatService = Store.ServicesStore.ChatService;
        initPageWithOtherParticipantId(otherParticipantId);
    }

    public ActivityIndicator activityIndicator = new ActivityIndicator();

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
        IsLoading = true;
        chat = await chatService.GetChatByParticipantsIds(Store.UserId, otherId);
        var messagesResponse = await chatService.GetChatMessages(chat.Id);
        IsLoading = false;

        messagesResponse.ForEach(_ => Messages.Add(_));
    }

    private async void initPageWithChatId(string chatId)
    {
    }
}

