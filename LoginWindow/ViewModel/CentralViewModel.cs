using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;

namespace LoginWindow.ViewModel
{
    class CentralViewModel
    {
        public MyCommand Login { get; set; }
        public MyCommand Register { get; set; }

        public CentralViewModel()
        {
            Login = new MyCommand(LogIn); 
        }

        private void LogIn(object obj)
        {
            AuthentificationViewModel newAuthentification = new AuthentificationViewModel();
            newAuthentification.Authentify();
            
        }
    }
}
