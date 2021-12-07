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
    /// Interaction logic for BrandCategoryMenu.xaml
    /// </summary>
    public partial class BrandCategoryMenu : Window
    {
        private UnitOfWork_Employee Uow_Employee;
        


        public BrandCategoryMenu(UnitOfWork_Employee _Uow_Employee)
        {
            Uow_Employee = _Uow_Employee;
            InitializeComponent();
        }

        private void updateBtnBrand_Click(object sender, RoutedEventArgs e)
        {
            BrandUpdate brandUpdate = new(Uow_Employee, Brands.SelectedItem as Brands);
            brandUpdate.ShowDialog();

        }

        private void updateBtnCategory_Click(object sender, RoutedEventArgs e)
        {
            CategoryUpdate categoryUpdate = new(Uow_Employee, Category.SelectedItem as Categories);
            categoryUpdate.ShowDialog();
        }

        private void AddBrands_Click(object sender, RoutedEventArgs e)
        {
            BrandAdd BrandAdd = new(Uow_Employee, new Brands());
            BrandAdd.ShowDialog();
        }

        private void Addcategory_Click(object sender, RoutedEventArgs e)
        {
            CategoryAdd categoryAdd = new(Uow_Employee, new Categories());
            categoryAdd.ShowDialog();
        }

        private async void SeeBrands_Click(object sender, RoutedEventArgs e)
        {

            Brands.ItemsSource = await Uow_Employee.brands.GetAllAsync();
        }

        private async void SeeCategories_Click(object sender, RoutedEventArgs e)
        {
            Category.ItemsSource = await Uow_Employee.category.GetAllAsync();
        }
    }
}
