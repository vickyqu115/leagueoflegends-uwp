using Leagueoflegends.Support.Local.Models;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;

namespace Leagueoflegends.Support.UI.Units;

public class RiotKeyButton : Button
{
    public static readonly DependencyProperty IconTypeProperty = DependencyProperty.Register(
        nameof(IconType), typeof(SmallIconType), typeof(RiotKeyButton),
        new PropertyMetadata(SmallIconType.Mic, OnIconTypeChanged));

    public SmallIconType IconType
    {
        get => (SmallIconType)GetValue(IconTypeProperty);
        set => SetValue(IconTypeProperty, value);
    }

    public RiotKeyButton()
    {
        DefaultStyleKey = typeof(RiotKeyButton);
    }

    protected override void OnApplyTemplate()
    {
        base.OnApplyTemplate();
        UpdateVisualState();
    }

    private static void OnIconTypeChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
    {
        if (d is RiotKeyButton button)
        {
            button.UpdateVisualState();
        }
    }

    private void UpdateVisualState()
    {
        VisualStateManager.GoToState(this, IconType.ToString(), false);
    }
}
