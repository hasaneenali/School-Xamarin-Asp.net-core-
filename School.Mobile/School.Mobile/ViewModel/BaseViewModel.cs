using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;
using System.Text;

namespace School.Mobile.ViewModel
{
    public class BaseViewModel : INotifyPropertyChanged
    {


        private bool _isLoading { get; set; }
        public bool IsLoading
        {
            get
            {
                return _isLoading;
            }
            set
            {
                if (value != _isLoading)
                {
                    _isLoading = value;
                    NotifyPropertyChanged();
                }
            }
        }

        private bool _isRunning { get; set; }
        public bool IsRunning
        {
            get
            {
                return _isRunning;
            }
            set
            {
                if (value != _isRunning)
                {
                    _isRunning = value;
                    NotifyPropertyChanged();
                }
            }
        }

        public event PropertyChangedEventHandler PropertyChanged;
        protected void NotifyPropertyChanged([CallerMemberName] string propertyName = "")
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        
    }

}
