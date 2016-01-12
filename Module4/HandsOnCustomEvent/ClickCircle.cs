using System;
using Windows.UI.Xaml.Controls;

// The Templated Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234235

namespace HandsOnCustomEvent
{
    public sealed class ClickCircle : Control
    {
        public ClickCircle()
        {
            this.DefaultStyleKey = typeof(ClickCircle);
            this.Tapped += ClickCircle_Tapped;
        }

        private void ClickCircle_Tapped(object sender, Windows.UI.Xaml.Input.TappedRoutedEventArgs e)
        {
            var device = e.PointerDeviceType.ToString();
            var eventArgs = new MessageEventArgs($"This control was clicked by: {device}");
            Circle_Tapped(this, eventArgs);
        }

        public event EventHandler<MessageEventArgs> Click;

        private void Circle_Tapped(object sender, MessageEventArgs e)
        {
            if (Click != null)
            {
                Click(sender, e);
            }
        }
    }
}
