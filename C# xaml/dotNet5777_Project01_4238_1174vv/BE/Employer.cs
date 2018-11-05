using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Employer
    {
        // attributs
        int id;
        bool isPrivate;
        string lastName;
        string firstName;
        string companyName;
        int phoneNumber;
        string adress;
        DateTime companyDateCreation;
        //double salaryNet;
        //double salaryBrut;
        //double commission;

        //properties
        public int Id { set { id = value; } get { return id; } }
        public bool IsPrivate { set { isPrivate = value; } get { return isPrivate; } }
        public string LastName { set { lastName = value; } get { return lastName; } }
        public string FirstName { set { firstName = value; } get { return firstName; } }
        public string CompanyName { set { companyName = value; } get { return companyName; } }
        public int PhoneNumber { set { phoneNumber = value; } get { return phoneNumber; } }
        public string Adress { set { adress = value; } get { return adress; } }
        public DateTime CompanyDateCreation { set { companyDateCreation = value; } get { return companyDateCreation; } }
        //public double SalaryNet { set { salaryNet = value; } get { return salaryNet; } }//for year
        //public double SalaryBrut { set { salaryBrut = value; } get { return salaryBrut; } }//for year
        //public double Commmission { set { commission = value; } get { return commission; } }
        public employerDomain Domain { set; get; }
        public DateTime DateContractSigned { set; get; }


        //------------------------------------------------------------------------------------
        //a faire apparement dans le bl
        // method , display if is the employer is private or public
        public string PrivateOrPublic()
        {
            if (isPrivate)
                return "Private";
            else
                return "Public";
        }
        //------------------------------------------------------------------------------------

        //ctor
        public Employer(int ids = 0, string lastName_ = null, string firstname_ = null, int phone = 0, string adresse_ = null,
            string compagnyname = null, employerDomain d = employerDomain.MobileProgramation, bool isprivate = false,
            DateTime cdatecreation = default(DateTime), DateTime dateContractSigned = default(DateTime))
        {
            id = ids;
            companyName = compagnyname;
            lastName = lastName_;
            firstName = firstname_;
            phoneNumber = phone;
            adress = adresse_;
            Domain = d;
            isPrivate = isprivate;//on part du principe quelle nest pas privé
            companyDateCreation = cdatecreation;
            DateContractSigned = dateContractSigned;
        }

        public override string ToString()
        {
            string s = "Id is:" + id + "\n"
                + "Company is:" + PrivateOrPublic() + "\n"
                + "Company name is:" + companyName + "\n"
                + "Last name is:" + lastName + "\n"
                + "First name is:" + firstName + "\n"
                + "Phone number is:" + phoneNumber + "\n"
                + "Adress is:" + adress + "\n"
                + "Date compagny creation is:" + companyDateCreation + "\n"
                + "Signature's date of contract is:" + DateContractSigned + "\n"
                + "Domain is:" + Domain + "\n";

            return s;
        }
    }
}
