using AdAbnb.Presentation;
using AdAbnb.Domain;
using AdAbnb.Repositories;
using System.Globalization;


namespace AdAbnb
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void btnAdvert_Click(object sender, EventArgs e)
        {
            var t = new Thread(() => Application.Run(new FormSign_adv()));
            this.Close();
            t.Start();
        }


        private void btnAdvert2_Click(object sender, EventArgs e)
        {
            var t = new Thread(() => Application.Run(new FormSign_adv()));
            this.Close();
            t.Start();
        }



        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnRent_Click(object sender, EventArgs e)
        {
            var t = new Thread(() => Application.Run(new Frm_SignInLogin_rnt()));
            this.Close();
            t.Start();
        }

        private void btnRent2_Click(object sender, EventArgs e)
        {
            var t = new Thread(() => Application.Run(new Frm_SignInLogin_rnt()));
            this.Close();
            t.Start();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void advertisimentToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var t = new Thread(() => Application.Run(new FormSign_adv()));
            this.Close();
            t.Start();
        }

        private void advertisimentToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            var t = new Thread(() => Application.Run(new Frm_SignInLogin_rnt()));
            this.Close();
            t.Start();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var t = new Thread(() => Application.Run(new Frm_AboutUs()));
            t.Start();
        }

        private void quitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            DialogResult dialogResult = MessageBox.Show("Voc? realmente deseja sair?", "Sair da aplica??o", MessageBoxButtons.YesNo);

            if(dialogResult == DialogResult.Yes)
            {
                Application.Exit();
            }
            else
            {

            }
        }

        private void btnAbout_Click(object sender, EventArgs e)
        {
            var t = new Thread(() => Application.Run(new Frm_AboutUs()));
            t.Start();
        }
    }

}

  
    
