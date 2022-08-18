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
            //this.Close();
        }

        private void btnAdvert2_Click(object sender, EventArgs e)
        {
            FormSign_adv frm = new();
            frm.Show();
           //this.Close();
        }
    }
}