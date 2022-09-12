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


    public async Task ReadAndUpdateCoupon(string redeemCode)
    {
        try
        {
            await CouponService.RedeemCoupon(redeemCode, Store.Auth.Business.Id);
            Shell.Current.DisplayAlert("Redeem Status", "Coupon has been redeemed successfully", "OK");
        }
        catch
        {
            Shell.Current.DisplayAlert("Redeem Status", "Coupon has been redeemed successfully", "OK");
        }
    }

    async public Task OnEnterCode()
    {
        string redeemCode = await Shell.Current.DisplayPromptAsync("Redeem Coupon", "Enter client 4-digit code", initialValue: "", keyboard: Keyboard.Text);

        if (redeemCode == "" || redeemCode == null)
        {
            return;
        }

        await ReadAndUpdateCoupon(redeemCode);
    }
}

