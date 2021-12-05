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
                DateTime? dateTimestart = StartDate.SelectedDate == null ? StartDate.SelectedDate = DateTime.MinValue : StartDate.SelectedDate.Value;
                DateTime? dateTimeend = EndDate.SelectedDate == null ? dateTimestart : EndDate.SelectedDate.Value;
               

                if (EDIid.Text != string.Empty)
                {
                    OrderShow.ItemsSource = (System.Collections.IEnumerable)await Uow_Employee.EDI.GetById(int.Parse(EDIid.Text));
                }
                else
                {
                    OrderShow.ItemsSource = await Uow_Employee.EDI.GetbyDateAsync(dateTimestart.Value, dateTimeend.Value);
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private async void NotApprovedEDI_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                OrderShow.ItemsSource = await Uow_Employee.EDI.GetnotapprovedAsync();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        

        private void ShowEDIDetails_Click(object sender, RoutedEventArgs e)
        {
            Ordershow_manager ordershow_Manager = new(Uow_Employee,OrderShow.SelectedItem as EDI);
        }

    }
}
