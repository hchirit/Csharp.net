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
    /// Logique d'interaction pour allEmployer.xaml
    /// </summary>
    public partial class allEmployer : Window
    {
        BE.Employer employer;
        BL.IBL bl;
        public allEmployer(BL.IBL Bl)
        {
            this.bl = Bl;
            InitializeComponent();
            employer = new BE.Employer();
            this.DataContext = employer;
            bl = BL.FactoryBL.GetBL();
            showDataGridView();
        }

        private void showDataGridView()
        {
            try
            {
                employerDataGrid.ItemsSource = null;
                employerDataGrid.ItemsSource = bl.allEmployer();
            }
            catch (Exception)
            {
                MessageBox.Show("שגיאה", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }


        private void button1_Return(object sender, RoutedEventArgs e)
        {
            Window menuEmployeur = new MenuEmployeur();
            menuEmployeur.Show();
            this.Close();
        }
    }
}
