namespace BizClient.Shells;

public partial class MobileAdminShell : Shell
{
    public MobileAdminShell()
    {
        InitializeComponent();

        Routing.RegisterRoute(Routes.Chat, typeof(ChatPage));
    }
}