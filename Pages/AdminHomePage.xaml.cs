namespace BizClient.Pages;

public partial class AdminHomePage : ContentPage
{
	public AdminHomePage(AdminHomePageViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}