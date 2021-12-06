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

namespace UserInterface.EmployeeAbilitys.Employee
{
    /// <summary>
    /// Interaction logic for EDIAccept.xaml
    /// </summary>
    public partial class EDIAccept : Window
    {
        private UnitOfWork_Employee Uow_Employee;
        private Employees _employee;
        public EDIAccept(UnitOfWork_Employee UoWemployee, Employees employee)
        {
            InitializeComponent();
            Uow_Employee = UoWemployee;
            _employee = employee;
            ContentRendered += Getedi;
        }

        private async void Getedi(object sender, EventArgs e)
        {

            EDI edi = await Uow_Employee.EDI.GetNextEDIAsync();
            ViewGrid.ItemsSource = edi.Items.GroupBy(n => n)
                    .Select(c => new { Key = c.Key, total = c.Count() }).ToDictionary(k => k.Key, t => t.total);
            EmployeeName.Text = $"{_employee.First_Name} {_employee.last_Name}";
            eduid.Text = edi.EDI_Id.ToString();
            timeplaced.Text = edi.Date.ToString();
        }
    }
}
