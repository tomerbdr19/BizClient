namespace BizClient.Pages;

public partial class CouponsPage : ContentPage
{
    public CouponsPage(CouponsPageViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}
