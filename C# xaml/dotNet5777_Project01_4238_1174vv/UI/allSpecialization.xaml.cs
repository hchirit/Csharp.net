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
    /// Logique d'interaction pour allSpecialization.xaml
    /// </summary>
    public partial class allSpecialization : Window
    {
        BL.IBL bl;
        BE.Specialization specialiste;

        public allSpecialization(BL.IBL Bl)
        {

            this.bl = Bl;
            InitializeComponent();
            specialiste = new BE.Specialization();
            this.DataContext = specialiste;
            bl = BL.FactoryBL.GetBL();
            showDataGridView();

        }
        private void showDataGridView()
        {
            try
            {
                specializationDataGrid.ItemsSource = null;
                specializationDataGrid.ItemsSource = bl.allSpecialization();
            }
            catch (Exception)
            {
                MessageBox.Show("שגיאה", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private void button1_Return(object sender, RoutedEventArgs e)
        {
            Window menuSpecialization = new MenuSpecialization();
            menuSpecialization.Show();
            this.Close();
        }
    }
}
