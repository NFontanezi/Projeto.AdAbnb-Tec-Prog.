using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using AdAbnb.Domain;
using System.Threading.Tasks;

namespace AdAbnb.Repositories
{
    public class AllProperties
    {
        //public int count_prop;
        //public int ID_prop //{ get; set; }
        //{
        //    get
        //    { return count_prop; }
        //    set
        //    { count_prop++; }
        //}
        //public decimal Daily { get; set; }
        //public string City { get; set; }
        //public string District { get; set; }
        //public string State { get; set; }
        //public int Footage { get; set; }
        //public bool Active { get; set; }
        //public string imagetext { get; set; }
        //public AllProperties(string district, string city, string state, int footage, decimal daily, bool active, string image)
        //{
        //    ID_prop = count_prop;
        //    District = district;
        //    City = city;
        //    State = state;
        //    Footage = footage;
        //    Daily = daily;
        //    Active = active;
        //    imagetext = image;

        //}

        static Property property1 = new Property("Bairro qualquer", "Guarujá", "SP", 100, 700, true,
        "https://viagemeturismo.abril.com.br/wp-content/uploads/2020/09/casas-airbnb-praia-perto-de-sao-paulo.jpg");

        static Property property2 = new Property("Bairro qualquer 2", "Ubatuba", "SP", 100, 800, true,
        "https://maladeaventuras.com/wp-content/uploads/2021/01/apartamento-de-temporada-bombinhas.jpg");

        public static List<Property> allProperties = new List<Property>() {property1, property2};
        
       
    }
}
