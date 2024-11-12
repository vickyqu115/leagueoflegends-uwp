using Windows.UI.Xaml.Controls.Primitives;

namespace Leagueoflegends.Support.UI.Units;
class RiotFoldableIcon : ToggleButton
{
    public RiotFoldableIcon()
    {
        DefaultStyleKey = typeof(RiotFoldableIcon);

        Tapped += RiotFoldableIcon_Tapped;
        DoubleTapped += RiotFoldableIcon_DoubleTapped;
    }

    private void RiotFoldableIcon_Tapped(object sender, Windows.UI.Xaml.Input.TappedRoutedEventArgs e)
    {
        e.Handled = true;
    }

    private void RiotFoldableIcon_DoubleTapped(object sender, Windows.UI.Xaml.Input.DoubleTappedRoutedEventArgs e)
    {
        e.Handled = true;
    }
}
