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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Frm_AdvToRent_rnt));
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ID_prop = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Daily = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.District = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.State = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Footage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Active = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.imagetext = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AC = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Piscina = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ProxMar = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.PetFriendly = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.Vaga = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.ProxTransp = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.propertyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.lblCidade = new System.Windows.Forms.Label();
            this.txbCidade = new System.Windows.Forms.TextBox();
            this.btnFilter = new System.Windows.Forms.Button();
            this.CkbPool = new System.Windows.Forms.CheckBox();
            this.CkbAC = new System.Windows.Forms.CheckBox();
            this.CkbProxAoMar = new System.Windows.Forms.CheckBox();
            this.CkbPetFriendly = new System.Windows.Forms.CheckBox();
            this.CkbVagaGaragem = new System.Windows.Forms.CheckBox();
            this.CkbProxTranspPublico = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertyBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.BackgroundColor = System.Drawing.Color.Cornsilk;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID_prop,
            this.Daily,
            this.City,
            this.District,
            this.State,
            this.Footage,
            this.Active,
            this.imagetext,
            this.AC,
            this.Piscina,
            this.ProxMar,
            this.PetFriendly,
            this.Vaga,
            this.ProxTransp});
            this.dataGridView1.DataSource = this.propertyBindingSource;
            this.dataGridView1.GridColor = System.Drawing.Color.Cornsilk;
            this.dataGridView1.Location = new System.Drawing.Point(106, 241);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 29;
            this.dataGridView1.Size = new System.Drawing.Size(900, 600);
            this.dataGridView1.TabIndex = 0;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellContentClick);
            //this.dataGridView1.DoubleClick += new System.EventHandler(this.dataGridView1_DoubleClick);
            // 
            // ID_prop
            // 
            this.ID_prop.DataPropertyName = "ID_prop";
            this.ID_prop.HeaderText = "ID_prop";
            this.ID_prop.MinimumWidth = 6;
            this.ID_prop.Name = "ID_prop";
            this.ID_prop.ReadOnly = true;
            this.ID_prop.Visible = false;
            // 
            // Daily
            // 
            this.Daily.DataPropertyName = "Daily";
            this.Daily.HeaderText = "Daily";
            this.Daily.MinimumWidth = 6;
            this.Daily.Name = "Daily";
            this.Daily.ReadOnly = true;
            // 
            // City
            // 
            this.City.DataPropertyName = "City";
            this.City.HeaderText = "City";
            this.City.MinimumWidth = 6;
            this.City.Name = "City";
            this.City.ReadOnly = true;
            // 
            // District
            // 
            this.District.DataPropertyName = "District";
            this.District.HeaderText = "District";
            this.District.MinimumWidth = 6;
            this.District.Name = "District";
            this.District.ReadOnly = true;
            this.District.Visible = false;
            // 
            // State
            // 
            this.State.DataPropertyName = "State";
            this.State.HeaderText = "State";
            this.State.MinimumWidth = 6;
            this.State.Name = "State";
            this.State.ReadOnly = true;
            this.State.Visible = false;
            // 
            // Footage
            // 
            this.Footage.DataPropertyName = "Footage";
            this.Footage.HeaderText = "Footage";
            this.Footage.MinimumWidth = 6;
            this.Footage.Name = "Footage";
            this.Footage.ReadOnly = true;
            // 
            // Active
            // 
            this.Active.DataPropertyName = "Active";
            this.Active.HeaderText = "Active";
            this.Active.MinimumWidth = 6;
            this.Active.Name = "Active";
            this.Active.ReadOnly = true;
            this.Active.Visible = false;
            // 
            // imagetext
            // 
            this.imagetext.DataPropertyName = "imagetext";
            this.imagetext.HeaderText = "imagetext";
            this.imagetext.MinimumWidth = 6;
            this.imagetext.Name = "imagetext";
            this.imagetext.ReadOnly = true;
            this.imagetext.Visible = false;
            // 
            // AC
            // 
            this.AC.DataPropertyName = "AC";
            this.AC.HeaderText = "AC";
            this.AC.MinimumWidth = 6;
            this.AC.Name = "AC";
            this.AC.ReadOnly = true;
            this.AC.Visible = false;
            // 
            // Piscina
            // 
            this.Piscina.DataPropertyName = "Piscina";
            this.Piscina.HeaderText = "Piscina";
            this.Piscina.MinimumWidth = 6;
            this.Piscina.Name = "Piscina";
            this.Piscina.ReadOnly = true;
            this.Piscina.Visible = false;
            // 
            // ProxMar
            // 
            this.ProxMar.DataPropertyName = "ProxMar";
            this.ProxMar.HeaderText = "ProxMar";
            this.ProxMar.MinimumWidth = 6;
            this.ProxMar.Name = "ProxMar";
            this.ProxMar.ReadOnly = true;
            this.ProxMar.Visible = false;
            // 
            // PetFriendly
            // 
            this.PetFriendly.DataPropertyName = "PetFriendly";
            this.PetFriendly.HeaderText = "PetFriendly";
            this.PetFriendly.MinimumWidth = 6;
            this.PetFriendly.Name = "PetFriendly";
            this.PetFriendly.ReadOnly = true;
            this.PetFriendly.Visible = false;
            // 
            // Vaga
            // 
            this.Vaga.DataPropertyName = "Vaga";
            this.Vaga.HeaderText = "Vaga";
            this.Vaga.MinimumWidth = 6;
            this.Vaga.Name = "Vaga";
            this.Vaga.ReadOnly = true;
            this.Vaga.Visible = false;
            // 
            // ProxTransp
            // 
            this.ProxTransp.DataPropertyName = "ProxTransp";
            this.ProxTransp.HeaderText = "ProxTransp";
            this.ProxTransp.MinimumWidth = 6;
            this.ProxTransp.Name = "ProxTransp";
            this.ProxTransp.ReadOnly = true;
            this.ProxTransp.Visible = false;
            // 
            // propertyBindingSource
            // 
            this.propertyBindingSource.DataSource = typeof(AdAbnb.Domain.Property);
            // 
            // lblCidade
            // 
            this.lblCidade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblCidade.AutoSize = true;
            this.lblCidade.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblCidade.ForeColor = System.Drawing.Color.Teal;
            this.lblCidade.Location = new System.Drawing.Point(269, 103);
            this.lblCidade.Name = "lblCidade";
            this.lblCidade.Size = new System.Drawing.Size(89, 23);
            this.lblCidade.TabIndex = 1;
            this.lblCidade.Text = "Cidade:";
            // 
            // txbCidade
            // 
            this.txbCidade.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbCidade.ForeColor = System.Drawing.Color.Teal;
            this.txbCidade.Location = new System.Drawing.Point(364, 103);
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
            this.btnFilter.ForeColor = System.Drawing.Color.Teal;
            this.btnFilter.Location = new System.Drawing.Point(814, 103);
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
            this.CkbPool.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CkbPool.ForeColor = System.Drawing.Color.Teal;
            this.CkbPool.Location = new System.Drawing.Point(275, 153);
            this.CkbPool.Name = "CkbPool";
            this.CkbPool.Size = new System.Drawing.Size(89, 23);
            this.CkbPool.TabIndex = 5;
            this.CkbPool.Text = "Piscina";
            this.CkbPool.UseVisualStyleBackColor = true;
            this.CkbPool.Click += new System.EventHandler(this.CkbPool_Click);
            // 
            // CkbAC
            // 
            this.CkbAC.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CkbAC.AutoSize = true;
            this.CkbAC.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CkbAC.ForeColor = System.Drawing.Color.Teal;
            this.CkbAC.Location = new System.Drawing.Point(275, 198);
            this.CkbAC.Name = "CkbAC";
            this.CkbAC.Size = new System.Drawing.Size(170, 23);
            this.CkbAC.TabIndex = 6;
            this.CkbAC.Text = "Ar condicionado";
            this.CkbAC.UseVisualStyleBackColor = true;
            this.CkbAC.Click += new System.EventHandler(this.CkbAC_Click);
            // 
            // CkbProxAoMar
            // 
            this.CkbProxAoMar.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CkbProxAoMar.AutoSize = true;
            this.CkbProxAoMar.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CkbProxAoMar.ForeColor = System.Drawing.Color.Teal;
            this.CkbProxAoMar.Location = new System.Drawing.Point(463, 153);
            this.CkbProxAoMar.Name = "CkbProxAoMar";
            this.CkbProxAoMar.Size = new System.Drawing.Size(162, 23);
            this.CkbProxAoMar.TabIndex = 7;
            this.CkbProxAoMar.Text = "Próximo ao mar";
            this.CkbProxAoMar.UseVisualStyleBackColor = true;
            this.CkbProxAoMar.Click += new System.EventHandler(this.CkbProxAoMar_Click);
            // 
            // CkbPetFriendly
            // 
            this.CkbPetFriendly.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CkbPetFriendly.AutoSize = true;
            this.CkbPetFriendly.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CkbPetFriendly.ForeColor = System.Drawing.Color.Teal;
            this.CkbPetFriendly.Location = new System.Drawing.Point(463, 198);
            this.CkbPetFriendly.Name = "CkbPetFriendly";
            this.CkbPetFriendly.Size = new System.Drawing.Size(124, 23);
            this.CkbPetFriendly.TabIndex = 8;
            this.CkbPetFriendly.Text = "Pet Friendly";
            this.CkbPetFriendly.UseVisualStyleBackColor = true;
            this.CkbPetFriendly.Click += new System.EventHandler(this.CkbPetFriendly_Click);
            // 
            // CkbVagaGaragem
            // 
            this.CkbVagaGaragem.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CkbVagaGaragem.AutoSize = true;
            this.CkbVagaGaragem.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CkbVagaGaragem.ForeColor = System.Drawing.Color.Teal;
            this.CkbVagaGaragem.Location = new System.Drawing.Point(636, 153);
            this.CkbVagaGaragem.Name = "CkbVagaGaragem";
            this.CkbVagaGaragem.Size = new System.Drawing.Size(183, 23);
            this.CkbVagaGaragem.TabIndex = 9;
            this.CkbVagaGaragem.Text = "Vaga na garagem";
            this.CkbVagaGaragem.UseVisualStyleBackColor = true;
            this.CkbVagaGaragem.Click += new System.EventHandler(this.CkbVagaGaragem_Click);
            // 
            // CkbProxTranspPublico
            // 
            this.CkbProxTranspPublico.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.CkbProxTranspPublico.AutoSize = true;
            this.CkbProxTranspPublico.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.CkbProxTranspPublico.ForeColor = System.Drawing.Color.Teal;
            this.CkbProxTranspPublico.Location = new System.Drawing.Point(636, 198);
            this.CkbProxTranspPublico.Name = "CkbProxTranspPublico";
            this.CkbProxTranspPublico.Size = new System.Drawing.Size(277, 23);
            this.CkbProxTranspPublico.TabIndex = 10;
            this.CkbProxTranspPublico.Text = "Próximo ao transporte público";
            this.CkbProxTranspPublico.UseVisualStyleBackColor = true;
            this.CkbProxTranspPublico.Click += new System.EventHandler(this.CkbProxTranspPublico_Click);
            // 
            // Frm_AdvToRent_rnt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(1082, 853);
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
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertyBindingSource)).EndInit();
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
        private BindingSource propertyBindingSource;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn ID_prop;
        private DataGridViewTextBoxColumn Daily;
        private DataGridViewTextBoxColumn City;
        private DataGridViewTextBoxColumn District;
        private DataGridViewTextBoxColumn State;
        private DataGridViewTextBoxColumn Footage;
        private DataGridViewCheckBoxColumn Active;
        private DataGridViewTextBoxColumn imagetext;
        private DataGridViewCheckBoxColumn AC;
        private DataGridViewCheckBoxColumn Piscina;
        private DataGridViewCheckBoxColumn ProxMar;
        private DataGridViewCheckBoxColumn PetFriendly;
        private DataGridViewCheckBoxColumn Vaga;
        private DataGridViewCheckBoxColumn ProxTransp;
    }
}