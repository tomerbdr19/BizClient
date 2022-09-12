namespace BizClient.Pages;

[QueryProperty(nameof(QRImageUrl), "QRImageUrl")]
[QueryProperty(nameof(RedeemCode), "RedeemCode")]
public partial class QRPage : ContentPage
{
    public QRPage()
    {
        InitializeComponent();
        BindingContext = new QRPageViewModel();
    }

    public static readonly BindableProperty QRImageUrlProperty =
    BindableProperty.Create(
    nameof(QRImageUrl),
    typeof(string),
    typeof(QRPage));

    public string QRImageUrl
    {
        get { return (string)GetValue(QRImageUrlProperty); }
        set { SetValue(QRImageUrlProperty, value); }
    }

    public static readonly BindableProperty RedeemCodeProperty =
    BindableProperty.Create(
    nameof(RedeemCode),
    typeof(string),
    typeof(QRPage));

    public string RedeemCode
    {
        get { return (string)GetValue(RedeemCodeProperty); }
        set { SetValue(RedeemCodeProperty, value); }
    }
}
