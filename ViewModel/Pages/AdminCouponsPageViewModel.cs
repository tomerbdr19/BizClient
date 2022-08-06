namespace BizClient.ViewModel;

public partial class AdminCouponsPageViewModel : BaseViewModel
{
    public AdminCouponsPageViewModel()
    {
        this.couponService = Store.ServicesStore.CouponService;
    }


    private readonly CouponService couponService;
    public ObservableCollection<Coupon> Coupons { get; } = new();

    [ICommand]
    async Task OnAddCouponClick()
    {
        //TODO
    }


    async public void OnAppearing()
    {
        Coupons.Clear();

        this.IsLoading = true;
        var couponService = await this.couponService.GetBusinessCoupons(Store.Auth.Business.Id);
        couponService.ForEach(_ => Coupons.Add(_));
        this.IsLoading = false;
    }

}

    

