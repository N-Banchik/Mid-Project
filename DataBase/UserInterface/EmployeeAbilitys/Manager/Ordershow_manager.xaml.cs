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
    /// Interaction logic for Ordershow_manager.xaml
    /// </summary>
    public partial class Ordershow_manager : Window
    {
        private Orders order;
        private UnitOfWork_Employee unit;

        public Ordershow_manager(UnitOfWork_Employee _unit, Orders order)
        {
            unit = _unit;
            this.order = order;
            InitializeComponent();
            Orderoutput.Loaded += PrintDetails;
        }
        private async void PrintDetails(object sender, RoutedEventArgs e)
        {
            order.items = await unit.orderitems.GetByCondition(i => i.Order_id == order.Order_ID);
            order.Total_Cost = await unit.orderitems.GetTotalCostAsync(order.Order_ID);
            order.Total_Weiget = await unit.orderitems.GetTotalWeightAsync(order.Order_ID);
            Orderoutput.Text = $"Order-ID - {order.Order_ID}\n" +
                $"Order Date - {order.Order_Date}\n" +
                $"Shipping Date -{(order.Ship_Date < order.Ship_Date ? "Not Shipped yet" : order.Ship_Date)}\n" +
                $"Total Weight -{order.Total_Weiget}\n" +
                $"Total Cost - {order.Total_Cost}\n" +
                $"Address - {order.Costumer_Address}\n";
            ItemsShow.ItemsSource = order.items;
        }
    }
}
