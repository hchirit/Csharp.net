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
    /// Interaction logic for Contract_to_employer.xaml
    /// </summary>
    public partial class Contract_to_employer : Window
    {
        BL.IBL bl;
        public Contract_to_employer()
        {
            InitializeComponent();
            bl = BL.FactoryBL.GetBL();

            foreach (int id in bl.return_names_id_employer())
            {
                comboBox_1.Items.Add(id);
            }
        }
        private void showDataGridView(int k)
        {
            try
            {
                DataGrid_s.ItemsSource = null;
                DataGrid_s.ItemsSource = bl.AllCONTRACT_TO_EMPLOYER(k);
            }
            catch (Exception)
            {
                MessageBox.Show("שגיאה", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void comboBox_1_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            int k;
            string i = comboBox_1.SelectedValue.ToString();
            Int32.TryParse(i, out k);
            showDataGridView(k);
        }

        private void menu_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
