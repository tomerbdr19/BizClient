namespace BizClient.View;

public partial class GraphView
{
    public GraphView()
    {
        InitializeComponent();
    }

    public static readonly BindableProperty TitleProperty =
    BindableProperty.Create(
    nameof(Title),
    typeof(string),
    typeof(GraphView));

    public string Title
    {
        get { return (string)GetValue(TitleProperty); }
        set { SetValue(TitleProperty, value); }
    }


    public static readonly BindableProperty DescriptionProperty =
    BindableProperty.Create(
    nameof(Description),
    typeof(string),
    typeof(GraphView));

    public string Description
    {
        get { return (string)GetValue(DescriptionProperty); }
        set { SetValue(DescriptionProperty, value); }
    }
}
