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
            CheckEmptyFields();
            Register();
        }

        private void CheckEmptyFields()
        {
            throw new NotImplementedException();
        }

        private void Register()
        {
            string name = txbName.Text;
            string email = txbEmail.Text;
            string cpf = txbCPF.Text;
            string phone = txbPhone.Text;
            DateTime birth = Convert.ToDateTime(txbBirth.Text);
            string password = txbPassword.Text;
            string bank = txbBank.Text;
            string bankAg = txbAg.Text;
            string bankAcc = txbBankAcc.Text;
            char gender = GetGender();

            Registration newReg = new Registration(email, password);
            Owner newOwner = new Owner(newReg, cpf, name, phone, birth, gender, bank, bankAg, bankAcc);
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
    