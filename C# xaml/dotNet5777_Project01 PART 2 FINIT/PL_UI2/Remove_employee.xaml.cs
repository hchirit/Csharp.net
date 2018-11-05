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
    /// Logique d'interaction pour Remove_employee.xaml
    /// </summary>
    public partial class Remove_employee : Window
    {
        BL.IBL bl;
        public Remove_employee(BL.IBL Bl)
        {
            this.bl = Bl;
            InitializeComponent();
            bl = BL.FactoryBL.GetBL();
        }
        private void button_Click(object sender, RoutedEventArgs e)
        {
            int Employee_ID;
            try
            {
                int.TryParse(textbox_id.Text, out Employee_ID);

                bl.removeEmployee(Employee_ID);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

    }
 }
