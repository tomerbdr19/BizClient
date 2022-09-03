namespace BizClient.Shells;

public partial class DesktopBusinessShell : Shell
{
    public DesktopBusinessShell()
    {
        InitializeComponent();
        Routing.RegisterRoute(Routes.Chat, typeof(ChatPage));
    }
}
