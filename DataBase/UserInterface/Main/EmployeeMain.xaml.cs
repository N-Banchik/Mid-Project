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

namespace UserInterface.Main
{
    /// <summary>
    /// Interaction logic for EmployeeMain.xaml
    /// </summary>
    public partial class EmployeeMain : Window
    {
        private UnitOfWork_Employee Uow_Employee;
        private Employees _employee;


        public EmployeeMain(UnitOfWork_Employee UoWemployee, Employees employee)
        {
            InitializeComponent();
            Uow_Employee = UoWemployee;
            _employee = employee;
            Closing += onClose;

        }

        private void onClose(object sender, CancelEventArgs e)
        {
        }

        private async void HelloBox_Loaded(object sender, RoutedEventArgs e)
        {

            HelloBox.Text = $"Hello {_employee.First_Name}";
            await Uow_Employee.shifts.NewShiftAsync(_employee.ID);
            await Uow_Employee.CompleteAsync();
        }

        private async void GetShifts_Click(object sender, RoutedEventArgs e)
        {
            
                _employee.Shifts = await Uow_Employee.shifts.GetByCondition(i => i.Employee_ID == _employee.ID);

           
            Shiftdata.ItemsSource = _employee.Shifts;
            Shiftdata.AutoGenerateColumns = true;
        }

        private void Orderwork_Click(object sender, RoutedEventArgs e)
        {

        }

        private async void Close_Click(object sender, RoutedEventArgs e)
        {
          await  Uow_Employee.shifts.UpdateLastShiftAsync(_employee.ID);
           await Uow_Employee.CompleteAsync();
            Close();
        }
    }
}
