using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace AdAbnb.Domain
{
    public class Property
    {
        public int count_prop;
        public int ID_prop //{ get; set; }
        {
           get
           { return count_prop; }
           set
           { count_prop++; }
       }
 
        public decimal Daily { get; set; }
        public string City { get; set; }
        public string District { get; set; }
        public string State { get; set; }
        public int Footage { get; set; }
        public bool Active { get; set; }
        public string imagetext { get; set; }
        public bool AC { get; set; }
        public bool Piscina { get; set; }
        public bool ProxMar { get; set; }
        public bool PetFriendly { get; set; }
        public bool Vaga { get; set; }
        public bool ProxTransp { get; set; }
       

        public Dictionary<string, bool> Facilities = new();

  
        public Property(string district, string city, string state, int footage, decimal daily, bool active, string image,
            bool ac, bool piscina, bool proxmar, bool pet, bool vaga, bool transp)
        {
            ID_prop = count_prop++;
            District = district;
            City = city;
            State = state;
            Footage = footage;
            Daily = daily;
            Active = active;
            imagetext = image;
            AC = ac;
            Piscina = piscina;
            ProxMar = proxmar;
            PetFriendly = pet;
            Vaga = vaga;
            ProxTransp=transp;

        }

        public void AddFacilities(string nome, bool status)
        {
            Facilities.Add(nome, status);   
        }





    }
}
