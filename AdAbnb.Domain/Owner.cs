using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdAbnb.Domain
{
    public class Owner : Person
    {
        private int count_owner = 0;
        public int ID_owner
        {
            get
            { return count_owner; }
            set
            { count_owner++; }

        }

        public string Bank { get; set; }
        public string BankAgency { get; set; }
        public string BankAccount { get; set; }

        public List<Property> PropertyList { get; set; } = new();

        public Owner(Registration registration, string cPF, string name,
           string phone, DateTime dateBirth, char gender,
            string bank, string bankAgency, string bankAccount) : base(registration, cPF, name, phone, dateBirth, gender)
        {
            ID_owner = this.ID_owner;
            Bank = bank;
            BankAgency = bankAgency;
            BankAccount = bankAccount;
        }

        public void AddProperty(Property prop)
        {
            PropertyList.Add(prop);
        }




    }
}
