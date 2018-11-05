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
    /// Logique d'interaction pour groupingExpert.xaml
    /// </summary>
    public partial class groupingExpert : Window
    {
        BL.IBL bl;
        public groupingExpert()
        {
            InitializeComponent();
            bl = BL.FactoryBL.GetBL();
            dataGrid.ItemsSource = null;
            dataGrid.ItemsSource = dataGrid.ItemsSource = from a in bl.allSpecialization()
                                                              select new
                                                              {
                                                                  ID = a.specializationNumber,
                                                                  Expertise = a.ExpertiseDomain,
                                                                  profil = a.maxTarif - a.minTarif,
                                                              };
        }

        private void button1_return(object sender, RoutedEventArgs e)
        {
            Window mainwindow = new MainWindows();
            mainwindow.Show();
            this.Close();
        }

      
    }
}
