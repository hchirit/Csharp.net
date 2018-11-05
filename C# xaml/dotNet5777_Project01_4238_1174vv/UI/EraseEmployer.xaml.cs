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
    /// Logique d'interaction pour EraseEmployer.xaml
    /// </summary>
    public partial class EraseEmployer : Window
    {
        BL.IBL bl;
        public EraseEmployer(BL.IBL Bl)
        {
            this.bl = Bl;
            InitializeComponent();
            bl = BL.FactoryBL.GetBL();
        }

        private void button2_return(object sender, RoutedEventArgs e)
        {
            Window menuEmployeur = new MenuEmployeur();
            menuEmployeur.Show();
            this.Close();
        }

        private void button_Erase(object sender, RoutedEventArgs e)
        {
            int EmployerId;
            try
            {
                int.TryParse(textBox.Text, out EmployerId);

                bl.eraseEmployer(EmployerId);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    
    }
}
