namespace BizClient.ViewModel;

public partial class AdminAddPostPageViewModel : BaseViewModel
{
    public AdminAddPostPageViewModel()
    {
        auth = Store.Auth;
    }

    public Auth auth { set; get; }
}

