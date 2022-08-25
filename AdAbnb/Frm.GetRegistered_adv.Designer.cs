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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGetRegistered));
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblNewAcc
            // 
            this.lblNewAcc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblNewAcc.AutoSize = true;
            this.lblNewAcc.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblNewAcc.ForeColor = System.Drawing.Color.Teal;
            this.lblNewAcc.Location = new System.Drawing.Point(332, 34);
            this.lblNewAcc.Name = "lblNewAcc";
            this.lblNewAcc.Size = new System.Drawing.Size(148, 28);
            this.lblNewAcc.TabIndex = 0;
            this.lblNewAcc.Text = "Nova conta";
            this.lblNewAcc.Click += new System.EventHandler(this.lblNewAcc_Click);
            // 
            // lblName
            // 
            this.lblName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblName.AutoSize = true;
            this.lblName.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblName.ForeColor = System.Drawing.Color.Teal;
            this.lblName.Location = new System.Drawing.Point(24, 94);
            this.lblName.Name = "lblName";
            this.lblName.Size = new System.Drawing.Size(121, 17);
            this.lblName.TabIndex = 1;
            this.lblName.Text = "Nome completo";
            this.lblName.Click += new System.EventHandler(this.lblName_Click);
            // 
            // txbName
            // 
            this.txbName.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbName.Location = new System.Drawing.Point(24, 114);
            this.txbName.Name = "txbName";
            this.txbName.Size = new System.Drawing.Size(238, 23);
            this.txbName.TabIndex = 2;
            this.txbName.TextChanged += new System.EventHandler(this.txbName_TextChanged);
            // 
            // lblEmail
            // 
            this.lblEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblEmail.AutoSize = true;
            this.lblEmail.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEmail.ForeColor = System.Drawing.Color.Teal;
            this.lblEmail.Location = new System.Drawing.Point(309, 94);
            this.lblEmail.Name = "lblEmail";
            this.lblEmail.Size = new System.Drawing.Size(52, 17);
            this.lblEmail.TabIndex = 1;
            this.lblEmail.Text = "E-mail";
            this.lblEmail.Click += new System.EventHandler(this.lblEmail_Click);
            // 
            // txbEmail
            // 
            this.txbEmail.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbEmail.Location = new System.Drawing.Point(309, 114);
            this.txbEmail.Name = "txbEmail";
            this.txbEmail.Size = new System.Drawing.Size(238, 23);
            this.txbEmail.TabIndex = 2;
            this.txbEmail.TextChanged += new System.EventHandler(this.txbEmail_TextChanged);
            // 
            // lblCPF
            // 
            this.lblCPF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCPF.AutoSize = true;
            this.lblCPF.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCPF.ForeColor = System.Drawing.Color.Teal;
            this.lblCPF.Location = new System.Drawing.Point(24, 154);
            this.lblCPF.Name = "lblCPF";
            this.lblCPF.Size = new System.Drawing.Size(34, 17);
            this.lblCPF.TabIndex = 1;
            this.lblCPF.Text = "CPF";
            this.lblCPF.Click += new System.EventHandler(this.lblCPF_Click);
            // 
            // txbCPF
            // 
            this.txbCPF.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbCPF.Location = new System.Drawing.Point(24, 175);
            this.txbCPF.Name = "txbCPF";
            this.txbCPF.Size = new System.Drawing.Size(238, 23);
            this.txbCPF.TabIndex = 2;
            this.txbCPF.TextChanged += new System.EventHandler(this.txbCPF_TextChanged);
            // 
            // lblPhone
            // 
            this.lblPhone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPhone.AutoSize = true;
            this.lblPhone.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPhone.ForeColor = System.Drawing.Color.Teal;
            this.lblPhone.Location = new System.Drawing.Point(309, 154);
            this.lblPhone.Name = "lblPhone";
            this.lblPhone.Size = new System.Drawing.Size(57, 17);
            this.lblPhone.TabIndex = 1;
            this.lblPhone.Text = "Celular";
            this.lblPhone.Click += new System.EventHandler(this.lblPhone_Click);
            // 
            // txbPhone
            // 
            this.txbPhone.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbPhone.Location = new System.Drawing.Point(309, 175);
            this.txbPhone.Name = "txbPhone";
            this.txbPhone.Size = new System.Drawing.Size(238, 23);
            this.txbPhone.TabIndex = 2;
            this.txbPhone.TextChanged += new System.EventHandler(this.txbPhone_TextChanged);
            // 
            // lblBirth
            // 
            this.lblBirth.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBirth.AutoSize = true;
            this.lblBirth.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBirth.ForeColor = System.Drawing.Color.Teal;
            this.lblBirth.Location = new System.Drawing.Point(24, 224);
            this.lblBirth.Name = "lblBirth";
            this.lblBirth.Size = new System.Drawing.Size(146, 17);
            this.lblBirth.TabIndex = 1;
            this.lblBirth.Text = "Data de nascimento";
            this.lblBirth.Click += new System.EventHandler(this.lblBirth_Click);
            // 
            // txbBirth
            // 
            this.txbBirth.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbBirth.Location = new System.Drawing.Point(24, 246);
            this.txbBirth.Name = "txbBirth";
            this.txbBirth.Size = new System.Drawing.Size(238, 23);
            this.txbBirth.TabIndex = 2;
            this.txbBirth.TextChanged += new System.EventHandler(this.txbBirth_TextChanged);
            // 
            // cbxFemale
            // 
            this.cbxFemale.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxFemale.AutoSize = true;
            this.cbxFemale.Location = new System.Drawing.Point(312, 248);
            this.cbxFemale.Name = "cbxFemale";
            this.cbxFemale.Size = new System.Drawing.Size(76, 19);
            this.cbxFemale.TabIndex = 3;
            this.cbxFemale.Text = "Feminino";
            this.cbxFemale.UseVisualStyleBackColor = true;
            this.cbxFemale.CheckedChanged += new System.EventHandler(this.cbxFemale_CheckedChanged);
            // 
            // cbxMale
            // 
            this.cbxMale.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.cbxMale.AutoSize = true;
            this.cbxMale.Location = new System.Drawing.Point(419, 248);
            this.cbxMale.Name = "cbxMale";
            this.cbxMale.Size = new System.Drawing.Size(81, 19);
            this.cbxMale.TabIndex = 3;
            this.cbxMale.Text = "Masculino";
            this.cbxMale.UseVisualStyleBackColor = true;
            this.cbxMale.CheckedChanged += new System.EventHandler(this.cbxMale_CheckedChanged);
            // 
            // lblGender
            // 
            this.lblGender.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblGender.AutoSize = true;
            this.lblGender.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblGender.ForeColor = System.Drawing.Color.Teal;
            this.lblGender.Location = new System.Drawing.Point(309, 224);
            this.lblGender.Name = "lblGender";
            this.lblGender.Size = new System.Drawing.Size(59, 17);
            this.lblGender.TabIndex = 1;
            this.lblGender.Text = "Gênero";
            this.lblGender.Click += new System.EventHandler(this.lblGender_Click);
            // 
            // lblPassword
            // 
            this.lblPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblPassword.AutoSize = true;
            this.lblPassword.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPassword.ForeColor = System.Drawing.Color.Teal;
            this.lblPassword.Location = new System.Drawing.Point(24, 289);
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(49, 17);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Senha";
            this.lblPassword.Click += new System.EventHandler(this.lblPassword_Click);
            // 
            // txbPassword
            // 
            this.txbPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbPassword.Location = new System.Drawing.Point(24, 312);
            this.txbPassword.Name = "txbPassword";
            this.txbPassword.Size = new System.Drawing.Size(238, 23);
            this.txbPassword.TabIndex = 2;
            this.txbPassword.TextChanged += new System.EventHandler(this.txbPassword_TextChanged);
            // 
            // btnRegister
            // 
            this.btnRegister.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRegister.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnRegister.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRegister.ForeColor = System.Drawing.Color.Transparent;
            this.btnRegister.Location = new System.Drawing.Point(123, 364);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(238, 46);
            this.btnRegister.TabIndex = 4;
            this.btnRegister.Text = "Cadastrar";
            this.btnRegister.UseVisualStyleBackColor = false;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // btnBack
            // 
            this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBack.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnBack.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBack.ForeColor = System.Drawing.Color.Transparent;
            this.btnBack.Location = new System.Drawing.Point(396, 364);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(238, 46);
            this.btnBack.TabIndex = 4;
            this.btnBack.Text = "Voltar";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblBank
            // 
            this.lblBank.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBank.AutoSize = true;
            this.lblBank.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBank.ForeColor = System.Drawing.Color.Teal;
            this.lblBank.Location = new System.Drawing.Point(585, 94);
            this.lblBank.Name = "lblBank";
            this.lblBank.Size = new System.Drawing.Size(51, 17);
            this.lblBank.TabIndex = 1;
            this.lblBank.Text = "Banco";
            this.lblBank.Click += new System.EventHandler(this.lblBank_Click);
            // 
            // txbBank
            // 
            this.txbBank.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbBank.Location = new System.Drawing.Point(585, 114);
            this.txbBank.Name = "txbBank";
            this.txbBank.Size = new System.Drawing.Size(184, 23);
            this.txbBank.TabIndex = 2;
            this.txbBank.TextChanged += new System.EventHandler(this.txbBank_TextChanged);
            // 
            // lblBankAg
            // 
            this.lblBankAg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBankAg.AutoSize = true;
            this.lblBankAg.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBankAg.ForeColor = System.Drawing.Color.Teal;
            this.lblBankAg.Location = new System.Drawing.Point(585, 154);
            this.lblBankAg.Name = "lblBankAg";
            this.lblBankAg.Size = new System.Drawing.Size(66, 17);
            this.lblBankAg.TabIndex = 1;
            this.lblBankAg.Text = "Agência";
            this.lblBankAg.Click += new System.EventHandler(this.lblBankAg_Click);
            // 
            // txbAg
            // 
            this.txbAg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbAg.Location = new System.Drawing.Point(585, 175);
            this.txbAg.Name = "txbAg";
            this.txbAg.Size = new System.Drawing.Size(184, 23);
            this.txbAg.TabIndex = 2;
            this.txbAg.TextChanged += new System.EventHandler(this.txbAg_TextChanged);
            // 
            // lblBankAcc
            // 
            this.lblBankAcc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblBankAcc.AutoSize = true;
            this.lblBankAcc.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblBankAcc.ForeColor = System.Drawing.Color.Teal;
            this.lblBankAcc.Location = new System.Drawing.Point(585, 224);
            this.lblBankAcc.Name = "lblBankAcc";
            this.lblBankAcc.Size = new System.Drawing.Size(49, 17);
            this.lblBankAcc.TabIndex = 1;
            this.lblBankAcc.Text = "Conta";
            this.lblBankAcc.Click += new System.EventHandler(this.lblBankAcc_Click);
            // 
            // txbBankAcc
            // 
            this.txbBankAcc.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbBankAcc.Location = new System.Drawing.Point(585, 244);
            this.txbBankAcc.Name = "txbBankAcc";
            this.txbBankAcc.Size = new System.Drawing.Size(184, 23);
            this.txbBankAcc.TabIndex = 2;
            this.txbBankAcc.TextChanged += new System.EventHandler(this.txbBankAcc_TextChanged);
            // 
            // lblMsg
            // 
            this.lblMsg.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblMsg.AutoSize = true;
            this.lblMsg.Font = new System.Drawing.Font("Century Gothic", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblMsg.Location = new System.Drawing.Point(271, 422);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(0, 16);
            this.lblMsg.TabIndex = 5;
            this.lblMsg.Click += new System.EventHandler(this.lblMsg_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(10, 0);
            this.pictureBox1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(108, 62);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            // 
            // frmGetRegistered
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(800, 446);
            this.Controls.Add(this.pictureBox1);
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
            this.ForeColor = System.Drawing.Color.Teal;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "frmGetRegistered";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Nova conta";
            this.Load += new System.EventHandler(this.frmGetRegistered_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
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
        private PictureBox pictureBox1;
    }
}