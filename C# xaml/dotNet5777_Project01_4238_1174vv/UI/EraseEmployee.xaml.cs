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
    /// Logique d'interaction pour EraseEmployee.xaml
    /// </summary>
    public partial class EraseEmployee : Window
    {
        BL.IBL bl;
        public EraseEmployee(BL.IBL Bl)
        {
            this.bl = Bl;
            InitializeComponent();
            bl = BL.FactoryBL.GetBL();
        }

        private void button2_return(object sender, RoutedEventArgs e)
        {
            Window menuEmployee = new MenuEmployee();
            menuEmployee.Show();
            this.Close();
        }

        private void button_Erase(object sender, RoutedEventArgs e)
        {
            int employeeId;
            try
            {
                int.TryParse(textBox.Text, out employeeId);

                bl.eraseEmployee(employeeId);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
