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
    /// Interaction logic for CostumerLogin.xaml
    /// </summary>
    public partial class CostumerLogin : Window
    {
        private LogIn_costumer log = new LogIn_costumer();
        public CostumerLogin()
        {
            InitializeComponent();
        }

        private void Register_Click(object sender, RoutedEventArgs e)
        {
            CostumerReg reg = new();
            reg.Show();
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
                    var costumer = await log.LogInAsync(Email_Text.Text, passwordText.Password);
                    if (costumer!=null)
                    {
                        CostumerMain main = new(log.costumer, costumer);
                        main.Show();
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
