using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Employee
    {

        //attributs
        int id;
        string lastName;
        string firstName;
        DateTime birthDate;
        int phoneNumber;
        string adress;
        bool isDoArmy;
       Specialization specialities;


        //properties
        public int Id { set { id = value; } get { return id; } }
        public string LastName { set { lastName = value; } get { return lastName; } }
        public string FirstName { set { firstName = value; } get { return firstName; } }
        public string Adress { set { adress = value; } get { return adress; } }
        public int PhoneNumber { set { phoneNumber = value; } get { return phoneNumber; } }
        public DateTime BirthDate { set { birthDate = value; } get { return birthDate; } }
        public bool IsDoArmy { set { isDoArmy = value; } get { return isDoArmy; } }
        public BankAccount BankDetails { set ;  get ;}
        public Specialization Specialities { set { specialities = value; } get { return specialities; } }
        public int age { set; get; }
        public double NetSalary { set; get; }
        public double BrutSalary { set; get; }
        public Degree degree { set; get; }

        //ctor
        public Employee(string lastname_ = null, string FirstName = null, DateTime birth = default(DateTime), int Age = 0, 
            double brut = 0, double net = 0,int ID = 0,Degree degrees =Degree.Student, int phone = 0, string adresse = "",
            bool army = false, string B_NAME = null ,int B_NUM = 0, string CITY = null, int B_BRANCHS = 0, string B_ADDRESS = null)
        {
            BankDetails = new BankAccount();
            lastName = lastname_;
            firstName = FirstName;
            birthDate = birth;
            age = Age;
            id = ID;
            adress = adresse;
            phoneNumber = phone;
            degree = degrees;
            BrutSalary = brut;
            NetSalary = net;
            isDoArmy = army;
            BankDetails.BankNumber = B_NUM;
            BankDetails.BankName = B_NAME;
            BankDetails.BranhCity = CITY;
            BankDetails.BranchNumber = B_BRANCHS;
            BankDetails.BranchAdress = B_ADDRESS;
        }

        public override string ToString()
        {
            string s = "Id is:" + id + "\n"
                    + "Last name is:" + lastName + "  "
                    + "First name is:" + firstName + "\n"
                    + "Adress is:" + adress + "\n"
                    + "Telephone number is:" + phoneNumber + "\n"
                    + "Birth date is:" + birthDate + "\n"
                    + "Is do the army:" + isDoArmy + "\n"
                   + "specialities:" + specialities + "\n";
            return s;
        }

    }
}
