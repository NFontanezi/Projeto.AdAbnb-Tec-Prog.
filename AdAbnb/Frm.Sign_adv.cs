using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdAbnb.Presentation;


namespace AdAbnb.Presentation
{
    public partial class FormSign_adv : Form
    {
        public FormSign_adv()
        {
            InitializeComponent();
        }


        private void btnRegistration_Click_1(object sender, EventArgs e)
        {

            var t = new Thread(() => Application.Run(new frmGetRegistered()));
            this.Close();
            t.Start();

        }

        private void btnSign_Click_1(object sender, EventArgs e)
        {
            var t = new Thread(() => Application.Run(new frmLogin()));
            this.Close();
            t.Start();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {

            var t = new Thread(() => Application.Run(new frmMain()));
            this.Close();
            t.Start();
        }
    }
}
