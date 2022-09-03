namespace BizClient.View;

public partial class ChatView
{
	public ChatView()
	{
		InitializeComponent();
        statusMsg.IsVisible = Store.IsBusiness;
    }

    public static readonly BindableProperty ChatProperty =
    BindableProperty.Create(nameof(Chat), typeof(Chat), typeof(ChatView), default(Chat));

    public Chat Chat
    {
        get { return (Chat)GetValue(ChatProperty); }
        set { SetValue(ChatProperty, value); }
    }

    [ICommand]
    async Task GoToChat()
    {
        if (Chat == null)
            return;

        await Shell.Current.GoToAsync(Routes.Chat, true, new Dictionary<string, object>
        {
            {"Chat", Chat}
        });
    }
}