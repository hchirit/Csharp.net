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

namespace UI
{
    /// <summary>
    /// Logique d'interaction pour allEmployee.xaml
    /// </summary>
    public partial class allEmployee : Window
    {

        BE.Employee employee;
        BL.IBL bl;
        public allEmployee(BL.IBL Bl)
        {
            this.bl = Bl;
            InitializeComponent();
            employee = new BE.Employee();
            this.DataContext = employee;
            bl = BL.FactoryBL.GetBL();
            showDataGridView();
        }

        private void showDataGridView()
        {
            try
            {
                employeeDataGrid.ItemsSource = null;
                employeeDataGrid.ItemsSource = bl.allEmployee();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Return(object sender, RoutedEventArgs e)
        {
            Window menuEmployee = new MenuEmployee();
            menuEmployee.Show();
            this.Close();
        }
    }
}
