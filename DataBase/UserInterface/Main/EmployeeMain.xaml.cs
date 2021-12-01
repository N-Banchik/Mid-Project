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

namespace UserInterface.Main
{
    /// <summary>
    /// Interaction logic for EmployeeMain.xaml
    /// </summary>
    public partial class EmployeeMain : Window
    {
        private UnitOfWork_Employee Uow_Employee;
        private Employees _employee;



        public EmployeeMain()
        {
            InitializeComponent();
        }
        public EmployeeMain(UnitOfWork_Employee UoWemployee, Employees employee)
        {
            InitializeComponent();
            Uow_Employee = UoWemployee;
            _employee = employee;

        }

        private void Helloboxinfo()
        {
            HelloBox.Text = $"Hello {_employee.First_Name}, Last Shift was on {_employee.Shifts.Last().Shift_Start.Day}";
        }
    }
}
