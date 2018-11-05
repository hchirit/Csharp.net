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
    /// Logique d'interaction pour UpdateSpecialization.xaml
    /// </summary>
    public partial class UpdateSpecialization : Window
    {
        BL.IBL bl;
        BE.Specialization expert;
        public UpdateSpecialization()
        {
            InitializeComponent();
            expert = new BE.Specialization();
            this.DataContext = expert;
            bl = BL.FactoryBL.GetBL();
            this.expertiseDomainComboBox1.ItemsSource = Enum.GetValues(typeof(BE.expertiseDomain));
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

        private void button_Update(object sender, RoutedEventArgs e)
        {
            try
            {

                bl.updatingExpert(expert);
                expert = new BE.Specialization();
                this.DataContext = expert;
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
            Window menuSpecialization = new MenuSpecialization();
            menuSpecialization.Show();
            this.Close();
        }

        
    }
}
