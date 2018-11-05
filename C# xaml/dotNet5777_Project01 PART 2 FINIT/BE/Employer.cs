using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Employer
    {
        public bool isPrivate { get; set; }
        public int companyID { get; set; }
        public string lastName { get; set; }
        public string firstName { get; set; }
        public string companyName { get; set; }
        public int phone { get; set; }
        public string adresse { get; set; }
        public discipline discipline { get; set; }
        public DateTime creationDate { get; set; }
        public int numberEmployee { get; set; }
        public string city { get; set; }



        public Employer(int id = 0,  string lastName_ = null, string firstname_ = null, int phone1 = 0, string adresse_ = null, string city_ = null, discipline d = 0, bool isprivate = false)
        {


            companyID = id;
           // companyName = companyName_;
            lastName = lastName_;
            firstName = firstname_;
            phone = phone1;
            adresse = adresse_;
            city = city_;
           // creationDate = creation;
            discipline = d;
           // numberEmployee = employeenum;

            isPrivate = isprivate;

        }


        public override string ToString()
        {
            string result = "Employer details\n";
            result += "*****************\n";
            result += string.Format("companyID:{0}", companyID);
            return result;

        }
    }
}

