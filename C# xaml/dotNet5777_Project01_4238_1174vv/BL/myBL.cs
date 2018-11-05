using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DAL;

namespace BL
{
    internal class myBL : IBL
    {
        DAL.Idal Dal = FactoryDal.getInstance("XML");

       
        //expert
        public void addExpert(Specialization s)
        {
            int ID = s.specializationNumber;
            if (Dal.SpecializationExist(ID))
                throw new NotImplementedException("This specialization id is already use");
            else
            {
                Dal.addExpert(s);
            }
        }
        public void eraseExpert(int Id)
        {
            /*Specialization s = new Specialization();
            if (Dal.SpecializationExist(Id))
            {
                s = Dal.findSpecialization(Id);
                Dal.eraseExpert(s);
                throw new NotImplementedException("this id specialisation was deleted");
            }
            else
                throw new NotImplementedException("id doesn't exist");*/
            Dal.eraseExpert(Id);
        }
        public void updatingExpert(Specialization s) { Dal.updateExpert(s); }
      
        //employee
        public void addEmployee(Employee e)
        {
            int id = e.Id;
            if (e.age < 18)
                throw new Exception("under 18 no possibility to work");
            else if (Dal.EmployeeExist(id))
                throw new Exception("This Employer id already use");
            else
            {
                Dal.addEmployee(e);
            }
        }
        public void eraseEmployee(int Id)
        {
            Employee e = new Employee();
            if (Dal.EmployeeExist(Id))
            {
                e = Dal.findEmployee(Id);
                Dal.eraseEmployee(e);
                throw new NotImplementedException("is deleted");
            }
            else
                throw new NotImplementedException("id doesn't exist");
        }
        public void updatingEmployee(Employee e) { Dal.uptdateEmployee(e); throw new NotImplementedException("employee was updated"); }
      
        //employer
        public void addEmployer(Employer e)
        {
            int id = e.Id;

            if (Dal.EmployerExist(id))
            {
                throw new NotImplementedException("This id is already use");
            }
            else
                Dal.addEmployer(e);
        }
        public void eraseEmployer(int Id)
        {
            Employer e = new Employer();
            if (Dal.EmployerExist(Id))
            {
                e = Dal.findEmployer(Id);
                Dal.eraseEmployer(e);
                throw new NotImplementedException("the id delete");
            }
            else
                throw new NotImplementedException("id doesn't exist");
        }
        public void updatingEmployer(Employer e) { Dal.uptdateEmployer(e); }
      

        //contract
        public void addContract(Contract c)
        {
            DateTime now = DateTime.Now;
            TimeSpan t = now - c.CompanyDateCreation;

            if (Dal.ContractExist(c.ContractNumber))
                throw new NotImplementedException("this contract id already used ");

            else if (t.Days < 365)
                throw new NotImplementedException("It is not possible to add a young company of less than a year");

            else if(!Dal.EmployerExist(c.EmployerId))
                throw new NotImplementedException("This employer id does not exist");

            else if (!Dal.EmployeeExist(c.EmployeeId)) { }
                //throw new NotImplementedException("This employee id does not exist");

            else if (!c.ContractIsSigned)
                throw new NotImplementedException("The contract not signed");

            else
            {
                calculSalaryEmployee(c);
                Dal.addContract(c);
               
            }
        }
        public void eraseContract(int Id)
        {
            Contract C = new Contract();
            if (Dal.ContractExist(Id))
            {
                C = Dal.findContract(Id);
                Dal.eraseContract(C);
                throw new NotImplementedException("this contract is delete");
            }
            else
                throw new NotImplementedException("this id does not exist");
        }
        public void updatingContract(Contract c) { Dal.uptdatecontract(c); }

        #region IEnumerable by condition  all list
        public IEnumerable<Specialization> Allspecialization_condition(Predicate<Specialization> condition = null)
        {
            return from c in Dal.allSpecialization()
                   where condition(c)
                   select c;
        }

        public IEnumerable<Contract> Allcontract_condition(Predicate<Contract> condition = null)
        {
            return from c in Dal.allContract()
                   where condition(c)
                   select c;
        }

        public IEnumerable<Employee> AllEmployee_condition(Predicate<Employee> condition = null)
        {
            return from c in Dal.allEmployee()
                   where condition(c)
                   select c;
        }

        public IEnumerable<Employer> AllEmployer_condition(Predicate<Employer> condition = null)
        {
            return from c in Dal.allEmployer()
                   where condition(c)
                   select c;
        }

        public IEnumerable<BankAccount> Allbank_condition(Predicate<BankAccount> condition = null)
        {
            return from c in Dal.allBank()
                   where condition(c)
                   select c;
        }
        #endregion

