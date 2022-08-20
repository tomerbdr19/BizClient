using System;
namespace BizClient.View;

public partial class SubscriberView
{
    public SubscriberView()
    {
        InitializeComponent();
    }

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

    void OnViewClick(Object sender, EventArgs e)
    {

    }
}
