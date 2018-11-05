using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Contract
    {
        // attributs 
        int contractNumber;
        int employerId;
        int employeeId;
        Employer employer;
        bool doInterview;
        bool contractIsSigned;
        double brutSalary;
        double netSalary;
        DateTime jobBegins;
        DateTime jobEndsup;
        int hourPerWeek;
        DateTime companyDateCreation;
       
        //ctor
        public Contract(double BrutSalary = 0, double NetSalary = 0, City city_s = City.Jerusalem, DateTime companyDateCreations = default(DateTime),
            bool isSigned_ = false, int Id = 0, bool DoInterview_s = false, int EmployeeId = 0, int EmployerId = 0,
            expertiseDomain domain = expertiseDomain.MobileProgramation, int HourPerWeeks = 0, DateTime JobbBegins = default(DateTime),
            DateTime jobbEndsup = default(DateTime),double comission=0)
        {
            brutSalary = BrutSalary;
            netSalary = NetSalary;
            city = city_s;
            companyDateCreation = companyDateCreations;
            contractIsSigned = isSigned_;
            contractNumber = Id;
            doInterview = DoInterview_s;
            employeeId = EmployeeId;
            employerId = EmployerId;
            Domain = domain;
            jobBegins = JobbBegins;
            jobEndsup = jobbEndsup;
            hourPerWeek = HourPerWeeks;
            Commission = comission;
        }

        //properties
        public int ContractNumber { set { contractNumber = value; } get { return contractNumber; } }
        public int EmployerId { set { employerId = value; } get { return employerId; } }
        public int EmployeeId { set { employeeId = value; } get { return employeeId; } }
        public bool DoInterview { set { doInterview = value; } get { return doInterview; } }
        public bool ContractIsSigned { set { contractIsSigned = value; } get { return contractIsSigned; } }
        public double BrutSalary { set { brutSalary = value; } get { return brutSalary; } }
        public double NetSalary { set { netSalary = value; } get { return netSalary; } }
        public DateTime JobBegins { set { jobBegins = value; } get { return jobBegins; } }
        public DateTime JobEndsup { set { jobEndsup = value; } get { return jobEndsup; } }
        public int HourPerWeek { set { hourPerWeek = value; } get { return hourPerWeek; } }
        public Employer Employer { set { employer = value; } get { return employer; } }
        public DateTime CompanyDateCreation { set { companyDateCreation = value; } get { return companyDateCreation; } }
        public  City  city{ set; get; }
        public expertiseDomain Domain { set;  get ; }
        public double Commission { get; set; }
//-------------------------------------------------------------------------------------
        //apprement a faire ds le bl
        //return if he did an interview or no
      /*  public string DidInterview()
        {
            if (doInterview)
                return "yes";
            else
                return "no";
        }

        //return if thecontract signed or no
        public string IsContractSigned()
        {
            if (contractIsSigned)
                return "yes";
            else
                return "no";
        } */
//---------------------------------------------------------------------------------------
        public override string ToString()
        {
            string s = "Contract number is:" + contractNumber + "\n"
                + "Employer id is:" + employerId + "\n"
                + "Did an interview:" + doInterview + "\n"
                + "Is contract signed:" + contractIsSigned + "\n"
                + "Brut salary per hour is:" + brutSalary + "\n"
                + "Net salary per hour:" + netSalary + "\n"
                + "Job begin at:" + jobBegins + "\n"
                + "Job finish at:" + jobEndsup + "\n"
                + "Hour work per week:" + hourPerWeek + "\n";

            return s;

        }
    }
}
