using BizService.Services;

namespace BizClient.View;

public partial class ProductView
{
	public ProductView()
	{
		InitializeComponent();
        deleteButton.IsVisible = Store.IsBusiness;
    }

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

    [ICommand]
    async Task OnDeleteClick()
    {
        var IsConfirmed = await Shell.Current.DisplayAlert("Delete confirmation", "Please confirm the delete", "Confirm", "Cancel");
        if (IsConfirmed)
        {
            //TODO remove product
        }
    }
}