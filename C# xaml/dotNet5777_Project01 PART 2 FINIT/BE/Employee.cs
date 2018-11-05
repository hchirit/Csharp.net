using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Employee
    {



        public int age { get; set; }
        public int ID { get; set; }
        public string lastName { get; set; }
        public string firstName { get; set; }
        public DateTime birthDate { get; set; }
        public int phone { get; set; }
        public string adress { get; set; }
        public Degree degree { get; set; }
        public bool veteran { get; set; }
    //    public bank bankdetails { get; set; }
        public specialization specialite { get; set; }
        public int experience { get; set; }
     //  public string recommendation { get; set; }
      //  public int mispar_iskote { get; set; }
        //public int remuneration { get; set; } // sahare

        public Employee(string lastname_ = null, string value2 = null, DateTime dateTime = default(DateTime), int v1 = 0, int v2 = 0, int v3 = 0, bool v4 = false, string value3 = null, Degree degree = 0,  specialization specialization = default(specialization), int v5 = 0)
        {
            this.lastName = lastname_;
            this.firstName = value2;
            this.birthDate = dateTime;
            this.age = v1;
            this.ID = v2;
            this.phone = v3;
            this.veteran = v4;
            this.adress = value3;
            this.degree = degree;
         //   this.bankdetails = bank;
            this.specialite = specialization;
            this.experience = v5;
        //    this.mispar_iskote = v6;
           // this.recommendation = value4;
        }

        public override string ToString()
        {
            string result = "Employee details\n";
            result += "****************\n";
            result += string.Format("firstname:{0}\t lastname:{1}\t degree:{2}\t experience:{3}", lastName, firstName, degree, experience);
            return result;
        }

    }
}
