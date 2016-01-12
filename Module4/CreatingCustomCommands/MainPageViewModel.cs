using System.ComponentModel;

namespace CreatingCustomCommands
{
    public class MainPageViewModel : INotifyPropertyChanged
    {
        public string LeftText { get; set; }

        public string RightText { get; set; }

        public string CenterText { get; set; }

        public event PropertyChangedEventHandler PropertyChanged;

        public SampleCommand RenderCommand { get; private set; }

        public MainPageViewModel()
        {
            this.RenderCommand = new SampleCommand(RenderExecute);
        }

        private void RenderExecute(string parameter)
        {
            CenterText = LeftText + parameter + RightText;
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs("CenterText"));
            }
        }
    }
}
