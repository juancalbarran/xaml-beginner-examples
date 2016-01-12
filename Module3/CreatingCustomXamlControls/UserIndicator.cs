using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI;

// The Templated Control item template is documented at http://go.microsoft.com/fwlink/?LinkId=234235

namespace CreatingCustomXamlControls
{
    public sealed class UserIndicator : Control
    {
        public Color StatusColor
        {
            get { return (Color)GetValue(StatusColorProperty); }
            set { SetValue(StatusColorProperty, value); }
        }

        public static readonly DependencyProperty StatusColorProperty =
            DependencyProperty.Register("StatusColor", typeof(Color), typeof(UserIndicator), null);

        public string Username
        {
            get { return (string)GetValue(UsernameProperty); }
            set { SetValue(UsernameProperty, value); }
        }

        public static readonly DependencyProperty UsernameProperty =
            DependencyProperty.Register("Username", typeof(string), typeof(UserIndicator), null);

        public int Ping
        {
            get { return (int)GetValue(PingProperty); }
            set { SetValue(PingProperty, value); }
        }

        public static readonly DependencyProperty PingProperty =
            DependencyProperty.Register("Ping", typeof(int), typeof(UserIndicator), null);


        public UserIndicator()
        {
            this.DefaultStyleKey = typeof(UserIndicator);
        }
    }
}
