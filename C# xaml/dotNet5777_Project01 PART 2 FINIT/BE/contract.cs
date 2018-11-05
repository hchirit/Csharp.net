using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class contract
    {
        public int contractID { get; set; } 
        public int employerID { get; set; }
        public int employeeID { get; set; }
        public int professionalID { get; set; }
        public bool isSigned { get; set; }
        public double salaryBrute { get; set; }
        public double salaryNet { get; set; }
        public DateTime beginning { get; set; }
        public DateTime end { get; set; }
        public int numHours { get; set; }
        public expertise expertise { get; set; }
        public string city { get; set; }
        public double commission { get; set; } 
       
        public override string ToString()
        {
            string result = string.Format("contract id :{0}\n", contractID);
            result += "**************\n";
            result += string.Format("expertise :{0}  \t", expertise);
            result += string.Format("city :{0}  \t", city);
            result += string.Format("begining contract :  {0}\t", beginning);
            result += string.Format("end contract :  {0}\t", end);
            return result;
        }
       public  contract (int contractID_=0 ,int employerID_=0 , int employeeID_=0 ,int professionalID_=0 ,bool isSigned_= false  ,
           double salaryBrute_=0 ,double salaryNet_ =0, DateTime dt = default(DateTime), DateTime end_ = default(DateTime), int  numHours_=0 ,expertise  e_= expertise.ALGO_INGINEER,
           string city_= null , double commission_=0 )
        {
            contractID = contractID_;
            employerID = employerID_;
            employeeID = employeeID_;
            professionalID = professionalID_;
            isSigned = isSigned_;
            salaryBrute = salaryBrute_;
            salaryNet = salaryNet_;
            beginning = dt;
            end = end_;
            numHours = numHours_;
            expertise = e_;
            city = city_;
           commission = commission_;

    }
    }
}
