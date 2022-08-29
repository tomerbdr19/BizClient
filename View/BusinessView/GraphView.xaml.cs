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

    public static readonly BindableProperty DataProperty =
                       BindableProperty.Create(nameof(Data),
                                              typeof(List<ChartData>),
                                              typeof(GraphView));

    public List<ChartData> Data
    {
        get { return (List<ChartData>)GetValue(DataProperty); }
        set { SetValue(DataProperty, value); }
    }

    public static readonly BindableProperty IsLoadingProperty =
                       BindableProperty.Create(nameof(IsLoading),
                                              typeof(bool),
                                              typeof(GraphView));

    public static readonly BindableProperty IsNotLoadingProperty =
                       BindableProperty.Create(nameof(IsNotLoading),
                                              typeof(bool),
                                              typeof(GraphView));

    public bool IsLoading
    {
        get { return (bool)GetValue(IsLoadingProperty); }
        set
        {
            SetValue(IsLoadingProperty, value);
        }
    }

    public bool IsNotLoading
    {
        get { return (bool)GetValue(IsNotLoadingProperty); }
        set
        {
            SetValue(IsNotLoadingProperty, value);
        }
    }
}
