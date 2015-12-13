using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginWindow.ViewModel
{
    class ClientViewModel : INotifyPropertyChanged
    {
        internal void RaisePropertyChanged(string property)
        {
            if (PropertyChanged != null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }
        public event PropertyChangedEventHandler PropertyChanged;
    }
}
