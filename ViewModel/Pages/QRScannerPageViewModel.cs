namespace BizClient.ViewModel;

public partial class QRScannerPageViewModel : BaseViewModel
{
    public QRScannerPageViewModel()
    {
        CouponService = Store.ServicesStore.CouponService;
        Description = "";
    }
    private CouponService CouponService { get; } = Store.ServicesStore.CouponService;
    public Coupon CouponToUpdate { get; set; }
    public string Description { get; set; }


    public async void ReadAndUpdateCoupon(string couponId)
    {
        CouponToUpdate = await CouponService.RedeemCoupon(couponId, Store.Auth.Business.Id);
        Description = CouponToUpdate.Discount.Description;
        if (CouponToUpdate == null)
        {
            Description = "Invalid coupon";
        }
        else
        {
            Description = CouponToUpdate.Discount.Description;
        }
    }
}

