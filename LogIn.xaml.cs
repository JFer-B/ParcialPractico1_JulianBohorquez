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
    /// Lógica de interacción para LogIn.xaml
    /// </summary>
    public partial class LogIn : Page
    {
        public LogIn()
        {
            InitializeComponent();
        }

        private void btnLogIn_Click(object sender, RoutedEventArgs e)
        {
            if(txtUsername.Text=="administrador" && txtPassword.Password=="1234")
            {
                MainWindow w = (MainWindow)Window.GetWindow(this);
                w.frameMain.NavigationService.Navigate(new Admin());
            }
            else
            {
                if(txtUsername.Text=="empleado" && txtPassword.Password=="5678")
                {
                    MainWindow w = (MainWindow)Window.GetWindow(this);
                    w.frameMain.NavigationService.Navigate(new Employee());
                }
                else
                {
                    MessageBox.Show("Error: Invalid Credentials");
                    txtUsername.Clear();
                    txtPassword.Clear();
                }
            }
        }
    }
}
