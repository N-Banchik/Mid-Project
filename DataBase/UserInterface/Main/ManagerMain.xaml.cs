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
        private UnitOfWork_Employee Unit_Employee;
        private Employees ME;

        public ManagerMain(UnitOfWork_Employee UoWemployee, Employees employee)
        {
            InitializeComponent();
            Unit_Employee = UoWemployee;
            ME = employee;

        }



        private void ShiftMenu_Click(object sender, RoutedEventArgs e)
        {
            ShiftMenu shift = new(Unit_Employee, ME);
            shift.ShowDialog();
        }

        private void EDIMenu_Click(object sender, RoutedEventArgs e)
        {
            EDIMenu EDIMenu = new(Unit_Employee);
            EDIMenu.ShowDialog();
        }

        private void ItemMenu_Click(object sender, RoutedEventArgs e)
        {
            Itemmenu item = new(Unit_Employee);
            item.ShowDialog();
        }

        private void UsersMenu_Click(object sender, RoutedEventArgs e)
        {
            UserMenu userMenu = new(Unit_Employee);
            userMenu.ShowDialog();
        }
        private void BrnadCategory_Click(object sender, RoutedEventArgs e)
        {
            BrandCategoryMenu brandCategory = new(Unit_Employee);
            brandCategory.ShowDialog();
        }

        private async void HelloBox_Loaded(object sender, RoutedEventArgs e)
        {
            HelloBox.Text = $"Hello {ME.First_Name} {ME.last_Name}";
            await Unit_Employee.shifts.NewShiftAsync(ME.ID);
            await Unit_Employee.CompleteAsync();
        }
        private void EmployeeMenubtn_Click(object sender, RoutedEventArgs e)
        {
            EmpMenu empMenu = new(Unit_Employee);
            empMenu.ShowDialog();
        }

        private async void Close_Click(object sender, RoutedEventArgs e)
        {
            await Unit_Employee.shifts.UpdateLastShiftAsync(ME.ID);
            await Unit_Employee.CompleteAsync();
            Close();
        }

        private void EditInfo_Click(object sender, RoutedEventArgs e)
        {
            PersonalInfoEdit_Employee personalInfo = new(Unit_Employee, ME);
            personalInfo.ShowDialog();
        }

        private void Restockbtn_Click(object sender, RoutedEventArgs e)
        {
            RestockMenu restockMenu = new(Unit_Employee);
            restockMenu.ShowDialog();
        }
    }
}
