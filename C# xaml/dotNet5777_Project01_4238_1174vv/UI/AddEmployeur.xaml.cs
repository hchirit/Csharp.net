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
    /// Logique d'interaction pour AddEmployeur.xaml
    /// </summary>
    public partial class AddEmployeur : Window
    {
        BE.Employer employer;
        BL.IBL bl;
        public AddEmployeur(BL.IBL Bl)
        {
            this.bl = Bl;
            InitializeComponent();
            employer = new BE.Employer();
            this.DataContext = employer;
            bl = BL.FactoryBL.GetBL();
            showDataGridView();
            this.domainComboBox.ItemsSource = Enum.GetValues(typeof(BE.employerDomain));
            employer.CompanyDateCreation = DateTime.Now;
            employer.DateContractSigned = DateTime.Now;
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

        private void button_Add(object sender, RoutedEventArgs e)
        {
            try
            {
                bl.addEmployer(employer);
                employer = new BE.Employer();
                this.DataContext = employer;
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
            Window menuEmployeur = new MenuEmployeur();
            menuEmployeur.Show();
            this.Close();
        }
    }
}
