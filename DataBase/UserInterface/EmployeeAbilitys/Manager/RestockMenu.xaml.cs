using DataBase.Models;
using DataBase.Models.Connactions;
using Logic_Layer.DataAccess.Access;
using System;
using System.Collections.Concurrent;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
    /// Interaction logic for RestockMenu.xaml
    /// </summary>
    public partial class RestockMenu : Window
    {
        private UnitOfWork_Employee Unit_Employee;
        private ObservableCollection<EDIItems> ToView = new ObservableCollection<EDIItems>();
        List<EDIItems> ToOrder = new List<EDIItems>();
        public RestockMenu(UnitOfWork_Employee UoWemployee)
        {
            InitializeComponent();
            Unit_Employee = UoWemployee;

        }

        private async void Window_ContentRendered(object sender, EventArgs e)
        {
            try
            {

                List<Items> items = (List<Items>)await Unit_Employee.items.GetItemsToOrderAsync();
                items.ForEach(i => ToView.Add(new EDIItems { Items = i, Quantity = i.Minimum_Units_In_Inventory - i.Units_In_Inventory }));
                Restockgrid.ItemsSource = ToView;

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void insertBtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                EDIItems eDI = Restockgrid.SelectedItem as EDIItems;
                Restockgrid.CommitEdit();
                if (eDI.Quantity == 0)
                {
                    MessageBox.Show("Item cannot have 0 quantity to order");
                    return;
                }
                ToOrder.Add(eDI);
                DataGridRow row = null;
                foreach (EDIItems dataobject in this.Restockgrid.SelectedItems)
                {
                    row = this.Restockgrid.ItemContainerGenerator.ContainerFromItem(dataobject) as DataGridRow;
                    row.IsEnabled = false;
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private async void Finishorderbtn_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                ToView = null;
                await Unit_Employee.EDI.NewEDIAsync(ToOrder);
                await Unit_Employee.CompleteAsync();
                Close();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private async void acceptall_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Restockgrid.CommitEdit();
                foreach (var item in ToView)
                {
                    if (item.Quantity == 0)
                    {
                        MessageBox.Show("Item cannot have 0 quantity to order");
                        return;
                    }
                    if (ToOrder.Contains(item))
                    {
                        continue;
                    }
                    else
                    {
                        ToOrder.Add(item);
                    }

                }
                Restockgrid.SelectAll();
                DataGridRow row = null;
                foreach (EDIItems dataobject in this.Restockgrid.SelectedItems)
                {
                    row = this.Restockgrid.ItemContainerGenerator.ContainerFromItem(dataobject) as DataGridRow;
                    row.IsEnabled = false;
                }
                try
                {
                    ToView = null;
                    await Unit_Employee.EDI.NewEDIAsync(ToOrder);
                    await Unit_Employee.CompleteAsync();
                    Close();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }


    }
}
