﻿using System;
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
using Logic_Layer.Log_in;
using UserInterface.LogIn;


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
            EmployeeLogin employeeLogin = new EmployeeLogin();
            employeeLogin.Show();
            this.WindowState = WindowState.Minimized;
        }

        private void CostumerLogInButton_Click(object sender, RoutedEventArgs e)
        {
            CostumerLogin costumerLogin = new CostumerLogin();
            costumerLogin.Show();
            this.WindowState = WindowState.Minimized;

        }
    }
}
