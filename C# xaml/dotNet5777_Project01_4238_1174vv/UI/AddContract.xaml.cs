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
    /// Logique d'interaction pour AddContract.xaml
    /// </summary>
    public partial class AddContract : Window
    {
        // BE.Employer employer;
        BL.IBL bl;
        BE.Contract contrat;

        public AddContract(BL.IBL Bl)
        {
            this.bl = Bl;
            InitializeComponent();
            //   employer = new Employer();
            //    this.DataContext = contr;

            contrat = new BE.Contract();
            this.DataContext = contrat;
            bl = BL.FactoryBL.GetBL();
            showDataGridView();
            this.domainComboBox.ItemsSource = Enum.GetValues(typeof(BE.expertiseDomain));
            this.cityComboBox.ItemsSource = Enum.GetValues(typeof(BE.City));
            contrat.CompanyDateCreation = DateTime.Now;
            contrat.JobBegins = DateTime.Now;
            contrat.JobEndsup = DateTime.Now;

            /*  int a ;   
              var v = bl.return_names_id_employer();
              foreach (var s in v)
              {
                  a = s;
                  comboB.Items.Add(a);
              } */
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
      

        private void button_Add(object sender, RoutedEventArgs e)
        {
           
            try
            {
               // int id;
                TimeSpan t = contrat.JobBegins - contrat.JobEndsup;
                if (t.Days > 0)
                    throw new Exception("error date end before date begining");
                if (contrat.ContractNumber != 0 && contrat.HourPerWeek != 0 && contrat.EmployeeId != 0 && contrat.BrutSalary != 0)
                {
                    //contrat.EmployerId = id;
                    bl.addContract(contrat);
                    contrat = new BE.Contract();
                    this.DataContext = contrat;
                    showDataGridView();
                }
                else throw new Exception(" don't enter value 0");

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
