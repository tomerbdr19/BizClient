namespace BizClient.Pages;

public partial class BusinessesPage : ContentPage
{
    public BusinessesPage(BusinessesPageViewModel viewModel)
    {
        InitializeComponent();
        BindingContext = viewModel;
    }
}
