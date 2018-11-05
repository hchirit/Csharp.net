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
    /// Logique d'interaction pour allContract.xaml
    /// </summary>
    public partial class allContract : Window
    {
        BL.IBL bl;
        BE.Contract contrat;

        public allContract(BL.IBL Bl)
        {
            this.bl = Bl;
            InitializeComponent();
            contrat = new BE.Contract();
            this.DataContext = contrat;
            bl = BL.FactoryBL.GetBL();
            showDataGridView();
        }

        private void showDataGridView()
        {
            try
            {
                contractDataGrid.ItemsSource = null;
                contractDataGrid.ItemsSource = bl.allContract();

            }
            catch (Exception)
            {
                MessageBox.Show("שגיאה", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void button1_return(object sender, RoutedEventArgs e)
        {
            Window menuContract = new MenuContract();
            menuContract.Show();
            this.Close();
        }
    }
}
