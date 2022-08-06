
namespace BizClient.ViewModel;

public partial class AdminHomePageViewModel : BaseViewModel
{

    [ICommand]
    async Task OnSubscribesListClick()
    {
        await Shell.Current.GoToAsync(Routes.SubscribesList, true);
    }

    [ICommand]
    async Task OnAddPostClick()
    {
        await Shell.Current.GoToAsync(Routes.AdminAddPost, true);
    }

    [ICommand]
    async Task OnCouponsClick()
    {
        await Shell.Current.GoToAsync(Routes.AdminCoupons, true);
    }

    //[ICommand]
    //async Task OnMessagesClick()
    //{
    //    await Shell.Current.GoToAsync(Routes., true);
    //}
}

