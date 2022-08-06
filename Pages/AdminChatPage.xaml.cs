namespace BizClient.Pages;
public partial class AdminChatPage : ContentPage
{
	public AdminChatPage(AdminChatPageViewModel viewModel)
	{
		InitializeComponent();
        BindingContext = viewModel;
    }
}