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

    void OnViewClick(Object sender, EventArgs e)
    {

    }
}
