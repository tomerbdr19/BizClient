namespace BizClient.Pages.BusinessPages;

public partial class BusinessHomePage : ContentPage
{
    public BusinessHomePage(BusinessHomePageViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
        this.viewModel = viewModel;
    }

    public BusinessHomePageViewModel viewModel;

    protected override void OnAppearing() {
        viewModel.OnAppearing();
    }
}
