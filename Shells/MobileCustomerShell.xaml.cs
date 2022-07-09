namespace BizClient.Shells;

public partial class MobileCustomerShell : Shell
{
    public MobileCustomerShell()
    {
        InitializeComponent();

        Routing.RegisterRoute(Routes.Login, typeof(LoginPage));
        Routing.RegisterRoute(Routes.Businesses, typeof(BusinessesPage));
        Routing.RegisterRoute(Routes.Home, typeof(HomePage));
    }
}
