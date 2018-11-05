using System.Collections.Generic;
using System;
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

        public void addExpert(Specialization s) { DS.DataSource.specializationList.Add(s); }
        public void addEmployer(Employer e) { DS.DataSource.EmployerList.Add(e); }
        public void addEmployee(Employee e) { DS.DataSource.EmployeeList.Add(e); }
        public void addContract(Contract c) { DS.DataSource.contractList.Add(c); }

        public void eraseExpert(int s) { DS.DataSource.specializationList.Remove(this.findSpecialization(s)); }
        public void eraseEmployer(Employer e) { DS.DataSource.EmployerList.Remove(e); }
        public void eraseEmployee(Employee e) { DS.DataSource.EmployeeList.Remove(e); }
        public void eraseContract(Contract c) { DS.DataSource.contractList.Remove(c); }

        public void updateExpert(Specialization e)
        {
            if (DS.DataSource.specializationList.Exists(c => c.specializationNumber == e.specializationNumber))
            {
                int index = DS.DataSource.specializationList.FindIndex(x => x.specializationNumber == e.specializationNumber);
                if (index != -1)
                    DataSource.specializationList[index] = e;
                else
                    throw new KeyNotFoundException("The SpecializationId doesn't exist");
            }

            else throw new KeyNotFoundException("The SpecializationId doesn't exist");
        }

        public void uptdatecontract(Contract c)
        {
            if (DS.DataSource.contractList.Exists(d => d.ContractNumber == c.ContractNumber))
            {
                int index = DS.DataSource.contractList.FindIndex(x => x.ContractNumber == c.ContractNumber);
                if (index != -1)
                    DataSource.contractList[index] = c;
                else
                    throw new KeyNotFoundException("The contractId doesn't exist");
            }

            else throw new KeyNotFoundException("The contractId doesn't exist");
        }

        public void uptdateEmployee(Employee e)
        {
            if (DS.DataSource.EmployeeList.Exists(c => c.Id == e.Id))
            {
                int index = DS.DataSource.EmployeeList.FindIndex(x => x.Id == e.Id);
                if (index != -1)
                    DataSource.EmployeeList[index] = e;
                else
                    throw new KeyNotFoundException("The Id doesn't exist");
            }

            else throw new KeyNotFoundException("The Id doesn't exist");
        }

        public void uptdateEmployer(Employer e)
        {
            if (DS.DataSource.EmployerList.Exists(c => c.Id == e.Id))
            {
                int index = DS.DataSource.EmployerList.FindIndex(x => x.Id == e.Id);
                if (index != -1)
                    DataSource.EmployerList[index] = e;
                else
                    throw new KeyNotFoundException("The companyID doesn't exist");
            }

            else throw new KeyNotFoundException("The companyID doesn't exist");
        }


        //this function tell if the id exist or not
        public bool EmployeeExist(int Id)
        {
            return (DS.DataSource.EmployeeList.Exists(e => e.Id == Id));
        }
        public bool EmployerExist(int Id)
        {
            return (DS.DataSource.EmployerList.Exists(e => e.Id == Id));
        }
        public bool ContractExist(int Id)
        {
            return (DataSource.contractList.Exists(s => s.ContractNumber == Id));
        }
        public bool SpecializationExist(int Id)
        {
            return (DataSource.specializationList.Exists(s => s.specializationNumber == Id));

        }

        //this function find with the id 
        public Contract findContract(int Id) { return DataSource.contractList.Find(s => s.ContractNumber == Id); }
        public Employer findEmployer(int Id) { return DataSource.EmployerList.Find(s => s.Id == Id); }
        public Employee findEmployee(int Id) { return DataSource.EmployeeList.Find(s => s.Id == Id); }
        public Specialization findSpecialization(int Id){ return DataSource.specializationList.Find(s => s.specializationNumber == Id); }

        public int get_number_Contract() { return DataSource.contractList.Count; }

        public List<Specialization> allExpert()
        {
            return DS.DataSource.specializationList;
        }


        /* public List<Employer> allEmployer() { return DS.DataSource.EmployerList; }
         public List<Employee> allEmployee() { return DS.DataSource.EmployeeList; }
         public List<Contract> allContract() { return DS.DataSource.contractList; }
         public List<BankAccount> allBranch() { return DS.DataSource.branchList; }*/

        public IEnumerable<Specialization> allSpecialization() { return DS.DataSource.specializationList; }
        public IEnumerable<Employee> allEmployee() { return DS.DataSource.EmployeeList; }
        public IEnumerable<Employer> allEmployer() { return DS.DataSource.EmployerList; }
        public IEnumerable<Contract> allContract() { return DS.DataSource.contractList; }
        public IEnumerable<BankAccount> allBank() { return DS.DataSource.branchList; }


        //bank
        public IEnumerable<int> returnBankCode(){ throw new NotImplementedException();}
        public IEnumerable<string> returnBankName(string y){throw new NotImplementedException();}
        public IEnumerable<string> returnCity(){throw new NotImplementedException();}
        public IEnumerable<int> returnBranchCode(){throw new NotImplementedException();}
        public IEnumerable<string> returnAdresse(string y, string b){throw new NotImplementedException();}
        public IEnumerable<string> returnAdresse(){throw new NotImplementedException();}
        public void threa_isalive(){throw new NotImplementedException();}
    }
}
