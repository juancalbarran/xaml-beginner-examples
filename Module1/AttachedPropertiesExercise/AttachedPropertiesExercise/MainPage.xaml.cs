using Windows.UI.Xaml.Controls;
using System.Threading.Tasks;

// The Blank Page item template is documented at http://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace AttachedPropertiesExercise1
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public MainPage()
        {
            this.InitializeComponent();
            LoadData();
        }

        async void LoadData()
        {
            this.SetValue(LoadingProperties.IsLoadingProperty, true);
            await Task.Delay(5000);
            this.SetValue(LoadingProperties.IsLoadingProperty, false);
        }
    }
}
