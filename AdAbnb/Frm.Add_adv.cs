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

        private void btnRegister_Click(object sender, EventArgs e)
        {
            string district = txbDistrict.Text == "" ? "" : txbDistrict.Text;
            string city = txbCity.Text == "" ? "" : txbCity.Text;
            string state = txbState.Text == "" ? "" : txbState.Text;
            int footage = txbFootage.Text == "" ? 0 : Convert.ToInt32(txbFootage.Text);
            int daily = txbFootage.Text == "" ? 0 : Convert.ToInt32(txbFootage.Text);
            bool active = cbxAtivo.Checked ? true : false;
            bool ac = cbxAC.Checked ? true : false;
            bool pool = cbxPool.Checked ? true : false;
            bool sea = cbxSea.Checked ? true : false;
            bool pet = cbxPet.Checked ? true : false;
            bool park = cbxPark.Checked ? true : false;
            bool bus = cbxBus.Checked ? true : false;

            bool check = CheckFields(district, city,  state,  footage,  daily);

            if (check)
            {
                Property newProp = new Property(district, city, state, footage, daily, active);
                newProp.AddFacilities("Piscina", pool);
                newProp.AddFacilities("Próximo ao mar", sea);
                newProp.AddFacilities("PetFriendly", pet);
                newProp.AddFacilities("Vaga estacionamento", park);
                newProp.AddFacilities("Próximo ao transporte público", bus);
                MessageBox.Show("Imovel incluído com sucesso");
                Owner.AddProperty(newProp);

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
    

        private bool CheckFields(string district, string city, string state, int footage, decimal daily)
        {
            if (district != "" && city != "" && state != "" && footage != 0 && daily != 0)
            {
                return true;
            }
            else return false;
        }

        private void Register()
        {
            throw new NotImplementedException();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var t = new Thread(() => Application.Run(new frmAdvArea(Owner)));
            this.Close();
            t.Start();
        }
    }
}
