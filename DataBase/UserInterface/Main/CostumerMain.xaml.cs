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
using DataBase.Models;
using Logic_Layer.DataAccess.Access;
using UserInterface.UserAbilitys;

namespace UserInterface.Main
{
    /// <summary>
    /// Interaction logic for CostumerMain.xaml
    /// </summary>
    public partial class CostumerMain : Window
    {
        private Costumers costumer;
        private UnitOfWork_Costumer unitOfWork_;
        public CostumerMain(UnitOfWork_Costumer unit, Costumers costumers)
        {
            InitializeComponent();
            costumer = costumers;
            unitOfWork_ = unit;
        }

        private void HelloBox_Loaded(object sender, RoutedEventArgs e)
        {
            HelloBox.Text = $"Hello {costumer.First_Name + " " + costumer.last_Name}";
        }

        private void Neworder_Click(object sender, RoutedEventArgs e)
        {

        }

        private async void Showorders_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                costumer.Orders = await unitOfWork_.orders.GetByCondition(i => i.Costumer_ID == costumer.Costumer_ID);
                User_viewOrders _ViewOrders = new(unitOfWork_, costumer);
                _ViewOrders.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

        }

        private async void Editpersonaldata_Click(object sender, RoutedEventArgs e)
        {

        }

        private void Logout_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
