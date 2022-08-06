namespace BizClient.Pages;

[QueryProperty(nameof(QRImageUrl), "QRImageUrl")]
public partial class QRPage : ContentPage
{
    public QRPage()
    {
        InitializeComponent();
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
}
