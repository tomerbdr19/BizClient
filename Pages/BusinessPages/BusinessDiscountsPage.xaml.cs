namespace BizClient.Pages.BusinessPages;

public partial class BusinessDiscountsPage : ContentPage
{
    public BusinessDiscountsPage(BusinessDiscountsPageViewModel viewModel)
    {
        InitializeComponent();
        this.viewModel = viewModel;
        BindingContext = viewModel;
    }

    private readonly BusinessDiscountsPageViewModel viewModel;

    protected override void OnAppearing()
    {
        base.OnAppearing();
        viewModel.OnAppearing();
    }

    void dataGrid_SelectionChanged(System.Object sender, Syncfusion.Maui.DataGrid.DataGridSelectionChangedEventArgs e)
    {
        viewModel.DataGrid_SelectionChanging(sender, e);
    }
}
