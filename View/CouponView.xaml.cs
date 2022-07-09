namespace BizClient.View;

public partial class CouponView
{
    public CouponView()
    {
        InitializeComponent();
    }

    public static readonly BindableProperty BusinessNameProperty =
    BindableProperty.Create(
    nameof(BusinessName),
    typeof(string),
    typeof(CouponView));

    public string BusinessName
    {
        get { return (string)GetValue(BusinessNameProperty); }
        set { SetValue(BusinessNameProperty, value); }
    }

    public static readonly BindableProperty BusinessImageUrlProperty =
    BindableProperty.Create(
    nameof(BusinessImageUrl),
    typeof(string),
    typeof(CouponView));

    public string BusinessImageUrl
    {
        get { return (string)GetValue(BusinessImageUrlProperty); }
        set { SetValue(BusinessImageUrlProperty, value); }
    }

    public static readonly BindableProperty CouponIdProperty =
    BindableProperty.Create(
    nameof(CouponId),
    typeof(string),
    typeof(CouponView));

    public string CouponId
    {
        get { return (string)GetValue(CouponIdProperty); }
        set { SetValue(CouponIdProperty, value); }
    }

    public static readonly BindableProperty ExpiredAtProperty =
    BindableProperty.Create(
    nameof(ExpiredAt),
    typeof(DateTime),
    typeof(CouponView));

    public DateTime ExpiredAt
    {
        get { return (DateTime)GetValue(ExpiredAtProperty); }
        set { SetValue(ExpiredAtProperty, value); }
    }

    public static readonly BindableProperty IsRedeemedProperty =
    BindableProperty.Create(
    nameof(IsRedeemed),
    typeof(bool),
    typeof(CouponView));

    public bool IsRedeemed
    {
        get { return (bool)GetValue(IsRedeemedProperty); }
        set { SetValue(IsRedeemedProperty, value); }
    }

    public static readonly BindableProperty DescriptionProperty =
    BindableProperty.Create(
    nameof(Description),
    typeof(string),
    typeof(CouponView));

    public string Description
    {
        get { return (string)GetValue(DescriptionProperty); }
        set { SetValue(DescriptionProperty, value); }
    }
}
