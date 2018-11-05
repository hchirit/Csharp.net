using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using System.Xml.Linq;
using System.IO;
using System.Net;
using System.Threading;
using DS;

namespace DAL
{
    public class DAL_IMP_XML : Idal
    {
        private static DAL_IMP_XML instance = null;

        public static DAL_IMP_XML getInstance()
        {
            return instance ?? (new DAL_IMP_XML());
        }
        XElement specialization_ROOT;
        XElement contrat_ROOT;
        XElement employee_ROOT;
        XElement employer_ROOT;
        XElement BANK_ROOT;

        string Specialization_path = @"XML\specialization.xml";
        string Contrat_path = @"XML\Contrats.xml";
        string Employee_path = @"XML\Employee.xml";
        string Employer_path = @"XML\Employer.xml";
        string bank_path = @"XML\atm.xml";

        Thread thread_bank;
        private bool thread_finish = false;

        public DAL_IMP_XML()
        {
            thread_bank = new Thread(new ThreadStart(load_bank_file));
            Newfiles();
            GetFiles();
        }

        #region private function 
        private void Newfiles()
        {
            if (!Directory.Exists("XML"))
                Directory.CreateDirectory(@"XML");
            if (!File.Exists(Specialization_path))
            {
                specialization_ROOT = new XElement(new XElement("specializations"));
                specialization_ROOT.Save(Specialization_path);
            }
            if (!File.Exists(Contrat_path))
            {
                contrat_ROOT = new XElement(new XElement("contrats"));
                contrat_ROOT.Save(Contrat_path);
            }
            if (!File.Exists(Employee_path))
            {
                employee_ROOT = new XElement(new XElement("Employees"));
                employee_ROOT.Save(Employee_path);
            }
            if (!File.Exists(Employer_path))
            {
                employer_ROOT = new XElement(new XElement("employers"));
                employer_ROOT.Save(Employer_path);
            }
            if (!File.Exists(bank_path) && thread_bank.IsAlive == false)
            {
                thread_bank.Start();  // TO START THE THREAD THE FUNCTION LOAD_BANK_FILE()
            }
            //  else thread_finish = true; 
        }

        private void load_bank_file()
        {
            try
            {
                if (!File.Exists(bank_path))
                {
                    BANK_ROOT = new XElement(new XElement("ATMs"));
                    BANK_ROOT.Save(bank_path);
                    WebClient wc = new WebClient();
                    try
                    {
                        string xmlServerPath = @"http://www.boi.org.il/he/BankingSupervision/BanksAndBranchLocations/Lists/BoiBankBranchesDocs/atm.xml";
                        wc.DownloadFile(xmlServerPath, bank_path);
                    }
                    catch (Exception)
                    {
                        string xmlServerPath = @"http://www.jct.ac.il/~coshri/atm.xml";
                        wc.DownloadFile(xmlServerPath, bank_path);
                    }
                    finally
                    {
                        wc.Dispose();
                        thread_finish = true;
                        BANK_ROOT = XElement.Load(bank_path);
                    }
                }
                thread_finish = true;
                BANK_ROOT = XElement.Load(bank_path);
                Thread.Sleep(200);
            }
            catch
            {
                throw new Exception("problem reading the files or intenet connection");
            }
        }

        private void GetFiles()
        {

            specialization_ROOT = XElement.Load(Specialization_path);
            contrat_ROOT = XElement.Load(Contrat_path);
            employee_ROOT = XElement.Load(Employee_path);
            employer_ROOT = XElement.Load(Employer_path);
            if (File.Exists(bank_path) && thread_bank.IsAlive == false && thread_finish == true)
                BANK_ROOT = XElement.Load(bank_path);

        }
        private void SaveFiles()
        {
            try
            {
                specialization_ROOT.Save(Specialization_path);
                contrat_ROOT.Save(Contrat_path);
                employer_ROOT.Save(Employer_path);
                employee_ROOT.Save(Employee_path);
                BANK_ROOT.Save(bank_path);

            }
            catch
            {
                throw new Exception("problem to save the files");
            }
        }
        #endregion

