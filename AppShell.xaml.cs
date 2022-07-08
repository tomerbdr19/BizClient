namespace BizClient;

public partial class AppShell : Shell
{
    public AppShell()
    {
        InitializeComponent();

        Routing.RegisterRoute(Routes.Login, typeof(LoginPage));
        Routing.RegisterRoute(Routes.Businesses, typeof(BusinessesPage));
        Routing.RegisterRoute(Routes.Home, typeof(HomePage));
    }
}
