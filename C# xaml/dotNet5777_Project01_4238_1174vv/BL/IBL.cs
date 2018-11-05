using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace BL
{
    public interface IBL
    {
        //Expert
        void addExpert(Specialization s);
        void eraseExpert(int id);
        void updatingExpert(Specialization s);
        //Employee
        void addEmployee(Employee e);
        void eraseEmployee(int id);
        void updatingEmployee(Employee e);
        //Employer
        void addEmployer(Employer e);
        void eraseEmployer(int id);
        void updatingEmployer(Employer e);
        //Contract
        void addContract(Contract c);
        void eraseContract(int id);
        void updatingContract(Contract c);

        //return number of valid contract
        int get_number_Contract();

       // bool contractCanBeSigned(Contract c);
        void calculSalaryEmployee(Contract c);

        Employer findEmployer(int ID);
        Specialization findExpert(int ID);
        Employee findEmployee(int ID);
        Contract findContrat(int ID);

        //void GroupingProfit(bool sorted);


        #region Function all lists condition
        IEnumerable<Specialization> Allspecialization_condition(Predicate<Specialization> condition = null);
        IEnumerable<Contract> Allcontract_condition(Predicate<Contract> condition = null);
        IEnumerable<Employee> AllEmployee_condition(Predicate<Employee> condition = null);
        IEnumerable<Employer> AllEmployer_condition(Predicate<Employer> condition = null);
        IEnumerable<BankAccount> Allbank_condition(Predicate<BankAccount> condition = null);
        #endregion 

        #region all lists
        IEnumerable<Specialization> allSpecialization();
        IEnumerable<Contract> allContract();
        IEnumerable<Employee> allEmployee();
        IEnumerable<Employer> allEmployer();
        IEnumerable<BankAccount> allBank();
        #endregion

        IEnumerable<IGrouping<expertiseDomain, Contract>> GroupingExpert(bool sort);
        IEnumerable<IGrouping<City, Contract>> Grouping_City();
        List<Contract> GroupingContractProfit(int b, int end);


        #region bank 
        IEnumerable<int> returnBankCode();
        IEnumerable<string> returnBankName(string y);
        IEnumerable<string> returnCity();
        IEnumerable<int> returnBranchCode();
        IEnumerable<string> returnAdresse(string y, string b);
        IEnumerable<int> Allist();
        #endregion
        int employeeSalary(int ID);

        // Employer findEmployer(int ID);
        //   Specialization return_expert(int ID);

        void threa_isalive();

    }
}
