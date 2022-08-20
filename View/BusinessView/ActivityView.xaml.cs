namespace BizClient.View;

public partial class ActivityView
{
    public ActivityView()
    {
        InitializeComponent();
    }

    public static readonly BindableProperty DescriptionProperty =
                            BindableProperty.Create(
                            nameof(Description),
                            typeof(string),
                            typeof(ActivityView));

    public string Description
    {
        get { return (string)GetValue(DescriptionProperty); }
        set { SetValue(DescriptionProperty, value); }
    }
}
