

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
            viewModel = new ChatPageViewModel(value);
            BindingContext = viewModel;
        }
    }

    private ChatPageViewModel viewModel { get; set; }

    [ICommand]
    public void OnSendClick()
    {
        viewModel.sendMessage(messageContent.Text);
    }

    [ICommand]
    async Task SetStatusClick()
    {
        var selectedIndex = picker.SelectedIndex;
        if (selectedIndex != -1)
        {
            var status = (string)picker.ItemsSource[selectedIndex];
            viewModel.SetStatus(status);
        }
    }

}
