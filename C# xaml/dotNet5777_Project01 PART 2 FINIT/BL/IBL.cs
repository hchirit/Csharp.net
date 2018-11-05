using BE;
using System;
using System.Collections.Generic;
using System.Linq;

namespace BL
{
    public interface IBL
    {


        #region Function add
        void addExpert(specialization  e);
        void addEmployee(Employee e);
        void addEmployer(Employer e);
        void addcontract(contract c);
        #endregion

        #region Function remove
        void removeEmployee(int id);
        void removeEmployer(int ID);
        void removecontract(int ID);
        void removeExpert(int id);
        #endregion

        #region Function update
        void uptdateEmployee(Employee e);
        void uptdateEmployer(Employer e);
        void uptdatecontract(contract c);
        void updateExpert(specialization e);
        #endregion

        #region Function all lists
        IEnumerable<specialization> Allspecialization(Func<specialization, bool> predicate = null);
        IEnumerable<contract> Allcontract(Func<contract, bool> predicate = null);
        IEnumerable<Employee> AllEmployee(Func<Employee, bool> predicate = null);
        IEnumerable<Employer> AllEmployer(Func<Employer, bool> predicate = null);
        IEnumerable<bank> Allbank(Func<bank, bool> predicate = null);
        IEnumerable<contract> AllCONTRACT_TO_EMPLOYER(int ID);
        #endregion

        #region function groupings
        IEnumerable<IGrouping<expertise, contract>> Grouping_expert(bool miyoun);
        IEnumerable<IGrouping<string, contract>>  Grouping_city();
        #endregion
        
        #region functions return object
        Employer searchId_find_employer(int ID);
        specialization return_expert(int ID);
        Employee return_emploee(int ID);
        contract return_contrat(int ID);
       
        #endregion

        #region functions return names id of all list
        IEnumerable<int> return_names_id_employer();
        IEnumerable<int> return_names_id_employee();
        IEnumerable<int> return_names_id_specialization();
        IEnumerable<int> return_names_id_contract();
        int get_number_Contract();

        #endregion
        List<double> Grouping_contract_revahim();
        int sahar_employer(int ID);
    }
}