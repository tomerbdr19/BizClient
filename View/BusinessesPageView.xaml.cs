namespace BizClient.View;

public partial class BusinessesPageView : ContentPage
{
	public BusinessesPageView(BusinessesPageViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}
