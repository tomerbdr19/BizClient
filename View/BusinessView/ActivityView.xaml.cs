using SkiaSharp;
using Syncfusion.Maui.Charts;
namespace BizClient.View;

public partial class ActivityView
{
    public ActivityView()
    {
        InitializeComponent();
    }

    public static readonly BindableProperty TitleProperty =
    BindableProperty.Create(
    nameof(Title),
    typeof(string),
    typeof(ActivityView));

    public string Title
    {
        get { return (string)GetValue(TitleProperty); }
        set { SetValue(TitleProperty, value); }
    }


    public static readonly BindableProperty DataProperty =
    BindableProperty.Create(
    nameof(Data),
    typeof(List<ChartData>),
    typeof(ActivityView),
    new List<ChartData>(),
    propertyChanged: OnDataChanged);

    public List<ChartData> Data
    {
        get { return (List<ChartData>)GetValue(DataProperty); }
        set
        {
            SetValue(DataProperty, value);
        }
    }

    private static void OnDataChanged(BindableObject sender, object oldValue, object newValue)
    {
        var bindable = (ActivityView)sender;
        var data = newValue as List<ChartData>;

        if (data != null && data.Count > 0)
        {
            var list = new List<Brush>();
            data.ForEach((_) => list.Add(GetColor(_.Label)));
            bindable.Chart.PaletteBrushes = list;
        }
    }

    private static Color GetColor(string label)
    {

        switch (label)
        {
            case ("active"):
            case ("resolved"):
            case ("redeemed"):
                return Color.FromHex("#69B34C");
            case ("expired"):
            case ("in-progress"):
            case ("available"):
                return Color.FromHex("#FAB733");
            case ("new"):
                return Color.FromHex("#FF0D0D");
            default:
                return Color.FromHex("#000000");
        }
    }


    public static readonly BindableProperty IsLoadingProperty =
                       BindableProperty.Create(nameof(IsLoading),
                                              typeof(bool),
                                              typeof(ActivityView));

    public static readonly BindableProperty IsNotLoadingProperty =
                       BindableProperty.Create(nameof(IsNotLoading),
                                              typeof(bool),
                                              typeof(ActivityView));

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
