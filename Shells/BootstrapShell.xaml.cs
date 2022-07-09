namespace BizClient.Shells;

public partial class BootstrapShell : Shell
{
    public BootstrapShell()
    {
        InitializeComponent();

        Routing.RegisterRoute(Routes.Login, typeof(LoginPage));
    }
}
