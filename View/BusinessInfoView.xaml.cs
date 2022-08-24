namespace BizClient.View;

public partial class BusinessInfoView
{
    public BusinessInfoView()
    {
        InitializeComponent();
    }

    public static readonly BindableProperty InfoProperty =
                       BindableProperty.Create(nameof(Info),
                                              typeof(BusinessInfo),
                                              typeof(BusinessInfoView));

    public BusinessInfo Info
    {
        get { return (BusinessInfo)GetValue(InfoProperty); }
        set { SetValue(InfoProperty, value); }
    }

    public static readonly BindableProperty EditedInfoProperty =
                   BindableProperty.Create(nameof(EditedInfo),
                                          typeof(BusinessInfo),
                                          typeof(BusinessInfoView));

    public BusinessInfo EditedInfo
    {
        get { return (BusinessInfo)GetValue(EditedInfoProperty); }
        set { SetValue(EditedInfoProperty, value); }
    }

    public static readonly BindableProperty IsEditProperty =
    BindableProperty.Create(
    nameof(IsEdit),
    typeof(bool),
    typeof(BusinessInfoView), false);

    public bool IsEdit
    {
        get { return (bool)GetValue(IsEditProperty); }
        set { SetValue(IsEditProperty, value); }
    }

    public static readonly BindableProperty IsNotEditProperty =
    BindableProperty.Create(
    nameof(IsNotEdit),
    typeof(bool),
    typeof(BusinessInfoView), true);

    public bool IsNotEdit
    {
        get { return (bool)GetValue(IsNotEditProperty); }
        set { SetValue(IsNotEditProperty, value); }
    }
}
