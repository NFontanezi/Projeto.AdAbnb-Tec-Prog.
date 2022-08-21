namespace AdAbnb.Presentation
{
    partial class frmAddAdv
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
            this.btnBack = new System.Windows.Forms.Button();
            this.btnRegister = new System.Windows.Forms.Button();
            this.cbxAtivo = new System.Windows.Forms.CheckBox();
            this.txbState = new System.Windows.Forms.TextBox();
            this.lblState = new System.Windows.Forms.Label();
            this.txbCity = new System.Windows.Forms.TextBox();
            this.lblCity = new System.Windows.Forms.Label();
            this.lblActive = new System.Windows.Forms.Label();
            this.txbFootage = new System.Windows.Forms.TextBox();
            this.lblFootage = new System.Windows.Forms.Label();
            this.txbDistrict = new System.Windows.Forms.TextBox();
            this.lblDistrict = new System.Windows.Forms.Label();
            this.lblNewAdv = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.lblDaily = new System.Windows.Forms.Label();
            this.txbDaily = new System.Windows.Forms.TextBox();
            this.lblReais = new System.Windows.Forms.Label();
            this.lblComod = new System.Windows.Forms.Label();
            this.cbxPool = new System.Windows.Forms.CheckBox();
            this.cbxSea = new System.Windows.Forms.CheckBox();
            this.cbxPet = new System.Windows.Forms.CheckBox();
            this.cbxPark = new System.Windows.Forms.CheckBox();
            this.cbxAC = new System.Windows.Forms.CheckBox();
            this.cbxBus = new System.Windows.Forms.CheckBox();
            this.lblMsg = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(358, 493);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(272, 61);
            this.btnBack.TabIndex = 24;
            this.btnBack.Text = "Voltar";
            this.btnBack.UseVisualStyleBackColor = true;
            // 
            // btnRegister
            // 
            this.btnRegister.Location = new System.Drawing.Point(32, 493);
            this.btnRegister.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRegister.Name = "btnRegister";
            this.btnRegister.Size = new System.Drawing.Size(272, 61);
            this.btnRegister.TabIndex = 23;
            this.btnRegister.Text = "Cadastrar";
            this.btnRegister.UseVisualStyleBackColor = true;
            this.btnRegister.Click += new System.EventHandler(this.btnRegister_Click);
            // 
            // cbxAtivo
            // 
            this.cbxAtivo.AutoSize = true;
            this.cbxAtivo.Location = new System.Drawing.Point(392, 429);
            this.cbxAtivo.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxAtivo.Name = "cbxAtivo";
            this.cbxAtivo.Size = new System.Drawing.Size(66, 24);
            this.cbxAtivo.TabIndex = 21;
            this.cbxAtivo.Text = "Ativo";
            this.cbxAtivo.UseVisualStyleBackColor = true;
            // 
            // txbState
            // 
            this.txbState.Location = new System.Drawing.Point(445, 160);
            this.txbState.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbState.Name = "txbState";
            this.txbState.Size = new System.Drawing.Size(49, 27);
            this.txbState.TabIndex = 20;
            // 
            // lblState
            // 
            this.lblState.AutoSize = true;
            this.lblState.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblState.Location = new System.Drawing.Point(448, 133);
            this.lblState.Name = "lblState";
            this.lblState.Size = new System.Drawing.Size(52, 17);
            this.lblState.TabIndex = 11;
            this.lblState.Text = "Estado";
            // 
            // txbCity
            // 
            this.txbCity.Location = new System.Drawing.Point(241, 160);
            this.txbCity.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbCity.Name = "txbCity";
            this.txbCity.Size = new System.Drawing.Size(179, 27);
            this.txbCity.TabIndex = 14;
            // 
            // lblCity
            // 
            this.lblCity.AutoSize = true;
            this.lblCity.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCity.Location = new System.Drawing.Point(245, 133);
            this.lblCity.Name = "lblCity";
            this.lblCity.Size = new System.Drawing.Size(52, 17);
            this.lblCity.TabIndex = 12;
            this.lblCity.Text = "Cidade";
            // 
            // lblActive
            // 
            this.lblActive.AutoSize = true;
            this.lblActive.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblActive.Location = new System.Drawing.Point(389, 408);
            this.lblActive.Name = "lblActive";
            this.lblActive.Size = new System.Drawing.Size(103, 17);
            this.lblActive.TabIndex = 8;
            this.lblActive.Text = "Anuncio Status";
            // 
            // txbFootage
            // 
            this.txbFootage.Location = new System.Drawing.Point(515, 160);
            this.txbFootage.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbFootage.Name = "txbFootage";
            this.txbFootage.Size = new System.Drawing.Size(77, 27);
            this.txbFootage.TabIndex = 18;
            // 
            // lblFootage
            // 
            this.lblFootage.AutoSize = true;
            this.lblFootage.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblFootage.Location = new System.Drawing.Point(519, 133);
            this.lblFootage.Name = "lblFootage";
            this.lblFootage.Size = new System.Drawing.Size(71, 17);
            this.lblFootage.TabIndex = 6;
            this.lblFootage.Text = "Metragem";
            // 
            // txbDistrict
            // 
            this.txbDistrict.Location = new System.Drawing.Point(32, 160);
            this.txbDistrict.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbDistrict.Name = "txbDistrict";
            this.txbDistrict.Size = new System.Drawing.Size(183, 27);
            this.txbDistrict.TabIndex = 19;
            // 
            // lblDistrict
            // 
            this.lblDistrict.AutoSize = true;
            this.lblDistrict.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDistrict.Location = new System.Drawing.Point(35, 133);
            this.lblDistrict.Name = "lblDistrict";
            this.lblDistrict.Size = new System.Drawing.Size(46, 17);
            this.lblDistrict.TabIndex = 10;
            this.lblDistrict.Text = "Bairro";
            // 
            // lblNewAdv
            // 
            this.lblNewAdv.AutoSize = true;
            this.lblNewAdv.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblNewAdv.Location = new System.Drawing.Point(35, 45);
            this.lblNewAdv.Name = "lblNewAdv";
            this.lblNewAdv.Size = new System.Drawing.Size(273, 37);
            this.lblNewAdv.TabIndex = 5;
            this.lblNewAdv.Text = "Novo Anuncio Imovel";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(595, 169);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(30, 20);
            this.label1.TabIndex = 25;
            this.label1.Text = "m2";
            // 
            // lblDaily
            // 
            this.lblDaily.AutoSize = true;
            this.lblDaily.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblDaily.Location = new System.Drawing.Point(392, 264);
            this.lblDaily.Name = "lblDaily";
            this.lblDaily.Size = new System.Drawing.Size(82, 17);
            this.lblDaily.TabIndex = 11;
            this.lblDaily.Text = "Valor Diaria";
            // 
            // txbDaily
            // 
            this.txbDaily.Location = new System.Drawing.Point(389, 292);
            this.txbDaily.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbDaily.Name = "txbDaily";
            this.txbDaily.Size = new System.Drawing.Size(73, 27);
            this.txbDaily.TabIndex = 20;
            // 
            // lblReais
            // 
            this.lblReais.AutoSize = true;
            this.lblReais.Location = new System.Drawing.Point(362, 296);
            this.lblReais.Name = "lblReais";
            this.lblReais.Size = new System.Drawing.Size(26, 20);
            this.lblReais.TabIndex = 25;
            this.lblReais.Text = "R$";
            // 
            // lblComod
            // 
            this.lblComod.AutoSize = true;
            this.lblComod.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblComod.Location = new System.Drawing.Point(35, 241);
            this.lblComod.Name = "lblComod";
            this.lblComod.Size = new System.Drawing.Size(170, 17);
            this.lblComod.TabIndex = 8;
            this.lblComod.Text = "Comodidades Disponiveis";
            // 
            // cbxPool
            // 
            this.cbxPool.AutoSize = true;
            this.cbxPool.Location = new System.Drawing.Point(39, 312);
            this.cbxPool.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxPool.Name = "cbxPool";
            this.cbxPool.Size = new System.Drawing.Size(76, 24);
            this.cbxPool.TabIndex = 26;
            this.cbxPool.Text = "Piscina";
            this.cbxPool.UseVisualStyleBackColor = true;
            // 
            // cbxSea
            // 
            this.cbxSea.AutoSize = true;
            this.cbxSea.Location = new System.Drawing.Point(39, 344);
            this.cbxSea.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxSea.Name = "cbxSea";
            this.cbxSea.Size = new System.Drawing.Size(114, 24);
            this.cbxSea.TabIndex = 26;
            this.cbxSea.Text = "Próx. ao mar";
            this.cbxSea.UseVisualStyleBackColor = true;
            // 
            // cbxPet
            // 
            this.cbxPet.AutoSize = true;
            this.cbxPet.Location = new System.Drawing.Point(39, 376);
            this.cbxPet.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxPet.Name = "cbxPet";
            this.cbxPet.Size = new System.Drawing.Size(103, 24);
            this.cbxPet.TabIndex = 26;
            this.cbxPet.Text = "PetFriendly";
            this.cbxPet.UseVisualStyleBackColor = true;
            // 
            // cbxPark
            // 
            this.cbxPark.AutoSize = true;
            this.cbxPark.Location = new System.Drawing.Point(39, 408);
            this.cbxPark.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxPark.Name = "cbxPark";
            this.cbxPark.Size = new System.Drawing.Size(174, 24);
            this.cbxPark.TabIndex = 26;
            this.cbxPark.Text = "Vaga estacionamento";
            this.cbxPark.UseVisualStyleBackColor = true;
            // 
            // cbxAC
            // 
            this.cbxAC.AutoSize = true;
            this.cbxAC.Location = new System.Drawing.Point(35, 281);
            this.cbxAC.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxAC.Name = "cbxAC";
            this.cbxAC.Size = new System.Drawing.Size(143, 24);
            this.cbxAC.TabIndex = 26;
            this.cbxAC.Text = "Ar Condicionado";
            this.cbxAC.UseVisualStyleBackColor = true;
            // 
            // cbxBus
            // 
            this.cbxBus.AutoSize = true;
            this.cbxBus.Location = new System.Drawing.Point(39, 441);
            this.cbxBus.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbxBus.Name = "cbxBus";
            this.cbxBus.Size = new System.Drawing.Size(165, 24);
            this.cbxBus.TabIndex = 26;
            this.cbxBus.Text = "Próx. transp. público";
            this.cbxBus.UseVisualStyleBackColor = true;
            // 
            // lblMsg
            // 
            this.lblMsg.AutoSize = true;
            this.lblMsg.Location = new System.Drawing.Point(205, 561);
            this.lblMsg.Name = "lblMsg";
            this.lblMsg.Size = new System.Drawing.Size(0, 20);
            this.lblMsg.TabIndex = 27;
            // 
            // frmAddAdv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(665, 600);
            this.Controls.Add(this.lblMsg);
            this.Controls.Add(this.cbxBus);
            this.Controls.Add(this.cbxPark);
            this.Controls.Add(this.cbxPet);
            this.Controls.Add(this.cbxSea);
            this.Controls.Add(this.cbxAC);
            this.Controls.Add(this.cbxPool);
            this.Controls.Add(this.lblReais);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnRegister);
            this.Controls.Add(this.cbxAtivo);
            this.Controls.Add(this.txbDaily);
            this.Controls.Add(this.lblDaily);
            this.Controls.Add(this.txbState);
            this.Controls.Add(this.lblState);
            this.Controls.Add(this.txbCity);
            this.Controls.Add(this.lblCity);
            this.Controls.Add(this.lblComod);
            this.Controls.Add(this.lblActive);
            this.Controls.Add(this.txbFootage);
            this.Controls.Add(this.lblFootage);
            this.Controls.Add(this.txbDistrict);
            this.Controls.Add(this.lblDistrict);
            this.Controls.Add(this.lblNewAdv);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmAddAdv";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnBack;
        private Button btnRegister;
        private CheckBox cbxAtivo;
        private TextBox txbState;
        private Label lblState;
        private TextBox txbCity;
        private Label lblCity;
        private Label lblActive;
        private TextBox txbFootage;
        private Label lblFootage;
        private TextBox txbDistrict;
        private Label lblDistrict;
        private Label lblNewAdv;
        private Label label1;
        private Label lblDaily;
        private TextBox txbDaily;
        private Label lblReais;
        private Label lblComod;
        private CheckBox cbxPool;
        private CheckBox cbxSea;
        private CheckBox cbxPet;
        private CheckBox cbxPark;
        private CheckBox cbxAC;
        private CheckBox cbxBus;
        private Label lblMsg;
    }
}