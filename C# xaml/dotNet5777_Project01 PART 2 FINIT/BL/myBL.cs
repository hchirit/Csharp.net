using BE;
using System;
using System.Collections.Generic;
using System.Linq;
using DS;
using DAL;
namespace BL
{
    internal class myBL : IBL
    {
        DAL.Idal dal = Factory_DAL.getInstance("XML");

      

        #region IEnumerable by condition  all list
        public IEnumerable<specialization> Allspecialization(Func<specialization, bool> predicate = null)
        {
            return dal.Allspecialization(predicate);
        }

        public IEnumerable<contract> Allcontract(Func<contract, bool> predicate = null)
        {
            return dal.Allcontract(predicate);
        }

        public IEnumerable<Employee> AllEmployee(Func<Employee, bool> predicate = null)
        {
            return dal.AllEmployee(predicate);
        }

        public IEnumerable<Employer> AllEmployer(Func<Employer, bool> predicate = null)
        {
            return dal.AllEmployer(predicate);
        }

        public IEnumerable<bank> Allbank(Func<bank, bool> predicate = null)
        {
            return dal.Allbank(predicate);
        }

        #endregion

        #region functions add
        public void addcontract(contract c)
        {
            int ID_E = c.employerID; // ID EMPLOYER
            int ID = c.contractID;  // ID CONTRACT
            DateTime T_BEGINING = c.beginning;
            DateTime T_END = c.end;
            TimeSpan t = T_END - T_BEGINING;
            c.employeeID = c.employerID;                 
            if (t.Days<365 )        
                throw new NotImplementedException("not possibility to add hevha age under 1 years");
            else
            {
                hichouvSacharEmployee(c);
                dal.addcontract(c);               
            }
            
        }

        public void addEmployee(Employee e) // miksoua
        {
            int ID = e.ID;
            DateTime d = DateTime.Today;
            DateTime birth_day = e.birthDate;
            TimeSpan Age = d - birth_day;
            int a = Age.Days / 365;
            e.age = a;
            if (e.age < 18)
                throw new Exception("not possibility to add employee Under 18 years");
            else
            {
                dal.addEmployee(e);
                //throw new NotImplementedException("Employer Added");
            }
        }
      
        public void addEmployer(Employer e)
        {
                dal.addEmployer(e);
        }

        public void addExpert(specialization s)
        {
                dal.addExpert(s);
        }
        #endregion

        #region functions remove
        public void removecontract(int ID)
        {
            contract C = new contract();
            C = dal.searchId_contract_find(ID);
            dal.removecontract(C);
        }

        public void removeEmployee(int ID)
        {

            Employee e = new Employee();
            if (dal.seaurchID_existEmployee(ID))
            {
                e = dal.searchId_find_employee(ID);
                dal.removeEmployee(e);
                throw new NotImplementedException("is deleted !!");
            }
            else
                throw new NotImplementedException("id doesn't exist");
        }

        public void removeEmployer(int ID)
        {
            Employer e = new Employer();
            if (dal.seaurchID_existEmployer(ID))
            {
                e = dal.searchId_find_employer(ID);
                dal.removeEmployer(e);
                throw new NotImplementedException("is deleted !!");
            }
            else
                throw new NotImplementedException("id doesn't exist");
        }

        public void removeExpert(int ID)
        {
          /*  specialization s = new specialization();
            if (dal.seaurchID_existspecialization(ID))
            {
               s = dal.searchId_find_specialization(ID);
                
                throw new NotImplementedException("is deleted !!");
            }
            else
                throw new NotImplementedException("id doesn't exist");*/
            dal.removeExpert(ID);
        }


        #endregion

        #region functions update
        public void updateExpert(specialization s)
        {
            dal.updateExpert(s);           
        }

        public void uptdatecontract(contract c)
        {
            dal.uptdatecontract(c);         
        }


        public void uptdateEmployee(Employee e)
        {
            dal.uptdateEmployee(e);      
          
        }


        public void uptdateEmployer(Employer e)
        {
            dal.uptdateEmployer(e);
           
        }


        #endregion

        #region functions grouping
        public IEnumerable<IGrouping<string, contract>> Grouping_city()
        {
            IEnumerable<IGrouping<string, contract>> result = from n in dal.Allcontract()
                                                                       group n by n.city;

            /*  foreach (IGrouping<string, contract> city in result)
              {
                  switch (city.Key)
                  {
                      case "natanya":
                          Console.WriteLine("natanya");
                          foreach (contract n   in city)
                              Console.WriteLine("{0}",n);
                          Console.WriteLine("  ");
                          break;

                      case "jerusalem":
                          Console.WriteLine("jerusalem");
                          foreach (contract n in city)
                              Console.WriteLine("{0}", n);
                          Console.WriteLine(" ");
                          break;

                      case "tel-aviv":
                          Console.WriteLine("tel-aviv");
                          foreach (contract n in city)
                              Console.WriteLine("{0}", n);
                          Console.WriteLine("  ");
                          break;

                      case "haifa":
                          Console.WriteLine("haifa");
                          foreach (contract n in city)
                              Console.WriteLine("{0}", n);
                          Console.WriteLine(" ");
                          break;
                    case "ranana":
                        Console.WriteLine("ranana");
                        foreach (contract n in city)
                            Console.WriteLine("{0}", n);
                        Console.WriteLine(" ");
                        break;

                    case "ashdod":
                        Console.WriteLine("ashdod");
                        foreach (contract n in city)
                            Console.WriteLine("{0}", n);
                        Console.WriteLine(" ");
                        break;
                    case "beer-sheva":
                        Console.WriteLine("beer-sheva");
                        foreach (contract n in city)
                            Console.WriteLine("{0}", n);
                        Console.WriteLine(" ");
                        break;
                    case "eilat":
                        Console.WriteLine("eilat");
                        foreach (contract n in city)
                            Console.WriteLine("{0}", n);
                        Console.WriteLine(" ");
                        break;
                    case "hertzilia":
                        Console.WriteLine("hertzilia");
                        foreach (contract n in city)
                            Console.WriteLine("{0}", n);
                        Console.WriteLine(" ");
                        break;
                }
            }   
              */
            return result;         
        }

