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
    public partial class Form_Img_Adv : Form
    {
        string path;
        public Form_Img_Adv(string path)
        {
            InitializeComponent();
            this.path = path;
        }

        private void Form_Img_Adv_Load(object sender, EventArgs e)
        {
            pictureBox1.Load(path);
        }
    }
}
