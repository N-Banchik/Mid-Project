using DataBase.Models;
using UserInterface.EmployeeAbilitys.Manager.BCMenu;
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

namespace UserInterface.EmployeeAbilitys.Manager.ItemsMenu
{
    /// <summary>
    /// Interaction logic for Itemadd.xaml
    /// </summary>
    public partial class Itemadd : Window
    {
        private UnitOfWork_Employee Uow_Employee;
        public Itemadd(UnitOfWork_Employee UoWemployee)
        {
            Uow_Employee = UoWemployee;

            InitializeComponent();
        }

        private async void Additem_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (Categorybox.SelectedValue != null && Brandbox.SelectedValue != null)
                {
                    await Uow_Employee.items.AddNewItemAsync(Name.Text, (Categories)Categorybox.SelectedValue, (Brands)Brandbox.SelectedValue, double.Parse(Wight.Text), int.Parse(Inventory.Text), int.Parse(Mininv.Text), double.Parse(Price.Text));
                    await Uow_Employee.CompleteAsync();
                    MessageBox.Show("Item Added Successfully");
                    Close();
                    

                }
                else
                {
                    throw new Exception("Category or Brand Must BE Chosen");
                }
                
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private async void Categorybox_Loaded(object sender, RoutedEventArgs e)
        {
            Categorybox.ItemsSource = await Uow_Employee.category.GetAllAsync();
            Brandbox.ItemsSource = await Uow_Employee.brands.GetAllAsync();
        }

        private async void NewCategory_Click(object sender, RoutedEventArgs e)
        {
            CategoryAdd categoryAdd = new(Uow_Employee, new());
            categoryAdd.ShowDialog();
            Categorybox.ItemsSource = await Uow_Employee.category.GetAllAsync();
        }

        private async void NewBrand_Click(object sender, RoutedEventArgs e)
        {
            BrandAdd BrandAdd = new(Uow_Employee, new());
            BrandAdd.ShowDialog();
            Brandbox.ItemsSource = await Uow_Employee.brands.GetAllAsync();

        }
    }
}
