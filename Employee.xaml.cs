using System;
using System.Collections.Generic;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace ParcialPractico1_JulianBohorquez
{
    /// <summary>
    /// Lógica de interacción para Employee.xaml
    /// </summary>
    public partial class Employee : Page
    {
        public Employee()
        {
            InitializeComponent();
        }

        private void btnLogOut_Employee_Click(object sender, RoutedEventArgs e)
        {
            MainWindow w = (MainWindow)Window.GetWindow(this);
            w.frameMain.NavigationService.Navigate(new LogIn());
        }
    }
}
