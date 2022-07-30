namespace BizClient.Pages;

[QueryProperty(nameof(OtherId), "otherId")]
public partial class ChatPage : ContentPage
{
    public ChatPage()
    {
        InitializeComponent();
    }

    private string otherId;
    public string OtherId
    {
        set
        {
            BindingContext = new ChatPageViewModel(value);
        }
    }
}