        #region object to Xelement
        private XElement ConvertSpecialization(BE.Specialization specialization)
        {
            XElement newspecialization = new XElement("specialization",
                new XElement("specializationNumber", specialization.specializationNumber),
                new XElement("expertiseDomain", specialization.ExpertiseDomain),
                new XElement("minTarif", specialization.minTarif),
                new XElement("maxTarif", specialization.maxTarif),
                 new XElement("employerDomain", specialization.EmployerDomain)
                );

            return newspecialization;
        }
        private XElement ConvertContract(BE.Contract C)
        {
            XElement newCONTRAT = new XElement("Contract",
                new XElement("contractNumber", C.ContractNumber),
                new XElement("EmployerID", C.EmployerId),
                new XElement("EmployeeId", C.EmployeeId),
                new XElement("DoInterview", C.DoInterview),
                new XElement("ContractIsSigned", C.ContractIsSigned),
                new XElement("BrutSalary", C.BrutSalary),
                new XElement("NetSalary", C.NetSalary),
                new XElement("JobBegins", C.JobBegins),
                new XElement("JobEndsup", C.JobEndsup),
                new XElement("HourPerWeek", C.HourPerWeek),
                new XElement("CompanyDateCreation", C.CompanyDateCreation),
                new XElement("City", C.city),
                new XElement("domain", C.Domain),
               new XElement("Commission", C.Commission)
                );
            return newCONTRAT;
        }
        private XElement ConvertEmployee(BE.Employee employee)
        {
            XElement newEmployee = new XElement("employee",
                new XElement("employeeID", employee.Id),
                new XElement("Lastname", employee.LastName),
                new XElement("Firstname", employee.FirstName),
                new XElement("adress", employee.Adress),
                new XElement("Phonenumber", employee.PhoneNumber),
                new XElement("BirthDate", employee.BirthDate),
                new XElement("IsdoArmy", employee.IsDoArmy),
                new XElement("CODE-BANK", employee.BankDetails.BankNumber),
                new XElement("NAME-BANK", employee.BankDetails.BankName),
                new XElement("CITY", employee.BankDetails.BranhCity),
                new XElement("CODE-SNIF", employee.BankDetails.BranchNumber),
                new XElement("ADDRESS-ATM", employee.BankDetails.BranchAdress),
                new XElement("specialities", employee.Specialities),
                new XElement("Age", employee.age),
                new XElement("Netsalary", employee.NetSalary),
                new XElement("Brutsalary", employee.BrutSalary),
                new XElement("degree", employee.degree)
                 );
            return newEmployee;
        }
        private XElement ConvertEmployer(BE.Employer employer)
        {
            XElement newEmployer = new XElement("employers",
                new XElement("employerID", employer.Id),
                new XElement("Isprivate", employer.IsPrivate),
                new XElement("Lastname", employer.LastName),
                new XElement("Firstname", employer.FirstName),
                new XElement("Companyname", employer.CompanyName),
                new XElement("PhoneNumber", employer.PhoneNumber),
                new XElement("adress", employer.Adress),
                new XElement("CompanyDateCreation", employer.CompanyDateCreation),
                new XElement("dateContractSigned", employer.DateContractSigned),
                new XElement("domain", employer.Domain)
                );
            return newEmployer;
        }
        private XElement ConvertBank(BE.BankAccount bank)
        {
            XElement newbank = new XElement("bank",
                new XElement("BankNum", bank.BankNumber),
                new XElement("BankName", bank.BankName),
                new XElement("City", bank.BranhCity),
                new XElement("Branch_Bank", bank.BranchNumber),
                new XElement("AdressBank", bank.BranchAdress),
                new XElement("AccountNum", bank.BankAccounts));
            return newbank;
        }
        #endregion

