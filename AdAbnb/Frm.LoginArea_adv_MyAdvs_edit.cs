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

        private void checkBox2_CheckedChanged(object sender, EventArgs e)
        {

        }

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
            checkBox1.Checked = true ? propList.AC == true : false;
            checkBox2.Checked = true ? propList.Piscina == true : false;
            checkBox3.Checked = true ? propList.ProxMar == true : false;
            checkBox4.Checked = true ? propList.PetFriendly == true : false;
            checkBox5.Checked = true ? propList.Vaga == true : false;
            checkBox6.Checked = true ? propList.ProxTransp == true : false;
            checkBox7.Checked = true ? propList.Active == true : false;

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

            active = true ? checkBox7.Checked : false;
            ac = true ? checkBox1.Checked : false;
            pool = checkBox2.Checked ? true : false;
            sea = true ? checkBox2.Checked : false;
            pet = true ? checkBox3.Checked : false;
            pet = true ? checkBox4.Checked : false;
            park = true ? checkBox5.Checked : false;
            bus = true ? checkBox6.Checked : false;
            active = true ? checkBox7.Checked : false;


            string footage2 = Convert.ToString(footage);
            string daily2 = Convert.ToString(daily);
            var t = new Thread(() => Application.Run(new frmAddAdv(Owner, x, district, city, state,
                footage2, daily2, imagetext, ac, pool, sea, pet, park, bus, active)));
            this.Close();
            t.Start();
            

        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            //ac = checkBox1.Checked ? true : false;
        }
    }
}
