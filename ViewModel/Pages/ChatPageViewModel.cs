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

//<<<<<<< ActivityIndicator
//    private async void initPageWithOtherParticipantId(string otherId)
//    {
//        IsLoading = true;
//        chat = await chatService.GetChatByParticipantsIds(Store.UserId, otherId);
//        var messagesResponse = await chatService.GetChatMessages(chat.Id);
//        IsLoading = false;

//        messagesResponse.ForEach(_ => Messages.Add(_));
//    }

//    private async void initPageWithChatId(string chatId)
//=======
    private async void initPage()
//>>>>>>> master
    {
        IsLoading = true;
        var messages = await chatService.GetChatMessages(chat);
        messages.ForEach(_ => Messages.Add(_));
        IsLoading = false;
    }
}

