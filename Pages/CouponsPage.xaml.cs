namespace BizClient.Pages;

public partial class CouponsPage : ContentPage
{
    public CouponsPage(CouponsPageViewModel viewModel)
    {
        InitializeComponent();
        this.viewModel = viewModel;
        BindingContext = viewModel;
    }

    private CouponsPageViewModel viewModel { get; set; }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        viewModel.OnAppearing();
    }
}
