using BE;
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
using BL;

namespace PL_UI2
{

    public partial class ADD_EMPLOYEE : Window
    {
        BE.Employee employee;
        BL.IBL bl;
        public ADD_EMPLOYEE(BL.IBL Bl)
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
                DataGrid_s.ItemsSource = null;
                DataGrid_s.ItemsSource = bl.AllEmployee();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {

            try
            {
                bl.addEmployee(employee);
                employee = new BE.Employee();
                this.DataContext = employee;
                showDataGridView();
            }
            catch (Exception ex)
            {
                showDataGridView();
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

    }
}
