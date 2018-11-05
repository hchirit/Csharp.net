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
    /// Logique d'interaction pour MenuEmployeur.xaml
    /// </summary>
    public partial class MenuEmployeur : Window
    {
        BL.IBL bl;
        public MenuEmployeur()
        {
            InitializeComponent();
            bl = BL.FactoryBL.GetBL();
        }

        private void Employer_b_Add(object sender, RoutedEventArgs e)
        {
            Window Add = new AddEmployeur(bl);
            Add.Show();
            this.Close();
        }

        private void button1_Copy_Erase(object sender, RoutedEventArgs e)
        {
            Window Erase = new EraseEmployer(bl);
            Erase.Show();
            this.Close();
        }

        private void button1_Copy4_Update(object sender, RoutedEventArgs e)
        {
            Window Update = new UpdateEmployer(bl);
            Update.Show();
            this.Close();
        }

        private void button_All(object sender, RoutedEventArgs e)
        {
            Window all = new allEmployer(bl);
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
