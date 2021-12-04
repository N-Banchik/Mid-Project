
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
using DataBase.Models;
using Logic_Layer.DataAccess.Access;

namespace UserInterface.EmployeeAbilitys.Manager.BCMenu
{
    /// <summary>
    /// Interaction logic for CategoryAdd.xaml
    /// </summary>
    public partial class CategoryAdd : Window
    {
        private UnitOfWork_Employee Uow_Employee;
        private Categories _Category;
        public CategoryAdd(UnitOfWork_Employee _Uow_Employee, Categories Category)
        {
            Uow_Employee = _Uow_Employee;
            _Category = Category;

            InitializeComponent();
        }



        private async void Add_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                _Category.Category_Name = Name.Text;
                _Category.Description = Description.Text;

                await Uow_Employee.category.Add(_Category);
                await Uow_Employee.CompleteAsync();
                MessageBox.Show("Category added!");
                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
