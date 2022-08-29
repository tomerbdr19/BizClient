namespace BizClient.View;

public partial class MessageView
{
    public MessageView()
    {
        InitializeComponent();
    }

    public static readonly BindableProperty MessageProperty =
    BindableProperty.Create(
    nameof(Message),
    typeof(Message),
    typeof(MessageView));

    public Message Message
    {
        get { return (Message)GetValue(MessageProperty); }
        set
        {
            SetValue(MessageProperty, value);
        }
    }
}
