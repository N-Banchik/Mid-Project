using DataBase.Models;
using Logic_Layer.DataAccess.Access;
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
using UserInterface.LogIn;

namespace UserInterface.UserAbilitys
{
    /// <summary>
    /// Interaction logic for PersonalInfoUpdate_costumer.xaml
    /// </summary>
    public partial class PersonalInfoUpdate_costumer : Window
    {
        private Costumers ME;
        private UnitOfWork_Costumer unitOfWork_;
        public PersonalInfoUpdate_costumer(UnitOfWork_Costumer unit, Costumers costumers)
        {
            InitializeComponent();
            ME = costumers;
            unitOfWork_ = unit;
        }

        private async void Window_ContentRendered(object sender, EventArgs e)
        {
            ME.Address = await unitOfWork_.addressCostumer.GetByCondition(i => i.Costumer_ID == ME.Costumer_ID);
            FirstNamebox.Text = ME.First_Name;
            Lastnamebox.Text = ME.last_Name;
            Emailbox.Text = ME.Email;
            Phonebox.Text = ME.Phone_Number;
            Addressgrid.ItemsSource = ME.Address;
        }
        private async void PassUpdatebtn_Click(object sender, RoutedEventArgs e)
        {


            try
            {
                if (Passwordbox.Password.Length is < 8 or > 12)
                {
                    MessageBox.Show("Password Must be between 8-12 characters! ");
                }
                else
                {
                    if (Passwordbox.Password != Repasswordbox.Password)
                    {
                        MessageBox.Show("Passwords not Match ");

                    }
                    else
                    {
                        MessageBox.Show("Password Changed successfully");
                        await unitOfWork_.costumer.UpdatePasswordAsync(ME.Email, Passwordbox.Password);
                        await unitOfWork_.CompleteAsync();
                    }
                }





            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }



        private async void Updatebtn_Click(object sender, RoutedEventArgs e)
        {
            foreach (var Tbox in WinGrid.Children.OfType<TextBox>())
            {
                if (Tbox.Text == string.Empty)
                {
                    MessageBox.Show("Cannot leave empty fields!");
                    return;
                }
            }
            ME.First_Name = FirstNamebox.Text;
            ME.last_Name = Lastnamebox.Text;
            ME.Email = Emailbox.Text;
            ME.Phone_Number = Phonebox.Text;
            await unitOfWork_.CompleteAsync();
            MessageBox.Show("user updated!");
            Close();
        }

        private async void deleteBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Address_Costumers del = Addressgrid.SelectedItem as Address_Costumers;
                if (del==null)
                {
                    MessageBox.Show("Cannot delete an empty address");
                    return;
                }
                await unitOfWork_.addressCostumer.Delete(del.Address_ID);
                await unitOfWork_.CompleteAsync();
                Addressgrid.ItemsSource = null;
                Addressgrid.ItemsSource = ME.Address;

            }
            catch (Exception)
            {

                throw;
            }
        }

        private async void updateBtn_Click_1(object sender, RoutedEventArgs e)
        {
            try
            {
                Address_Costumers update = Addressgrid.SelectedItem as Address_Costumers;
                if (update == null)
                {
                    MessageBox.Show("Cannot update an empty address");
                    return;
                }
                await unitOfWork_.addressCostumer.UpdateAddressAsync(update);
                await unitOfWork_.CompleteAsync();
                Addressgrid.ItemsSource = null;
                Addressgrid.ItemsSource = ME.Address;

            }
            catch (Exception)
            {

                MessageBox.Show("Unable to update  address");

            }
        }

        private async void insertBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                Address_Costumers toadd = Addressgrid.SelectedItem as Address_Costumers;
                if (toadd==null)
                {
                    MessageBox.Show("Cannot update an empty address");
                    return;
                }
                if (toadd.Street_Name==null|| toadd.Street_Name==string.Empty||toadd.City==null|| toadd.City == string.Empty)
                {
                    MessageBox.Show("not all fields are full. please try again");
                    return;
                }
                ME.Address.Add(toadd);
                await unitOfWork_.CompleteAsync();
            }
            catch (Exception)
            {

                MessageBox.Show("Unable to add new address");
            }
        }

    }
}
