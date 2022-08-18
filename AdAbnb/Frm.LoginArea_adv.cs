using AdAbnb.Domain;
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
    public partial class frmAdvArea : Form
    {   Owner Owner { get; set; }
        public frmAdvArea(Owner owner)
        {
            Owner = owner;
            InitializeComponent();
        }

        private void btnNewAdv_Click(object sender, EventArgs e)
        {

            frmAddAdv frm = new(Owner);
            frm.Show();
        }

        private void btnAdvOn_Click(object sender, EventArgs e)
        {

        }
    }
}
