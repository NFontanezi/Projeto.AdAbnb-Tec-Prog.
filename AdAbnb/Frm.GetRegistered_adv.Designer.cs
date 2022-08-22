namespace AdAbnb.Presentation
{
    partial class frmGetRegistered
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.lblNewAcc = new System.Windows.Forms.Label();
            this.lblName = new System.Windows.Forms.Label();
            this.txbName = new System.Windows.Forms.TextBox();
            this.lblEmail = new System.Windows.Forms.Label();
            this.txbEmail = new System.Windows.Forms.TextBox();
            this.lblCPF = new System.Windows.Forms.Label();
            this.txbCPF = new System.Windows.Forms.TextBox();
            this.lblPhone = new System.Windows.Forms.Label();
            this.txbPhone = new System.Windows.Forms.TextBox();
            this.lblBirth = new System.Windows.Forms.Label();
            this.txbBirth = new System.Windows.Forms.TextBox();
            this.cbxFemale = new System.Windows.Forms.CheckBox();
            this.cbxMale = new System.Windows.Forms.CheckBox();
            this.lblGender = new System.Windows.Forms.Label();
            this.lblPassword = new System.Windows.Forms.Label();
            this.txbPassword = new System.Windows.Forms.TextBox();
            this.btnRegister = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblBank = new System.Windows.Forms.Label();
            this.txbBank = new System.Windows.Forms.TextBox();
            this.lblBankAg = new System.Windows.Forms.Label();
            this.txbAg = new System.Windows.Forms.TextBox();
            this.lblBankAcc = new System.Windows.Forms.Label();
            this.txbBankAcc = new System.Windows.Forms.TextBox();
            this.lblMsg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNewAcc
            // 
            this.lblNewAcc.AutoSize = true;
            this.lblNewAcc.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNewAcc.Location = new System.Drawing.Point(27, 30);
            this.lblNewAcc.Name = "lblNewAcc";
            this.lblNewAcc.Size = new System.Drawing.Size(138, 30);
            this.lblNewAcc.TabIndex = 0;
            this.lblNewAcc.Text = "New Account";
            // 
            // lblName
            // 
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblName.Location = new System.Drawing.Point(27, 96);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(82, 13);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Nome Completo";
            // 
            // txbName
            // 
            this.txbName.Location = new System.Drawing.Point(24, 116);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(238, 23);
            this.txbName.TabIndex = 2;
            this.txbName.TextChanged += new System.EventHandler(this.txbName_TextChanged);
            // 
            // lblEmail
            // 
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblEmail.Location = new System.Drawing.Point(312, 96);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(32, 13);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "Email";
            // 
            // txbEmail
            // 
            this.txbEmail.Location = new System.Drawing.Point(309, 116);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(238, 23);
            this.txbEmail.TabIndex = 2;
            // 
            // lblCPF
            // 
            this.lblCPF.AutoSize = true;
            this.lblCPF.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCPF.Location = new System.Drawing.Point(27, 157);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(27, 13);
            this.lblCPF.TabIndex = 1;
            this.lblCPF.Text = "CPF";
            // 
            // txbCPF
            // 
            this.txbCPF.Location = new System.Drawing.Point(24, 177);
            this.txbCPF.Name = "txbCPF";
            this.txbCPF.Size = new System.Drawing.Size(238, 23);
            this.txbCPF.TabIndex = 2;
            // 
            // lblPhone
            // 
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPhone.Location = new System.Drawing.Point(312, 157);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(39, 13);
            this.lblPhone.TabIndex = 1;
            this.lblPhone.Text = "Celular";
            // 
            // txbPhone
            // 
            this.txbPhone.Location = new System.Drawing.Point(309, 177);
            this.txbPhone.Name = "txbPhone";
            this.txbPhone.Size = new System.Drawing.Size(238, 23);
            this.txbPhone.TabIndex = 2;
            // 
            // lblBirth
            // 
            this.lblBirth.AutoSize = true;
            this.lblBirth.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBirth.Location = new System.Drawing.Point(27, 228);
            this.lblBirth.Name = "lblBirth";
            this.lblBirth.Size = new System.Drawing.Size(104, 13);
            this.lblBirth.TabIndex = 1;
            this.lblBirth.Text = "Data de Nascimento";
            // 
            // txbBirth
            // 
            this.txbBirth.Location = new System.Drawing.Point(24, 248);
            this.txbBirth.Name = "txbBirth";
            this.txbBirth.Size = new System.Drawing.Size(238, 23);
            this.txbBirth.TabIndex = 2;
            // 
            // cbxFemale
            // 
            this.cbxFemale.AutoSize = true;
            this.cbxFemale.Location = new System.Drawing.Point(312, 250);
            this.cbxFemale.Name = "cbxFemale";
            this.cbxFemale.Size = new System.Drawing.Size(76, 19);
            this.cbxFemale.TabIndex = 3;
            this.cbxFemale.Text = "Feminino";
            this.cbxFemale.UseVisualStyleBackColor = true;
            // 
            // cbxMale
            // 
            this.cbxMale.AutoSize = true;
            this.cbxMale.Location = new System.Drawing.Point(419, 250);
            this.cbxMale.Name = "cbxMale";
            this.cbxMale.Size = new System.Drawing.Size(81, 19);
            this.cbxMale.TabIndex = 3;
            this.cbxMale.Text = "Masculino";
            this.cbxMale.UseVisualStyleBackColor = true;
            // 
            // lblGender
            // 
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblGender.Location = new System.Drawing.Point(309, 234);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(42, 13);
            this.lblGender.TabIndex = 1;
            this.lblGender.Text = "Genero";
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPassword.Location = new System.Drawing.Point(27, 294);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(38, 13);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Senha";
            // 
            // txbPassword
            // 
            this.txbPassword.Location = new System.Drawing.Point(24, 314);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.Size = new System.Drawing.Size(238, 23);
            this.txbPassword.TabIndex = 2;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(24, 366);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(238, 46);
            this.btnRegister.TabIndex = 4;
            this.btnRegister.Text = "Cadastrar";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(309, 366);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(238, 46);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Voltar";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblBank
            // 
            this.lblBank.AutoSize = true;
            this.lblBank.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBank.Location = new System.Drawing.Point(588, 96);
            this.lblBank.Name = "lblBank";
            this.lblBank.Size = new System.Drawing.Size(38, 13);
            this.lblBank.TabIndex = 1;
            this.lblBank.Text = "Banco";
            // 
            // txbBank
            // 
            this.txbBank.Location = new System.Drawing.Point(585, 116);
            this.txbBank.Name = "txbBank";
            this.txbBank.Size = new System.Drawing.Size(184, 23);
            this.txbBank.TabIndex = 2;
            // 
            // lblBankAg
            // 
            this.lblBankAg.AutoSize = true;
            this.lblBankAg.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBankAg.Location = new System.Drawing.Point(588, 157);
            this.lblBankAg.Name = "lblBankAg";
            this.lblBankAg.Size = new System.Drawing.Size(46, 13);
            this.lblBankAg.TabIndex = 1;
            this.lblBankAg.Text = "Agencia";
            // 
            // txbAg
            // 
            this.txbAg.Location = new System.Drawing.Point(585, 177);
            this.txbAg.Name = "txbAg";
            this.txbAg.Size = new System.Drawing.Size(184, 23);
            this.txbAg.TabIndex = 2;
            // 
            // lblBankAcc
            // 
            this.lblBankAcc.AutoSize = true;
            this.lblBankAcc.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblBankAcc.Location = new System.Drawing.Point(588, 226);
            this.lblBankAcc.Name = "lblBankAcc";
            this.lblBankAcc.Size = new System.Drawing.Size(80, 13);
            this.lblBankAcc.TabIndex = 1;
            this.lblBankAcc.Text = "Conta Bancaria";
            // 
            // txbBankAcc
            // 
            this.txbBankAcc.Location = new System.Drawing.Point(585, 246);
            this.txbBankAcc.Name = "txbBankAcc";
            this.txbBankAcc.Size = new System.Drawing.Size(184, 23);
            this.txbBankAcc.TabIndex = 2;
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Location = new System.Drawing.Point(647, 366);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(0, 15);
            this.lblMsg.TabIndex = 5;
            // 
            // frmGetRegistered
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.cbxMale);
            this.Controls.Add(this.cbxFemale);
            this.Controls.Add(this.txbBankAcc);
            this.Controls.Add(this.lblBankAcc);
            this.Controls.Add(this.txbAg);
            this.Controls.Add(this.lblBankAg);
            this.Controls.Add(this.txbBank);
            this.Controls.Add(this.lblBank);
            this.Controls.Add(this.txbEmail);
            this.Controls.Add(this.lblEmail);
            this.Controls.Add(this.txbPhone);
            this.Controls.Add(this.lblPhone);
            this.Controls.Add(this.txbPassword);
            this.Controls.Add(this.txbBirth);
            this.Controls.Add(this.lblPassword);
            this.Controls.Add(this.lblGender);
            this.Controls.Add(this.lblBirth);
            this.Controls.Add(this.txbCPF);
            this.Controls.Add(this.lblCPF);
            this.Controls.Add(this.txbName);
            this.Controls.Add(this.lblName);
            this.Controls.Add(this.lblNewAcc);
            this.Name = "frmGetRegistered";
            this.Text = "Registration";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblNewAcc;
        private Label lblName;
        private TextBox txbName;
        private Label lblEmail;
        private TextBox txbEmail;
        private Label lblCPF;
        private TextBox txbCPF;
        private Label lblPhone;
        private TextBox txbPhone;
        private Label lblBirth;
        private TextBox txbBirth;
        private CheckBox cbxFemale;
        private CheckBox cbxMale;
        private Label lblGender;
        private Label lblPassword;
        private TextBox txbPassword;
        private Button btnRegister;
        private Button btnBack;
        private Label lblBank;
        private TextBox txbBank;
        private Label lblBankAg;
        private TextBox txbAg;
        private Label lblBankAcc;
        private TextBox txbBankAcc;
        private Label lblMsg;
    }
}