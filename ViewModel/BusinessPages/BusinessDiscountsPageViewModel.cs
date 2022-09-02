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

        public async void OnAppearing()
        {
            await GetDiscounts();
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

