using System;
using Windows.UI;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Media;

namespace Leagueoflegends.Support.Local.Converters;

public class MatchResultToColorConverter : IValueConverter
{
    public object Convert(object value, Type targetType, object parameter, string language)
    {
        if (value is string result)
        {
            switch (result.ToLower())
            {
                case "victory": return "#1BA83E";
                case "defeat": return "#D31A45";
            }
        }
        return new SolidColorBrush(Colors.Gray); 
    }

    public object ConvertBack(object value, Type targetType, object parameter, string language)
    {
        throw new NotImplementedException();
    }
}
