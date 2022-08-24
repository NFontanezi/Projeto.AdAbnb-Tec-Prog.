using AdAbnb.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdAbnb.Presentation
{
    public partial class frmAddAdv : Form
    {
        
        Owner Owner { get; set; }
       
        public frmAddAdv(Owner owner)
        {
            Owner = owner;
            InitializeComponent();

        }

        Property x;
        string district, city, state,imagetext;

        int footage, daily;

        bool ac, pool, sea, pet, park, bus, active;
        

        public frmAddAdv(Owner owner, Property propList, string district, string city,
            string state, string footage, string daily, string image, bool propAC, bool propPis,
             bool propMar, bool propPet, bool proVaga, bool proBus, bool active)
        { 


            InitializeComponent();
            txbDistrict.Text = district;
            txbCity.Text = city;
            txbState.Text = state;
            txbFootage.Text = Convert.ToString(footage);
            txbDaily.Text = Convert.ToString(daily);
            txbURL.Text = image;
            active = true ? cbxAC.Checked : false;
            propList.AC = true ? cbxAC.Checked : false;
            propList.Piscina = true ? cbxPool.Checked : false;
            propList.ProxMar = true ? cbxSea.Checked : false;
            propList.PetFriendly = true ? cbxPet.Checked : false;
            propList.Vaga = true ? cbxPark.Checked : false;
            propList.ProxTransp = true ? cbxBus.Checked : false;

        }


        public void btnRegister_Click(object sender, EventArgs e)
        { 
            
            district = txbDistrict.Text;
            city = txbCity.Text == "" ? "" : txbCity.Text;
            state = txbState.Text == "" ? "" : txbState.Text;
            footage = txbFootage.Text == "" ? 0 : Convert.ToInt32(txbFootage.Text);
            daily = txbDaily.Text == "" ? 0 : Convert.ToInt32(txbDaily.Text);
            imagetext = txbURL.Text; //== "" ? "" : txbURL.Text;
            active = cbxAtivo.Checked ? true : false;
             ac = cbxAC.Checked ? true : false;
             pool = cbxPool.Checked ? true : false;
             sea = cbxSea.Checked ? true : false;
             pet = cbxPet.Checked ? true : false;
             park = cbxPark.Checked ? true : false;
             bus = cbxBus.Checked ? true : false;

            bool check = CheckFields(district, city, state, footage, daily,imagetext);

            if (check)
            {
                Property newProp = new Property(district, city, state, footage, daily, active,
                imagetext, ac, pool, sea, pet, park, bus );
                newProp.AddFacilities("Ar Condicionado", ac);
                newProp.AddFacilities("Piscina", pool);
                newProp.AddFacilities("Próximo ao mar", sea);
                newProp.AddFacilities("PetFriendly", pet);
                newProp.AddFacilities("Vaga estacionamento", park);
                newProp.AddFacilities("Próximo ao transporte público", bus);
                MessageBox.Show("Imovel incluído com sucesso");
                Owner.AddProperty(newProp);

                Repositories.AllProperties.allProperties.Add(newProp);

                var t = new Thread(() => Application.Run(new frmAdvArea(Owner)));
                this.Close();
                t.Start();
                

                
            }
            else
            {
                lblMsg.Text = "Preencha todos os campos";

            }


        }



        private bool CheckFields(string district, string city, string state, int footage, decimal daily, string image)
        {
            if (district != "" && city != "" && state != "" && footage != 0 && daily != 0 && image != "")
            {
                return true;
            }
            else return false;
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            var t = new Thread(() => Application.Run(new frmAdvArea(Owner)));
            t.Start();
            this.Close();
           
            btnRegister_Click(sender, e);
            
        }

        private void frmAddAdv_Load(object sender, EventArgs e)
        {

        }

        
        
    }
}
