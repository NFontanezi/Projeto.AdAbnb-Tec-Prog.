using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdAbnb.Domain
{
    public class Property
    {
        public int ID_prop { get; private set; }
        public Owner Owner { get;  set; }
        public decimal Daily { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string Footage { get; set; }

        // lista de comodidades?? e imagens?
        public Property(int iD_prop, Owner owner, decimal daily, string city, string district, string footage)
        {
            ID_prop = iD_prop;
            Owner = owner;
            Daily = daily;
            City = city;
            District = district;
            Footage = footage;
        }

        



    }
}
