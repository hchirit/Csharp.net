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
    /// Logique d'interaction pour update_Employee.xaml
    /// </summary>
    public partial class update_Employee : Window
    {
        BE.Employee employee;
        BL.IBL bl;
        public update_Employee(BL.IBL Bl)
        {
            this.bl = Bl;
            InitializeComponent();
            employee = new BE.Employee();
            this.DataContext = employee;

            bl = BL.FactoryBL.GetBL();
          //  showDataGridView();
            foreach (int id in bl.return_names_id_employee())
            {
                comboBox.Items.Add(id);
            }
        }
        private void showDataGridView()
        {
            try
            {
                DataGrid_s.ItemsSource = null;
                DataGrid_s.ItemsSource = bl.AllEmployee();
            }
            catch (Exception)
            {
                MessageBox.Show("שגיאה", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void addButton_Click(object sender, RoutedEventArgs e)
        {
            int ID;
            int.TryParse(comboBox.SelectedItem.ToString(), out ID);
            try
            {
                employee.ID = ID;
                bl.uptdateEmployee(employee);
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

        private void comboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int ID;
            int.TryParse(comboBox.SelectedItem.ToString(), out ID);
            employee = bl.return_emploee(ID);
            this.DataContext = employee;
            showDataGridView();
        }

        private void REMOVE_Click(object sender, RoutedEventArgs e)
        {
            int ID;
            try
            {
                int.TryParse(comboBox.SelectedItem.ToString(), out ID);
                bl.removeEmployee(ID);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
