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



    }
}
