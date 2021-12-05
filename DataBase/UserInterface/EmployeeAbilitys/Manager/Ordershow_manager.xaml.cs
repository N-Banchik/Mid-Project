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
        private UnitOfWork_Employee unit;
        private EDI _EDI;

        public Ordershow_manager(UnitOfWork_Employee _unit, EDI edi)
        {
            unit = _unit;
            _EDI = edi;
            InitializeComponent();
            ContentRendered += Showitems;

        }

        private void Showitems(object sender, EventArgs e)
        {

            ItemsShow.ItemsSource = _EDI.Items.GroupBy(n => n.Item_Name)
                    .Select(c => new { Key = c.Key, total = c.Count() });

        }
    }
}