        #region IEnumerable all list
        public IEnumerable<Specialization> allSpecialization(){return Dal.allSpecialization();}
        public IEnumerable<Contract> allContract(){return Dal.allContract();}
        public IEnumerable<Employee> allEmployee(){return Dal.allEmployee();}
        public IEnumerable<Employer> allEmployer(){return Dal.allEmployer();}
        public IEnumerable<BankAccount> allBank(){return Dal.allBank();}
        #endregion

        #region grouping
        public IEnumerable<IGrouping<City, Contract>> Grouping_City()
        {
            IEnumerable<IGrouping<City, Contract>> result = from n in Dal.allContract()
                                                            group n by n.city;
            return result;
        }
        public IEnumerable<IGrouping<expertiseDomain, Contract>> GroupingExpert(bool sort)
        {
            IEnumerable<IGrouping<expertiseDomain, Contract>> result = from n in Dal.allContract()
                                                                       group n by n.Domain;
            List<Contract> lst = new List<Contract>();

            foreach (IGrouping<expertiseDomain, Contract> expert in result)
            {
                switch (expert.Key)
                {
                    case expertiseDomain.DataBase:
                        foreach (Contract n in expert)
                            lst.Add(n);
                        break;

                    case expertiseDomain.MobileProgramation:
                        foreach (Contract n in expert)
                            lst.Add(n);
                        break;

                    case expertiseDomain.NetWork:
                        foreach (Contract n in expert)
                            lst.Add(n);
                        break;

                    case expertiseDomain.SecurityInfo:
                        foreach (Contract n in expert)
                            lst.Add(n);
                        break;

                    case expertiseDomain.ServerSideProgramming:
                        foreach (Contract n in expert)
                            lst.Add(n);
                        break;

                    case expertiseDomain.UserInterfaceDesign:
                        foreach (Contract n in expert)
                            lst.Add(n);
                        break;

                }
            }
            return result;
        }
        public List<Contract> GroupingContractProfit(int beg, int end)
        {
            IEnumerable<IGrouping<double, Contract>> result = from n in Dal.allContract()
                                                              group n by n.Commission;

            List<Contract> lst = new List<Contract>();
            foreach (Contract n in Dal.allContract())
            {
                if (n.JobBegins.Year >= beg && n.JobEndsup.Year <= end)
                {
                    lst.Add(n);
                }
            }
            return lst;
        }
        #endregion

        public delegate bool conditionDelegate(Contract c);
        public int numberValidContracts(conditionDelegate cond)
        {
            var List_contract = from n in Dal.allContract()
                                where cond(n)
                                select n;
            return List_contract.Count();
        }

        public void calculSalaryEmployee(Contract c)
        {
            var Listcontracts = from n in Dal.allContract()
                                where n.EmployeeId == c.EmployeeId && n.EmployerId == c.EmployerId
                                select n;
            if (Listcontracts.Count() == 0)
            {
                c.Commission = (c.BrutSalary * 0.10);
                c.NetSalary = c.BrutSalary - c.Commission;
            }
            else
            {
                c.Commission = c.BrutSalary * Math.Pow(0.25, Listcontracts.Count());
                c.NetSalary = c.BrutSalary - c.Commission;
            }
        }

       /* public Employer findEmployer(int ID)
        {
            return Dal.findEmployer(ID);
        }*/

        //return number of valid contract
        public int get_number_Contract()
        {
            return Dal.get_number_Contract();
        }

        public Employer findEmployer(int ID) { return Dal.findEmployer(ID); }
        public Specialization findExpert(int ID) { return Dal.findSpecialization(ID); }
        public Employee findEmployee(int ID) { return Dal.findEmployee(ID); }
        public Contract findContrat(int ID) { return Dal.findContract(ID); }

        #region bank
        public IEnumerable<int> returnBankCode(){return Dal.returnBankCode();}
        public IEnumerable<string> returnBankName(string y){return Dal.returnBankName(y);}
        public IEnumerable<string> returnCity(){return Dal.returnCity();}
        public IEnumerable<int> returnBranchCode(){return Dal.returnBranchCode();}
        public IEnumerable<string> returnAdresse(string y, string b){return Dal.returnAdresse(y, b);}
        public IEnumerable<int> Allist(){List<int> lst = new List<int>();    return lst;}
        #endregion

        public int employeeSalary(int ID)
        {
            int sahar;
            var v = from n in Dal.allContract()
                    where n.EmployeeId == ID
                    select n.NetSalary;
            string a = v.ToString();
            int.TryParse(a, out sahar);

            return sahar;
        }
        public void threa_isalive()// To update a specialization
        {
            Dal.threa_isalive();
        }
    }
}
