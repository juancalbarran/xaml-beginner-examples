using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;

// The User Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234236

namespace UserControlExercise
{
    public sealed partial class HeaderControl : UserControl
    {
        public HeaderControl()
        {
            this.InitializeComponent();
        }

        public static DependencyProperty TitleProperty = DependencyProperty.Register(
            "Title",
            typeof(string),
            typeof(HeaderControl),
            new PropertyMetadata(string.Empty, new PropertyChangedCallback(TitleChanged))
            );

        private static void TitleChanged(DependencyObject d, DependencyPropertyChangedEventArgs e)
        {
            HeaderControl control = d as HeaderControl;
            //control.HeaderText.Text = e.NewValue.ToString();
        }

        public string Title
        {
            get { return (string)GetValue(TitleProperty); }
            set { SetValue(TitleProperty, value); }
        }
    }
}
