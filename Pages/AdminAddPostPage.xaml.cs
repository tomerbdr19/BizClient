namespace BizClient.Pages;

public partial class AdminAddPostPage : ContentPage
{
	public AdminAddPostPage(AdminAddPostPageViewModel viewModel)
	{
		InitializeComponent();
        BindingContext = viewModel;
    }
}