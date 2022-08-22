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
            this.iDpropDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.dailyDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cityDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.districtDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.stateDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.footageDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.activeDataGridViewCheckBoxColumn = new System.Windows.Forms.DataGridViewCheckBoxColumn();
            this.facilities = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Edit = new System.Windows.Forms.DataGridViewImageColumn();
            this.Delete = new System.Windows.Forms.DataGridViewImageColumn();
            this.propertyBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.ownerBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
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
            this.iDpropDataGridViewTextBoxColumn,
            this.dailyDataGridViewTextBoxColumn,
            this.cityDataGridViewTextBoxColumn,
            this.districtDataGridViewTextBoxColumn,
            this.stateDataGridViewTextBoxColumn,
            this.footageDataGridViewTextBoxColumn,
            this.activeDataGridViewCheckBoxColumn,
            this.facilities,
            this.Edit,
            this.Delete});
            this.dataGridView_adv.DataSource = this.propertyBindingSource;
            this.dataGridView_adv.Location = new System.Drawing.Point(-150, 72);
            this.dataGridView_adv.Name = "dataGridView_adv";
            this.dataGridView_adv.RowTemplate.Height = 25;
            this.dataGridView_adv.Size = new System.Drawing.Size(1031, 219);
            this.dataGridView_adv.TabIndex = 0;
            this.dataGridView_adv.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_adv_CellContentClickfacilities);
            // 
            // iDpropDataGridViewTextBoxColumn
            // 
            this.iDpropDataGridViewTextBoxColumn.DataPropertyName = "ID_prop";
            this.iDpropDataGridViewTextBoxColumn.HeaderText = "ID";
            this.iDpropDataGridViewTextBoxColumn.Name = "iDpropDataGridViewTextBoxColumn";
            this.iDpropDataGridViewTextBoxColumn.ReadOnly = true;
            this.iDpropDataGridViewTextBoxColumn.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            // 
            // dailyDataGridViewTextBoxColumn
            // 
            this.dailyDataGridViewTextBoxColumn.DataPropertyName = "Daily";
            this.dailyDataGridViewTextBoxColumn.HeaderText = "Diária";
            this.dailyDataGridViewTextBoxColumn.Name = "dailyDataGridViewTextBoxColumn";
            this.dailyDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // cityDataGridViewTextBoxColumn
            // 
            this.cityDataGridViewTextBoxColumn.DataPropertyName = "City";
            this.cityDataGridViewTextBoxColumn.HeaderText = "Cidade";
            this.cityDataGridViewTextBoxColumn.Name = "cityDataGridViewTextBoxColumn";
            this.cityDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // districtDataGridViewTextBoxColumn
            // 
            this.districtDataGridViewTextBoxColumn.DataPropertyName = "District";
            this.districtDataGridViewTextBoxColumn.HeaderText = "Bairro";
            this.districtDataGridViewTextBoxColumn.Name = "districtDataGridViewTextBoxColumn";
            this.districtDataGridViewTextBoxColumn.ReadOnly = true;
            this.districtDataGridViewTextBoxColumn.Visible = false;
            // 
            // stateDataGridViewTextBoxColumn
            // 
            this.stateDataGridViewTextBoxColumn.DataPropertyName = "State";
            this.stateDataGridViewTextBoxColumn.HeaderText = "Estado";
            this.stateDataGridViewTextBoxColumn.Name = "stateDataGridViewTextBoxColumn";
            this.stateDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // footageDataGridViewTextBoxColumn
            // 
            this.footageDataGridViewTextBoxColumn.DataPropertyName = "Footage";
            this.footageDataGridViewTextBoxColumn.HeaderText = "Metragem";
            this.footageDataGridViewTextBoxColumn.Name = "footageDataGridViewTextBoxColumn";
            this.footageDataGridViewTextBoxColumn.ReadOnly = true;
            // 
            // activeDataGridViewCheckBoxColumn
            // 
            this.activeDataGridViewCheckBoxColumn.DataPropertyName = "Active";
            this.activeDataGridViewCheckBoxColumn.HeaderText = "Ativo";
            this.activeDataGridViewCheckBoxColumn.Name = "activeDataGridViewCheckBoxColumn";
            this.activeDataGridViewCheckBoxColumn.ReadOnly = true;
            // 
            // facilities
            // 
            this.facilities.HeaderText = "Comodidades";
            this.facilities.Name = "facilities";
            this.facilities.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.facilities.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Edit
            // 
            this.Edit.HeaderText = "Editar";
            this.Edit.Name = "Edit";
            this.Edit.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Edit.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // Delete
            // 
            this.Delete.HeaderText = "Excluir";
            this.Delete.Name = "Delete";
            this.Delete.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.Delete.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // propertyBindingSource
            // 
            this.propertyBindingSource.DataSource = typeof(AdAbnb.Domain.Property);
            // 
            // ownerBindingSource1
            // 
            this.ownerBindingSource1.DataSource = typeof(AdAbnb.Domain.Owner);
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
        private DataGridViewTextBoxColumn iDpropDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn dailyDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn cityDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn districtDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn stateDataGridViewTextBoxColumn;
        private DataGridViewTextBoxColumn footageDataGridViewTextBoxColumn;
        private DataGridViewCheckBoxColumn activeDataGridViewCheckBoxColumn;
        private DataGridViewButtonColumn facilities;
        private DataGridViewImageColumn Edit;
        private DataGridViewImageColumn Delete;
    }
}