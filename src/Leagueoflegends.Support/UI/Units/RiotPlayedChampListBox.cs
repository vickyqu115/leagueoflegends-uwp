using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Leagueoflegends.Support.UI.Units;
public class RiotPlayedChampListBox : ListBox
{
    public RiotPlayedChampListBox()
    {
        DefaultStyleKey = typeof(RiotPlayedChampListBox);
    }

    protected override DependencyObject GetContainerForItemOverride()
    {
        return new RiotPlayedChampListBoxItem();
    }
}
