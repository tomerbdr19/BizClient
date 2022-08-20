namespace BizClient.Pages.BusinessPages;

public partial class BusinessSubscribersPage : ContentPage
{
    public BusinessSubscribersPage(BusinessSubscribersPageViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
        this.viewModel = viewModel;
    }

    private BusinessSubscribersPageViewModel viewModel;

    protected override void OnAppearing()
    {
        base.OnAppearing();
        viewModel.OnAppearing();
    }
}
