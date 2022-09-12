using BizService.Services;

namespace BizClient.View;

public partial class ProductView
{
	public ProductView()
	{
		InitializeComponent();
        deleteButton.IsVisible = Store.IsBusiness;
        editButton.IsVisible = Store.IsBusiness;
        this.businessService = Store.ServicesStore.BusinessService;
        this.IsEdit = false;
        this.IsNotEdit = true;
    }

    private readonly BusinessService businessService;

    public static readonly BindableProperty ProductProperty =
    BindableProperty.Create(
    nameof(Product),
    typeof(Product),
    typeof(ProductView));

    public Product Product
    {
        get { return (Product)GetValue(ProductProperty); }
        set
        {
            SetValue(ProductProperty, value);
        }
    }

    public static readonly BindableProperty EditPriceProperty =
    BindableProperty.Create(
    nameof(EditPrice),
    typeof(string),
    typeof(ProductView));

    public string EditPrice
    {
        get { return (string)GetValue(EditPriceProperty); }
        set
        {
            SetValue(EditPriceProperty, value);
        }
    }

    public static readonly BindableProperty IsEditProperty =
    BindableProperty.Create(
    nameof(IsEdit),
    typeof(bool),
    typeof(ProductView), false);

    public bool IsEdit
    {
        get { return (bool)GetValue(IsEditProperty); }
        set { SetValue(IsEditProperty, value); }
    }

    public static readonly BindableProperty IsNotEditProperty =
    BindableProperty.Create(
    nameof(IsNotEdit),
    typeof(bool),
    typeof(ProductView), true);

    public bool IsNotEdit
    {
        get { return (bool)GetValue(IsNotEditProperty); }
        set { SetValue(IsNotEditProperty, value); }
    }

    [ICommand]
    async Task OnDeleteClick()
    {
        var IsConfirmed = await Shell.Current.DisplayAlert("Delete confirmation", "Please confirm the delete", "Confirm", "Cancel");
        if (IsConfirmed)
        {
            await businessService.DeleteProduct(Store.BusinessId, Product.Id);
        }
    }

    [ICommand]
    public void OnEditClick()
    {
        this.IsEdit = true;
        this.IsNotEdit = false;
    }

    [ICommand]
    public void OnCancelEdit()
    {
        this.IsEdit = false;
        this.IsNotEdit = true;
        this.EditPrice = Product.Price;
    }

    [ICommand]
    public async void OnSaveEdit()
    {
        var IsConfirmed = await Shell.Current.DisplayAlert("Edit confirmation", "Please confirm your changes", "Confirm", "Cancel");

        if (IsConfirmed)
        {
            this.IsEdit = false;
            this.IsNotEdit = true;
            var product = await businessService.UpdateProductPrice(Store.BusinessId, Product.Id, EditPrice);
            priceLabel.Text = EditPrice;
            
        }
    }
}