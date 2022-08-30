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


    public static readonly BindableProperty DataProperty =
    BindableProperty.Create(
    nameof(Data),
    typeof(Statistic),
    typeof(GraphView),
    new Statistic());

    public Statistic Data
    {
        get { return (Statistic)GetValue(DataProperty); }
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
