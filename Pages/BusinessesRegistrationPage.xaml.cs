namespace BizClient.Pages;

public partial class BusinessesRegistrationPage : ContentPage
{
	public BusinessesRegistrationPage(BusinessesRegistrationViewModel viewModel)
	{
		InitializeComponent();
        BindingContext = viewModel;
    }
}