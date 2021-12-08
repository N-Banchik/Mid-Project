using DataBase.Models;
using DataBase.Models.Connactions;
using Logic_Layer.DataAccess.Access;
using System;
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
    /// Interaction logic for EDIShow_manager.xaml
    /// </summary>
    public partial class EDIShow_manager : Window
    {
        private UnitOfWork_Employee unit;
        private EDI _EDI;

        public EDIShow_manager(UnitOfWork_Employee _unit, EDI edi)
        {
            unit = _unit;
            _EDI = edi;
            InitializeComponent();
            ContentRendered += Showitems;

        }

        private void Showitems(object sender, EventArgs e)
        {
            ObservableCollection<EDIItems> itm = new ObservableCollection<EDIItems>(_EDI.Items.ToList());
            ItemsShow.ItemsSource =itm;

        }
    }
}
