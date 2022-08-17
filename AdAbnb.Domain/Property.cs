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

    }
}
