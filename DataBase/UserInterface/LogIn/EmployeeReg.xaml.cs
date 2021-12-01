using Logic_Layer.Log_in;
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

namespace UserInterface.LogIn
{
    /// <summary>
    /// Interaction logic for EmployeeReg.xaml
    /// </summary>
    public partial class EmployeeReg : Window
    {
        LogIn_employee log = new();
        public EmployeeReg()
        {
            InitializeComponent();
        }
        private async void submit_Click(object sender, RoutedEventArgs e)
        {
            try
            {


                await log.RegistarAsync(Streetname.Text, int.Parse(Housenumber.Text), int.Parse(APT.Text), int.Parse(Zip.Text), City.Text, Firstname.Text, Lastname.Text, Bdate.SelectedDate.Value.Date, Password.Password, Phonenumber.Text, CheckManager.IsChecked.Value, Email.Text);
                MessageBox.Show($"User Created! Please log in now", "Congratulation", MessageBoxButton.OK);
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}