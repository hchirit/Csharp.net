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
using BL;

namespace UI
{
    /// <summary>
    /// Logique d'interaction pour AddEmployee.xaml
    /// </summary>
    public partial class AddEmployee : Window
    {
        BE.Employee employee;
        BE.BankAccount BANK;
        BL.IBL bl;
        public AddEmployee(BL.IBL Bl)
        {
            this.bl = Bl;
            InitializeComponent();
            BANK = new BE.BankAccount();
            employee = new BE.Employee();
            this.DataContext = employee;
            bl = BL.FactoryBL.GetBL();
            showDataGridView();
            this.degreeComboBox.ItemsSource = Enum.GetValues(typeof(BE.Degree));
            foreach (string id in bl.returnCity())
            {
                cityComboBox.Items.Add(id);
            }
        }

        private void showDataGridView()
        {
            try
            {
                employeeDataGrid.ItemsSource = null;
                employeeDataGrid.ItemsSource = bl.allEmployee();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void button1_Return(object sender, RoutedEventArgs e)
        {
            Window menuEmployee = new MenuEmployee();
            menuEmployee.Show();
            this.Close();
        }

        private void button_Add(object sender, RoutedEventArgs e)
        {
            int branch;
            int bank_n;
            try
            {
                BANK.BranhCity = cityComboBox.SelectedItem.ToString();
                BANK.BankName = bankNameComboBox.SelectedItem.ToString();
                BANK.BranchAdress = adressBankComboBox.SelectedItem.ToString();
                int.TryParse(branchBankComboBox.SelectedItem.ToString(), out branch);
                int.TryParse(banknum.Text, out bank_n);
                BANK.BranchNumber = branch;
                BANK.BankNumber = bank_n;
                employee.BankDetails = BANK;
                bl.addEmployee(employee);
                employee = new BE.Employee();
                banknum.Text = null;
                branchBankComboBox.SelectedItem = null;
                adressBankComboBox.SelectedItem = null;
                bankNameComboBox.SelectedItem = null;
                cityComboBox.SelectedItem = null;
                this.DataContext = employee;
                showDataGridView();
            }
            catch (Exception ex)
            {
                showDataGridView();
                MessageBox.Show(ex.Message);
            }
        }
        private void cityComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

            if (cityComboBox.SelectedItem != null)
            {
                bankNameComboBox.Items.Clear();
                foreach (string id in bl.returnBankName(cityComboBox.SelectedItem.ToString()))
                {
                    bankNameComboBox.Items.Add(id);
                }
            }
        }

        private void bankNameComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (bankNameComboBox.SelectedItem != null)
            {
                adressBankComboBox.Items.Clear();
                foreach (string id in bl.returnAdresse(cityComboBox.SelectedItem.ToString(), bankNameComboBox.SelectedItem.ToString()))
                {
                    adressBankComboBox.Items.Add(id);
                }
            }
        }


        private void adressBankComboBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if (adressBankComboBox.SelectedItem != null)
            {
                branchBankComboBox.Items.Clear();
                foreach (int id in bl.returnBranchCode())
                {
                    branchBankComboBox.Items.Add(id);
                }
            }
        }
    }
}
