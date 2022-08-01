namespace BizClient.Pages;

public partial class CustomerRegistrationPage : ContentPage
{
	public CustomerRegistrationPage(CustomerRegistrationViewModel viewModel)
	{
		InitializeComponent();
        BindingContext = viewModel;
    }
}