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
        private UnitOfWork_Employee Unit_Employee;
        public Itemadd(UnitOfWork_Employee UoWemployee)
        {
            Unit_Employee = UoWemployee;

            InitializeComponent();
        }

        private async void Additem_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (Categorybox.SelectedValue != null && Brandbox.SelectedValue != null)
                {
                    foreach (var Tbox in WinGrid.Children.OfType<TextBox>())
                    {
                        if (Tbox.Text == string.Empty)
                        {
                            MessageBox.Show("Cannot leave empty fields!");
                            return;
                        }
                        
                    }
                    foreach (var cbox in WinGrid.Children.OfType<ComboBox>())
                    {
                        if (cbox.SelectedItem == null)
                        {
                            MessageBox.Show("Cannot leave empty fields!");
                            return;
                        }

                    }
                    await Unit_Employee.items.AddNewItemAsync(Name.Text, (Categories)Categorybox.SelectedValue, (Brands)Brandbox.SelectedValue, double.Parse(Wight.Text), int.Parse(Inventory.Text), int.Parse(Mininv.Text), double.Parse(Price.Text));
                    await Unit_Employee.CompleteAsync();
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
            Categorybox.ItemsSource = await Unit_Employee.category.GetAllAsync();
            Brandbox.ItemsSource = await Unit_Employee.brands.GetAllAsync();
        }

        private async void NewCategory_Click(object sender, RoutedEventArgs e)
        {
            CategoryAdd categoryAdd = new(Unit_Employee, new());
            categoryAdd.ShowDialog();
            Categorybox.ItemsSource = await Unit_Employee.category.GetAllAsync();
        }

        private async void NewBrand_Click(object sender, RoutedEventArgs e)
        {
            BrandAdd BrandAdd = new(Unit_Employee, new());
            BrandAdd.ShowDialog();
            Brandbox.ItemsSource = await Unit_Employee.brands.GetAllAsync();

        }
    }
}
