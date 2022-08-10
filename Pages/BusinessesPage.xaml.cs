namespace BizClient.Pages;

[QueryProperty(nameof(BusinessesList), "BusinessesList")]
public partial class BusinessesPage : ContentPage
{
    public BusinessesPage(BusinessesPageViewModel viewModel)
    {
        InitializeComponent();
        this.viewModel = viewModel;
        BindingContext = viewModel;
    }

    private BusinessesPageViewModel viewModel;
    public List<Business> BusinessesList { get; set; }


    protected override void OnAppearing()
    {
        base.OnAppearing();
        viewModel.OnAppearing(BusinessesList);
        BusinessesList = null;
    }
}
