namespace AdAbnb.Presentation
{
    partial class frmLoginArea_MyAdvs
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
            this.ownerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.dataGridView_adv = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Daily = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.District = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.State = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Footage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Active = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.facilities = new System.Windows.Forms.DataGridViewButtonColumn();
            this.imagetext = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.propertyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ownerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.btnDelete = new System.Windows.Forms.Button();
            this.btnEdit = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.ownerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_adv)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertyBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ownerBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // ownerBindingSource
            // 
            this.ownerBindingSource.DataSource = typeof(AdAbnb.Domain.Owner);
            // 
            // dataGridView_adv
            // 
            this.dataGridView_adv.AllowUserToOrderColumns = true;
            this.dataGridView_adv.AutoGenerateColumns = false;
            this.dataGridView_adv.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_adv.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.Daily,
            this.City,
            this.District,
            this.State,
            this.Footage,
            this.Active,
            this.facilities,
            this.imagetext});
            this.dataGridView_adv.DataSource = this.propertyBindingSource;
            this.dataGridView_adv.Location = new System.Drawing.Point(-286, 68);
            this.dataGridView_adv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dataGridView_adv.Name = "dataGridView_adv";
            this.dataGridView_adv.RowHeadersWidth = 51;
            this.dataGridView_adv.RowTemplate.Height = 25;
            this.dataGridView_adv.Size = new System.Drawing.Size(973, 292);
            this.dataGridView_adv.TabIndex = 0;
            this.dataGridView_adv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_adv_CellContentClick);
            this.dataGridView_adv.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_adv_CellContentDoubleClick);
            this.dataGridView_adv.ControlRemoved += new System.Windows.Forms.ControlEventHandler(this.dataGridView_adv_ControlRemoved);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID_prop";
            this.ID.HeaderText = "ID";
            this.ID.MinimumWidth = 6;
            this.ID.Name = "ID";
            this.ID.Width = 125;
            // 
            // Daily
            // 
            this.Daily.DataPropertyName = "Daily";
            this.Daily.HeaderText = "Diária";
            this.Daily.MinimumWidth = 6;
            this.Daily.Name = "Daily";
            this.Daily.ReadOnly = true;
            this.Daily.Width = 125;
            // 
            // City
            // 
            this.City.DataPropertyName = "City";
            this.City.HeaderText = "Cidade";
            this.City.MinimumWidth = 6;
            this.City.Name = "City";
            this.City.ReadOnly = true;
            this.City.Width = 125;
            // 
            // District
            // 
            this.District.DataPropertyName = "District";
            this.District.HeaderText = "Bairo";
            this.District.MinimumWidth = 6;
            this.District.Name = "District";
            this.District.ReadOnly = true;
            this.District.Visible = false;
            this.District.Width = 125;
            // 
            // State
            // 
            this.State.DataPropertyName = "State";
            this.State.HeaderText = "Estado";
            this.State.MinimumWidth = 6;
            this.State.Name = "State";
            this.State.ReadOnly = true;
            this.State.Width = 125;
            // 
            // Footage
            // 
            this.Footage.DataPropertyName = "Footage";
            this.Footage.HeaderText = "Metragem";
            this.Footage.MinimumWidth = 6;
            this.Footage.Name = "Footage";
            this.Footage.ReadOnly = true;
            this.Footage.Width = 125;
            // 
            // Active
            // 
            this.Active.DataPropertyName = "Active";
            this.Active.HeaderText = "Ativo";
            this.Active.MinimumWidth = 6;
            this.Active.Name = "Active";
            this.Active.ReadOnly = true;
            this.Active.Width = 125;
            // 
            // facilities
            // 
            this.facilities.DataPropertyName = "facilities";
            this.facilities.HeaderText = "Comodidades";
            this.facilities.MinimumWidth = 6;
            this.facilities.Name = "facilities";
            this.facilities.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.facilities.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.facilities.Width = 125;
            // 
            // imagetext
            // 
            this.imagetext.DataPropertyName = "imagetext";
            this.imagetext.HeaderText = "imagetext";
            this.imagetext.MinimumWidth = 6;
            this.imagetext.Name = "imagetext";
            this.imagetext.Width = 125;
            // 
            // propertyBindingSource
            // 
            this.propertyBindingSource.DataSource = typeof(AdAbnb.Domain.Property);
            // 
            // ownerBindingSource1
            // 
            this.ownerBindingSource1.DataSource = typeof(AdAbnb.Domain.Owner);
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(718, 113);
            this.btnDelete.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(125, 36);
            this.btnDelete.TabIndex = 2;
            this.btnDelete.Text = "Deletar";
            this.btnDelete.UseVisualStyleBackColor = true;
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // btnEdit
            // 
            this.btnEdit.Location = new System.Drawing.Point(718, 157);
            this.btnEdit.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnEdit.Name = "btnEdit";
            this.btnEdit.Size = new System.Drawing.Size(125, 36);
            this.btnEdit.TabIndex = 2;
            this.btnEdit.Text = "Editar";
            this.btnEdit.UseVisualStyleBackColor = true;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(720, 228);
            this.button1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(122, 56);
            this.button1.TabIndex = 3;
            this.button1.Text = "Editar2";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // frmLoginArea_MyAdvs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.btnEdit);
            this.Controls.Add(this.btnDelete);
            this.Controls.Add(this.dataGridView_adv);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(932, 647);
            this.Name = "frmLoginArea_MyAdvs";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LoginArea_MyAdvs";
            this.Load += new System.EventHandler(this.LoginArea_MyAdvs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ownerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_adv)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.propertyBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ownerBindingSource1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private BindingSource ownerBindingSource;
        private DataGridView dataGridView_adv;
        private BindingSource propertyBindingSource;
        private BindingSource ownerBindingSource1;
        private DataGridViewButtonColumn iDpropDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dailyDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn districtDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn stateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn footageDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn activeDataGridViewCheckBoxColumn;
        private DataGridViewTextBoxColumn ID;
        private DataGridViewTextBoxColumn Daily;
        private DataGridViewTextBoxColumn City;
        private DataGridViewTextBoxColumn District;
        private DataGridViewTextBoxColumn State;
        private DataGridViewTextBoxColumn Footage;
        private DataGridViewCheckBoxColumn Active;
        private DataGridViewButtonColumn facilities;
        private DataGridViewTextBoxColumn imagetext;
        private Button btnDelete;
        private Button btnEdit;
        private Button button1;
    }
}