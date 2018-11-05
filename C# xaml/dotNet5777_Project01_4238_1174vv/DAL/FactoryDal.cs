using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DAL
{
    public static class FactoryDal
    {
        //  private static Idal instance = null;

        public static Idal getInstance(string type = "XML")
        {


            if ("XML" == type.ToUpper())
            {

                return DAL_IMP_XML.getInstance();
                //  instance = new Dal_imp();
            }
            else return Dal_imp.getInstance();

        }
    }
}