        public IEnumerable<IGrouping<expertise, contract>> Grouping_expert(bool miyoun)
        {
            IEnumerable<IGrouping<expertise, contract>> result = from n in dal.Allcontract()
                                                                 group n by n.expertise;

            List<contract> lst = new List<contract>();
            foreach (IGrouping<expertise, contract> expert in result)
            {
              
                switch (expert.Key)
                {
                    case expertise.PROGRAMMER:
                        foreach (contract n in expert)
                            lst.Add(n);                          
                        break;
                    case expertise.DESIGNER:
                        foreach (contract n in expert)
                            lst.Add(n);
                        break;
                    case expertise.APPLICATION_INGINEER:
                        foreach (contract n in expert)
                            lst.Add(n);
                        break;
                    case expertise.ALGO_INGINEER:
                        foreach (contract n in expert)
                            lst.Add(n);
                        break;
                }
            }
            
            return result;
        }
       
        public List<double>  Grouping_contract_revahim()
        {
            IEnumerable<IGrouping<int, contract>> result = from n in dal.Allcontract()
                                                           group n by n.beginning.Year;
            
            double count=0;
            List<double> lst = new List<double>();
            foreach (IGrouping<int, contract> date in result)
            {
                for (int i=result.FirstOrDefault().Key;i<result.LastOrDefault().Key ; i++)
                {
                        Console.WriteLine(i);
                        foreach (contract n in date) 
                        {
                            count += n.commission;
                            
                        }
                        lst.Add(count);                                                  
                }                       
            }
            return lst;
                                 
        }

        #endregion

        #region other functions
        public int get_number_Contract()
        {
            return dal.get_number_Contract();
        }


        public delegate bool conditionDelegate(contract c);
        public int number_of_contracts (conditionDelegate cond)
        {
            var List_contract = from n in dal.Allcontract()
                                where cond(n)
                                select n;
            return List_contract.Count(); 
        }

        public void hichouvSacharEmployee(contract c)
        {
            var Listcontracts =from  n in dal.Allcontract()
                               where n.employeeID == c.employeeID && n.employerID == c.employerID
                               select n;
            if (Listcontracts.Count() == 1)
            {
                c.commission = (c.salaryBrute * 0.10);
                c.salaryNet = c.salaryBrute - c.commission;
            }
            else
            {
                c.commission = c.salaryBrute * Math.Pow(0.25, Listcontracts.Count());
                c.salaryNet = c.salaryBrute - c.commission;
            }
        }

        #endregion

        #region functions return object
        public IEnumerable<contract> AllCONTRACT_TO_EMPLOYER(int ID)
        {
            var Listcontracts = from n in dal.Allcontract()
                                where n.employerID == ID
                                select n;

            return Listcontracts;

        }

        public Employee return_emploee(int ID)
        {
            return dal.searchId_find_employee(ID);
        }

        public contract return_contrat(int ID)
        {
            return dal.searchId_contract_find(ID);
        }
        public Employer searchId_find_employer(int ID)
        {
            return dal.searchId_find_employer(ID);
        }

        public specialization return_expert(int ID)
        {
            return dal.searchId_find_specialization(ID);
        }
        #endregion

        #region functions return names id of all list
        public IEnumerable<int> return_names_id_employee()
        {
            var v = from item in dal.AllEmployee()
                    select item.ID;
            return v;
        }

        public IEnumerable<int> return_names_id_specialization()
        {
            var v = from item in dal.Allspecialization()
                    select item.specialization_id;
            return v;
        }

        public IEnumerable<int> return_names_id_contract()
        {
            var v = from item in dal.Allcontract()
                    select item.contractID;
            return v;
        }
        public IEnumerable<int> return_names_id_employer()
        {
            var v = from item in dal.AllEmployer()
                    select item.companyID;
            return v;
        }

        public int sahar_employer(int ID)
        {
            int sahar;
           var v = from n in dal.Allcontract()
                    where n.employeeID == ID
                    select n.commission;
           string c = v.ToString();
           int.TryParse(c, out sahar);

            return sahar;
        }
        #endregion

    }
}
