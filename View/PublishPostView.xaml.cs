namespace BizClient.View;

public partial class PublishPostView
{
    public PublishPostView()
    {
        InitializeComponent();
        viewModel = new PublishPostViewModel();
        BindingContext = viewModel;
    }
    PublishPostViewModel viewModel;
}