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
    }
}