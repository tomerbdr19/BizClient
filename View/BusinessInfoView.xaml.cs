namespace BizClient.View;

public partial class BusinessInfoView
{
    public BusinessInfoView()
    {
        InitializeComponent();
    }

    public static readonly BindableProperty DescriptionProperty =
    BindableProperty.Create(
    nameof(Description),
    typeof(string),
    typeof(BusinessInfoView));

    public string Description
    {
        get { return (string)GetValue(DescriptionProperty); }
        set { SetValue(DescriptionProperty, value); }
    }

    public static readonly BindableProperty AddressProperty =
    BindableProperty.Create(
    nameof(Address),
    typeof(string),
    typeof(BusinessInfoView));

    public string Address
    {
        get { return (string)GetValue(AddressProperty); }
        set { SetValue(AddressProperty, value); }
    }

    public static readonly BindableProperty PhoneProperty =
    BindableProperty.Create(
    nameof(Phone),
    typeof(string),
    typeof(BusinessInfoView));

    public string Phone
    {
        get { return (string)GetValue(PhoneProperty); }
        set { SetValue(PhoneProperty, value); }
    }

    public static readonly BindableProperty EmailProperty =
    BindableProperty.Create(
    nameof(Email),
    typeof(string),
    typeof(BusinessInfoView));

    public string Email
    {
        get { return (string)GetValue(EmailProperty); }
        set { SetValue(EmailProperty, value); }
    }
}
