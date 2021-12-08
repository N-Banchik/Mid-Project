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
        private UnitOfWork_Employee Unit_Employee;



        public BrandCategoryMenu(UnitOfWork_Employee _Unit_Employee)
        {
            Unit_Employee = _Unit_Employee;
            InitializeComponent();
        }

        private void updateBtnBrand_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                BrandUpdate brandUpdate = new(Unit_Employee, Brands.SelectedItem as Brands);
                brandUpdate.ShowDialog();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private void updateBtnCategory_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                CategoryUpdate categoryUpdate = new(Unit_Employee, Category.SelectedItem as Categories);
                categoryUpdate.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void AddBrands_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                BrandAdd BrandAdd = new(Unit_Employee, new Brands());
                BrandAdd.ShowDialog();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void Addcategory_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                CategoryAdd categoryAdd = new(Unit_Employee, new Categories());
                categoryAdd.ShowDialog();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private async void SeeBrands_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                Brands.ItemsSource = await Unit_Employee.brands.GetAllAsync();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private async void SeeCategories_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                Category.ItemsSource = await Unit_Employee.category.GetAllAsync();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
