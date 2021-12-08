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

namespace UserInterface.EmployeeAbilitys
{
    /// <summary>
    /// Interaction logic for PersonalInfoEdit_Employee.xaml
    /// </summary>
    public partial class PersonalInfoEdit_Employee : Window
    {
        private UnitOfWork_Employee Unit_Employee;
        private Employees ME;

        public PersonalInfoEdit_Employee(UnitOfWork_Employee UoWemployee, Employees employee)
        {
            InitializeComponent();
            Unit_Employee = UoWemployee;
            ME = employee;
        }
        private void Window_ContentRendered(object sender, EventArgs e)
        {
            FirstNamebox.Text = ME.First_Name;
            Lastnamebox.Text = ME.last_Name;
            Emailbox.Text = ME.Email;
            Phonebox.Text = ME.Phone_Number;
            Streetbox.Text = ME.Address.Street_Name;
            Housebox.Text = ME.Address.House_Number.ToString();
            Aptbox.Text = ME.Address.Apartment_Number.ToString();
            Zipbox.Text = ME.Address.Zipcode.ToString();
            Citybox.Text = ME.Address.City;
        }

        private async void Updatebtn_Click(object sender, RoutedEventArgs e)
        {
            foreach (var Tbox in WinGrid.Children.OfType<TextBox>())
            {
                if (Tbox.Text==string.Empty)
                {
                    MessageBox.Show("Cannot leave empty fields!");
                    return;
                }
            }
            ME.First_Name = FirstNamebox.Text;
            ME.last_Name = Lastnamebox.Text;
            ME.Email = Emailbox.Text;
            ME.Phone_Number = Phonebox.Text;
            ME.Address.Street_Name = Streetbox.Text;
            ME.Address.House_Number = int.Parse(Housebox.Text);
            ME.Address.Apartment_Number = int.Parse(Aptbox.Text);
            ME.Address.Zipcode = int.Parse(Zipbox.Text);
            ME.Address.City = Citybox.Text;
            await Unit_Employee.employee.Upsert(ME);
            await Unit_Employee.CompleteAsync();
            MessageBox.Show("User updated");
            Close();

        }

        private async void PassUpdatebtn_Click(object sender, RoutedEventArgs e)
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
                    await Unit_Employee.employee.UpdatePasswordAsync(ME.Email, Passwordbox.Password);
                    await Unit_Employee.CompleteAsync();
                }
            }

        }

    }
}
