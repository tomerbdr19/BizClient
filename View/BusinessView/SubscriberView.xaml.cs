using System;
namespace BizClient.View;

public partial class SubscriberView
{
    public SubscriberView()
    {
        InitializeComponent();
        this.chatService = Store.ServicesStore.ChatService;
    }

    private readonly ChatService chatService;

    public static readonly BindableProperty SubscriptionProperty =
        BindableProperty.Create(
        nameof(Subscription),
        typeof(Subscription),
        typeof(GraphView));

    public Subscription Subscription
    {
        get { return (Subscription)GetValue(SubscriptionProperty); }
        set { SetValue(SubscriptionProperty, value); }
    }

    public int Age => DateHelper.GetAge(Subscription.User.Info.BirthDate);
    public string SubscriptionPeriod => DateHelper.GetStringPeriod(Subscription.CreatedAt);
    public string LastActivity => Subscription.Activity.LastRedeemed != null ? Subscription.Activity.LastRedeemed.ToString() : "Not yet.";

    async void OnMessageClick(Object sender, EventArgs e)
    {
        Chat chat = await chatService.GetChatByParticipants(Subscription.User, Subscription.Business);

        if (chat == null)
            return;

        await Shell.Current.GoToAsync(Routes.Chat, true, new Dictionary<string, object>
        {
            {"Chat", chat}
        });
    }
}
