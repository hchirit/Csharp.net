using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
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
using BE;
namespace PL_UI2
{
    /// <summary>
    /// Logique d'interaction pour grouping_expert.xaml
    /// </summary>
    public partial class grouping_expert : Window
    {
        BL.IBL bl;
        contract c = new contract();
        private ObservableCollection<contract> _myCollection =
      new ObservableCollection<contract>();

        public grouping_expert(int k)
        {
            InitializeComponent();
            bl = BL.FactoryBL.GetBL();
          //  DataContext = _myCollection;
            //if (k == 1)
        //        groupe_expert();
         //   else groupe_city();
        }


        void groupe_expert()
        {
            foreach (IGrouping<expertise, contract> expert in bl.Grouping_expert(true))
            {
                switch (expert.Key)
                {
                    case expertise.PROGRAMMER:

                        foreach (contract n in expert)
                            _myCollection.Add(n);
                        break;

                    case expertise.DESIGNER:
                        foreach (contract n in expert)
                            _myCollection.Add(n);
                        break;

                    case expertise.APPLICATION_INGINEER:
                        foreach (contract n in expert)
                            _myCollection.Add(n);
                        break;

                    case expertise.ALGO_INGINEER:
                        foreach (contract n in expert)
                            _myCollection.Add(n);
                        break;

                }
            }

        }



        void groupe_city()
        {
            foreach (IGrouping<string, contract> city in bl.Grouping_city())
            {
                switch (city.Key)
                {
                    case "natanya":
                       
                        foreach (contract n in city)
                            _myCollection.Add(n);
                       
                        break;

                    case "jerusalem":
                        
                        foreach (contract n in city)
                            _myCollection.Add(n);
                      
                        break;

                    case "tel-aviv":
                       
                        foreach (contract n in city)
                            _myCollection.Add(n);
                      
                        break;

                    case "haifa":
                       
                        foreach (contract n in city)
                            _myCollection.Add(n);
                       
                        break;
                    case "ranana":
                       
                        foreach (contract n in city)
                            _myCollection.Add(n);
                       
                        break;

                    case "ashdod":
                        
                        foreach (contract n in city)
                            _myCollection.Add(n);
                       
                        break;
                    case "beer-sheva":
                      
                        foreach (contract n in city)
                            _myCollection.Add(n);
                        
                        break;
                    case "eilat":
                        
                        foreach (contract n in city)
                            _myCollection.Add(n);
                        
                        break;
                    case "hertzilia":
                        
                        foreach (contract n in city)
                            _myCollection.Add(n);
                       
                        break;
                }
            }

        }



        private void expert_Click(object sender, RoutedEventArgs e)
        {
            DataGrid_s.ItemsSource = null;
            DataGrid_s.ItemsSource = DataGrid_s.ItemsSource = from a in bl.Allspecialization()
                                                              select new
                                                              {
                                                                  expert = a.expertise.ToString(),
                                                                  ID = a.specialization_id,
                                                              };

        }

        private void city_Click(object sender, RoutedEventArgs e)
        {
            DataGrid_s.ItemsSource = null;
            DataGrid_s.ItemsSource = DataGrid_s.ItemsSource = from a in bl.Grouping_city()
                                                              select new
                                                              {
                                                                  city = a.FirstOrDefault(),
                                                              };

        }


        private void date_Click(object sender, RoutedEventArgs e)
        {
            DataGrid_s.ItemsSource = null;
            DataGrid_s.ItemsSource = DataGrid_s.ItemsSource = from a in bl.Allcontract()
                                                              select new
                                                              {
                                                                  date_beginig = a.beginning ,
                                                                  date_end = a.end,
                                                                  hevah = a.salaryBrute - a.salaryNet
                                                              };
        }

        private void age_Click(object sender, RoutedEventArgs e)
        {
            DataGrid_s.ItemsSource = null;
            DataGrid_s.ItemsSource = from a in bl.AllEmployee()
                                     select new
                                     {
                                         age = a.age,
                                         name = a.firstName + a.lastName,
                                         SAHAR = (bl.sahar_employer(a.ID)),
        };
        }

        private void branch_Click(object sender, RoutedEventArgs e)
        {
            DataGrid_s.ItemsSource = null;
            DataGrid_s.ItemsSource = from a in bl.Allcontract() select new {ID_contract = a.contractID ,salaire_brute = a.salaryBrute,
                salaire_net = a.salaryNet ,hevah = a.salaryBrute-a.salaryNet };
        }

        private void menu_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }
    }
}
