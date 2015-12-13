using LoginWindow.Model;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace LoginWindow.View
{
    /// <summary>
    /// Interaction logic for CreateAccountView.xaml
    /// </summary>
    public partial class CreateAccountView : Window, INotifyPropertyChanged
    {
        //Creates a new client object that will store the login details entered by the person
        private Client newClient = new Client();

        public CreateAccountView()
        {
            InitializeComponent();
        }

        public event PropertyChangedEventHandler PropertyChanged;

        public void RaiseProperty(string property)
        {
            if (PropertyChanged!= null)
            {
                PropertyChanged(this, new PropertyChangedEventArgs(property));
            }
        }
        
        //The data entered here by the person is stored as the username of the client object created above
        private void txtName_TextChanged(object sender, TextChangedEventArgs e)
        {
            
            if (txtUsername.Text.ToString()!= null)
            {
                newClient.Name = txtUsername.Text.ToString();
            }
            else
            {
                MessageBox.Show("Please enter a valid username");
            }
        }

        ////The data entered here by the person is stored as the password of the client object created above
        private void txtPassword_TextChanged(object sender, TextChangedEventArgs e)
        {
            if (txtPassword.Text.ToString() != null)
            {
                newClient.Password = txtPassword.Text.ToString();
            }
            else
            {
                MessageBox.Show("Please enter a valid password");
            }
        }
    }
}
