namespace BizClient.View;

public partial class PublishProductView
{
	public PublishProductView()
	{
		InitializeComponent();
		viewModel = new PublishProductViewModel();
		BindingContext = viewModel;
    }

	PublishProductViewModel viewModel;
}