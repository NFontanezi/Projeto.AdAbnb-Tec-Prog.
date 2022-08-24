using AdAbnb.Domain;
using AdAbnb.Repositories;
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
    public partial class frmLoginAreaAdv_MyInfo : Form
    {
        Owner Owner { get; set; }
        public frmLoginAreaAdv_MyInfo(Owner owner)
        {
            Owner = owner;
            InitializeComponent();
        }

        private void frmLoginAreaAdv_MyInfo_Load(object sender, EventArgs e)
        {
            lblMyInfo_adv.Text = ToString1(Owner);
        }

        public static string ToString1(Owner owner)
        {
            return $@"
    Nome: {owner.Name}
    CPF: {owner.CPF}
    Telefone: {owner.Phone}   
    Data de nascimento: {owner.DateBirth}
    Gênero: {owner.Gender}
    Banco: {owner.Bank}
    Agência: {owner.BankAgency}
    Conta: {owner.BankAccount}
    Data de nascimento: {owner.DateBirth}";
        }


        private void btnVoltar_Click(object sender, EventArgs e)
        {
            var t = new Thread(() => Application.Run(new frmAdvArea(Owner)));
            this.Close();
            t.Start();
        }
    }
}
