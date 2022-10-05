namespace MauiAuth;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
        Routing.RegisterRoute("MainPage", typeof(MainPage));
        Routing.RegisterRoute("RegistrationPage", typeof(RegistrationPage));
        Routing.RegisterRoute("Logout", typeof(RegistrationPage));
    }
}
