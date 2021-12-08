using System;
using System.Collections.Generic;
using System.Data;
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
using DataBase.Models;
using Logic_Layer.DataAccess.Access;

namespace UserInterface.EmployeeAbilitys.Manager.ItemsMenu
{
    /// <summary>
    /// Interaction logic for Itemmenu.xaml
    /// </summary>
    public partial class Itemmenu : Window
    {
        private UnitOfWork_Employee Unit_Employee;
        private Items _items;

        private List<Items> itemlist;

        public Itemmenu(UnitOfWork_Employee UoWemployee)
        {
            Unit_Employee = UoWemployee;
            InitializeComponent();
        }

        private async void Categorybox_Loaded(object sender, RoutedEventArgs e)
        {
            Categorybox.ItemsSource = await Unit_Employee.category.GetAllAsync();
            Brandbox.ItemsSource = await Unit_Employee.brands.GetAllAsync();


        }
        private async Task updateItemlistAsync()
        {

            itemlist = (List<Items>)await Unit_Employee.items.GetAllAsync();
            ItemsShow.ItemsSource = null;
            ItemsShow.ItemsSource = itemlist;

        }

        private async void search_Click(object sender, RoutedEventArgs e)
        {

            await updateItemlistAsync();

            try
            {
                if (Brandbox.SelectedItem == null && Categorybox.SelectedItem == null)
                {

                    ItemsShow.ItemsSource = itemlist;

                }
                else if (Categorybox.SelectedItem == null && Brandbox.SelectedItem != null)
                {

                    ItemsShow.ItemsSource = itemlist.Where(i => i.Brand.Brand_Name == Brandbox.SelectedValue.ToString());
                }
                else if (Brandbox.SelectedItem == null && Categorybox.SelectedItem != null)
                {
                    ItemsShow.ItemsSource = itemlist.Where(i => i.Category.Category_Name == Categorybox.SelectedValue.ToString());
                }

                if (Itemname.Text != string.Empty)
                {
                    ItemsShow.ItemsSource = itemlist.Where(i => i.Item_Name.Contains(Itemname.Text));
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private async void updateBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                ItemUpdate itemUpdate = new(Unit_Employee, ItemsShow.SelectedItem as Items);
                itemUpdate.ShowDialog();
                await updateItemlistAsync();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }


        }

        private async void deleteBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                _items = ItemsShow.SelectedItem as Items;
                await Unit_Employee.items.Delete(_items.Item_ID);
                await Unit_Employee.CompleteAsync();
                _items = null;
                await updateItemlistAsync();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private async void Additembtn_Click(object sender, RoutedEventArgs e)
        {
            Itemadd itemadd = new(Unit_Employee);
            itemadd.ShowDialog();
            await updateItemlistAsync();
            Categorybox.ItemsSource = await Unit_Employee.category.GetAllAsync();
            Brandbox.ItemsSource = await Unit_Employee.brands.GetAllAsync();
        }
    }
}
