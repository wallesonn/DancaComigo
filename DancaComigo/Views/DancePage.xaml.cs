using DancaComigo.ViewModels;

namespace DancaComigo.Views;

public partial class DancePage : ContentPage
{
	public DancePage(DanceViewModel viewModel)
	{
		InitializeComponent();
		BindingContext = viewModel;
	}
}