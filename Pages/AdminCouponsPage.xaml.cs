namespace BizClient.Pages;

public partial class AdminCouponsPage : ContentPage
{
	public AdminCouponsPage(AdminCouponsPageViewModel viewModel)
	{
		InitializeComponent();
        BindingContext = viewModel;
    }
}