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
}
