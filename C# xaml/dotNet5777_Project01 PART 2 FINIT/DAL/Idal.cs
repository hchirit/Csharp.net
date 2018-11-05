using BE;
using System;
using System.Collections.Generic;


namespace DAL
{
    public interface Idal
    {
        void addExpert(specialization e);
        void removeExpert(int id);
        void updateExpert(specialization e);

        void addEmployee(Employee e);
        void removeEmployee(Employee e);
        void uptdateEmployee(Employee e);

        void addEmployer(Employer e);
        void removeEmployer(Employer e);
        void uptdateEmployer(Employer e);

        void addcontract(contract c);
        void removecontract(contract c);
        void uptdatecontract(contract c);
        int get_number_Contract();
        bool seaurchID_existEmployee(int ID);
        bool seaurchID_existEmployer(int ID);
        Employer searchId_find_employer(int ID);
        Employee searchId_find_employee(int ID);
        specialization searchId_find_specialization(int ID);
        bool seaurchID_existspecialization(int ID);


        List<specialization> allExpert();

        /*
        List<Employee> allEmployee();
        List<Employer> allEmployer();
        List<contract> allContract();
        List<bank> allbranch();
        */


       // rajouter
        IEnumerable<specialization> Allspecialization(Func<specialization, bool> predicate = null);
        IEnumerable<contract> Allcontract(Func<contract, bool> predicate = null);
        IEnumerable<Employee> AllEmployee(Func<Employee, bool> predicate = null);
        IEnumerable<Employer> AllEmployer(Func<Employer, bool> predicate = null);
        IEnumerable<bank> Allbank(Func<bank, bool> predicate = null);

        bool seaurchID_existcontract(int ID);
        contract searchId_contract_find(int ID);
       
    }
}