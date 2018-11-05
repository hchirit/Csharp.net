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
    /// Logique d'interaction pour MenuEmployee.xaml
    /// </summary>
    public partial class MenuEmployee : Window
    {
        BL.IBL bl;
        public MenuEmployee()
        {
            InitializeComponent();
            bl = BL.FactoryBL.GetBL();
        }

        private void button_Add(object sender, RoutedEventArgs e)
        {
            Window Add= new  AddEmployee(bl);
            Add.Show();
            this.Close();
        }

        private void button1_Erase(object sender, RoutedEventArgs e)
        {
            Window Erase = new EraseEmployee(bl);
            Erase.Show();
            this.Close();
        }

        private void button2_Update(object sender, RoutedEventArgs e)
        {
            Window Update = new UpdateEmployee(bl);
            Update.Show();
            this.Close();
        }

        private void button3_All(object sender, RoutedEventArgs e)
        {
            Window all = new allEmployee(bl);
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
