namespace BizClient.View;

public partial class SubscribesListView 
{
	public SubscribesListView()
	{
		InitializeComponent();
	}

	public static readonly BindableProperty SubscribeNameProperty =
    BindableProperty.Create(
    nameof(SubscribeName),
    typeof(string),
    typeof(SubscribesListView));

    public string SubscribeName
    {
        get { return (string)GetValue(SubscribeNameProperty); }
        set { SetValue(SubscribeNameProperty, value); }
    }

}