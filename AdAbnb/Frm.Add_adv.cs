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


       public void btnRegister_Click(object sender, EventArgs e)
        { 
            
            string district = txbDistrict.Text;
            string city = txbCity.Text == "" ? "" : txbCity.Text;
            string state = txbState.Text == "" ? "" : txbState.Text;
            int footage = txbFootage.Text == "" ? 0 : Convert.ToInt32(txbFootage.Text);
            int daily = txbDaily.Text == "" ? 0 : Convert.ToInt32(txbDaily.Text);
            string imagetext = txbURL.Text; //== "" ? "" : txbURL.Text;
            bool active = cbxAtivo.Checked ? true : false;
            bool ac = cbxAC.Checked ? true : false;
            bool pool = cbxPool.Checked ? true : false;
            bool sea = cbxSea.Checked ? true : false;
            bool pet = cbxPet.Checked ? true : false;
            bool park = cbxPark.Checked ? true : false;
            bool bus = cbxBus.Checked ? true : false;

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
                //MessageBox.Show("Preencha todos os campos");
                //corrigir gender e birth para ""
            }

            //BindDataGridView();
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

        public void GetEdit(string district, string city,
            string state, string imagetext, int footage, int daily)
        {
            txbDistrict.Text = district;
            txbCity.Text = city;
            txbState.Text = state;
            txbFootage.Text = Convert.ToString(footage);
            txbDaily.Text = Convert.ToString(daily);
            txbURL.Text = imagetext;
        }
        
        
    }
}
