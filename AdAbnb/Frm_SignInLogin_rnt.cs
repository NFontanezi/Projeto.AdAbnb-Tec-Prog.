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

namespace AdAbnb.Presentation
{
    public partial class Frm_SignInLogin_rnt : Form
    {
        Person User;

        public Frm_SignInLogin_rnt()
        {
            InitializeComponent();
        }

        private void btn_Login_rnt_Click(object sender, EventArgs e)
        {
            var t = new Thread(() => Application.Run(new Frm_Login_rnt()));
            this.Close();
            t.Start();
        }

        private void btn_SignIn_rnt_Click(object sender, EventArgs e)
        {
            var t = new Thread(() => Application.Run(new Frm_GetRegistered_rnt()));
            this.Close();
            t.Start();
        }

        private void btn_BackMenu_rnt_Click(object sender, EventArgs e)
        {
            var t = new Thread(() => Application.Run(new frmMain()));
            this.Close();
            t.Start();

        }

        private void Frm_SignInLogin_rnt_Load(object sender, EventArgs e)
        {

        }
    }
}
