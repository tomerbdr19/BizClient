namespace BizClient.Shells;

public partial class CustomerRegistrationShell : Shell
{
    public CustomerRegistrationShell()
    {
        InitializeComponent();
        Routing.RegisterRoute(Routes.CustomerRegistration, typeof(CustomerRegistrationPage));
    }
}