using System.Collections.ObjectModel;
using CommunityToolkit.Mvvm.ComponentModel;
using CommunityToolkit.Mvvm.Input;
using DancaComigo.Models;

namespace DancaComigo.ViewModels;

public partial class DanceViewModel : BaseViewModel
{
	[ObservableProperty]
	private ObservableCollection<Dance> dances;

	public DanceViewModel()
	{
		Title = "Danças";
		Dances = new ObservableCollection<Dance>();
		LoadDances();
	}

	[RelayCommand]
	private void LoadDances()
	{
		IsBusy = true;

		try
		{
			Dances.Clear();
			var danceList = new List<Dance>
			{
				new Dance { Name = "Samba", Description = "Dança brasileira com ritmo contagiante", DifficultyLevel = "Intermediário", IsFavorite = false },
				new Dance { Name = "Forró", Description = "Dança de salão popular no nordeste", DifficultyLevel = "Iniciante", IsFavorite = false },
				new Dance { Name = "Salsa", Description = "Dança latina cheia de energia", DifficultyLevel = "Avançado", IsFavorite = false }
			};

			foreach (var dance in danceList)
			{
				Dances.Add(dance);
			}
		}
		finally
		{
			IsBusy = false;
		}
	}

	[RelayCommand]
	private void ToggleFavorite(Dance dance)
	{
		if (dance == null)
			return;

		dance.IsFavorite = !dance.IsFavorite;
	}
}