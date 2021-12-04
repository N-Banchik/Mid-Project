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

namespace UserInterface.EmployeeAbilitys.Manager.Employeemenu
{
    /// <summary>
    /// Interaction logic for EmpMenu.xaml
    /// </summary>
    public partial class EmpMenu : Window
    {
        private UnitOfWork_Employee Uow_Employee;
        private List<Employees> employees;
        private List<Address_Employees> Address_Employees;
        public EmpMenu(UnitOfWork_Employee Employee)
        {
            Uow_Employee = Employee;
            InitializeComponent();
        }


        private void EmpOrders_Click(object sender, RoutedEventArgs e)
        {
            OrderMenu orderMenu = new(Uow_Employee);
            orderMenu.OrderShow.ItemsSource = (UserShow.SelectedItem as Employees).Orders;
            orderMenu.Show();
        }

        private async void ShowUers_Click(object sender, RoutedEventArgs e)
        {
            Address_Employees = (List<Address_Employees>)await Uow_Employee.addressEmployee.GetAllAsync();
            employees = (List<Employees>)await Uow_Employee.employee.GetAllAsync();
            await Uow_Employee.orders.GetAllAsync();
            if (IDBox.Text != string.Empty)
            {
                UserShow.ItemsSource = employees.Where(i => i.ID == int.Parse(IDBox.Text));
                IDBox.Clear();
            }
            else if (NameBox.Text != string.Empty)
            {
                UserShow.ItemsSource = employees.Where(i => i.First_Name.Contains(NameBox.Text) || i.last_Name.Contains(NameBox.Text));
                NameBox.Clear();
            }
            else if (Phonebox.Text != string.Empty)
            {
                UserShow.ItemsSource = employees.Where(i => i.Phone_Number == Phonebox.Text);
                Phonebox.Clear();
            }
            else if (EmailBox.Text != string.Empty)
            {
                UserShow.ItemsSource = employees.Where(i => i.Email == EmailBox.Text);
                EmailBox.Clear();
            }
            else
            {
                UserShow.ItemsSource = employees;

            }
        }

        private void NewEmp_Click(object sender, RoutedEventArgs e)
        {

        }

        
    }
}
