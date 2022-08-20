namespace BizClient.Pages;

public partial class AdminHomePage : ContentPage
{
    public AdminHomePage(AdminHomePageViewModel viewModel)
    {
        InitializeComponent();
        this.viewModel = viewModel;
        BindingContext = viewModel;
        PublishPost.OnPublishSuccess = viewModel.AddPublishedPost;
    }

    private AdminHomePageViewModel viewModel { get; set; }

    protected override void OnAppearing()
    {
        base.OnAppearing();
        viewModel.OnAppearing();
    }

}