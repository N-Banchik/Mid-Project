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

namespace UserInterface.EmployeeAbilitys.Manager
{
    /// <summary>
    /// Interaction logic for UserMenu.xaml
    /// </summary>
    public partial class UserMenu : Window
    {
        private UnitOfWork_Employee Uow_Employee;
        List<Address_Costumers> _Address_Costumers;
        List<Costumers> _costumers;
        public UserMenu(UnitOfWork_Employee Employee)
        {
            Uow_Employee = Employee;
            InitializeComponent();
        }


        private void UserOrders_Click(object sender, RoutedEventArgs e)
        {
            OrderMenu orderMenu = new(Uow_Employee);
            orderMenu.ById.Text = (UserShow.SelectedItem as Costumers).Costumer_ID.ToString();
            orderMenu.OrderShow.ItemsSource = (UserShow.SelectedItem as Costumers).Orders;
            orderMenu.Show();
        }

        private async void ShowUers_Click(object sender, RoutedEventArgs e)
        {
            _Address_Costumers = (List<Address_Costumers>)await Uow_Employee.addressCostumer.GetAllAsync();
            _costumers = (List<Costumers>)await Uow_Employee.costumer.GetAllAsync();
            if (IDBox.Text != string.Empty)
            {
                UserShow.ItemsSource = _costumers.Where(i => i.Costumer_ID == int.Parse(IDBox.Text));
                IDBox.Clear();
            }
            else if (NameBox.Text != string.Empty)
            {
                UserShow.ItemsSource = _costumers.Where(i => i.First_Name.Contains(NameBox.Text) || i.last_Name.Contains(NameBox.Text));
                NameBox.Clear();
            }
            else if (Phonebox.Text != string.Empty)
            {
                UserShow.ItemsSource = _costumers.Where(i => i.Phone_Number == Phonebox.Text);
                Phonebox.Clear();
            }
            else if (EmailBox.Text != string.Empty)
            {
                UserShow.ItemsSource = _costumers.Where(i => i.Email == EmailBox.Text);
                EmailBox.Clear();
            }
            else
            {
                UserShow.ItemsSource = _costumers;

            }


        }
    }
}
