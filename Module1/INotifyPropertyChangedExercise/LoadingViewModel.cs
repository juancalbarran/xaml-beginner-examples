using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace INotifyPropertyChangedExercise
{
    public class LoadingViewModel : INotifyPropertyChanged
    {
        public LoadingViewModel()
        {
            this.ShowLoadingIndicator = true;
        }

        private bool _showLoadingIndicator = false;

        public bool ShowLoadingIndicator
        {
            get { return this._showLoadingIndicator; }
            set
            {
                if (value != this._showLoadingIndicator)
                {
                    this._showLoadingIndicator = value;
                    this.OnPropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName]string propName = null)
        {
            if (PropertyChanged != null)
            {
                this.PropertyChanged(this, new PropertyChangedEventArgs(propName));
            }
        }
    }
}
