namespace BizClient.Shells;

public partial class MobileCustomerShell : Shell
{
    public MobileCustomerShell()
    {
        InitializeComponent();

        Routing.RegisterRoute(Routes.Login, typeof(LoginPage));
        Routing.RegisterRoute(Routes.Business, typeof(BusinessPage));
        Routing.RegisterRoute(Routes.Chat, typeof(ChatPage));
        Routing.RegisterRoute(Routes.QRCode, typeof(QRPage));
    }
}
