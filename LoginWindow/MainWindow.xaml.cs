using LoginWindow.View;
using LoginWindow.ViewModel;
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
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LoginWindow
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window, INotifyPropertyChanged
    {
        AuthentificationViewModel currentAuthentification = new AuthentificationViewModel();
        CentralViewModel newModel = new CentralViewModel();
        Window myWindow = new Window();

        public MainWindow()
        {
            InitializeComponent();

        }
        //The AuthentificationView Model is called, which creates a new user with the name as the text entered by user
        private void txtName_TextChanged(object sender, TextChangedEventArgs e)
        {
            currentAuthentification.CurrentClient.Name = txtName.Text.ToString();
        }
        //The AuthentificationView Model is called, which creates a new user with the name as the text entered by user
        private void txtPassword_TextChanged(object sender, TextChangedEventArgs e)
        {
            currentAuthentification.CurrentClient.Password = txtPassword.Text.ToString();
        }

        //On clicking the Login button, the authentification process is initiated. 
        private void Login_Click(object sender, RoutedEventArgs e)
        {
            //Check if user has entered login and password
            if (txtName.Text.ToString() != "" && txtPassword.Text.ToString() != "")
            {
                //if Authentification has been made successfully, user is logged in
                if (Model.Authentification.Authentify(txtName.Text.ToString(), txtPassword.Text.ToString()))
                {
                    MessageBox.Show("You are now logged in");
                    
                }
                //alternatively, he is notified that the user credentials he has tried to enter are not valid 
                else
                {
                    MessageBox.Show("Sorry, this user does not exist");
                }
               
            }
            //If user does not enter any login details, he is asked to enter them 
            else
            {
                MessageBox.Show("Please enter your login details");
            }
            
        }

        //Closing the main window
        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            Close();
        }

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
