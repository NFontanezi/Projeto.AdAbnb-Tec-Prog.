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
        public static int clickEye = 0;
        Person User { get; set; }   
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
            string name = txbName.Text;
            string email = txbEmail.Text;
            string cpf = txbCPF.Text;
            string phone = txbPhone.Text;
            string password = txbPassword.Text;

            
            if(string.IsNullOrEmpty(name)|| string.IsNullOrEmpty(email)|| string.IsNullOrEmpty(cpf)|| string.IsNullOrEmpty(phone) || string.IsNullOrEmpty(password))
            {
                MessageBox.Show("Preencha todos os campos");
                return;
            }

            if(!DateTime.TryParse(txbBirth.Text, out DateTime dataValida))
            {
                MessageBox.Show("Data de nascimento inválida. Insira uma data no formato: DD/MM/AAAA");
                return;
            }


            DateTime Birth = DateTime.Parse(txbBirth.Text);

            Registration userRegistration = new Registration(txbEmail.Text, txbPassword.Text);

            UsersRentDB.usersRentDic.Add(userRegistration.Login, userRegistration.Password);

            Person user = new Person(userRegistration, txbCPF.Text, txbName.Text, txbPhone.Text, Birth, Gender);
            UsersRentDB.usersRentInfos.Add(user);

            //Frm_ClientArea clientArea = new();
            //this.Hide();
            //clientArea.Show();

            User = user;

            var t = new Thread(() => Application.Run(new Frm_ClientArea(User)));
            this.Close();
            t.Start();
            


        }

        private void btnBack_Click(object sender, EventArgs e)
        {

            //Frm_SignInLogin_rnt form = new();
            //this.Hide();
            //form.Show();

            var t = new Thread(() => Application.Run(new Frm_SignInLogin_rnt()));
            this.Close();
            t.Start();
        }

        public void viewPassword()
        {
            clickEye++;

            if (clickEye % 2 != 0)
            {
                txbPassword.PasswordChar = '\0';
                pictureBox2.Visible = false;
                pictureBox3.Visible = true;
            }
            else
            {
                txbPassword.PasswordChar = '*';
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
    }
}
