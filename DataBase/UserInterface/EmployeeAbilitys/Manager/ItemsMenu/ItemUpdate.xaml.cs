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

namespace UserInterface.EmployeeAbilitys.Manager.ItemsMenu
{
    /// <summary>
    /// Interaction logic for ItemUpdate.xaml
    /// </summary>
    public partial class ItemUpdate : Window
    {
        private UnitOfWork_Employee Uow_Employee;
        private Items _Item;
        public ItemUpdate(UnitOfWork_Employee UoWemployee, Items Item)
        {
            _Item = Item;
            Uow_Employee = UoWemployee;
            InitializeComponent();
        }

        private async void Categorybox_Loaded(object sender, RoutedEventArgs e)
        {

            Categorybox.ItemsSource = await Uow_Employee.category.GetAllAsync();
            Brandbox.ItemsSource = await Uow_Employee.brands.GetAllAsync();
        }

        private async void Update_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                _Item.Item_Name = Name.Text;
                _Item.Price = double.Parse(Price.Text);
                _Item.Weight = double.Parse(Wight.Text);
                _Item.Minimum_Units_In_Inventory = int.Parse(Mininv.Text);
                if (_Item.Category!=Categorybox.SelectedValue)
                {
                    _Item.Category = (Categories)Categorybox.SelectedValue;
                }


                await Uow_Employee.items.Upsert(_Item);
                await Uow_Employee.CompleteAsync();
                MessageBox.Show("Item Updated.");
                Close();


            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void Window_ContentRendered(object sender, EventArgs e)
        {
            try
            {

                Name.Text = _Item.Item_Name;
                Price.Text = _Item.Price.ToString();
                Wight.Text = _Item.Weight.ToString();
                Inventory.Text = _Item.Units_In_Inventory.ToString();
                Inventory.IsEnabled = true;
                Mininv.Text = _Item.Minimum_Units_In_Inventory.ToString();
                Categorybox.SelectedItem = _Item.Category;
                Brandbox.SelectedItem = _Item.Brand;
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void NewBrand_Click(object sender, RoutedEventArgs e)
        {

        }

        private void NewCategory_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
