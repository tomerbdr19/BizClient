namespace BizClient;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        Routing.RegisterRoute(Routes.Login, typeof(LoginPageView));
        Routing.RegisterRoute(Routes.Businesses, typeof(BusinessesPageView));
        Routing.RegisterRoute(Routes.Home, typeof(HomePage));
    }
}
