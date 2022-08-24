namespace BizClient.Pages;

[QueryProperty(nameof(Business), "Business")]
public partial class BusinessPage : ContentPage
{
    public BusinessPage()
    {
        InitializeComponent();

        if (Store.IsBusiness)
        {
            var viewModel = new BusinessPageViewModel(Store.Auth.Business);
            BindingContext = viewModel;
            this.PalettePicker.OnApplyClick += viewModel.OnApplyPalette;
        }
    }

    private Business business;
    public Business Business
    {
        set
        {
            var viewModel = new BusinessPageViewModel(value);
            BindingContext = viewModel;
        }
    }
}
