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
        private Employees _employee;
        private Orders _order;
        public OrderMenu(UnitOfWork_Employee UoWemployee, Employees employee)
        {
            InitializeComponent();
            Uow_Employee = UoWemployee;
            _employee = employee;
            Style rowStyle = new Style(typeof(DataGridRow));
            rowStyle.Setters.Add(new EventSetter(DataGridRow.MouseDoubleClickEvent,
                                     new MouseButtonEventHandler(Row_DoubleClick)));
            OrderShow.RowStyle = rowStyle;

        }
        private void Row_DoubleClick(object sender, MouseButtonEventArgs e)
        {
            Orders order = sender as Orders;
            Ordershow_manager os = new Ordershow_manager(Uow_Employee,order);
            os.ShowDialog();
        }
        private async void Search_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DateTime? dateTimestart = StartDate.SelectedDate == null ? StartDate.SelectedDate = DateTime.MinValue : StartDate.SelectedDate.Value;
                DateTime? dateTimeend = EndDate.SelectedDate == null ? dateTimestart : EndDate.SelectedDate.Value;

                if (ById.Text != string.Empty)
                {

                    OrderShow.ItemsSource = await Uow_Employee.orders.GetByCondition(i => i.Order_Date.Date >= dateTimestart && i.Order_Date <= dateTimeend && i.Costumer_ID == int.Parse(ById.Text));

                }
                else if (orderid.Text != string.Empty)
                {
                    OrderShow.ItemsSource = await Uow_Employee.orders.GetByCondition(i => i.Order_Date.Date >= dateTimestart && i.Order_Date <= dateTimeend && i.Order_ID == int.Parse(orderid.Text));

                }
                else
                {
                    OrderShow.ItemsSource = await Uow_Employee.orders.GetByCondition(i => i.Order_Date.Date >= dateTimestart && i.Order_Date <= dateTimeend);

                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
