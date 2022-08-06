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
            Coupons.Clear();

            IsLoading = true;
            var coupons = await couponService.GetUserCoupons(Store.UserId);
            coupons.ForEach(_ => Coupons.Add(_));
            IsLoading = false;
        }

    }
}