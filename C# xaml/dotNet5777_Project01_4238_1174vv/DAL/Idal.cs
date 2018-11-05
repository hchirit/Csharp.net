using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;

namespace DAL
{
    public interface Idal
    {
        void addExpert(Specialization s);
        void eraseExpert(int s);
        void updateExpert(Specialization e);
        
        void addEmployee(Employee e);
        void eraseEmployee(Employee e);
        void uptdateEmployee(Employee e);
      
        void addEmployer(Employer e);
        void eraseEmployer(Employer e);
        void uptdateEmployer(Employer e);
       
        void addContract(Contract c);
        void eraseContract(Contract c);
        void uptdatecontract(Contract c);
      
        //return true if the id exist
        bool EmployeeExist(int Id);
        bool EmployerExist(int Id);
        bool ContractExist(int Id);
        bool SpecializationExist(int Id);

        //find with the id 
        Contract findContract(int ID);
        Employer findEmployer(int ID);
        Employee findEmployee(int ID);
        Specialization findSpecialization(int ID);
        List<Specialization> allExpert();



        IEnumerable<Specialization> allSpecialization();
        IEnumerable<Employee> allEmployee();
        IEnumerable<Employer> allEmployer();
        IEnumerable<Contract> allContract();
        IEnumerable<BankAccount> allBank();


        int get_number_Contract();
        //bank
        IEnumerable<string> returnCity();
        IEnumerable<string> returnBankName(string y);
        IEnumerable<string> returnAdresse(string y, string b);
        IEnumerable<int> returnBankCode();
        IEnumerable<int> returnBranchCode();
        void threa_isalive();
    }
}
