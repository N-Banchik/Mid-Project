using Logic_Layer.DataAccess.Access;
using Logic_Layer.Log_in;
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
using System.ComponentModel;
using UserInterface.EmployeeAbilitys;

namespace UserInterface.Main
{
    /// <summary>
    /// Interaction logic for EmployeeMain.xaml
    /// </summary>
    public partial class EmployeeMain : Window
    {
        private UnitOfWork_Employee Uow_Employee;
        private Employees ME;

        public EmployeeMain(UnitOfWork_Employee UoWemployee, Employees employee)
        {
            InitializeComponent();
            Uow_Employee = UoWemployee;
            ME = employee;
        }
        private async void HelloBox_Loaded(object sender, RoutedEventArgs e)
        {

            HelloBox.Text = $"Hello {ME.First_Name}";
            await Uow_Employee.shifts.NewShiftAsync(ME.ID);
            await Uow_Employee.CompleteAsync();
        }

        private  void GetShifts_Click(object sender, RoutedEventArgs e)
        {
            Shiftdata.ItemsSource = ME.Shifts;
        }

        private void Orderwork_Click(object sender, RoutedEventArgs e)
        {

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
