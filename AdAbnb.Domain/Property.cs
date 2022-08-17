using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdAbnb.Domain
{
    public class Property
    {
        private int count_prop=0;
        public int ID_prop
        {
            get
            { return count_prop; }
            set
            { count_prop++; }
        }
        public Owner Owner { get; set; }
        public decimal Daily { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string Footage { get; set; }

        // lista de comodidades?? e imagens?
        public Property( Owner owner, decimal daily, string city, string district, string footage)
        {
            ID_prop = this.ID_prop;
            Owner = owner;
            Daily = daily;
            City = city;
            District = district;
            Footage = footage;
        }





    }
}
