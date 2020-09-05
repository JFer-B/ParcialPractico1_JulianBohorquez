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
        int flag = 0;
        int Total = 0;
        private void btnNewProduct_Click(object sender, RoutedEventArgs e)
        {
            string ClientName = txtClientName.Text;
            string ClientCC = txtCC.Text;
            string Product = txtProducto.Text;
            string Cantidad = txtCantidad.Text;
            int Subtotal = 0;
            if(Product=="Pan Aliñado")
            {
                Subtotal = 1000 * int.Parse(Cantidad);
            }
            else
            {
                if(Product=="Pan No Aliñado")
                {
                    Subtotal = 500 * int.Parse(Cantidad);
                }
                else
                {
                    if(Product=="Pan Especial")
                    {
                        Subtotal = 2000 * int.Parse(Cantidad);
                    }
                }
            }
            Total = Total + Subtotal;
            if(flag==0)
            {
                txtRegister.Text = txtRegister.Text + ClientName + "\n" + "C.C. " + ClientCC + "\n\n" + Product + " X " + Cantidad + ".........." + Subtotal.ToString();
                txtCantidad.Clear();
                flag = 1;
            }
            else
            {
                txtRegister.Text = txtRegister.Text + "\n" + Product + " X " + Cantidad + ".........." + Subtotal.ToString();
                txtCantidad.Clear();
            }
        }

        private void btnSell_Click(object sender, RoutedEventArgs e)
        {
            string DateTimeSell = DateTime.Now.ToString();
            txtRegister.Text = txtRegister.Text + "\n\n" + "Total.........." + Total.ToString() + "\n" + DateTimeSell;
        }

        private void btnNewSell_Click(object sender, RoutedEventArgs e)
        {
            Total = 0;
            flag = 0;
            txtClientName.Clear();
            txtCC.Clear();
            txtCantidad.Clear();
            txtRegister.Text = "";
        }
    }
}
