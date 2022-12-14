using AdAbnb.Domain;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
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
        

        public frmAddAdv(Owner owner, string district, string city,
            string state, string footage, string daily, string image, bool propAC, bool propPis,
             bool propMar, bool propPet, bool proVaga, bool proBus, bool active)
        { 


            InitializeComponent();
            Owner = owner;
            txbDistrict.Text = district;
            txbCity.Text = city;
            txbState.Text = state;
            txbFootage.Text = Convert.ToString(footage);
            txbDaily.Text = Convert.ToString(daily);
            txbURL.Text = image;
            cbxAC.Checked = true ? propAC == true : false;
            cbxPool.Checked = true ? propPis == true : false;
            cbxSea.Checked = true ? propMar == true : false;
            cbxPet.Checked = true ? propPet == true : false;
            cbxPark.Checked = true ? proVaga == true : false;
            cbxBus.Checked = true ? proBus == true : false;
            cbxAtivo.Checked = true ? active == true : false;


        }


        public void btnRegister_Click(object sender, EventArgs e)
        { 
            
            district = txbDistrict.Text;
            city = txbCity.Text == "" ? "" : txbCity.Text;
            state = txbState.Text == "" ? "" : txbState.Text;

            imagetext = txbURL.Text == "" ? "" : txbURL.Text;
            active = cbxAtivo.Checked ? true : false;
             ac = cbxAC.Checked ? true : false;
             pool = cbxPool.Checked ? true : false;
             sea = cbxSea.Checked ? true : false;
             pet = cbxPet.Checked ? true : false;
             park = cbxPark.Checked ? true : false;
             bus = cbxBus.Checked ? true : false;

            if (!IsValidURL(imagetext))
            {
                MessageBox.Show("Insira uma URL válida");
                return;
            }
            if (!Decimal.TryParse(txbFootage.Text, out decimal Valida))
            {
                MessageBox.Show("Por favor inserir um número inteiro para Metragem");
                return;
            }
            if (!Decimal.TryParse(txbDaily.Text, out decimal Valida2))
            {
                MessageBox.Show("Por favor inserir um número inteiro para Diária");
                return;
            }
            footage = txbFootage.Text == "" ? 0 : Convert.ToInt32(txbFootage.Text);
            daily = txbDaily.Text == "" ? 0 : Convert.ToInt32(txbDaily.Text);

            bool check = CheckFields(district, city, state, footage, daily,imagetext);

            if (check)
            {
                Property newProp = new Property(district, city, state, footage, daily, active,
                imagetext, ac, pool, sea, pet, park, bus );
                newProp.AddFacilities("Ativo", active);
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
        bool IsValidURL(string url)
        {
            string Pattern = @"^(?:http(s)?:\/\/)?[\w.-]+(?:\.[\w\.-]+)+[\w\-\._~:/?#[\]@!\$&'\(\)\*\+,;=.]+$";
            Regex Rgx = new Regex(Pattern, RegexOptions.Compiled | RegexOptions.IgnoreCase);
            return Rgx.IsMatch(imagetext);
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
