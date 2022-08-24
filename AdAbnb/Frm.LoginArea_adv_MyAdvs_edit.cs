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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace AdAbnb.Presentation
{
    public partial class FrmEdit : Form
    {
        public FrmEdit()
        {
            InitializeComponent();
        }
        Owner Owner;
        Property x;
        string district, city, state, imagetext;

         int footage, daily;

        bool ac, pool, sea, pet, park, bus, active;

        public FrmEdit(Owner owner, Property propList, string district, string city,
            string state, decimal footage, decimal daily, string image)
        {
            InitializeComponent();
            Owner = owner;
            x = propList;
            textBox1.Text = district;
            textBox2.Text = city;
            textBox3.Text = state;
            textBox4.Text = Convert.ToString(footage);
            textBox5.Text = Convert.ToString(daily);
            textBox6.Text = image;
            propList.AC = true ? checkBox1.Checked : false;
            propList.Piscina = true ? checkBox2.Checked : false;
            propList.ProxMar = true ? checkBox3.Checked : false;
            propList.PetFriendly = true ? checkBox4.Checked : false;
            propList.Vaga = true ? checkBox5.Checked : false;
            propList.ProxTransp = true ? checkBox6.Checked : false;



        }

        private void FrmEdit_Load(object sender, EventArgs e)
        {


        }

        private void btnSalvar_Click(object sender, EventArgs e)
        {//*

            district = textBox1.Text;
            city = textBox2.Text == "" ? "" : textBox2.Text;
            state = textBox2.Text == "" ? "" : textBox2.Text;
            footage = textBox4.Text == "" ? 0 : Convert.ToInt32(textBox4.Text);
            daily = textBox5.Text == "" ? 0 : Convert.ToInt32(textBox5.Text);
            imagetext = textBox6.Text == "" ? "" : textBox6.Text;
            active = checkBox7.Checked ? true : false;
            ac = checkBox1.Checked ? true : false;
            pool = checkBox2.Checked ? true : false;
            sea = checkBox3.Checked ? true : false;
            pet = checkBox4.Checked ? true : false;
            park = checkBox5.Checked ? true : false;
            bus = checkBox6.Checked ? true : false;

            string footage2 = Convert.ToString(footage);
            string daily2 = Convert.ToString(daily);
            var t = new Thread(() => Application.Run(new frmAddAdv(Owner, x, district, city, state,
                footage2, daily2, imagetext, ac, pool, sea, pet, park, bus, active)));
            this.Close();
            t.Start();
            

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
