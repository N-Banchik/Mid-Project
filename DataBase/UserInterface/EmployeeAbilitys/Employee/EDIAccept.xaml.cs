using DataBase.Models;
using DataBase.Models.Connactions;
using Logic_Layer.DataAccess.Access;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Data;
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
        private UnitOfWork_Employee Unit_Employee;
        private Employees _employee;
        private EDI edi;
        private ObservableCollection<EDIItems> _items = new ObservableCollection<EDIItems>();
        ObservableCollection<EDIItems> itm = new ObservableCollection<EDIItems>();
        public EDIAccept(UnitOfWork_Employee UoWemployee, Employees employee)
        {
            InitializeComponent();
            Unit_Employee = UoWemployee;
            _employee = employee;
            ContentRendered += Getedi;
            ViewGrid.BeginningEdit += Beginedit;
        }

        private void Beginedit(object sender, DataGridBeginningEditEventArgs e)
        {
            try
            {

                if (e.Column.DisplayIndex == 0)
                {
                    return;
                }
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private async void Getedi(object sender, EventArgs e)
        {
            try
            {

                edi = await Unit_Employee.EDI.GetNextWorkEDIAsync();
                edi.Items.ToList().ForEach((i) => itm.Add(i));
                ViewGrid.ItemsSource = itm;
                EmployeeName.Text = $"{_employee.First_Name} {_employee.last_Name}";
                eduid.Text = edi.EDI_Id.ToString();
                timeplaced.Text = edi.Date.ToString();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private async void submit_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                if (_items.Count < itm.Count)
                {
                    throw new Exception("Not all Items have been reviewed.\n" +
                        "Please review all items.");
                }
                foreach (EDIItems item in _items)
                {
                    await Unit_Employee.items.UpdateInventoryAsync(item.Item_Id, item.QuantityArrived.Value);
                }
                edi.employee = _employee;
                await Unit_Employee.CompleteAsync();
                Close();

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void select_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                ViewGrid.CommitEdit();
                EDIItems item = ViewGrid.SelectedItem as EDIItems;

                if (item.QuantityArrived == null)
                {
                    throw new Exception($"Item {item.Items.Item_Name} do not have Arrived quantity.\n Please indicate number of items");
                }
                if (item.QuantityArrived.Value != item.Quantity)
                {
                    if (MessageBox.Show("Arrived quantity different from quantity on EDI\n is that correct?", " Quantities not matched", MessageBoxButton.YesNo, MessageBoxImage.None, MessageBoxResult.No) == MessageBoxResult.No)
                    {
                        return;
                    }
                }
                _items.Add(ViewGrid.SelectedItem as EDIItems);
                DataGridRow row = null;
                foreach (EDIItems dataobject in this.ViewGrid.SelectedItems)
                {
                    row = this.ViewGrid.ItemContainerGenerator.ContainerFromItem(dataobject) as DataGridRow;
                    row.IsEnabled = false;
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
