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
    /// Logique d'interaction pour AddSpecialization.xaml
    /// </summary>
    public partial class AddSpecialization : Window
    {
        BL.IBL bl;
        BE.Specialization specialiste;

        public AddSpecialization(BL.IBL Bl)
        {
            this.bl = Bl;
            InitializeComponent();
            specialiste = new BE.Specialization();
            this.DataContext = specialiste;
            bl = BL.FactoryBL.GetBL();
            showDataGridView();
            this.expertiseDomainComboBox1.ItemsSource = Enum.GetValues(typeof(BE.expertiseDomain));
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

        private void button_Add(object sender, RoutedEventArgs e)
        {
            try
            {
                bl.addExpert(specialiste);
                specialiste = new BE.Specialization();
                this.DataContext = specialiste;
                showDataGridView();
            }
            catch (Exception ex)
            {
                showDataGridView();
                MessageBox.Show(ex.Message);
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
