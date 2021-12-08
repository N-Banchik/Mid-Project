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

namespace UserInterface.UserAbilitys
{
    /// <summary>
    /// Interaction logic for User_viewOrders.xaml
    /// </summary>
    public partial class User_viewOrders : Window
    {
        private Costumers costumer;
        private UnitOfWork_Costumer unitOfWork_;
        public User_viewOrders(UnitOfWork_Costumer unit, Costumers costumers)
        {
            
        }

        private void Details_Click(object sender, RoutedEventArgs e)
        {
            try
            {

                EDIShow order = new(unitOfWork_, OrderViewer.SelectedCells as Orders);
                Window temp = new();
                temp.Content = order;
                temp.ShowDialog();
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }
    }
}
