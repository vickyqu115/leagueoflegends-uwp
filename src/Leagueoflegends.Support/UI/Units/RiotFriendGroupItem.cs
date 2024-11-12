using Jamesnet.Uwp;
using Windows.UI.Xaml;

namespace Leagueoflegends.Support.UI.Units;

public class RiotFriendGroupItem : RecursiveControl
{
    public RiotFriendGroupItem()
    {
        DefaultStyleKey = typeof(RiotFriendGroupItem);
    }

    protected override DependencyObject GetContainerForItemOverride()
    {
        return new RiotFriendItemControl();
    }
}
