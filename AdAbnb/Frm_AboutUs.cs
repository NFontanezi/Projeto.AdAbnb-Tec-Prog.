using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AdAbnb.Presentation
{
    public partial class Frm_AboutUs : Form
    {
        public Frm_AboutUs()
        {
            InitializeComponent();
        }




        private void abrirLinkedinNatC()
        {
            lnklblNatC.LinkVisited = true;
            var processes = Process.GetProcessesByName("Chrome");
            var path = processes.FirstOrDefault()?.MainModule?.FileName;
            Process.Start(path, "https://www.linkedin.com/in/naccamposs/");
        }

        private void abrirLinkedinNatF()
        {
            lnklblNatF.LinkVisited = true;
            var processes = Process.GetProcessesByName("Chrome");
            var path = processes.FirstOrDefault()?.MainModule?.FileName;
            Process.Start(path, "https://www.linkedin.com/in/natalia-fontanezi-86083436/");
        }


        private void pbxLinkedInNatC_Click(object sender, EventArgs e)
        {
            abrirLinkedinNatC();
        }
        private void lnklblNatC_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            abrirLinkedinNatC();
        }


        private void pbxLinkedInNatF_Click(object sender, EventArgs e)
        {
            abrirLinkedinNatF();
        }
        private void lnklblNatF_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            abrirLinkedinNatF();
        }



        public void abrirGithubNatC()
        {
            lnklblNatCgit.LinkVisited = true;
            var processes = Process.GetProcessesByName("Chrome");
            var path = processes.FirstOrDefault()?.MainModule?.FileName;
            Process.Start(path, "https://github.com/NataliaNCCS");
        }


        public void abrirGithubNatF()
        {
            lnklblNatFgit.LinkVisited = true;
            var processes = Process.GetProcessesByName("Chrome");
            var path = processes.FirstOrDefault()?.MainModule?.FileName;
            Process.Start(path, "https://github.com/nfontanezi/");
        }

        private void pbxGithubNatC_Click(object sender, EventArgs e)
        {
            abrirGithubNatC();
        }
        private void lnklblNatCgit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            abrirGithubNatC();
        }

        private void pbxGithubNatF_Click(object sender, EventArgs e)
        {
            abrirGithubNatF();
        }

        private void lnklblNatFgit_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            abrirGithubNatF();
        }
    }
}
