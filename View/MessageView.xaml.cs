namespace BizClient.View;

public partial class MessageView
{
    public MessageView()
    {
        InitializeComponent();
    }


    public static readonly BindableProperty SenderNameProperty =
    BindableProperty.Create(
    nameof(SenderName),
    typeof(string),
    typeof(MessageView));

    public string SenderName
    {
        get { return (string)GetValue(SenderNameProperty); }
        set { SetValue(SenderNameProperty, value); }
    }

    public static readonly BindableProperty SenderImageUrlProperty =
    BindableProperty.Create(
    nameof(SenderImageUrl),
    typeof(string),
    typeof(MessageView));

    public string SenderImageUrl
    {
        get { return (string)GetValue(SenderImageUrlProperty); }
        set { SetValue(SenderImageUrlProperty, value); }
    }

    public static readonly BindableProperty MessageContentProperty =
    BindableProperty.Create(
    nameof(MessageContent),
    typeof(string),
    typeof(MessageView));

    public string MessageContent
    {
        get { return (string)GetValue(MessageContentProperty); }
        set { SetValue(MessageContentProperty, value); }
    }

    public static readonly BindableProperty CreatedAtProperty =
    BindableProperty.Create(
    nameof(CreatedAt),
    typeof(DateTime),
    typeof(MessageView));

    public DateTime CreatedAt
    {
        get { return (DateTime)GetValue(CreatedAtProperty); }
        set { SetValue(CreatedAtProperty, value); }
    }

}