        #region convert Xelement to object 
        private BE.Specialization ConvertSpecialization(XElement specialization)
        {
            try
            {
                return new BE.Specialization(
                    int.Parse(specialization.Element("specializationNumber").Value),
                    (BE.expertiseDomain)(Enum.Parse(typeof(BE.expertiseDomain), specialization.Element("expertiseDomain").Value)),
                    double.Parse(specialization.Element("minTarif").Value),
                    double.Parse(specialization.Element("maxTarif").Value),
                     (BE.employerDomain)(Enum.Parse(typeof(BE.employerDomain), specialization.Element("employerDomain").Value))
                    );
            }
            catch
            {
                throw new Exception("the object may not be converted");
            }
        }
        private BE.Contract ConvertContract(XElement c)
        {
            try
            {
                return new BE.Contract(
                    double.Parse(c.Element("BrutSalary").Value),
                    double.Parse(c.Element("NetSalary").Value),
                    (BE.City)(Enum.Parse(typeof(BE.City), c.Element("City").Value)),
                    DateTime.Parse(c.Element("CompanyDateCreation").Value),
                    bool.Parse(c.Element("ContractIsSigned").Value),
                    int.Parse(c.Element("contractNumber").Value),
                    bool.Parse(c.Element("DoInterview").Value),
                    int.Parse(c.Element("EmployeeId").Value),
                    int.Parse(c.Element("EmployerID").Value),
                    (BE.expertiseDomain)(Enum.Parse(typeof(BE.expertiseDomain), c.Element("domain").Value)),
                    int.Parse(c.Element("HourPerWeek").Value),
                    DateTime.Parse(c.Element("JobBegins").Value),
                    DateTime.Parse(c.Element("JobEndsup").Value),
                    double.Parse(c.Element("Commission").Value)
                      );
            }
            catch
            {
                throw new Exception("the object may not be converted");
            }
        }
        private BE.Employee ConvertEmployee(XElement employee)
        {
            try
            {
                return new Employee(
               employee.Element("Lastname").Value,
               employee.Element("Firstname").Value,
               DateTime.Parse(employee.Element("BirthDate").Value),
               int.Parse(employee.Element("Age").Value),
               double.Parse(employee.Element("Brutsalary").Value),
               double.Parse(employee.Element("Netsalary").Value),
               int.Parse(employee.Element("employeeID").Value),
               (BE.Degree)(Enum.Parse(typeof(BE.Degree), employee.Element("degree").Value)),
               int.Parse(employee.Element("Phonenumber").Value),
               employee.Element("adress").Value,
               bool.Parse(employee.Element("IsdoArmy").Value),
               employee.Element("NAME-BANK").Value,
               int.Parse(employee.Element("CODE-BANK").Value),
               employee.Element("CITY").Value,
               int.Parse(employee.Element("CODE-SNIF").Value),
               employee.Element("ADDRESS-ATM").Value
                );
            }
            catch
            {
                throw new Exception("the object may not be converted");
            }
        }
        private BE.Employer ConvertEmployer(XElement employer)
        {
            try
            {
                return new Employer(
                    int.Parse(employer.Element("employerID").Value),
                    employer.Element("Lastname").Value,
                    employer.Element("Firstname").Value,
                    int.Parse(employer.Element("PhoneNumber").Value),
                    employer.Element("adress").Value,
                    employer.Element("Companyname").Value,
                    (BE.employerDomain)(Enum.Parse(typeof(BE.employerDomain), employer.Element("domain").Value)),
                    bool.Parse(employer.Element("Isprivate").Value),
                    DateTime.Parse(employer.Element("CompanyDateCreation").Value),
                    DateTime.Parse(employer.Element("dateContractSigned").Value)
                    );
            }
            catch
            {
                throw new Exception("the object may not be converted");
            }

        }
        private BE.BankAccount ConvertBank(XElement bank)
        {
            try
            {
                return new BE.BankAccount(
                     bank.Element("שם_בנק").Value.ToString(),
                      int.Parse(bank.Element("קוד_סניף").Value),
                    int.Parse(bank.Element("קוד_בנק").Value),
                     bank.Element("כתובת_ה-ATM").Value.ToString(),
                     bank.Element("ישוב").Value.ToString()
                    );
            }
            catch
            {
                throw new Exception("the object bank could not be converted");
            }
        }
        #endregion

