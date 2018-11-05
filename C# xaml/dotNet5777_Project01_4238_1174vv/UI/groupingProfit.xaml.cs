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
    /// Logique d'interaction pour groupingProfit.xaml
    /// </summary>
    public partial class groupingProfit : Window
    {
        BL.IBL bl;
        public groupingProfit()
        {
            InitializeComponent();  
            bl = BL.FactoryBL.GetBL();
            dataGrid.ItemsSource = null;
        }

        private void button1_return(object sender, RoutedEventArgs e)
        {
            Window mainwindow = new MainWindows();
            mainwindow.Show();
            this.Close();
        }
    }
}
