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
       // public Owner Owner { get; set; }
        public decimal Daily { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string State { get; set; }
        public int Footage { get; set; }
        public bool Active { get; set; }

        public Dictionary<string, bool> Facilities = new();

        // lista de comodidades?? e imagens?
        public Property(string district, string city, string state, int footage, decimal daily, bool active)
        {
            ID_prop = this.ID_prop;
            //Owner = owner;
            District = district;
            City = city;
            State = state;
            Footage = footage;
            Daily = daily;
            Active = active;
        }

        public void AddFacilities(string nome, bool status)
        {
            Facilities.Add(nome, status);   
        }





    }
}
