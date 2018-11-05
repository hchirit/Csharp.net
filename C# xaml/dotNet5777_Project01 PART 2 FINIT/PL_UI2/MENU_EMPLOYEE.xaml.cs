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

namespace PL_UI2
{
    /// <summary>
    /// Logique d'interaction pour MENU_EMPLOYEE.xaml
    /// </summary>
    public partial class MENU_EMPLOYEE : Window
    {
        BL.IBL bl;
        public MENU_EMPLOYEE()
        {
            InitializeComponent();
            bl = BL.FactoryBL.GetBL();
        }

        private void Employee_b_Click(object sender, RoutedEventArgs e)
        {
            Window addemployee = new ADD_EMPLOYEE(bl);
            addemployee.Show();
        }

        private void button1_Copy1_Click(object sender, RoutedEventArgs e)
        {
            Window remove_Employee = new Remove_employee(bl);
            remove_Employee.Show();
        }

        private void button1_Copy5_Click(object sender, RoutedEventArgs e)
        {
            Window update_Employee = new update_Employee(bl);
            update_Employee.Show();
        }

        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {
            Window alllists = new all_lists(3);
            alllists.Show();
        }

        private void butto_Copy_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
