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
//using BL;
//using BE;


namespace PL_UI2
{
    /// <summary>
    /// Logique d'interaction pour ADDEmployer.xaml
    /// </summary>
    /// 

    
    public partial class ADDEmployer : Window
    {
        BE.Employer employer;
        BL.IBL bl;
        public ADDEmployer(BL.IBL Bl)
        {
            this.bl = Bl;
            InitializeComponent();
            employer = new BE.Employer();
            this.DataContext = employer;

            bl = BL.FactoryBL.GetBL();
            showDataGridView();
            this.disciplineComboBox.ItemsSource = Enum.GetValues(typeof(BE.discipline));
        }
        private void showDataGridView()
        {
            try
            {
                DataGrid_s.ItemsSource = null;
                DataGrid_s.ItemsSource = bl.AllEmployer();

            }
            catch (Exception)
            {
                MessageBox.Show("שגיאה", "ERROR", MessageBoxButton.OK, MessageBoxImage.Error);
            }
        }
        private void addButton_Click(object sender, RoutedEventArgs e)
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

   
    }
}
