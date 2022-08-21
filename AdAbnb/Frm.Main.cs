using AdAbnb.Presentation;

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
            FormSign_adv frm = new();
            this.Hide();
            frm.Show();
        }

        internal Form CenterToScreen()
        {
            throw new NotImplementedException();
        }

        private void btnAdvert2_Click(object sender, EventArgs e)
        {
            FormSign_adv frm = new();
            this.Hide();
            frm.Show();
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

        private void btnRent2_Click(object sender, EventArgs e)
        {
            Frm_SignInLogin_rnt signInOrLogin = new Frm_SignInLogin_rnt();
            this.Hide();
            signInOrLogin.Show();
        }

        private void frmMain_Load(object sender, EventArgs e)
        {

        }
    }
}