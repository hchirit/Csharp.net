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
    /// Logique d'interaction pour all_lists.xaml
    /// </summary>
    public partial class all_lists : Window
    {
      
        BL.IBL bl;
        public all_lists(int x)
        {
            InitializeComponent();
            bl = BL.FactoryBL.GetBL();
            showDataGridView(x);                      
        }
        private void showDataGridView(int a )
        {
            
            try
            {
                if (a == 1)
                {
                    DataGrid_s.ItemsSource = null;
                    DataGrid_s.ItemsSource = bl.Allcontract();
                }
                else if (a == 3)
                {
                    DataGrid_s.ItemsSource = null;
                    DataGrid_s.ItemsSource = bl.AllEmployee();
                }
                else if (a == 2)
                {
                    DataGrid_s.ItemsSource = null;
                    DataGrid_s.ItemsSource = bl.AllEmployer();
                }
                else if (a == 4)
                {
                    DataGrid_s.ItemsSource = null;
                    DataGrid_s.ItemsSource = bl.Allspecialization();
                }

            }
            catch (Exception)
            {
                MessageBox.Show("שגיאה", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
