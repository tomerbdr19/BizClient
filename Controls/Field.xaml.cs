namespace BizClient.Controls;

public partial class Field : HorizontalStackLayout
{
    public Field()
    {
        InitializeComponent();
    }
    public static readonly BindableProperty KeyProperty =
                           BindableProperty.Create(nameof(Key),
                                                  typeof(string),
                                                  typeof(Field));

    public string Key
    {
        get { return (string)GetValue(KeyProperty); }
        set { SetValue(KeyProperty, value); }
    }

    public static readonly BindableProperty ValueProperty =
                       BindableProperty.Create(nameof(Value),
                                              typeof(string),
                                              typeof(Field));

    public string Value
    {
        get { return (string)GetValue(ValueProperty); }
        set { SetValue(ValueProperty, value); }
    }
}

