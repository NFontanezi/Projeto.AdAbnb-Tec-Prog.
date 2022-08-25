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
            var t = new Thread(() => Application.Run(new FormSign_adv()));
            this.Close();
            t.Start();

        }

        private void btnRegister_Click(object sender, EventArgs e)
        {
            
            Register();
        }
        private bool checkBirth(string birth)
        {
            if (!DateTime.TryParse(txbBirth.Text, out DateTime dataValida))
            {
                MessageBox.Show("Data de nascimento inválida. Insira uma data no formato: DD/MM/AAAA");
                return true;
                
            }
            else return false;
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
                string password = txbPassword.Text;
                char gender = GetGender();
                string bank = txbBank.Text;
                string bankAg = txbAg.Text;
                string bankAcc = txbBankAcc.Text;


                if (!DateTime.TryParse(txbBirth.Text, out DateTime dataValida))
                {
                    MessageBox.Show("Data de nascimento inválida. Insira uma data no formato: DD/MM/AAAA");
                    return;
                }
                DateTime birth = Convert.ToDateTime(txbBirth.Text);
            


                bool check = CheckEmptyFields(email, password, cpf, name, phone, birth, gender, bank, bankAg, bankAcc);

                if (check)
                {
                    Registration newReg = new Registration(email, password);
                    Owner newOwner = new Owner(newReg, cpf, name, phone, birth, gender, bank, bankAg, bankAcc);
                    MessageBox.Show("Registro incluído com sucesso");
                    OwnerAdvDB.ownerAdvInfos.Add(newOwner);
                    listOwner_adv.Add(newOwner);
                    listReg_adv.Add(newReg);
                    Person.UserList.Add(newOwner, newReg);


                    var t = new Thread(() => Application.Run(new frmAdvArea(newOwner)));
                    t.Start();
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

            private void frmGetRegistered_Load(object sender, EventArgs e)
            {

            }

        private void lblNewAcc_Click(object sender, EventArgs e)
        {

        }

        private void lblMsg_Click(object sender, EventArgs e)
        {

        }

        private void cbxMale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void cbxFemale_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void txbBankAcc_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblBankAcc_Click(object sender, EventArgs e)
        {

        }

        private void txbAg_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblBankAg_Click(object sender, EventArgs e)
        {

        }

        private void txbBank_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblBank_Click(object sender, EventArgs e)
        {

        }

        private void txbEmail_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblEmail_Click(object sender, EventArgs e)
        {

        }

        private void txbPhone_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPhone_Click(object sender, EventArgs e)
        {

        }

        private void txbPassword_TextChanged(object sender, EventArgs e)
        {

        }

        private void txbBirth_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblPassword_Click(object sender, EventArgs e)
        {

        }

        private void lblGender_Click(object sender, EventArgs e)
        {

        }

        private void lblBirth_Click(object sender, EventArgs e)
        {

        }

        private void txbCPF_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblCPF_Click(object sender, EventArgs e)
        {

        }

        private void txbName_TextChanged(object sender, EventArgs e)
        {

        }

        private void lblName_Click(object sender, EventArgs e)
        {

        }
    }
}
