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
using System.Windows.Navigation;
using System.Windows.Shapes;
using BE;
using System.Collections.ObjectModel;
using BL;

namespace PL_UI2
{
    /// <summary>
    /// Logique d'interaction pour MainWindow.xaml
    /// </summary>
    ///
    public partial class MainWindow : Window
    {
        
        BL.IBL bl;
        public MainWindow()
        {
            InitializeComponent();
            bl = BL.FactoryBL.GetBL();

        }
        // contract
        private void Button_Click(object sender, RoutedEventArgs e)
        {
            Window contrat = new MENU_CONTARCT();
            contrat.Show();
        }
        // employer
        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            Window EMPLOYER = new MENU_EMPLOYER();
            EMPLOYER.Show();
        }
        //employee
        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            Window EMPLOYEE = new MENU_EMPLOYEE();
            EMPLOYEE.Show();
        }
        //specialization
        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            Window EXPERT = new MENU_EXPERT();
            EXPERT.Show();
        }

        private void button_Click_4(object sender, RoutedEventArgs e)
        {
            Window groupe = new grouping_expert(1);
            groupe.Show();
        }

        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {
            Window groupe = new grouping_expert(2);
            groupe.Show();
        }

        private void Button_Click_5(object sender, RoutedEventArgs e)
        {
            Window c_to_em = new Contract_to_employer();
            c_to_em.Show();
        }

        private void button1_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }




        /*
        // all  add

        void button1_Click(object sender, RoutedEventArgs e)
        {
            Window addCONTRACT = new ADD_CONTRACT(bl);
            addCONTRACT.Show();
        }

        void Employer_b_Click(object sender, RoutedEventArgs e)
        {
            Window addemployer = new ADDEmployer(bl);
            addemployer.Show();
        }

        void Employee_b_Click(object sender, RoutedEventArgs e)
        {
            Window addemployee = new ADD_EMPLOYEE(bl);
            addemployee.Show();
        }

        void specialization_b_Click(object sender, RoutedEventArgs e)
        {
            Window specialization_w = new Window_specialization(bl);
            specialization_w.Show();
        }




        //remove
        private void button1_contract(object sender, RoutedEventArgs e)
        {
            Window remove_contrat = new Remove_Contract(bl);
            remove_contrat.Show();
        }

        private void button1_specialization(object sender, RoutedEventArgs e)
        {
            Window remove_specialization = new  Remove_specialization(bl);
            remove_specialization.Show();
        }

        private void button1_Employee(object sender, RoutedEventArgs e)
        {
            Window remove_Employee = new Remove_employee(bl);
            remove_Employee.Show();
        }

        private void button1_Employer(object sender, RoutedEventArgs e)
        {
            Window remove_Employer = new Remove_Employer(bl);
            remove_Employer.Show();
        }

        private void button1_Copy2_Click(object sender, RoutedEventArgs e) // remove specialization
        {
            Window remove_specialization = new Remove_specialization(bl);
            remove_specialization.Show();
        }

        private void button1_Copy1_Click(object sender, RoutedEventArgs e)  // remove EMployee
        {
            Window remove_Employee = new Remove_employee(bl);
            remove_Employee.Show();
        }

        private void button1_Copy6_Click(object sender, RoutedEventArgs e)
        {
            Window update_Employee = new  Update_specialization();
            update_Employee.Show();
        }

        private void button1_Copy3_Click(object sender, RoutedEventArgs e)
        {          
            Window update_contract = new update_contract(bl);
            update_contract.Show();
        }

        private void button1_Copy4_Click(object sender, RoutedEventArgs e)
        {
            Window update_employer = new update_employer(bl);
            update_employer.Show();
        }

        private void button1_Copy5_Click(object sender, RoutedEventArgs e)
        {
            
            Window update_employee = new update_Employee(bl);
            update_employee.Show();
        }


        //list


        private void button_Click(object sender, RoutedEventArgs e)
        {
            Window alllists = new all_lists(3);
            alllists.Show();
        }

        private void button_Copy_Click(object sender, RoutedEventArgs e)
        {
            Window alllists = new all_lists(2);
            alllists.Show();
        }

        private void button_Copy1_Click(object sender, RoutedEventArgs e)
        {
            Window alllists = new all_lists(1);
            alllists.Show();
        }

        private void button_Copy2_Click(object sender, RoutedEventArgs e)
        {
            Window alllists = new all_lists(4);
            alllists.Show();
        }
        */
    }

}


    
