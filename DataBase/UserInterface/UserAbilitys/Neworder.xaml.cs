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

namespace UserInterface.UserAbilitys
{
    /// <summary>
    /// Interaction logic for Neworder.xaml
    /// </summary>
    public partial class Neworder : Window
    {
        private Costumers ME;
        private UnitOfWork_Costumer unitOfWork_;
        List<Categories> Categories;
        List<Brands> Brands;
        List<Items> Items;
        public Neworder(UnitOfWork_Costumer unit, Costumers costumers)
        {
            InitializeComponent();
            ME = costumers;
            unitOfWork_ = unit;
        }

        private async void Window_Loaded(object sender, RoutedEventArgs e)
        {
           
        }

        private void deleteBtn_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
