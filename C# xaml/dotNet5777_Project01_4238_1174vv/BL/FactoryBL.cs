using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BL
{
    public class FactoryBL
    {
        //creating a factory singleton so we get only one instanse of BL
        private static IBL instance = null;

        public static IBL GetBL()
        {
            if (instance == null)
            {
                instance = new myBL();
            }
            return instance;
        }
    }
}
