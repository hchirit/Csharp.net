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
    /// Logique d'interaction pour UpdateContract.xaml
    /// </summary>
    public partial class UpdateContract : Window
    {
        BL.IBL bl;
        BE.Contract contract;
        public UpdateContract(BL.IBL Bl)
        {
            this.bl = Bl;
            InitializeComponent();
            contract = new BE.Contract();
            this.DataContext = contract;
            bl = BL.FactoryBL.GetBL();
            showDataGridView();
            this.domainComboBox.ItemsSource = Enum.GetValues(typeof(BE.expertiseDomain));
            this.cityComboBox.ItemsSource = Enum.GetValues(typeof(BE.City));
            contract.CompanyDateCreation = DateTime.Now;
            contract.JobBegins = DateTime.Now;
            contract.JobEndsup = DateTime.Now;

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

        private void button_Update(object sender, RoutedEventArgs e)
        {
            try
            {
                bl.updatingContract(contract);
                contract = new BE.Contract();
                this.DataContext = contract;
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
            Window menuContract = new MenuContract();
            menuContract.Show();
            this.Close();
        }
    }
}
