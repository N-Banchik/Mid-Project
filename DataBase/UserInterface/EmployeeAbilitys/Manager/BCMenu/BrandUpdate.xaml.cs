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

namespace UserInterface.EmployeeAbilitys.Manager.BCMenu
{
    /// <summary>
    /// Interaction logic for BrandUpdate.xaml
    /// </summary>
    public partial class BrandUpdate : Window
    {
        private UnitOfWork_Employee Unit_Employee;
        private Brands _brand;
        public BrandUpdate(UnitOfWork_Employee _Unit_Employee, Brands brand)
        {
            Unit_Employee = _Unit_Employee;
            _brand = brand;
            InitializeComponent();
        }

        private async void Update_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                _brand.Brand_Name = Name.Text;
                _brand.Manufacturing_Country = Manufacturingcountry.Text;
                await Unit_Employee.brands.Add(_brand);
                await Unit_Employee.CompleteAsync();
                Close();
                MessageBox.Show("Brand Updated!");
                Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);

            }
        }

        private void Window_ContentRendered(object sender, EventArgs e)
        {
            Name.Text = _brand.Brand_Name;
            Manufacturingcountry.Text = _brand.Manufacturing_Country;
        }
    }
}
