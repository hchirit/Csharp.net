using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BE
{
    //cette classe va s'occuper de stocker les données concernant la bank de l'employee
    public class BankAccount
    {
        //attributs
        int bankNumber;
        string bankName;
        int bankAccount;
        int branchNumber;
        string branchAdress;
        string branchCity;
      
        //ctor      
        public BankAccount(string bank_name="", int branch_number=0, int bank_number=0, string branch_address="", string branch_city="")
        {
            bankNumber = bank_number;
            bankName = bank_name;
            branchNumber = branch_number;
            branchAdress = branch_address;
            branchCity = branch_city;
        }
        
        //properties
        public int BankNumber { set { bankNumber = value; } get { return bankNumber; } }
        public string BankName { set { bankName = value; } get { return bankName; } }
        public int BankAccounts { set { bankAccount = value; } get { return bankAccount; } }//pas utiliser 
        public int BranchNumber { set { branchNumber = value; } get { return branchNumber; } }
        public string BranchAdress { set { branchAdress = value; } get { return branchAdress; } }
        public string BranhCity { set { branchCity = value; } get { return branchCity; } }



    }
}
