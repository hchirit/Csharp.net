using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using BE;
using System.Xml.Linq;
using System.IO;

namespace DAL
{
    class DAL_IMP_XML : Idal
    {
        private static DAL_IMP_XML instance = null;

        public static DAL_IMP_XML getInstance()
        {
            return instance ?? (new DAL_IMP_XML());
        }

        XElement SPECIALIZATION_ROOT;
        XElement CONTRACT_ROOT;
        XElement EMPLOYEE_ROOT;
        XElement EMPLOYER_ROOT;

        string specialization_path = @"XML\SPECIALIZATION.xml";
        string CONTRACT_path = @"XML\CONTRACTS.xml";
        string EMPLOYEE_path = @"XML\EMPLOYEE.XML";
        string EMPLOYER_path = @"XML\EMPLOYER.XML";

        DAL_IMP_XML()
        {            
            CreateFiles();
            loadFIles();
            
        }

        #region private function
        private void CreateFiles()
        {
            if (!Directory.Exists("XML"))
                Directory.CreateDirectory(@"XML");
            if (!File.Exists(specialization_path))
            {
                SPECIALIZATION_ROOT = new XElement(new XElement("specializations"));
                SPECIALIZATION_ROOT.Save(specialization_path);
            }
            if (!File.Exists(CONTRACT_path))
            {
                CONTRACT_ROOT = new XElement(new XElement("CONTRACTS"));
                CONTRACT_ROOT.Save(CONTRACT_path);
            }
            if (!File.Exists(EMPLOYEE_path))
            {
                EMPLOYEE_ROOT = new XElement(new XElement("employees"));
                EMPLOYEE_ROOT.Save(EMPLOYEE_path);
            }
            if (!File.Exists(EMPLOYER_path))
            {
                EMPLOYER_ROOT = new XElement(new XElement("employer"));
                EMPLOYER_ROOT.Save(EMPLOYER_path);
            }
            // rajouter les autres fichier xml

        }
        private void loadFIles()
        {
            try
            {
                SPECIALIZATION_ROOT = XElement.Load(specialization_path);
                CONTRACT_ROOT = XElement.Load(CONTRACT_path);
                EMPLOYER_ROOT = XElement.Load(EMPLOYER_path);
                EMPLOYEE_ROOT = XElement.Load(EMPLOYEE_path);
            }
            catch
            {
                throw new Exception("problem reading the files");
            }
        }

        private void SaveFiles()
        {
            try
            {
                SPECIALIZATION_ROOT.Save(specialization_path);
                CONTRACT_ROOT.Save(CONTRACT_path);
                EMPLOYEE_ROOT.Save(EMPLOYEE_path);
                EMPLOYER_ROOT.Save(EMPLOYER_path);
                //rajouter le reste
            }
            catch
            {
                throw new Exception("problem saving the files");
            }
        }
        #endregion
        
        #region object to Xelement 
        private XElement ConvertSpecialization(BE.specialization specialization)
        {
            XElement newpecialization = new XElement("specialisation",
                new XElement("specialization_id", specialization.specialization_id),
                new XElement("discipline", specialization.discipline),
                new XElement("expertise", specialization.expertise),
                new XElement("minWage", specialization.minWage),
                new XElement("maxWage", specialization.maxWage)
                );

            return newpecialization;
        }

