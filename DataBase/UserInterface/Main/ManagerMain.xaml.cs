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
        
    }
}
