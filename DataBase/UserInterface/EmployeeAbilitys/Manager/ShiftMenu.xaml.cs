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
using UserInterface.EmployeeAbilitys.Manager.Employeemenu;

namespace UserInterface.EmployeeAbilitys.Manager
{
    /// <summary>
    /// Interaction logic for ShiftMenu.xaml
    /// </summary>
    public partial class ShiftMenu : Window
    {
        private UnitOfWork_Employee Unit_Employee;
        private Employees _employee;
        public ShiftMenu(UnitOfWork_Employee UoWemployee, Employees employee)
        {
            InitializeComponent();
            Unit_Employee = UoWemployee;
            _employee = employee;

        }



        private async void ShowToday_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                ShiftShow.ItemsSource = await Unit_Employee.shifts.GetByCondition(i => i.Shift_Start.Date == DateTime.Today && i.Shift_End < i.Shift_Start);
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private async void Search_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DateTime? dateTimestart = StartDate.SelectedDate == null ? StartDate.SelectedDate = DateTime.Today : StartDate.SelectedDate.Value;
                DateTime? dateTimeend = EndDate.SelectedDate == null ? dateTimestart : EndDate.SelectedDate.Value;
                if (ById.Text != string.Empty)
                {

                    ShiftShow.ItemsSource = await Unit_Employee.shifts.GetByCondition(i => i.Shift_Start.Date >= dateTimestart && i.Shift_End <= dateTimeend && i.Employee_ID == int.Parse(ById.Text));

                }
                else
                {
                    ShiftShow.ItemsSource = await Unit_Employee.shifts.GetByCondition(i => i.Shift_Start.Date >= dateTimestart && i.Shift_End <= dateTimeend);

                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private async void Employeeinfo_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                PersonalInfoEdit_Employee PE = new(Unit_Employee, await Unit_Employee.employee.GetById((ShiftShow.SelectedItem as Shifts).Employee_ID));
                PE.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
