namespace BizClient.Pages;

public partial class UserRegisterPage : ContentPage
{
	public UserRegisterPage(UserRegisterViewModel viewModel)
	{
		InitializeComponent();
        BindingContext = viewModel;
    }
}