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
    public partial class Frm_SignInLogin_rnt : Form
    {
        public Frm_SignInLogin_rnt()
        {
            InitializeComponent();
        }

        private void btn_Login_rnt_Click(object sender, EventArgs e)
        {
            frmLogin form_Login = new();
            this.Hide();
            form_Login.Show();
        }

        private void btn_SignIn_rnt_Click(object sender, EventArgs e)
        {
            Frm_GetRegistered_rnt form_GetRegistered = new();
            this.Hide();
            form_GetRegistered.Show();
        }

        private void btn_Search_rnt_Click(object sender, EventArgs e)
        {
            Frm_Search_rnt form_Search = new();
            this.Hide();
            form_Search.Show();

        }
    }
}
