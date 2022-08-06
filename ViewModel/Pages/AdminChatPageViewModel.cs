namespace BizClient.ViewModel;

public partial class AdminChatPageViewModel : BaseViewModel
{
    public AdminChatPageViewModel(string otherParticipantId)
    {
        this.chatService = Store.ServicesStore.ChatService;
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
        //TODO
    }

    private async void initPageWithOtherParticipantId(string otherId)
    {
        chat = await chatService.GetChatByParticipantsIds(Store.Auth.Business.Id, otherId);
        var messagesResponse = await chatService.GetChatMessages(chat.Id);

        messagesResponse.ForEach(_ => Messages.Add(_));
    }
}

