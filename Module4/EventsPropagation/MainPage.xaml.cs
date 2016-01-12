using Windows.UI.Xaml.Controls;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace EventsPropagation
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
        }

        private void Tapped_Handle(object sender, Windows.UI.Xaml.Input.TappedRoutedEventArgs e)
        {
            if (sender is StackPanel) e.Handled = true;
        }

    }
}
