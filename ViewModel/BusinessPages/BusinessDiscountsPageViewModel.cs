using System;
using BizService.Services;

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
            IsActionShown = false;
            selectedDiscount = null;
            await GetDiscounts();
        }

        [ICommand]
        public async void OnDeleteClick()
        {
            var IsConfirmed = await Shell.Current.DisplayAlert("Delte confirmation", "Are you sure?", "Yes", "Cancel");

            if (IsConfirmed)
            {
                try
                {
                    IsLoading = true;
                    var deleted = await discountService.DeleteDiscount(Store.BusinessId, selectedDiscount.Id);

                    Discounts.Remove(selectedDiscount);
                    IsActionShown = false;
                    selectedDiscount = null;
                }
                catch
                {

                }
            }

            IsLoading = false;
        }

        [ICommand]
        public async void OnExtendClick()
        {
            var days = await Shell.Current.DisplayPromptAsync("Discount extenstion", "number of days", initialValue: "0", keyboard: Keyboard.Numeric);

            if (Int32.Parse(days) > 0)
            {
                try
                {
                    var newDate = selectedDiscount.ExpiredAt.AddDays(Int32.Parse(days));
                    IsLoading = true;
                    var discount = await discountService.ExtendDiscount(Store.BusinessId, selectedDiscount.Id, newDate);

                    var index = Discounts.IndexOf(selectedDiscount);
                    Discounts.Remove(selectedDiscount);
                    Discounts.Insert(index, discount);
                }
                catch
                {

                }
            }

            IsLoading = false;
        }

        [ICommand]
        public async void OnShareClick()
        {
            if (!selectedDiscount.IsPublic)
            {
                var IsConfirmed = await Shell.Current.DisplayAlert("Share discount", "Share this discount will make it public", "Ok", "Cancel");

                if (!IsConfirmed)
                    return;
            }

            try
            {
                IsLoading = true;
                var discount = await discountService.ShareDiscount(Store.BusinessId, selectedDiscount.Id);

                var index = Discounts.IndexOf(selectedDiscount);
                Discounts.Remove(selectedDiscount);
                Discounts.Insert(index, discount);
            }
            catch
            {

            }

            IsLoading = false;
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

