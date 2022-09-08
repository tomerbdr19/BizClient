namespace BizClient.View;

public partial class ChatView
{
    public ChatView()
    {
        InitializeComponent();
        statusMsg.IsVisible = Store.IsBusiness;
        IsSelfUser = Store.IsUser;
    }

    public static readonly BindableProperty ChatProperty =
    BindableProperty.Create(nameof(Chat), typeof(Chat), typeof(ChatView), default(Chat));

    public Chat Chat
    {
        get { return (Chat)GetValue(ChatProperty); }
        set { SetValue(ChatProperty, value); }
    }

    public static readonly BindableProperty IsSelfUserProperty =
                     BindableProperty.Create(nameof(IsSelfUser),
                                            typeof(bool),
                                            typeof(MessageView));

    public bool IsSelfUser
    {
        get { return (bool)GetValue(IsSelfUserProperty); }
        set { SetValue(IsSelfUserProperty, value); }
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