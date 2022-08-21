using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdAbnb.Domain;
using AdAbnb.Repositories;

namespace AdAbnb.Presentation
{
    public partial class Frm_GetRegistered_rnt : Form
    {
        public char Gender { get; set; }


        public Frm_GetRegistered_rnt()
        {
            InitializeComponent();
        }

        private void Frm_GetRegistered_rnt_Load(object sender, EventArgs e)
        {

        }

        private void cbxFemale_Click(object sender, EventArgs e)
        {
            Gender = 'F';
        }

        private void cbxMale_Click(object sender, EventArgs e)
        {
            Gender = 'M';
        }

        private void btnRegister_rnt_Click(object sender, EventArgs e)
        {
            DateTime Birth = DateTime.Parse(txbBirth.Text);

            Registration userRegistration = new Registration(txbEmail.Text, txbPassword.Text);

            UsersRentDB userToBeAdd = new();
            userToBeAdd.usersRentList.Add(userRegistration);

            Person user = new Person(userRegistration, txbCPF.Text, txbName.Text, txbPhone.Text, Birth, Gender);

            Frm_ClientArea clientArea = new();
            this.Hide();
            clientArea.Show();


        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Frm_SignInLogin_rnt form = new();
            this.Hide();
            form.Show();
        }
    }
}
