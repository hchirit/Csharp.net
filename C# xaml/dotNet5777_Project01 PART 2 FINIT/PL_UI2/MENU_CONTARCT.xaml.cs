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

namespace PL_UI2
{
    /// <summary>
    /// Logique d'interaction pour MENU_CONTARCT.xaml
    /// </summary>
    public partial class MENU_CONTARCT : Window
    {
        BL.IBL bl;
        public MENU_CONTARCT()
        {
            InitializeComponent();
            bl = BL.FactoryBL.GetBL();
        }

        private void contract_b_Click(object sender, RoutedEventArgs e)
        {
            Window addCONTRACT = new ADD_CONTRACT(bl);
            addCONTRACT.Show();
        }

        private void button1_Copy3_Click(object sender, RoutedEventArgs e)
        {
            Window update_contract = new update_contract(bl);
            update_contract.Show();
        }

        private void button_Copy1_Click(object sender, RoutedEventArgs e)
        {
            Window alllists = new all_lists(1);
            alllists.Show();
        }

        private void menu_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
