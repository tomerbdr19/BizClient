using System;
namespace BizClient.ViewModel
{
    public class CouponsPageViewModel : BaseViewModel
    {
        public CouponsPageViewModel()
        {
            Coupons.Add(new Coupon());
            Coupons.Add(new Coupon());
            Coupons.Add(new Coupon());
        }

        public ObservableCollection<Coupon> Coupons { get; } = new();

    }
}