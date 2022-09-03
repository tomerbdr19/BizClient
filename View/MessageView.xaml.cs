namespace BizClient.View;

public partial class MessageView
{
    public MessageView()
    {
        InitializeComponent();
        IsSelfUser = Store.IsUser;
        IsSelfBusiness = Store.IsBusiness;
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

    public static readonly BindableProperty IsSelfUserProperty =
                       BindableProperty.Create(nameof(IsSelfUser),
                                              typeof(bool),
                                              typeof(MessageView));

    public bool IsSelfUser
    {
        get { return (bool)GetValue(IsSelfUserProperty); }
        set { SetValue(IsSelfUserProperty, value); }
    }

    public static readonly BindableProperty IsSelfBusinessProperty =
                   BindableProperty.Create(nameof(IsSelfBusiness),
                                          typeof(bool),
                                          typeof(MessageView));

    public bool IsSelfBusiness
    {
        get { return (bool)GetValue(IsSelfBusinessProperty); }
        set { SetValue(IsSelfBusinessProperty, value); }
    }
}
