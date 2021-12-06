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
using Logic_Layer.DataAccess.Access;
using Logic_Layer.Log_in;
using UserInterface.EmployeeAbilitys.Manager.Employeemenu;
using UserInterface.LogIn;
using UserInterface.Main;

namespace UserInterface
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();



        }

        private void EmployeeLogInButton_Click(object sender, RoutedEventArgs e)
        {
            EmployeeLogin employeeLogin = new();
            employeeLogin.Show();
            this.WindowState = WindowState.Minimized;
        }

        private void CostumerLogInButton_Click(object sender, RoutedEventArgs e)
        {
            CostumerLogin costumerLogin = new();
            costumerLogin.Show();
            this.WindowState = WindowState.Minimized;
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            EmpMenu empMenu = new EmpMenu(new UnitOfWork_Employee());
            empMenu.ShowDialog();
        }
    }
}