        #region Specialization
        public bool SpecializationExist(int specializationNumber)
        {
            try
            {

                XElement expertID_xml = (from s in specialization_ROOT.Elements()
                                         where s.Element("specializationNumber").Value == specializationNumber.ToString()
                                         select s).First();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public void addExpert(Specialization s)
        {
            if (s.specializationNumber == 0)
                throw new Exception("the specialization does not contain ID");
            else if (s.minTarif == 0)
                throw new Exception("the specialization does not containt min tarif");
            else if (s.minTarif == 0)
                throw new Exception("the specialization does not contain a max tarif");
            else if (SpecializationExist(s.specializationNumber))
                throw new Exception("the specialization id to add: " + s.specializationNumber + "  not exist");
            else
            {
                specialization_ROOT.Add(ConvertSpecialization(s));
                SaveFiles();
            }
        }

        public void updateExpert(Specialization s)
        {
            if (s.specializationNumber == 0)
                throw new Exception("the specialization do not contain id");
            else if (s.minTarif == 0)
                throw new Exception("the specilization does not have a minTarif");
            else if (s.maxTarif == 0)
                throw new Exception("the specialization does not have a maxTarif");
            else if (SpecializationExist(s.specializationNumber))
            {
                eraseExpert(s.specializationNumber);
                this.addExpert(s);
            }
            else throw new Exception("the specialization number to update: " + s.specializationNumber + " not exist");

        }
        public List<Specialization> allExpert()
        {
            return (from c in specialization_ROOT.Elements() select ConvertSpecialization(c)).ToList();
        }

        public Specialization findSpecialization(int specializationNumber)
        {
            try
            {
                XElement expertid_xml = (from s in specialization_ROOT.Elements()
                                         where s.Element("specializationNumber").Value == specializationNumber.ToString()
                                         select s).First();
                return ConvertSpecialization(expertid_xml);
            }
            catch
            {
                return null;
            }
        }

        public void eraseExpert(int id)
        {
            if (SpecializationExist(id) == true)
            {
                XElement expertid_delete = (from s in specialization_ROOT.Elements()
                                            where s.Element("specializationNumber").Value == id.ToString()
                                            select s).First();
                expertid_delete.Remove();
                SaveFiles();
            }
            else throw new Exception("the specialization ID to erase: " + id + " not exist");
        }

        public IEnumerable<Specialization> allSpecialization()
        {
            return (from s in specialization_ROOT.Elements() select ConvertSpecialization(s)).ToList();
        }
        #endregion

        #region contrat
        public void addContract(Contract c)
        {
            if (c.ContractNumber == 0)
                throw new Exception("the contract doesn't have an id");
            else if (ContractExist(c.ContractNumber))
                throw new Exception("the id:" + c.ContractNumber + " already exists");
            else if (!EmployerExist(c.EmployerId))
                throw new NotImplementedException("employer ID does not exist");
            else if (!EmployeeExist(c.EmployeeId))
                throw new NotImplementedException("employee ID does not exist");
            else
            {
                contrat_ROOT.Add(ConvertContract(c));
                SaveFiles();
            }
        }
        public IEnumerable<Contract> allContract()
        {
            return (from c in contrat_ROOT.Elements() select ConvertContract(c)).ToList();

        }
        public int get_number_Contract()
        {
            return (from c in contrat_ROOT.Elements() select ConvertContract(c)).Count();
        }
        public void eraseContract(Contract c)
        {
            if (ContractExist(c.ContractNumber))
            {
                XElement contract_delete = (from s in contrat_ROOT.Elements()
                                            where s.Element("contractNumber").Value == c.ContractNumber.ToString()
                                            select s).First();
                contract_delete.Remove();
                SaveFiles();
            }
            else
                throw new NotImplementedException("contrct id does not exist");
        }
        public Contract findContract(int Id)
        {
            try
            {
                XElement c_xml = (from s in contrat_ROOT.Elements()
                                  where s.Element("contractNumber").Value == Id.ToString()
                                  select s).First();
                return ConvertContract(c_xml);
            }
            catch
            {
                return null;
            }
        }

        public bool ContractExist(int id)
        {
            try
            {
                XElement contrat_xml = (from s in contrat_ROOT.Elements()
                                        where s.Element("contractNumber").Value == id.ToString()
                                        select s).First();
                return true;
            }
            catch
            {
                return false;
            }
        }
        public void uptdatecontract(Contract c)
        {
            if (c.ContractNumber == 0)
                throw new Exception("the contract doesn't have an id");
            else if (!ContractExist(c.ContractNumber))
                throw new Exception("the id:" + c.ContractNumber + " not exists");
            else if (!EmployerExist(c.ContractNumber))
                throw new NotImplementedException("employer ID does not exist");
            else if (!EmployeeExist(c.ContractNumber))
                throw new NotImplementedException("employee ID does not exist");
            else
            {
                eraseContract(c);
                addContract(c);
            }
        }
        #endregion

        #region Employee
        public void addEmployee(Employee e)
        {
            if (e.Id == 0)
                throw new Exception("the employee doesn't have a id");
            else if (e.PhoneNumber == 0)
                throw new Exception("there is no phone num");
            else if (EmployeeExist(e.Id))
                throw new Exception("the employee id: " + e.Id + " already exist ");
            else
            {
                employee_ROOT.Add(ConvertEmployee(e));
                SaveFiles();
            }
        }

        public void eraseEmployee(Employee E)
        {
            int Id = E.Id;
            if (EmployeeExist(Id))
            {
                XElement employee_delete = (from e in employee_ROOT.Elements()
                                            where e.Element("employeeID").Value == Id.ToString()
                                            select e).First();
                employee_delete.Remove();
                SaveFiles();
            }

        }

        public void uptdateEmployee(Employee e)
        {
            if (e.age < 18)
                throw new Exception("the employee is too much young");
            else if (e.Id == 0)
                throw new Exception("doesn't have an id");
            else if (e.PhoneNumber == 0)
                throw new Exception("there is no phone number");
            else if (EmployeeExist(e.Id))
            {
                eraseEmployee(e);
                addEmployee(e);
            }
            else
                throw new Exception("this employee ID :" + e.Id + "does not exist");

        }

        public IEnumerable<Employee> allEmployee()
        {
            return (from e in employee_ROOT.Elements() select ConvertEmployee(e)).ToList();
        }

        public bool EmployeeExist(int Id)
        {
            try
            {
                XElement employee_xml = (from e in employee_ROOT.Elements()
                                         where e.Element("employeeID").Value == Id.ToString()
                                         select e).First();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public Employee findEmployee(int Id)
        {
            try
            {
                XElement employee_xml = (from e in employee_ROOT.Elements()
                                         where e.Element("employeeID").Value == Id.ToString()
                                         select e).First();
                return ConvertEmployee(employee_xml);
            }
            catch
            {
                return null;

            }

        }
        #endregion

        #region Employer
        public void addEmployer(Employer e)
        {
            if (e.Id == 0)
                throw new Exception("there is no id");
            else if (e.LastName.Length == 0)
                throw new Exception("there is no last name");
            else if (e.FirstName.Length == 0)
                throw new Exception("there is no first name");
            else if (e.CompanyName.Length == 0 && !e.IsPrivate)
                throw new Exception("there is no company name");
            else if (e.PhoneNumber == 0)
                throw new Exception("there is no phone number");
            else if (EmployerExist(e.Id))
                throw new Exception("the company id: " + e.CompanyName + " already exist");
            else
            {
                employer_ROOT.Add(ConvertEmployer(e));
                SaveFiles();
            }


        }

        public void eraseEmployer(Employer E)
        {
            int Id = E.Id;
            if (EmployerExist(Id))
            {
                XElement employer_delete = (from e in employer_ROOT.Elements()
                                            where e.Element("employerID").Value == Id.ToString()
                                            select e).First();
                employer_delete.Remove();
                SaveFiles();
            }
        }
        public void uptdateEmployer(Employer e)
        {
            if (e.Id == 0)
                throw new Exception("there is no id");
            else if (e.LastName.Length == 0)
                throw new Exception("there is no last name");
            else if (e.FirstName.Length == 0)
                throw new Exception("there is no first name");
            else if (e.CompanyName.Length == 0 && !e.IsPrivate)
                throw new Exception("there is no company name");
            else if (e.PhoneNumber == 0)
                throw new Exception("there is no phone number");
            else if (EmployerExist(e.Id))
            {
                eraseEmployer(e);
                addEmployer(e);
            }
            else throw new Exception("the company id:" + e.Id + "doesn not exist");
        }

        public IEnumerable<Employer> allEmployer()
        {
            return (from e in employer_ROOT.Elements() select ConvertEmployer(e)).ToList();

        }
        public Employer findEmployer(int Id)
        {
            try
            {
                XElement employer_xml = (from e in employer_ROOT.Elements()
                                         where e.Element("employerID").Value == Id.ToString()
                                         select e).First();
                return ConvertEmployer(employer_xml);
            }
            catch
            {
                return null;
            }
        }

        public bool EmployerExist(int Id)
        {
            try
            {

                XElement employer_xml = (from e in employer_ROOT.Elements()
                                         where e.Element("employerID").Value == Id.ToString()
                                         select e).First();
                return true;
            }
            catch
            {
                return false;
            }
        }


        #endregion

        #region BANK
        public IEnumerable<BankAccount> allBank()
        {
            return (from c in BANK_ROOT.Elements() select ConvertBank(c)).ToList();
        }

        public IEnumerable<int> returnBankCode()
        {
            var v = from item in allBank()
                    select item.BankNumber;
            List<int> newList = new List<int>();
            foreach (int item in v)
            {
                if (newList.Contains(item) == false)
                {
                    newList.Add(item);
                }
            }
            return newList;
        }

        public IEnumerable<string> returnBankName(string y)
        {
            var v = from item in allBank()
                    where item.BranhCity == y
                    select item.BankName;
            List<string> newList = new List<string>();
            foreach (string item in v)
            {
                if (newList.Contains(item) == false)
                {
                    newList.Add(item);
                }
            }
            return newList;
        }

        public IEnumerable<string> returnCity()
        {
            var v = from item in allBank()
                    select item.BranhCity;
            List<string> newList = new List<string>();
            foreach (string item in v)
            {
                if (newList.Contains(item) == false)
                {
                    newList.Add(item);
                }
            }
            return newList;
        }

        public IEnumerable<int> returnBranchCode()
        {
            var v = from item in allBank()
                    select item.BankNumber;
            List<int> newList = new List<int>();
            foreach (int item in v)
            {
                if (newList.Contains(item) == false)
                {
                    newList.Add(item);
                }
            }
            return newList;
        }

        public IEnumerable<string> returnAdresse(string y, string b)
        {
            var v = from item in allBank()
                    where item.BranhCity == y && item.BankName == b
                    select item.BranchAdress;
            List<string> newList = new List<string>();
            foreach (string item in v)
            {
                if (newList.Contains(item) == false)
                {
                    newList.Add(item);
                }
            }
            return newList;

        }
        public void threa_isalive()// To update a specialization
        {

            try
            {
                BANK_ROOT = XElement.Load(bank_path);
                thread_finish = true;
            }
            catch
            {
                throw new Exception("the bank doesn't finish to download");
            }
        }

        #endregion


    }

}
