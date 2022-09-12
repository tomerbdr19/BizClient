namespace BizClient.View;

public partial class CouponView
{
    public CouponView()
    {
        InitializeComponent();
    }

    public static readonly BindableProperty CouponProperty =
    BindableProperty.Create(
    nameof(Coupon),
    typeof(Coupon),
    typeof(CouponView));

    public Coupon Coupon
    {
        get { return (Coupon)GetValue(CouponProperty); }
        set { SetValue(CouponProperty, value); }
    }

    async void OnRedeemClick(System.Object sender, System.EventArgs e)
    {
        try
        {
            var redeemRes = await Store.ServicesStore.CouponService.GetRedeemCode(Coupon.Id);
            if (redeemRes.QrUrl == String.Empty)
            {
                throw new Exception();
            }

            await Shell.Current.GoToAsync(Routes.QRCode, true, new Dictionary<string, object> { { "QRImageUrl", redeemRes.QrUrl }, { "RedeemCode", redeemRes.RedeemCode } });
        }
        catch
        {
            // TODO: handle error
            return;
        }
    }
}