        private XElement ConvertCONTRACT(BE.contract C)
        {
            XElement newCONTRACT = new XElement("Contract",
                new XElement("contractID",C.contractID ),
                new XElement("employerID",C.employerID),
                new XElement("employeeID",C.employeeID ),
                new XElement("professionalID",C.professionalID ),
                new XElement("isSigned",C.isSigned ),
                new XElement("salaryBrute", C.salaryBrute),
                new XElement("salaryNet", C.salaryNet),
                new XElement("beginning", C.beginning),
                new XElement("end", C.end),
                new XElement("numHours",C.numHours ),
                new XElement("expertise", C.expertise),
                new XElement("city",C.city ),
                new XElement("commission",C.commission )
                );

            return newCONTRACT;
        }
        private XElement ConvertEmployee(BE.Employee employee)
        {
            XElement newemployee = new XElement("employee",
                      /*   
                        
                         new XElement("birthdate", employee.birthDate),
                         new XElement("ID", employee.ID),
                         new XElement("phone", employee.phone),
                         new XElement("adresse", employee.adress),
                         new XElement("degree", employee.degree),
                         new XElement("veteran", employee.veteran),
                         new XElement("bankdetails", employee.bankdetails),
                         new XElement("specialite", employee.specialite),
                         new XElement("experience", employee.experience),
                         new XElement("recommandatation", employee.recommendation),
                         new XElement("mispar iskot", employee.mispar_iskote) ,*/
                
                  
                  new XElement("lastname", employee.lastName),
                  new XElement("firstname", employee.firstName),
                  new XElement("birthdate", employee.birthDate),
                  new XElement("age", employee.age),
                  new XElement("ID", employee.ID),
                  new XElement("phone", employee.phone)
               //   new XElement("veteran", employee.veteran),
              //    new XElement("adresse", employee.adress),
              //    new XElement("degree", employee.degree),                                        
            //    new XElement("bankdetails", employee.bankdetails),
              //    new XElement("specialite", employee.specialite),
              //    new XElement("experience", employee.experience)

                         
                );

            return newemployee;
        }
        private XElement Convertemployer(BE.Employer employer)
        {
            XElement newemployer = new XElement("employer",
                new XElement("ID", employer.companyID),
            //  new XElement("company name", employer.companyName),
            
              new XElement("lastname", employer.lastName),
              new XElement("firstname", employer.firstName),
              new XElement("phone", employer.phone),
              new XElement("adresse", employer.adresse),
              new XElement("city", employer.city),

              //  new XElement("creation date", employer.creationDate),
                new XElement("discipline", employer.discipline),
               // new XElement("number employee", employer.numberEmployee),
                new XElement("private", employer.isPrivate)/* */
                );

            return newemployer;
        }
        #endregion

        #region convert Xelement to object 

        private BE.specialization ConvertSpecialization(XElement specialization)
        {
            try
            {
                return new BE.specialization(
                    int.Parse(specialization.Element("specialization_id").Value),
                    (BE.discipline)(Enum.Parse(typeof(BE.discipline),specialization.Element("discipline").Value)),
                    (BE.expertise)(Enum.Parse(typeof(BE.expertise), specialization.Element("expertise").Value)),
                    double.Parse(specialization.Element("minWage").Value),
                    double.Parse(specialization.Element("maxWage").Value)

                    );

            }
            catch
            {
                throw new Exception("the object cold not be converted");
            }
            
        }


