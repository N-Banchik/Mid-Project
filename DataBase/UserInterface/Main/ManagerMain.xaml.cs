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
using UserInterface.EmployeeAbilitys.Manager.BCMenu;
using UserInterface.EmployeeAbilitys.Manager.Employeemenu;
using UserInterface.EmployeeAbilitys;

namespace UserInterface.Main
{
    /// <summary>
    /// Interaction logic for ManagerMain.xaml
    /// </summary>
    public partial class ManagerMain : Window
    {
        private UnitOfWork_Employee Uow_Employee;
        private Employees ME;

        public ManagerMain(UnitOfWork_Employee UoWemployee, Employees employee)
        {
            InitializeComponent();
            Uow_Employee = UoWemployee;
            ME = employee;

        }



        private void ShiftMenu_Click(object sender, RoutedEventArgs e)
        {
            ShiftMenu shift = new(Uow_Employee, ME);
            shift.ShowDialog();
        }

        private void OrderMenu_Click(object sender, RoutedEventArgs e)
        {
            OrderMenu orderMenu = new(Uow_Employee);
            orderMenu.ShowDialog();
        }

        private void ItemMenu_Click(object sender, RoutedEventArgs e)
        {
            Itemmenu item = new(Uow_Employee);
            item.ShowDialog();
        }

        private void UsersMenu_Click(object sender, RoutedEventArgs e)
        {
            UserMenu userMenu = new(Uow_Employee);
            userMenu.ShowDialog();
        }
        private void BrnadCategory_Click(object sender, RoutedEventArgs e)
        {
            BrandCategoryMenu brandCategory = new(Uow_Employee);
            brandCategory.ShowDialog();
        }

        private async void HelloBox_Loaded(object sender, RoutedEventArgs e)
        {
            HelloBox.Text = $"Hello {ME.First_Name} {ME.last_Name}";
            await Uow_Employee.shifts.NewShiftAsync(ME.ID);
            await Uow_Employee.CompleteAsync();
        }
        private void EmployeeMenubtn_Click(object sender, RoutedEventArgs e)
        {
            EmpMenu empMenu = new(Uow_Employee);
            empMenu.ShowDialog();
        }

        private async void Close_Click(object sender, RoutedEventArgs e)
        {
            await Uow_Employee.shifts.UpdateLastShiftAsync(ME.ID);
            await Uow_Employee.CompleteAsync();
            Close();
        }

        private void EditInfo_Click(object sender, RoutedEventArgs e)
        {
            PersonalInfoEdit_Employee personalInfo = new(Uow_Employee, ME);
            personalInfo.ShowDialog();
        }
    }
}
