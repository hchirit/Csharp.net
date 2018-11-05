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
using BE;

namespace PL_UI2
{
    /// <summary>
    /// Logique d'interaction pour ADD_CONTRACT.xaml
    /// </summary>
    public partial class ADD_CONTRACT : Window
    {

       // BE.Employer employer;
        BL.IBL bl;
        BE.contract contrat;
      
       public ADD_CONTRACT(BL.IBL Bl)
        {
            this.bl = Bl;
            InitializeComponent();  
            contrat = new BE.contract();
            this.DataContext = contrat;
            bl = BL.FactoryBL.GetBL();
            showDataGridView();
            this.expertiseComboBox.ItemsSource = Enum.GetValues(typeof(BE.expertise));
            foreach (int id in bl.return_names_id_employer())
            {
                comboBox.Items.Add(id);
            }
        }
        private void showDataGridView()
        {
            try
            {
                DataGrid_s.ItemsSource = null;
                DataGrid_s.ItemsSource = bl.Allcontract();

            }
            catch (Exception)
            {
                MessageBox.Show("שגיאה", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }

        private void button_Click(object sender, RoutedEventArgs e)
        {
            int id; 
            try
            {
                if (contrat.contractID != 0 &&  contrat.numHours!=0  && contrat.professionalID!=0 && contrat.salaryBrute!=0)
                {
                    int.TryParse(comboBox.SelectedItem.ToString(), out id);
                    contrat.employerID = id;
                    bl.addcontract(contrat);
                    contrat = new BE.contract();
                    this.DataContext = contrat;
                    showDataGridView();
                }
                else throw new Exception(" impossible to enter 0  !!");

            }
            catch (Exception ex)
            {
                showDataGridView();
                MessageBox.Show(ex.Message);
            }
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        

    }
}