        private BE.contract ConvertCONTRACT(XElement c)
        {
            try
            {
                return new BE.contract(
                   int.Parse(c.Element("contractID").Value),
                   int.Parse(c.Element("employerID").Value),
                   int.Parse(c.Element("employeeID").Value),
                   int.Parse(c.Element("professionalID").Value),
                   bool.Parse(c.Element("isSigned").Value),
                   double.Parse(c.Element("salaryBrute").Value),
                   double.Parse(c.Element("salaryNet").Value),
                   DateTime.Parse(c.Element("beginning").Value),
                   DateTime.Parse(c.Element("end").Value),
                   int.Parse(c.Element("numHours").Value),

                    (BE.expertise)(Enum.Parse(typeof(BE.expertise), c.Element("expertise").Value)),
                   c.Element("city").Value,
                    double.Parse(c.Element("commission").Value)

                    );

            }
            catch
            {
                throw new Exception("the object cold not be converted");
            }

        }
        private BE.Employee ConvertEmployee(XElement EMPLOYEE)
        {
           
           try
            {

                return new Employee(
                    EMPLOYEE.Element("lastname").Value,
                    EMPLOYEE.Element("firstname").Value,
                    DateTime.Parse(EMPLOYEE.Element("birthdate").Value),
                    int.Parse(EMPLOYEE.Element("age").Value),
                    int.Parse(EMPLOYEE.Element("ID").Value),
                    int.Parse(EMPLOYEE.Element("phone").Value)
                //    bool.Parse(EMPLOYEE.Element("veteran").Value),
                //  EMPLOYEE.Element("adresse").Value,
                //   (BE.Degree)(Enum.Parse(typeof(BE.Degree), EMPLOYEE.Element("degree").Value)),
                // (BE.bank)(Enum.Parse(typeof(BE.bank), EMPLOYEE.Element("bankdetails").Value)),
                //   (BE.specialization)(Enum.Parse(typeof(BE.specialization), EMPLOYEE.Element("specialite").Value)),
                //  int.Parse(EMPLOYEE.Element("experience").Value)
                     
                  //  int.Parse(EMPLOYEE.Element("mispar iskot").Value),
                //    EMPLOYEE.Element("recommandation").Value
                    );
             



            }
            catch
            {
                 throw new Exception("the object cold not be converted  ");
                
            }

        }
        private BE.Employer ConvertEmployer(XElement EMPLOYER)
        {
         
            try
            {
                return new Employer(
                    int.Parse(EMPLOYER.Element("ID").Value),
                 //   EMPLOYER.Element("company name").Value,
                    EMPLOYER.Element("lastname").Value,
                    EMPLOYER.Element("firstname").Value,
                  //  EMPLOYER.Element("phone").Value,
                    int.Parse(EMPLOYER.Element("phone").Value),
                    EMPLOYER.Element("adresse").Value,
                    EMPLOYER.Element("city").Value,
                   // DateTime.Parse(EMPLOYER.Element("creation date").Value),
                    (BE.discipline)(Enum.Parse(typeof(BE.discipline), EMPLOYER.Element("discipline").Value)),
                  //  int.Parse(EMPLOYER.Element("number employee").Value),
                   bool.Parse(EMPLOYER.Element("private").Value)
                        
  
                    );  
    
            }
            catch
            {
               
                throw new Exception("the object cold not be converted");
            }

        }
        //autre

        #endregion

        #region specialization
        public void addExpert(specialization e)
        {
            if (e.specialization_id == 0)
                throw new Exception("the specialization doesn't have a  id");
            else if(e.minWage==0)
                throw new Exception("the specialization doesn't have a min wage");
            else if (e.maxWage == 0)
                throw new Exception("the specialization doesn't have a max age");
            else if (seaurchID_existspecialization(e.specialization_id))
              throw new Exception("the specialization id :" + e.specialization_id + " doesn't exist");
            else 
            {
                SPECIALIZATION_ROOT.Add(ConvertSpecialization(e));
                SaveFiles();
            }
        }
        public void removeExpert(int id)
        {
              if (seaurchID_existspecialization(id) == true)
            {
                XElement expertid_delete = (from s in SPECIALIZATION_ROOT.Elements()
                                         where s.Element("specialization_id").Value == id.ToString()
                                         select s).First();
                expertid_delete.Remove();
                SaveFiles();
                //throw new NotImplementedException("is deleted !!");
            }
           else throw new Exception("the specialization id :" + id + " doesn't exist");
        }
        public bool seaurchID_existspecialization(int ID)
        {
            try
            {
                XElement expertid_xml = (from s in SPECIALIZATION_ROOT.Elements()
                                         where s.Element("specialization_id").Value == ID.ToString()
                                         select s).First();
                return true;
            }
            catch
            {
                return false;
            }

        }
        public void updateExpert(specialization e)
        {
            if (e.specialization_id == 0)
                throw new Exception("the specialization doesn't have a  id");
            else if (e.minWage == 0)
                throw new Exception("the specialization doesn't have a min wage");
            else if (e.maxWage == 0)
                throw new Exception("the specialization doesn't have a max age");
            else if (seaurchID_existspecialization(e.specialization_id))
            {
                removeExpert(e.specialization_id);
                this.addExpert(e);
            }
            else throw new Exception("the specialization id :" + e.specialization_id +" doesn't exist");

        }
        public List<specialization> allExpert()
        {
            return (from c in SPECIALIZATION_ROOT.Elements() select ConvertSpecialization(c)).ToList();
        }
        public specialization searchId_find_specialization(int ID)
        {
            try
            {
                XElement expertid_xml = (from s in SPECIALIZATION_ROOT.Elements()
                                         where s.Element("specialization_id").Value == ID.ToString()
                                         select s).First();
                return ConvertSpecialization(expertid_xml);
            }
            catch
            {
                return null;
            }
        }
        public IEnumerable<specialization> Allspecialization(Func<specialization, bool> predicate = null)  // annuler
        {
            return (from c in SPECIALIZATION_ROOT.Elements() select ConvertSpecialization(c)).ToList();
        }

