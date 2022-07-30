using System;
namespace BizClient.ViewModel
{
    public class CouponsPageViewModel : BaseViewModel
    {
        public CouponsPageViewModel()
        {
        }

        public ObservableCollection<Coupon> Coupons { get; } = new();

    }
}