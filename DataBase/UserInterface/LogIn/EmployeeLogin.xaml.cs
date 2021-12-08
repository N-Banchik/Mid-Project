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
using UserInterface.Main;

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
                    foreach (var Tbox in WinGrid.Children.OfType<TextBox>())
                    {
                        if (Tbox.Text == string.Empty)
                        {
                            MessageBox.Show("Email and Password Cannot be empty");
                            return;
                        }
                    }
                    var employee = await log.LogInAsync(Email_Text.Text, passwordText.Password);
                    if (employee != null)
                    {
                        if (employee.Is_Manager == 1)
                        {
                            ManagerMain Mng_Main = new(log.employee, employee);
                            Mng_Main.Show();
                        }
                        else
                        {
                            EmployeeMain Emp_main = new(log.employee, employee);
                            Emp_main.Show();

                        }
                        this.Close();

                    }
                    else
                    {
                        MessageBox.Show("Email and Password combination is incorrect,please try again", "Information Error", MessageBoxButton.OK);
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
