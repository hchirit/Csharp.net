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
    /// Logique d'interaction pour Remove_Employer.xaml
    /// </summary>
    public partial class Remove_Employer : Window
    {
        BL.IBL bl;
        public Remove_Employer(BL.IBL Bl)
        {
            this.bl = Bl;
            InitializeComponent();
            bl = BL.FactoryBL.GetBL();
        }
        private void button_Click(object sender, RoutedEventArgs e)
        {
            int Employer_ID;
            try
            {
                int.TryParse(textbox_id.Text, out Employer_ID);

                bl.removeEmployer(Employer_ID);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
