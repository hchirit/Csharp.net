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
    /// Logique d'interaction pour MainWindows.xaml
    /// </summary>
    public partial class MainWindows : Window
    {
        BL.IBL bl;
        public MainWindows()
        {
            InitializeComponent();
            bl = BL.FactoryBL.GetBL();
        }

        private void button6_GroupingExpert(object sender, RoutedEventArgs e)
        {
            Window groupingexpert = new groupingExpert();
            groupingexpert.Show();
            this.Close();
        }

        private void button7_GroupingSalary(object sender, RoutedEventArgs e)
        {
            Window groupingprofit = new groupingProfit();
            groupingprofit.Show();
            this.Close();
        }

        private void button8_GroupingCity(object sender, RoutedEventArgs e)
        {
            Window groupingcity = new groupingCity();
            groupingcity.Show();
            this.Close();
        }

        private void Button_Contrat(object sender, RoutedEventArgs e)
        {
            Window menuContract = new MenuContract();
            menuContract.Show();
            this.Close();
        }

        private void Button_Employer(object sender, RoutedEventArgs e)
        {
            Window menuEmployer = new MenuEmployeur();


            menuEmployer.Show();


            this.Close();
        }

        private void Button_Employee(object sender, RoutedEventArgs e)
        {
            Window menuEmployee = new MenuEmployee();
            try
            {
                bl.threa_isalive();
                menuEmployee.Show();
                this.Close();
            }
            catch (Exception)
            {
                MessageBox.Show("bank doesn't downloaded");
            }
           
        }

        private void Button_Specialization(object sender, RoutedEventArgs e)
        {
            Window menuSpecialization = new MenuSpecialization();
            menuSpecialization.Show();
            this.Close();
        }


    }
}
