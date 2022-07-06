namespace BizClient.View;

public partial class LoginPageView : ContentPage
{
	public LoginPageView(LoginPageViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}
