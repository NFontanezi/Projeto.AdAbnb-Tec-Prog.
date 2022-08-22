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
    public partial class Frm_Search_rnt : Form
    {
        public Frm_Search_rnt()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            pictureBox1.Image = Image.FromFile(@"C:\Users\natal\Downloads\logoAda-depositphotos-bgremover.png");



        }

        private void Frm_Search_rnt_Load(object sender, EventArgs e)
        {
        }
    }
}
