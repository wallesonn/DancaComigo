using System.Globalization;

namespace DancaComigo.Converters;

public class BoolToFavoriteIconConverter : IValueConverter
{
	public object Convert(object value, Type targetType, object parameter, CultureInfo culture)
	{
		if (value is bool isFavorite)
		{
			return isFavorite ? "favorite_filled.png" : "favorite_outline.png";
		}
		return "favorite_outline.png";
	}

	public object ConvertBack(object value, Type targetType, object parameter, CultureInfo culture)
	{
		throw new NotImplementedException();
	}
}