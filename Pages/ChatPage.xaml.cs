namespace BizClient.Pages;

[QueryProperty(nameof(OtherId), "otherId")]
public partial class ChatPage : ContentPage
{
    public ChatPage(ChatService chatService)
    {
        this.chatService = chatService;
        InitializeComponent();
    }

    private readonly ChatService chatService;
    
    private string otherId;
    public string OtherId
    {
        set
        {
            BindingContext = new ChatPageViewModel(value, chatService);
        }
    }
}
