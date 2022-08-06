namespace BizClient.Shells;

public partial class BusinessDesktopShell : Shell
{
	public BusinessDesktopShell()
	{
		InitializeComponent();

        //Admin UI
        Routing.RegisterRoute(Routes.AdminHome, typeof(AdminHomePage));
        Routing.RegisterRoute(Routes.SubscribesList, typeof(SubscribesListPage));
        Routing.RegisterRoute(Routes.AdminCoupons, typeof(AdminCouponsPage));
        Routing.RegisterRoute(Routes.AdminCoupons, typeof(AdminChatPage));
        Routing.RegisterRoute(Routes.AdminAddPost, typeof(AdminAddPostPage));
    }
}