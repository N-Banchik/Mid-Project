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
using System.Windows.Navigation;
using System.Windows.Shapes;
using DataBase.Models;
using Logic_Layer.DataAccess.Access;

namespace UserInterface.UserAbilitys
{
    /// <summary>
    /// Interaction logic for OrderShow.xaml
    /// </summary>
    public partial class OrderShow : Page
    {
        private Orders order;
        private UnitOfWork_Costumer unit;

        public OrderShow(UnitOfWork_Costumer _unit, Orders order)
        {
            unit = _unit;
            this.order = order;
            InitializeComponent();
            Orderoutput.Loaded += PrintDetails;
        }

        private async void PrintDetails(object sender, RoutedEventArgs e)
        {
            
        }
    }
}
