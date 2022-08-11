namespace BizClient.Pages;

[QueryProperty(nameof(Chat), "Chat")]
public partial class ChatPage : ContentPage
{
    public ChatPage()
    {
        InitializeComponent();
    }

    public Chat Chat
    {
        set
        {
            BindingContext = new ChatPageViewModel(value);
        }
    }
}
