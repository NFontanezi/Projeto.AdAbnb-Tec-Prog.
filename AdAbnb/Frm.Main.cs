using AdAbnb.Presentation;

namespace AdAbnb
{
    public partial class frmMain : Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void advertisimentToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void btnAdvert_Click(object sender, EventArgs e)
        {
            FormSign_adv frm = new();
            frm.Show();
        }

        private void btnAdvert2_Click(object sender, EventArgs e)
        {
            FormSign_adv frm = new();
            frm.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void btnRent_Click(object sender, EventArgs e)
        {
            Frm_SignInLogin_rnt signInOrLogin = new Frm_SignInLogin_rnt();
            this.Hide();
            signInOrLogin.Show();

        }


    }
}