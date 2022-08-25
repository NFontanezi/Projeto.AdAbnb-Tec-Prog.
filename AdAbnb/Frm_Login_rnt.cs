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
    public partial class Frm_Login_rnt : Form
    {
        static int clickEye { get; set; } = 0;
        public static Person User { get; set; }
        public static bool logado { get; set; } = false;
        public Frm_Login_rnt()
        {
            InitializeComponent();
        }


        private void btnBack_Click(object sender, EventArgs e)
        {
            var t = new Thread(() => Application.Run(new Frm_SignInLogin_rnt()));
            this.Close();
            t.Start();
        }

        public static string emailLog { get; set; }
        public static string passwordLog { get; set; }
        private void btnLogin_Click(object sender, EventArgs e)
        {
            if (UsersRentDB.usersRentDic.ContainsKey(txbEmailLogin.Text) && UsersRentDB.usersRentDic[txbEmailLogin.Text] == txbPasswordLogin.Text)
            {
                User = UsersRentDB.usersRentInfos.Where(x => x.Email == txbEmailLogin.Text).Single();

                MessageBox.Show("Usuário logado com sucesso");
                emailLog = txbEmailLogin.Text;
                passwordLog = txbPasswordLogin.Text;
                logado = true;
                var t = new Thread(() => Application.Run(new Frm_ClientArea(User)));
                this.Close();
                t.Start();
            }
            else
            {
                MessageBox.Show("Usuário ou senha incorretos, tente novamente");
                txbEmailLogin.Text = String.Empty;
                txbPasswordLogin.Text = String.Empty;
            }
        }

        public void viewPassword()
        {
            clickEye++;

            if (clickEye % 2 != 0)
            {
                txbPasswordLogin.PasswordChar = '\0';
                pictureBox4.Visible = false;
                pictureBox5.Visible = true;
            }
            else
            {
                txbPasswordLogin.PasswordChar = '*';
                pictureBox4.Visible = true;
                pictureBox5.Visible = false;
            }
        }
        private void pictureBox5_Click(object sender, EventArgs e)
        {

        }



    }
}

