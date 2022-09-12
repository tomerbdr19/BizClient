namespace BizClient.Pages;

[QueryProperty(nameof(Business), "Business")]
public partial class BusinessPage : ContentPage
{
    public BusinessPage()
    {
        InitializeComponent();
        addButton.IsVisible = false;
        if (Store.IsBusiness)
        {
            var viewModel = new BusinessPageViewModel(Store.Auth.Business);
            BindingContext = viewModel;
            this.PalettePicker.OnApplyClick += viewModel.OnApplyPalette;
            addButton.IsVisible = true;
        }
        AddProduct.IsVisible = false;
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

    [ICommand]
    public void OnAddProductClick()
    {
        AddProduct.IsVisible = true;
    }

    [ICommand]
    public void OnCloseProductClick()
    {
        AddProduct.IsVisible = false;
    }
}
