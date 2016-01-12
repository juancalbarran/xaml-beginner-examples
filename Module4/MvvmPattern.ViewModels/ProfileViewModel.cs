using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvvmPattern.ViewModels
{
    public sealed class ProfileViewModel : ViewModel
    {
        private string _name;

        public string Name
        {
            get { return _name; }
            set { _name = value; NotifyPropertyChanged(); }
        }

        private int _credentialCount;

        public int CredentialCount
        {
            get { return _credentialCount; }
            set { _credentialCount = value; NotifyPropertyChanged(); }
        }

        private DateTimeOffset _hiredOn = DateTimeOffset.Now;

        public DateTimeOffset HiredOn
        {
            get { return _hiredOn; }
            set { _hiredOn = value; NotifyPropertyChanged(); }
        }
    }
}
