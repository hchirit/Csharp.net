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
    /// Logique d'interaction pour MenuSpecialization.xaml
    /// </summary>
    public partial class MenuSpecialization : Window
    {
        BL.IBL bl;
        public MenuSpecialization()
        {
            InitializeComponent();
            bl = BL.FactoryBL.GetBL();
        }

        private void specialization_Add(object sender, RoutedEventArgs e)
        {
            Window Add = new AddSpecialization(bl);
            Add.Show();
            this.Close();
        }

        private void button1_Copy2_Erase(object sender, RoutedEventArgs e)
        {
            Window Erase = new EraseSpecialization(bl);
            Erase.Show();
            this.Close();
        }

        private void button1_Copy6_Update(object sender, RoutedEventArgs e)
        {
            Window Update = new UpdateSpecialization();
            Update.Show();
            this.Close();
        }

        private void button_Copy2_All(object sender, RoutedEventArgs e)
        {
            Window all = new allSpecialization(bl);
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
