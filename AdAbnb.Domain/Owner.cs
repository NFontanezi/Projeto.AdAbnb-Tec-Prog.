using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdAbnb.Domain
{
     public class Owner: Person
    {

        public int ID_owner { get; private set; }
        public string BankAgency { get; set; }
        public string BankAccount { get; set; }

        public List<Property> PropertyList { get; set; }

        public Owner(Registration registration, string cPF, string name, 
            string email, string phone, DateTime dateBirth, char gender,
            string bankAgency, string bankAccount) : base(registration, cPF, name, email, phone, dateBirth, gender)
        {
            BankAgency = bankAgency;
            BankAccount = bankAccount;
        }




    }
}
