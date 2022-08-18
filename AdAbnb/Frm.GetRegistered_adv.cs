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
    public partial class frmGetRegistered : Form
    {
        List<Owner> listOwner_adv = new();
        List<Registration> listReg_adv=new();
        public frmGetRegistered()
        {
            InitializeComponent();
        }

        private void btnBack_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnRegister_Click(object sender, EventArgs e)
        {

            Register();
        }

        private bool CheckEmptyFields(string email, string password, string name, string cpf, string phone, DateTime birth, char gender, string bank, string bankAg, string bankAcc)
        {
            if (email != "" && password != "" && name != "" && cpf != "" && phone != "" && birth != null && bank != "" && bankAg != "" && bankAcc != "" && gender != null)
            {
                return true;
            }
            else return false;
        }

        private void Register()
        {

                string name = txbName.Text;
                string email = txbEmail.Text;
                string cpf = txbCPF.Text;
                string phone = txbPhone.Text;
                DateTime birth = Convert.ToDateTime(txbBirth.Text);
                string password = txbPassword.Text;
                char gender = GetGender();
                string bank = txbBank.Text;
                string bankAg = txbAg.Text;
                string bankAcc = txbBankAcc.Text;

            
                bool check = CheckEmptyFields(email, password, cpf, name, phone, birth, gender, bank, bankAg, bankAcc);

                if (check)
                {
                    Registration newReg = new Registration(email, password);
                    Owner newOwner = new Owner(newReg, cpf, name, phone, birth, gender, bank, bankAg, bankAcc);
                    MessageBox.Show("Registro incluído com sucesso");
                    listOwner_adv.Add(newOwner);
                    listReg_adv.Add(newReg);
                    frmAdvArea frm = new(newOwner);
                    frm.Show();
                    this.Close();
                }
                else
                {
                    lblMsg.Text = "Preencha todos os campos";
                    //MessageBox.Show("Preencha todos os campos");
                    //corrigir gender e birth para ""
                }

            //BindDataGridView();

        }

        private char GetGender()
        {
            if (cbxFemale.Checked)
                return 'F';

            else
                return 'M';


        }
    }
}
