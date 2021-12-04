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
using UserInterface.EmployeeAbilitys.Manager.ItemsMenu;
using UserInterface.EmployeeAbilitys.Manager;

namespace UserInterface.Main
{
    /// <summary>
    /// Interaction logic for ManagerMain.xaml
    /// </summary>
    public partial class ManagerMain : Window
    {
        private UnitOfWork_Employee Uow_Employee;
        private Employees _employee;

        public ManagerMain(UnitOfWork_Employee UoWemployee, Employees employee)
        {
            InitializeComponent();
            Uow_Employee = UoWemployee;
            _employee = employee;

        }



        private void ShiftMenu_Click(object sender, RoutedEventArgs e)
        {
            ShiftMenu shift = new(Uow_Employee, _employee);
            shift.ShowDialog();
        }

        private void OrderMenu_Click(object sender, RoutedEventArgs e)
        {
            OrderMenu orderMenu = new(Uow_Employee, _employee);
            orderMenu.ShowDialog();
        }

        private void ItemMenu_Click(object sender, RoutedEventArgs e)
        {
            Itemmenu item = new(Uow_Employee);
            item.ShowDialog();
        }

        private void UsersMenu_Click(object sender, RoutedEventArgs e)
        {

        }

        private async void HelloBox_Loaded(object sender, RoutedEventArgs e)
        {
            HelloBox.Text = $"Hello {_employee.First_Name}";
            await Uow_Employee.shifts.NewShiftAsync(_employee.ID);
            await Uow_Employee.CompleteAsync();
        }

        private async void Close_Click(object sender, RoutedEventArgs e)
        {
            await Uow_Employee.shifts.UpdateLastShiftAsync(_employee.ID);
            await Uow_Employee.CompleteAsync();
            Close();
        }

        private void BrnadCategory_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
