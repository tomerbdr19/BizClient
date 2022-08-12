namespace BizClient.View;

public partial class ActivityIndicatorView
{
	public ActivityIndicatorView()
	{
		InitializeComponent();
	}

	public static readonly BindableProperty IsLoadingProperty =
    BindableProperty.Create(
    nameof(IsLoading),
    typeof(bool),
    typeof(ActivityIndicatorView));

    public bool IsLoading
    {
        get { return (bool)GetValue(IsLoadingProperty); }
        set { SetValue(IsLoadingProperty, value); }
    }
}