        #endregion

        #region contract

          public void addcontract(contract c)
        {
            if (c.contractID == 0)
                throw new Exception("the specialization doesn't have a  id");
           
             else if (seaurchID_existcontract(c.contractID))
              throw new Exception("the specialization id :" + c.contractID + " exist");
          else if (seaurchID_existEmployer(c.contractID) == true)
               throw new NotImplementedException("EMPLOYER ID DOESN'T EXIST !!"); 
            else
            {
                CONTRACT_ROOT.Add(ConvertCONTRACT(c));
                SaveFiles();
            }
        }
        public IEnumerable<contract> Allcontract(Func<contract, bool> predicate = null)
        {
            return (from c in CONTRACT_ROOT.Elements() select ConvertCONTRACT(c)).ToList();
        }

        public int get_number_Contract()
        {
            return (from c in CONTRACT_ROOT.Elements() select ConvertCONTRACT(c)).Count();
        }
        public void removecontract(contract c)
        {
         
            if (seaurchID_existcontract(c.contractID))
            {

                XElement contrat_delete = (from s in CONTRACT_ROOT.Elements()
                                            where s.Element("contractID").Value == c.contractID.ToString()
                                            select s).First();
                contrat_delete.Remove();
                SaveFiles();
             //   throw new NotImplementedException("is deleted !!");
            }
            else
                throw new NotImplementedException("id doesn't exist");
        }

        public contract searchId_contract_find(int ID)
        {
            try
            {
                XElement c_xml = (from s in CONTRACT_ROOT.Elements()
                                         where s.Element("contractID").Value == ID.ToString()
                                         select s).First();
                return ConvertCONTRACT(c_xml);
            }
            catch
            {
                return null;
            }
        }
        public bool seaurchID_existcontract(int ID)
        {
            try
            {
                XElement contrat_xml = (from s in CONTRACT_ROOT.Elements()
                                         where s.Element("contractID").Value == ID.ToString()
                                         select s).First();
                return true;
            }
            catch
            {
                return false;
            }

        }
        public void uptdatecontract(contract c)
        {
            if (c.contractID == 0)
                throw new Exception("the specialization doesn't have a  id");
          
            else
            {
                removecontract(c);
                addcontract(c);
            }
        }
        #endregion

        #region EMPLOYEE
        public void addEmployee(Employee e)
        {          
             if (e.ID == 0)
                throw new Exception("the employee doesnt have an ID");
            else if (e.phone == 0)
                throw new Exception("their is no phone number");
            else if (searchId_find_employee(e.ID) == null)
            {
                EMPLOYEE_ROOT.Add(ConvertEmployee(e));
                SaveFiles();
            }
            else
                throw new Exception("the employee id :" + e.ID + " still exist");
        }

        public void removeEmployee(Employee P)
        {
            int ID = P.ID;
            if (seaurchID_existEmployee(ID))
            {

                XElement employee_delete = (from e in EMPLOYEE_ROOT.Elements()
                                            where e.Element("ID").Value == ID.ToString()
                                            select e).First();
                employee_delete.Remove();
                SaveFiles();

            }
        }

