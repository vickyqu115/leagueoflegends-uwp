using Jamesnet.Core;
using Windows.UI.Xaml.Controls;

namespace Leagueoflegends.Tft.UI.Views;

public class TftContent : ContentControl, IView
{
    public TftContent()
    {
        DefaultStyleKey = typeof(TftContent);   
    }
}
