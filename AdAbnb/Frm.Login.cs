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
    public partial class frmLogin : Form
    {
        static int clickEye { get; set; } = 0;
        public frmLogin()
        {
            InitializeComponent();
        }

        private void Frm_Load(object sender, EventArgs e)
        {

        }

        private void btnBack_Click(object sender, EventArgs e)
        {

            var t = new Thread(() => Application.Run(new FormSign_adv()));
            this.Close();
            t.Start();

        }

        public void viewPassword()
        {
            clickEye++;

            if (clickEye % 2 != 0)
            {
                txbPasswordLogin.PasswordChar = '\0';
                pictureBox2.Visible = false;
                pictureBox3.Visible = true;
            }
            else
            {
                txbPasswordLogin.PasswordChar = '*';
                pictureBox2.Visible = true;
                pictureBox3.Visible = false;
            }
        }
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            viewPassword();
        }

        private void pictureBox3_Click(object sender, EventArgs e)
        {
            viewPassword();
        }

        private void btnLogin_Click(object sender, EventArgs e)
        {
            GetLogin();
        }

        private void GetLogin()
        {

            string email = txbEmailLogin.Text == "" ? "" : txbEmailLogin.Text;
            string password = txbPasswordLogin.Text == "" ? "" : txbPasswordLogin.Text;

            foreach (KeyValuePair<Person, Registration> pair in Person.UserList)
            {
                if (pair.Value.Login == email && pair.Value.Password == password)
                {
                    var t = new Thread(() => Application.Run(new frmAdvArea((Owner)pair.Key)));
                    t.Start();
                    this.Close();


                }
                else
                    MessageBox.Show("Email ou senha não encontrado");


            }
        }
    }
}
