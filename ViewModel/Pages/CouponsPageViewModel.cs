using System;
namespace BizClient.ViewModel
{
    public class CouponsPageViewModel : BaseViewModel
    {
        public CouponsPageViewModel()
        {
            foreach (Coupon coupon in Mocks.coupons)
            {
                Coupons.Add(coupon);
            }
        }

        public ObservableCollection<Coupon> Coupons { get; } = new();

    }
}