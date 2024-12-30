namespace DancaComigo;

public partial class AppShell : Shell
{
	public AppShell()
	{
		InitializeComponent();
		Routing.RegisterRoute(nameof(Views.DancePage), typeof(Views.DancePage));
	}
}
