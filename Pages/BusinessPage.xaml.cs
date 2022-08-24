namespace BizClient.Pages;

[QueryProperty(nameof(Business), "Business")]
public partial class BusinessPage : ContentPage
{
    public BusinessPage()
    {
        InitializeComponent();
    }

    private Business business;
    public Business Business
    {
        set
        {
            var viewModel = new BusinessPageViewModel(value);
            BindingContext = viewModel;
            this.PalettePicker.OnApplyClick += viewModel.OnApplyPalette;
        }
    }
}
