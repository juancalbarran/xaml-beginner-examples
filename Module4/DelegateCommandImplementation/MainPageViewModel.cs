using Windows.UI.Popups;

namespace DelegateCommandImplementation
{
    public class MainPageViewModel
    {
        public DelegateCommand<string> DisplayPopupCommand { get; set; }

        public MainPageViewModel()
        {
            DisplayPopupCommand = new DelegateCommand<string>(DisplayPopupExecute);
        }

        private void DisplayPopupExecute(string parameter)
        {
            new MessageDialog(parameter).ShowAsync();
        }
    }
}
