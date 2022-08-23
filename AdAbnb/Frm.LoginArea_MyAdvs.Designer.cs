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
            this.propertyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ownerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Daily = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.City = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.District = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.State = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Footage = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Active = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.facilities = new System.Windows.Forms.DataGridViewButtonColumn();
            this.imagetext = new System.Windows.Forms.DataGridViewTextBoxColumn();
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
            this.dataGridView_adv.Location = new System.Drawing.Point(12, 105);
            this.dataGridView_adv.Name = "dataGridView_adv";
            this.dataGridView_adv.RowTemplate.Height = 25;
            this.dataGridView_adv.Size = new System.Drawing.Size(794, 219);
            this.dataGridView_adv.TabIndex = 0;
            this.dataGridView_adv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_adv_CellContentClick);
            this.dataGridView_adv.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_adv_CellContentDoubleClick);
            // 
            // propertyBindingSource
            // 
            this.propertyBindingSource.DataSource = typeof(AdAbnb.Domain.Property);
            // 
            // ownerBindingSource1
            // 
            this.ownerBindingSource1.DataSource = typeof(AdAbnb.Domain.Owner);
            // 
            // ID
            // 
            this.ID.DataPropertyName = "ID_prop";
            this.ID.HeaderText = "ID";
            this.ID.Name = "ID";
            // 
            // Daily
            // 
            this.Daily.DataPropertyName = "Daily";
            this.Daily.HeaderText = "Diária";
            this.Daily.Name = "Daily";
            this.Daily.ReadOnly = true;
            // 
            // City
            // 
            this.City.DataPropertyName = "City";
            this.City.HeaderText = "Cidade";
            this.City.Name = "City";
            this.City.ReadOnly = true;
            // 
            // District
            // 
            this.District.DataPropertyName = "District";
            this.District.HeaderText = "Bairo";
            this.District.Name = "District";
            this.District.ReadOnly = true;
            this.District.Visible = false;
            // 
            // State
            // 
            this.State.DataPropertyName = "State";
            this.State.HeaderText = "Estado";
            this.State.Name = "State";
            this.State.ReadOnly = true;
            // 
            // Footage
            // 
            this.Footage.DataPropertyName = "Footage";
            this.Footage.HeaderText = "Metragem";
            this.Footage.Name = "Footage";
            this.Footage.ReadOnly = true;
            // 
            // Active
            // 
            this.Active.DataPropertyName = "Active";
            this.Active.HeaderText = "Ativo";
            this.Active.Name = "Active";
            this.Active.ReadOnly = true;
            // 
            // facilities
            // 
            this.facilities.DataPropertyName = "facilities";
            this.facilities.HeaderText = "Comodidades";
            this.facilities.Name = "facilities";
            this.facilities.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.facilities.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // imagetext
            // 
            this.imagetext.DataPropertyName = "imagetext";
            this.imagetext.HeaderText = "imagetext";
            this.imagetext.Name = "imagetext";
            // 
            // frmLoginArea_MyAdvs
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.dataGridView_adv);
            this.Name = "frmLoginArea_MyAdvs";
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
    }
}