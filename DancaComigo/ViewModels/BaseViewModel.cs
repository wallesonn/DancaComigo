using CommunityToolkit.Mvvm.ComponentModel;

namespace DancaComigo.ViewModels;

public partial class BaseViewModel : ObservableObject
{
	[ObservableProperty]
	private bool isBusy;

	[ObservableProperty]
	private string title;

	public BaseViewModel()
	{
		Title = string.Empty;
	}
}