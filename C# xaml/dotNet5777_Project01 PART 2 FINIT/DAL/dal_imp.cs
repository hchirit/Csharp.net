using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using DS;

namespace DAL
{
    public class Dal_imp : Idal
    {
        private static Dal_imp instance = null;

        public static Dal_imp getInstance()
        {
            return instance ?? (new Dal_imp());
        }

        public void addcontract(contract c)
        {
            DS.DataSource.contractList.Add(c);
        }

        public void addEmployee(Employee e)
        {
            DS.DataSource.EmployeeList.Add(e);
        }

        public void addEmployer(Employer e)
        {
            DS.DataSource.EmployerList.Add(e);
        }

        public void addExpert(specialization e)
        {
            DS.DataSource.specializationList.Add(e);
        }



        public List<specialization> allExpert()
        {
            return DS.DataSource.specializationList;
        }


        public int get_number_Contract()
        {
            return DataSource.contractList.Count;
        }

        public void removecontract(contract c)
        {
            DS.DataSource.contractList.Remove(c);
        }

        public void removeEmployee(Employee e)
        {
            DS.DataSource.EmployeeList.Remove(e);
        }

        public void removeEmployer(Employer e)
        {
            DS.DataSource.EmployerList.Remove(e);
        }

        public void removeExpert(int id)
        {
            DS.DataSource.specializationList.Remove(this.searchId_find_specialization(id));
        }

        public bool seaurchID_existEmployee(int ID)
        {
            if (DataSource.EmployeeList.Exists(s => s.ID == ID))
                return true;
            else return false;
        }
        public bool seaurchID_existEmployer(int ID)
        {
            return (DataSource.EmployerList.Exists(s => s.companyID == ID));
        }
        public Employer searchId_find_employer(int ID)
        {
            return DataSource.EmployerList.Find(s => s.companyID == ID);            
        }
        public Employee searchId_find_employee(int ID)
        {
            return DataSource.EmployeeList.Find(s => s.ID == ID);
        }
       


        public void updateExpert(specialization e)
        {
            int id = e.specialization_id;
               if (DS.DataSource.specializationList.Exists(c => c.specialization_id == e.specialization_id))
               {
                   int index = DS.DataSource.specializationList.FindIndex(x => x.specialization_id == e.specialization_id);
                if (index != -1)
                    DataSource.specializationList[index] = e;
                else
                   throw new KeyNotFoundException(" The Specialization Id doesn't exist  : " + id);
               }
               else throw new KeyNotFoundException("The Specialization Id doesn't exist  : " + id);
                          
        }

        public void uptdatecontract(contract c)
        {
            int id = c.contractID;
            if (DS.DataSource.contractList.Exists(d => d.contractID == c.contractID))
            {
                int index = DS.DataSource.contractList.FindIndex(x => x.contractID == c.contractID);
                if (index != -1)
                    DataSource.contractList[index] = c;
                else
                    throw new KeyNotFoundException(" The contractId Id doesn't exist  : " + id);
            }

            else throw new KeyNotFoundException(" The contractId Id doesn't exist  : " + id);
        }

        public void uptdateEmployee(Employee e)
        {
            int id = e.ID;
            if (DS.DataSource.EmployeeList.Exists(c => c.ID == e.ID))
            {
                int index = DS.DataSource.EmployeeList.FindIndex(x => x.ID == e.ID);
                if (index != -1)
                    DataSource.EmployeeList[index] = e;
                else
                    throw new KeyNotFoundException(" The Employee Id doesn't exist  : " + id);             
            }
            else throw new KeyNotFoundException(" The Employee Id doesn't exist  : " + id);
        }

        public void uptdateEmployer(Employer e)
        {
            int id = e.companyID;
            if (DS.DataSource.EmployerList.Exists(c => c.companyID == e.companyID))
            {
               
                int index = DS.DataSource.EmployerList.FindIndex(x => x.companyID == e.companyID);
                if (index != -1)
                    DataSource.EmployerList[index] = e;
                else
                    throw new KeyNotFoundException(" The Employer Id doesn't exist  : " + id);
            }

            else throw new KeyNotFoundException(" The Employee Id doesn't exist  : " + id);
        }

        public IEnumerable<specialization> Allspecialization(Func<specialization, bool> predicate = null)
        {
            return DataSource.specializationList;
        }

        public IEnumerable<contract> Allcontract(Func<contract, bool> predicate = null)
        {
            return DataSource.contractList;
        }

        public IEnumerable<Employee> AllEmployee(Func<Employee, bool> predicate = null)
        {
            return DataSource.EmployeeList;
        }

        public IEnumerable<Employer> AllEmployer(Func<Employer, bool> predicate = null)
        {           
            return DataSource.EmployerList;
        }

        public IEnumerable<bank> Allbank(Func<bank, bool> predicate = null)
        {
            return DataSource.branchlist;           
        }

        public bool seaurchID_existcontract(int ID)
        {
            return (DataSource.contractList.Exists(s => s.contractID == ID));
        }

        public contract searchId_contract_find(int ID)
        {
            return DataSource.contractList.Find(s => s.contractID == ID);
        }

        public specialization searchId_find_specialization(int ID)
        {
            return DataSource.specializationList.Find(s => s.specialization_id == ID);
        }

        public bool seaurchID_existspecialization(int ID)
        {
            return (DataSource.specializationList.Exists(s => s.specialization_id == ID));
        }

        
    }
}
