using Windows.UI.Xaml;

public class DialogProperties : DependencyObject
{
    public static readonly DependencyProperty TextProperty = DependencyProperty.RegisterAttached(
        "Text",
        typeof(string),
        typeof(DialogProperties),
        null
    );

    public static string GetText(UIElement element)
    {
        return (string)element.GetValue(TextProperty);
    }

    public static void SetText(UIElement element, string value)
    {
        element.SetValue(TextProperty, value);
    }
}