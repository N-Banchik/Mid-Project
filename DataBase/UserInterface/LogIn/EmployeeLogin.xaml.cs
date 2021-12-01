using System;
using System.Collections.Generic;
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
using Logic_Layer.Log_in;

namespace UserInterface.LogIn
{
    /// <summary>
    /// Interaction logic for EmployeeLogin.xaml
    /// </summary>
    public partial class EmployeeLogin : Window
    {
        private LogIn_employee log;
        public EmployeeLogin()
        {
            InitializeComponent();
            this.log = new LogIn_employee();

        }


        private async void Login_Click(object sender, RoutedEventArgs e)
        {
            if (passwordText.Password.Length < 8 || passwordText.Password.Length > 12)
            {
                MessageBox.Show("Password Must be between 8-12 characters! ");
                passwordText.Clear();
                this.Title = "Employee Log-In";
            }
            else
            {
                try
                {

                    if (await log.LogInAsync(UsernameText.Text, passwordText.Password))
                    {
                        //add employee main screen
                        this.Close();

                    }
                    else
                    {
                        MessageBox.Show("Username and Password combination is incorrect,please try again","Information Error",MessageBoxButton.OK);
                    }
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }
            }
        }
    }
}
