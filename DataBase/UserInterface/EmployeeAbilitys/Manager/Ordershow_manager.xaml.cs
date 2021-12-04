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
        private Orders _order;
        private UnitOfWork_Employee unit;

        public Ordershow_manager(UnitOfWork_Employee _unit, Orders order)
        {
            unit = _unit;
            _order = order;
            InitializeComponent();


        }
        private async void PrintDetails(object sender, EventArgs e)
        {
            _order.items = await unit.orderitems.GetByCondition(i => i.Order_id == _order.Order_ID);
            _order.Total_Cost = await unit.orderitems.GetTotalCostAsync(_order.Order_ID);
            _order.Total_Weiget = await unit.orderitems.GetTotalWeightAsync(_order.Order_ID);
            ItemsShow.ItemsSource = _order.items;
        }

        
    }
}
