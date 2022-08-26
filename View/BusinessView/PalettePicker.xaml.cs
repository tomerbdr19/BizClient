namespace BizClient.View;

public partial class PalettePicker : Frame
{
    public PalettePicker()
    {
        InitializeComponent();
    }

    public static readonly BindableProperty SelectedProperty =
                       BindableProperty.Create(nameof(Selected),
                                              typeof(Palette),
                                              typeof(PalettePicker));

    public Palette Selected
    {
        get { return (Palette)GetValue(SelectedProperty); }
        set { SetValue(SelectedProperty, value); }
    }

    public static readonly BindableProperty OnApplyClickProperty =
                       BindableProperty.Create(nameof(OnApplyClick),
                                              typeof(Action<Palette>),
                                              typeof(PalettePicker));

    public Action<Palette> OnApplyClick
    {
        get { return (Action<Palette>)GetValue(OnApplyClickProperty); }
        set { SetValue(OnApplyClickProperty, value); }
    }

    public void OnCheckedChange(object obj, SelectionChangedEventArgs e)
    {
        Selected = e.CurrentSelection.FirstOrDefault() as Palette;
    }

    [Obsolete]
    public List<Palette> Palettes { get; set; } = BusinessPalettes.Palettes;

    void OnApplyClickHandler(System.Object sender, System.EventArgs e)
    {
        this.OnApplyClick.Invoke(Selected);
    }
}