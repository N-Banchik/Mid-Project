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
        private UnitOfWork_Employee Unit_Employee;
        public OrderMenu(UnitOfWork_Employee UoWemployee)
        {
            InitializeComponent();
            Unit_Employee = UoWemployee;
        }

        private async void Search_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                DateTime? dateTimestart = StartDate.SelectedDate == null ? StartDate.SelectedDate = DateTime.Today : StartDate.SelectedDate.Value;
                DateTime? dateTimeend = EndDate.SelectedDate == null ? StartDate.SelectedDate = DateTime.Today : EndDate.SelectedDate.Value;
               

                if (EDIid.Text != string.Empty)
                {
                    OrderShow.ItemsSource = await Unit_Employee.EDI.GetByCondition(i=>i.EDI_Id==int.Parse(EDIid.Text));
                }
                else
                {
                    OrderShow.ItemsSource = await Unit_Employee.EDI.GetbyDateAsync(dateTimestart.Value, dateTimeend.Value);
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
                OrderShow.ItemsSource = await Unit_Employee.EDI.GetAllNotapprovedAsync();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
        

        private void ShowEDIDetails_Click(object sender, RoutedEventArgs e)
        {
            Ordershow_manager ordershow_Manager = new(Unit_Employee,OrderShow.SelectedItem as EDI);
            ordershow_Manager.ShowDialog();
        }

    }
}
