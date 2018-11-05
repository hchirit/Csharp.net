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
    /// Logique d'interaction pour EraseContract.xaml
    /// </summary>
    public partial class EraseContract : Window
    {
        BL.IBL bl;
        public EraseContract(BL.IBL Bl)
        {
            this.bl = Bl;
            InitializeComponent();
            bl = BL.FactoryBL.GetBL();
        }

        private void button2_return(object sender, RoutedEventArgs e)
        {
            Window menuContract = new MenuContract();
            menuContract.Show();
            this.Close();
        }

        private void button_Erase(object sender, RoutedEventArgs e)
        {

            int contract_ID;
            try
            {
                int.TryParse(textBox.Text, out contract_ID);

                bl.eraseContract(contract_ID);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
