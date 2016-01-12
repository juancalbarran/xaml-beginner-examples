using System;
using Microsoft.Xaml.Interactivity;
using Windows.UI.Xaml;
using Windows.UI.Popups;
using Windows.UI.Xaml.Controls;

namespace CustomBehavior
{
    public class ShowDialogBehavior : DependencyObject, IBehavior
    {
        public string Message { get; set; }

        public DependencyObject AssociatedObject
        {
            get;
            private set;
        }

        public void Attach(DependencyObject associatedObject)
        {
            this.AssociatedObject = associatedObject;
            (this.AssociatedObject as Button).Click += Button_Click;
        }

        public void Detach()
        {
            (this.AssociatedObject as Button).Click -= Button_Click;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            if (this.AssociatedObject is Button)
                (this.AssociatedObject as Button).Click -= Button_Click;
        }
    }
}
