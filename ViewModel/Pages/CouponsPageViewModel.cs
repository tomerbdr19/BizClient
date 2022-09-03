using System;
namespace BizClient.ViewModel
{
    public class CouponsPageViewModel : BaseViewModel
    {
        public CouponsPageViewModel()
        {
        }

        private CouponService couponService { get; } = Store.ServicesStore.CouponService;
        public ObservableCollection<Coupon> Coupons { get; } = new();

        async public void OnAppearing()
        {
            IsLoading = true;
            try
            {
                var coupons = await couponService.GetUserCoupons(Store.UserId);
                Coupons.Clear();
                coupons.ForEach(_ => Coupons.Add(_));
            }
            catch (Exception exp)
            {
                Console.WriteLine(exp);
            }

            IsLoading = false;
        }

    }
}