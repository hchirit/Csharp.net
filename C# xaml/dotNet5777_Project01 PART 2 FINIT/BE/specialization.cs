using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    public class specialization
    {
        public int specialization_id { get; set; }
        public discipline discipline { get; set; }
        public expertise expertise { get; set; }
        public double minWage { get; set; }
        public double maxWage { get; set; }
        public override string ToString()
        {
            string result = "specialization details\n";
            result += "**********************";
            result += string.Format("specialization_id:{0}\t discipline:{1}", specialization_id,discipline);
            return result;
        }
        public specialization (int id=0, discipline discipline_= 0 , expertise expertise_=0 , double minWage_=0, double maxWage_=0)
        {
            specialization_id = id;
            discipline = discipline_;
            expertise = expertise_;
            minWage = minWage_;
            maxWage = maxWage_;
        }
    }
}
