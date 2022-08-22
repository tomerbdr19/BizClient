namespace BizClient.Pages;

public partial class QRScannerPage : ContentPage
{
    public QRScannerPage(QRScannerPageViewModel viewModel)
    {
        InitializeComponent();
        this.viewModel = viewModel;
    }

    private QRScannerPageViewModel viewModel { get; set; }

    private void CameraBarcodeReaderView_BarcodesDetected(object sender, ZXing.Net.Maui.BarcodeDetectionEventArgs e)
    {
        Dispatcher.Dispatch(() =>
        {
            viewModel.ReadAndUpdateCoupon(e.Results[0].Value);
            barcodeResult.Text = viewModel.Description;
        });

    }
}