using System;
namespace BizClient.ViewModel.BusinessViewModel
{
    public partial class BusinessDiscountsPageViewModel : BaseViewModel
    {
        public BusinessDiscountsPageViewModel()
        {
        }

        private readonly DiscountService discountService = Store.ServicesStore.DiscountService;

        public ObservableCollection<Discount> Discounts { get; } = new();

        [ObservableProperty]
        public Thickness actionMargin;

        [ObservableProperty]
        public bool isActionShown = false;

        private Discount selectedDiscount { get; set; }

        public async void OnAppearing()
        {
            await GetDiscounts();
        }

        public void DataGrid_SelectionChanging(object sender, Syncfusion.Maui.DataGrid.DataGridSelectionChangedEventArgs e)
        {
            var grid = sender as Syncfusion.Maui.DataGrid.SfDataGrid;
            selectedDiscount = (Discount)grid.CurrentRow;

            if (selectedDiscount != null && selectedDiscount.IsActive)
            {
                IsActionShown = true;
                var marginTop = (grid.HeaderRowHeight + (grid.SelectedIndex * grid.RowHeight)) - grid.RowHeight / 2;
                ActionMargin = new Thickness(0, marginTop, 0, 0);
            }
            else
            {
                IsActionShown = false;
            }
        }

        private async Task GetDiscounts()
        {
            IsLoading = true;

            try
            {
                var discounts = await discountService.GetDiscounts(Store.BusinessId);
                Discounts.Clear();
                discounts.ForEach(_ => Discounts.Add(_));
            }
            catch (Exception ex)
            {
                Console.WriteLine(ex);
            }

            IsLoading = false;
        }
    }
}

