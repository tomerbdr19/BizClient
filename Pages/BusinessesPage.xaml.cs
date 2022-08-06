namespace BizClient.Pages;

public partial class BusinessesPage : ContentPage
{
    public BusinessesPage(BusinessesPageViewModel viewModel)
    {
        InitializeComponent();
        this.viewModel = viewModel;
        BindingContext = viewModel;
    }

    private BusinessesPageViewModel viewModel;


    protected override void OnAppearing()
    {
        base.OnAppearing();
        viewModel.OnAppearing();
    }
}
