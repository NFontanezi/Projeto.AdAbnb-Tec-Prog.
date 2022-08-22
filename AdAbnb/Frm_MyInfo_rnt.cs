using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using AdAbnb.Repositories;
using AdAbnb.Domain;

namespace AdAbnb.Presentation
{
    public partial class Frm_MyInfo_rnt : Form
    {
        public Frm_MyInfo_rnt()
        {
            InitializeComponent();
        }

        private void Frm_MyInfo_rnt_Load(object sender, EventArgs e)
        {
            lbInfoBlank.Text = ToString1(UsersRentDB.usersRentInfos.Where(x => x.Email == Frm_Login_rnt.emailLog).Single());

        }

        public static string ToString1(Person usuario)
        {
            return $@"
    Nome: {usuario.Name}
    CPF: {usuario.CPF}
    Telefone: {usuario.Phone}   
    Data de nascimento: {usuario.DateBirth}
    Gênero: {usuario.Gender}";
        }

    }
}
