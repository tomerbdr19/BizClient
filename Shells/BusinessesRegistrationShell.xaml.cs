namespace BizClient.Shells;

public partial class BusinessesRegistrationShell : Shell
{
	public BusinessesRegistrationShell()
	{
		InitializeComponent();
        Routing.RegisterRoute(Routes.BusinessesRegistration, typeof(BusinessesRegistrationPage));
    }
}