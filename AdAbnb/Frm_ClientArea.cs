﻿using System;
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
    public partial class Frm_ClientArea : Form
    {
        public Frm_ClientArea()
        {
            InitializeComponent();
        }

        private void btn_Search_Click(object sender, EventArgs e)
        {
            var t = new Thread(() => Application.Run(new Frm_AdvToRent_rnt()));
            this.Close();
            t.Start();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            var t = new Thread(() => Application.Run(new Frm_SignInLogin_rnt()));
            this.Close();
            t.Start();
        }

        private void btn_Infos_Click(object sender, EventArgs e)
        {
            var t = new Thread(() => Application.Run(new Frm_MyInfo_rnt()));
            this.Close();
            t.Start();
        }
    }
}
