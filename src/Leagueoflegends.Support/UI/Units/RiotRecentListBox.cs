using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Leagueoflegends.Support.UI.Units;

public class RiotRecentListBox : ListBox
{
    public RiotRecentListBox()
    {
        DefaultStyleKey = typeof(RiotRecentListBox);
    }

    protected override DependencyObject GetContainerForItemOverride()
    {
        return new RiotRecentListBoxItem();
    }
}
