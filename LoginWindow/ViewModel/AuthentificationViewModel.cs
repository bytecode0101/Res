using LoginWindow.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LoginWindow.ViewModel
{
    class AuthentificationViewModel : ClientViewModel
    {
        //A new client object is created
        public AuthentificationViewModel()
        {
            CurrentClient = new Client { Name = "Name", Password = "password" };   
        }

        internal bool isAuthentified;
        public bool IsAuthentified
        {
            get
            {
                return isAuthentified;
            }

            set
            {
                if (value != isAuthentified)
                {
                    isAuthentified = value;
                    RaisePropertyChanged("IsAuthentified");
                }
            }
            
        }

        private Client currentClient;
        public Client CurrentClient
        {
            get
            {
                return currentClient;
            }

            set
            {
                if (value != currentClient)
                {
                    currentClient = value;
                    RaisePropertyChanged("CurrentClient");
                }
            }
        }
        //This is where the logic for the authentification goes. It will take the username, check it against a database, then verify if the username 
        //matches the password and enter the Client's account
         
        public void Authentify()
        {
            IsAuthentified = true;
        }

        //Client logs out, is no longer authentified
        public void LogOut()
        {
            IsAuthentified = false;
        }


    }
}
