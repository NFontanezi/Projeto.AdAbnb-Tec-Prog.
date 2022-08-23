namespace AdAbnb.Presentation
{
    partial class Frm_AdvToRent_rnt
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_AdvToRent_rnt));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.lblCidade = new System.Windows.Forms.Label();
            this.txbCidade = new System.Windows.Forms.TextBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.CkbPool = new System.Windows.Forms.CheckBox();
            this.CkbAC = new System.Windows.Forms.CheckBox();
            this.CkbProxAoMar = new System.Windows.Forms.CheckBox();
            this.CkbPetFriendly = new System.Windows.Forms.CheckBox();
            this.CkbVagaGaragem = new System.Windows.Forms.CheckBox();
            this.CkbProxTranspPublico = new System.Windows.Forms.CheckBox();
            this.lblTitle = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Cornsilk;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(127, 238);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(838, 530);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // lblCidade
            // 
            this.lblCidade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCidade.AutoSize = true;
            this.lblCidade.Font = new System.Drawing.Font("Segoe UI", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblCidade.Location = new System.Drawing.Point(266, 102);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(71, 25);
            this.lblCidade.TabIndex = 1;
            this.lblCidade.Text = "Cidade:";
            // 
            // txbCidade
            // 
            this.txbCidade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbCidade.Location = new System.Drawing.Point(343, 103);
            this.txbCidade.MaxLength = 70;
            this.txbCidade.Name = "txbCidade";
            this.txbCidade.Size = new System.Drawing.Size(444, 27);
            this.txbCidade.TabIndex = 2;
            // 
            // btnFilter
            // 
            this.btnFilter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnFilter.AutoSize = true;
            this.btnFilter.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnFilter.BackgroundImage")));
            this.btnFilter.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.btnFilter.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btnFilter.Location = new System.Drawing.Point(793, 103);
            this.btnFilter.Name = "btnFilter";
            this.btnFilter.Size = new System.Drawing.Size(34, 31);
            this.btnFilter.TabIndex = 4;
            this.btnFilter.UseVisualStyleBackColor = true;
            this.btnFilter.Click += new System.EventHandler(this.btnFilter_Click);
            // 
            // CkbPool
            // 
            this.CkbPool.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CkbPool.AutoSize = true;
            this.CkbPool.Location = new System.Drawing.Point(114, 153);
            this.CkbPool.Name = "CkbPool";
            this.CkbPool.Size = new System.Drawing.Size(76, 24);
            this.CkbPool.TabIndex = 5;
            this.CkbPool.Text = "Piscina";
            this.CkbPool.UseVisualStyleBackColor = true;
            this.CkbPool.Click += new System.EventHandler(this.CkbPool_Click);
            // 
            // CkbAC
            // 
            this.CkbAC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CkbAC.AutoSize = true;
            this.CkbAC.Location = new System.Drawing.Point(196, 153);
            this.CkbAC.Name = "CkbAC";
            this.CkbAC.Size = new System.Drawing.Size(141, 24);
            this.CkbAC.TabIndex = 6;
            this.CkbAC.Text = "Ar condicionado";
            this.CkbAC.UseVisualStyleBackColor = true;
            this.CkbAC.Click += new System.EventHandler(this.CkbAC_Click);
            // 
            // CkbProxAoMar
            // 
            this.CkbProxAoMar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CkbProxAoMar.AutoSize = true;
            this.CkbProxAoMar.Location = new System.Drawing.Point(343, 153);
            this.CkbProxAoMar.Name = "CkbProxAoMar";
            this.CkbProxAoMar.Size = new System.Drawing.Size(137, 24);
            this.CkbProxAoMar.TabIndex = 7;
            this.CkbProxAoMar.Text = "Próximo ao mar";
            this.CkbProxAoMar.UseVisualStyleBackColor = true;
            this.CkbProxAoMar.Click += new System.EventHandler(this.CkbProxAoMar_Click);
            // 
            // CkbPetFriendly
            // 
            this.CkbPetFriendly.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CkbPetFriendly.AutoSize = true;
            this.CkbPetFriendly.Location = new System.Drawing.Point(486, 153);
            this.CkbPetFriendly.Name = "CkbPetFriendly";
            this.CkbPetFriendly.Size = new System.Drawing.Size(107, 24);
            this.CkbPetFriendly.TabIndex = 8;
            this.CkbPetFriendly.Text = "Pet Friendly";
            this.CkbPetFriendly.UseVisualStyleBackColor = true;
            this.CkbPetFriendly.Click += new System.EventHandler(this.CkbPetFriendly_Click);
            // 
            // CkbVagaGaragem
            // 
            this.CkbVagaGaragem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CkbVagaGaragem.AutoSize = true;
            this.CkbVagaGaragem.Location = new System.Drawing.Point(599, 153);
            this.CkbVagaGaragem.Name = "CkbVagaGaragem";
            this.CkbVagaGaragem.Size = new System.Drawing.Size(148, 24);
            this.CkbVagaGaragem.TabIndex = 9;
            this.CkbVagaGaragem.Text = "Vaga na garagem";
            this.CkbVagaGaragem.UseVisualStyleBackColor = true;
            this.CkbVagaGaragem.Click += new System.EventHandler(this.CkbVagaGaragem_Click);
            // 
            // CkbProxTranspPublico
            // 
            this.CkbProxTranspPublico.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CkbProxTranspPublico.AutoSize = true;
            this.CkbProxTranspPublico.Location = new System.Drawing.Point(753, 153);
            this.CkbProxTranspPublico.Name = "CkbProxTranspPublico";
            this.CkbProxTranspPublico.Size = new System.Drawing.Size(233, 24);
            this.CkbProxTranspPublico.TabIndex = 10;
            this.CkbProxTranspPublico.Text = "Próximo ao transporte público";
            this.CkbProxTranspPublico.UseVisualStyleBackColor = true;
            this.CkbProxTranspPublico.Click += new System.EventHandler(this.CkbProxTranspPublico_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.Teal;
            this.lblTitle.Location = new System.Drawing.Point(114, 45);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(441, 27);
            this.lblTitle.TabIndex = 11;
            this.lblTitle.Text = "Filtre por cidade OU por comodidades";
            // 
            // Frm_AdvToRent_rnt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(1082, 853);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.CkbProxTranspPublico);
            this.Controls.Add(this.CkbVagaGaragem);
            this.Controls.Add(this.CkbPetFriendly);
            this.Controls.Add(this.CkbProxAoMar);
            this.Controls.Add(this.CkbAC);
            this.Controls.Add(this.CkbPool);
            this.Controls.Add(this.btnFilter);
            this.Controls.Add(this.txbCidade);
            this.Controls.Add(this.lblCidade);
            this.Controls.Add(this.dataGridView1);
            this.Name = "Frm_AdvToRent_rnt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_AdvToRent_rnt";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_AdvToRent_rnt_Load);
            this.Click += new System.EventHandler(this.Frm_AdvToRent_rnt_Click);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dataGridView1;
        private Label lblCidade;
        private TextBox txbCidade;
        private Button btnFilter;
        private CheckBox CkbPool;
        private CheckBox CkbAC;
        private CheckBox CkbProxAoMar;
        private CheckBox CkbPetFriendly;
        private CheckBox CkbVagaGaragem;
        private CheckBox CkbProxTranspPublico;
        private Label lblTitle;
    }
}