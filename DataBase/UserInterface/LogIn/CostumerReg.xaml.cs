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
    /// Interaction logic for CostumerReg.xaml
    /// </summary>
    public partial class CostumerReg : Window
    {
        private LogIn_costumer log = new LogIn_costumer();
        public CostumerReg()
        {
            InitializeComponent();

        }


        private async void submit_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (await log.ChackIfExsistsAsync(Email.Text))
                {
                    MessageBox.Show("Costumer already exists with this Email");

                }
                else
                {
                    if (Password.Password.Length < 8 || Password.Password.Length > 12)
                    {
                        MessageBox.Show("Password Must be between 8-12 characters! ");
                        Password.Clear();
                        return;
                    }
                    foreach (var Tbox in WinGrid.Children.OfType<TextBox>())
                    {
                        if (Tbox.Text == string.Empty)
                        {
                            MessageBox.Show("Cannot leave empty fields!");
                            return;
                        }
                    }
                    await log.RegistarAsync(Streetname.Text, int.Parse(Housenumber.Text), int.Parse(APT.Text), int.Parse(Zip.Text), City.Text, Firstname.Text, Lastname.Text, Bdate.SelectedDate.Value.Date, Password.Password, Phonenumber.Text, false, Email.Text);
                    MessageBox.Show($"User Created! Please log in now", "Congratulation", MessageBoxButton.OK);
                    Close();

                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }
    }
}
