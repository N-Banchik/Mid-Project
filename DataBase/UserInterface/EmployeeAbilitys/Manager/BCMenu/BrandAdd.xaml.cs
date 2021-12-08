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
    /// Interaction logic for BrandAdd.xaml
    /// </summary>
    public partial class BrandAdd : Window
    {
        private UnitOfWork_Employee Unit_Employee;
        private Brands _Brand;
        public BrandAdd(UnitOfWork_Employee _Unit_Employee, Brands Category)
        {
            Unit_Employee = _Unit_Employee;
            _Brand = Category;

            InitializeComponent();
        }



        private async void Add_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                _Brand.Brand_Name = Name.Text;
                _Brand.Manufacturing_Country = Manufacturingcountry.Text;

                await Unit_Employee.brands.Add(_Brand);
                await Unit_Employee.CompleteAsync();
                MessageBox.Show("Brand added!");
                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
