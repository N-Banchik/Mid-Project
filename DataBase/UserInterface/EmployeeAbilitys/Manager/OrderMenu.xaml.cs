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
    /// Interaction logic for OrderMenu.xaml
    /// </summary>
    public partial class OrderMenu : Window
    {
        private UnitOfWork_Employee Uow_Employee;
        public OrderMenu(UnitOfWork_Employee UoWemployee)
        {
            InitializeComponent();
            Uow_Employee = UoWemployee;
        }

        private async void Search_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                List<Orders> orders = await Uow_Employee.orders.GetAllAsync() as List<Orders>;
                DateTime? dateTimestart = StartDate.SelectedDate == null ? StartDate.SelectedDate = DateTime.MinValue : StartDate.SelectedDate.Value;
                DateTime? dateTimeend = EndDate.SelectedDate == null ? dateTimestart : EndDate.SelectedDate.Value;

                if (ById.Text != string.Empty)
                {

                    OrderShow.ItemsSource = orders.Where(i => i.Order_Date.Date >= dateTimestart && i.Order_Date <= dateTimeend && i.Costumer_ID == int.Parse(ById.Text));

                }
                else if (orderid.Text != string.Empty)
                {
                    OrderShow.ItemsSource = orders.Where(i => i.Order_Date.Date >= dateTimestart && i.Order_Date <= dateTimeend && i.Order_ID == int.Parse(orderid.Text));

                }
                else
                {
                    OrderShow.ItemsSource = orders.Where(i => i.Order_Date.Date >= dateTimestart && i.Order_Date <= dateTimeend);

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private async void ShowOrderDetails_Click(object sender, RoutedEventArgs e)
        {
            //Ordershow_manager os = new(Uow_Employee, OrderShow.SelectedItem as Orders);
            //os.ShowDialog();

           await Uow_Employee.orders.NewOrderAsync(4,0,0,"Aaa");
           await Uow_Employee.CompleteAsync();

        }
    }
}
