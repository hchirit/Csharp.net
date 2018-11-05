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
    /// Logique d'interaction pour UpdateEmployee.xaml
    /// </summary>
    public partial class UpdateEmployee : Window
    {
        BL.IBL bl;
        BE.Employee employee;
        public UpdateEmployee(BL.IBL Bl)
        {
            this.bl = Bl;
            InitializeComponent();
            employee = new BE.Employee();
            this.DataContext = employee;
            this.degreeComboBox.ItemsSource = Enum.GetValues(typeof(BE.Degree));
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
            catch (Exception)
            {
                MessageBox.Show("שגיאה", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        

        private void button_Update(object sender, RoutedEventArgs e)
        {
            try
            {
                bl.updatingEmployee(employee);
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

        private void button1_return(object sender, RoutedEventArgs e)
        {
            Window menuEmployee = new MenuEmployee();
            menuEmployee.Show();
            this.Close();
        }
    }
}
