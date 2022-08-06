namespace BizClient.Pages;

public partial class SubscribesListPage : ContentPage
{
	public SubscribesListPage(SubscribesListPageViewModel viewModel)
	{
		InitializeComponent();
        BindingContext = viewModel;
    }
}