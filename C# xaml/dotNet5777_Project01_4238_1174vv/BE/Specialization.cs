using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class Specialization
    {
        //ctor
        public Specialization(int id = 0, expertiseDomain expertise = 0
            , double MinTarif = 0, double MaxTarif = 0,employerDomain employerdomain=default(employerDomain))
        {
            specializationNumber = id;
            ExpertiseDomain = expertise;
            minTarif = MinTarif;
            maxTarif = MaxTarif;
            EmployerDomain = employerdomain;

        }
        //attributs
        int SpecializationNumber;
        double MinTarif;
        double MaxTarif;

        //properties
        public int specializationNumber { set { SpecializationNumber = value; } get { return SpecializationNumber; } }
        public expertiseDomain ExpertiseDomain { get; set; }
        public employerDomain EmployerDomain { get; set; }
        public double minTarif { set { MinTarif = value; } get { return MinTarif; } }
        public double maxTarif { set { MaxTarif = value; } get { return MaxTarif; } }

        //to string
        public override string ToString()
        {
            string s = "Specialization number is:" + SpecializationNumber + "\n"
                    + "Domain is:" + ExpertiseDomain
                    + "Min tarif is:" + MinTarif + "\n"
                    + "Max tarif is:" + MaxTarif + "\n";
            return s;
        }
    }

}
