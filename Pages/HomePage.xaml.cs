namespace BizClient.Pages;

public partial class HomePage : ContentPage
{
    HomePageViewModel viewModel => BindingContext as HomePageViewModel;

    public HomePage(HomePageViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}
