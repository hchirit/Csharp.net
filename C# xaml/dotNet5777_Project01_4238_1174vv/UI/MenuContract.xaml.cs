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
    /// Logique d'interaction pour MenuContract.xaml
    /// </summary>
    public partial class MenuContract : Window
    {
        BL.IBL bl;
        public MenuContract()
        {
            InitializeComponent();
            bl = BL.FactoryBL.GetBL();
        }

        private void contract_b_Add(object sender, RoutedEventArgs e)
        {
            Window Add = new AddContract(bl);
            Add.Show();
            this.Close();
        }

        private void button1_Erase(object sender, RoutedEventArgs e)
        {
            Window Erase = new EraseContract(bl);
            Erase.Show();
            this.Close();
        }

        private void button2_Update(object sender, RoutedEventArgs e)
        {
            Window Update = new UpdateContract(bl);
            Update.Show();
            this.Close();
        }

        private void button3_All(object sender, RoutedEventArgs e)
        {
            Window all = new allContract(bl);
            all.Show();
            this.Close();
        }

        private void button1_return(object sender, RoutedEventArgs e)
        {
            Window mainWindow = new MainWindows();
            mainWindow.Show();
            this.Close();
        }
    }
}