        public void uptdateEmployee(Employee e)
        {
            if (e.age < 18)
                throw new Exception("the employee is to young");
            else if (e.ID == 0)
                throw new Exception("the specialization doesn't have a min wage");
            else if (e.phone == 0)
                throw new Exception("their is no phone number");
            else if (seaurchID_existEmployee(e.ID))
            {
                removeEmployee(e);
                addEmployee(e);

            }
            else throw new Exception("the  id :" + e.ID + " doesn't exist");
        }

        public IEnumerable<Employee> AllEmployee(Func<Employee, bool> predicate = null)
        {
            return (from c in EMPLOYEE_ROOT.Elements() select ConvertEmployee(c)).ToList();            
        }

        public bool seaurchID_existEmployee(int ID)
        {
            try
            {
                XElement employee_xml = (from e in EMPLOYEE_ROOT.Elements()
                                         where e.Element("ID").Value == ID.ToString()
                                         select e).First();
                return true;
            }
            catch
            {
                return false;
            }
        }

        public Employee searchId_find_employee(int ID)
        {
            try
            {
                XElement employee_xml = (from e in EMPLOYEE_ROOT.Elements()
                                         where e.Element("ID").Value == ID.ToString()
                                         select e).First();
                return ConvertEmployee(employee_xml);
            }
            catch
            {
                return null;
            }
        }


        #endregion

        #region EMPLOYER
        public void addEmployer(Employer e)
        {

            if (e.companyID == 0)
                throw new Exception("the specialization doesn't have a min wage");
            else if (e.lastName.Length == 0)
                throw new Exception("their is no last name");
            else if (e.firstName.Length == 0)
                throw new Exception("their is no first name");
            else if (e.companyName.Length == 0)
                throw new Exception("their is no company name");
            else if (e.phone == 0)
                throw new Exception("their is no phone number");
            else if (searchId_find_employer(e.companyID) == null)
            {
                EMPLOYER_ROOT.Add(Convertemployer(e));
                SaveFiles();
            }
            else
                throw new Exception("the company id :" + e.companyID + " still exist");
        }

        public void removeEmployer(Employer P)
        {
            int ID = P.companyID;
            if (seaurchID_existEmployee(ID))
            {

                XElement employer_delete = (from e in EMPLOYER_ROOT.Elements()
                                            where e.Element("ID").Value == ID.ToString()
                                            select e).First();
                employer_delete.Remove();
                SaveFiles();

            }
        }

        public void uptdateEmployer(Employer e)
        {
            if (e.companyID == 0)
                throw new Exception("the specialization doesn't have a min wage");
            else if (e.lastName.Length == 0)
                throw new Exception("their is no last name");
            else if (e.firstName.Length == 0)
                throw new Exception("their is no first name");
            else if (e.companyName.Length == 0)
                throw new Exception("their is no company name");
            else if (e.phone == 0)
                throw new Exception("their is no phone number");
            else if (seaurchID_existEmployer(e.companyID))
            {
                removeEmployer(e);
                addEmployer(e);

            }
            else throw new Exception("the  company id :" + e.companyID + " doesn't exist");
        }

        public IEnumerable<Employer> AllEmployer(Func<Employer, bool> predicate = null)
        {
            return (from e in EMPLOYER_ROOT.Elements() select ConvertEmployer(e)).ToList();
            
        }

        public Employer searchId_find_employer(int ID)
        {
            try
            {
                XElement employer_xml = (from e in EMPLOYER_ROOT.Elements()
                                         where e.Element("ID").Value == ID.ToString()
                                         select e).First();
                return ConvertEmployer(employer_xml);
            }
            catch
            {
                return null;
            }
        }

        public bool seaurchID_existEmployer(int ID)
        {
            try
            {
                XElement employer_xml = (from e in EMPLOYER_ROOT.Elements()
                                         where e.Element("ID").Value == ID.ToString()
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
        public IEnumerable<bank> Allbank(Func<bank, bool> predicate = null)
        {
            throw new NotImplementedException();
        }
        #endregion

        


    }
}
