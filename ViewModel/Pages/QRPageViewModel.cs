namespace BizClient.ViewModel;

public partial class QRPageViewModel : BaseViewModel
{
    public QRPageViewModel()
    {
        MessagingCenter.Subscribe<SignalRConnector>(this, "redeemCoupon", async (_) => await this.OnRedeemed());
    }

    [ObservableProperty]
    public bool isRedeemed = false;

    [ObservableProperty]
    public bool isCode = true;

    [ICommand]
    async public Task OnRedeemed()
    {
        IsCode = false;
        IsLoading = true;

        await Task.Delay(1000);

        IsLoading = false;
        IsRedeemed = true;
    }
}

