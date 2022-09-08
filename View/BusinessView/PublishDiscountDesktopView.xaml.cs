namespace BizClient.View;

public partial class PublishDiscountDesktopView : Frame
{
	public PublishDiscountDesktopView()
	{
        InitializeComponent();
        viewModel = new PublishDiscountDesktopViewModel();
        BindingContext = viewModel;
    }
    PublishDiscountDesktopViewModel viewModel;

    public Action<Discount> OnPublishSuccess
    {
        set { this.viewModel.OnPublishSuccess = value; }
    }
}