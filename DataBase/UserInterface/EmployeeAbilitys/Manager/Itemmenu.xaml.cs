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

namespace UserInterface.EmployeeAbilitys.Manager
{
    /// <summary>
    /// Interaction logic for Itemmenu.xaml
    /// </summary>
    public partial class Itemmenu : Window
    {
        private UnitOfWork_Employee Uow_Employee;
        private Items _items;
        private Categories categories;
        private Brands Brands;

        public Itemmenu(UnitOfWork_Employee UoWemployee)
        {
            Uow_Employee = UoWemployee;
            InitializeComponent();
        }

        private async void Categorybox_Loaded(object sender, RoutedEventArgs e)
        {
            Categorybox.ItemsSource = await Uow_Employee.category.GetAllAsync();
            Brandbox.ItemsSource = await Uow_Employee.brands.GetAllAsync();


        }

        private async void Categorybox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        }



        private void Brandbox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private async void search_Click(object sender, RoutedEventArgs e)
        {
            //categories = await Uow_Employee.category.GetOneByCondition(i => i.Category_Name == Categorybox.SelectedValue.ToString());
            //categories.item = await Uow_Employee.items.GetByCondition(i => i.Category_Id == categories.Category_ID);
            //Brands = await Uow_Employee.brands.GetOneByCondition(i => i.Brand_Name == Brandbox.SelectedValue.ToString());
            List<Categories> catlist = (List<Categories>)await Uow_Employee.category.GetAllAsync();
            List<Items> itemlist = (List<Items>)await Uow_Employee.items.GetAllAsync();
            var newlist = catlist.Join(itemlist, i => i.Category_ID, o => o.Category_Id, (category, items) => new { itemname = items.Item_Name, categoryname = category.Category_Name });
            try
            {
                if (Brandbox.SelectedItem == null)
                {

                    ItemsShow.ItemsSource = newlist;

                }
                else if (Categorybox.SelectedItem == null)
                {

                }
                else
                {
                    ItemsShow.ItemsSource = categories.item.Where(i => i.Brand_Id == Brands.Brand_Id);

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }
    }
}
