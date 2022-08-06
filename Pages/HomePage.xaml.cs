namespace BizClient.Pages;

public partial class HomePage : ContentPage
{
    private HomePageViewModel viewModel { get; set; }

    public HomePage(HomePageViewModel viewModel)
    {
        InitializeComponent();
        this.viewModel = viewModel;
        BindingContext = viewModel;
    }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        viewModel.OnAppearing();
    }
}
