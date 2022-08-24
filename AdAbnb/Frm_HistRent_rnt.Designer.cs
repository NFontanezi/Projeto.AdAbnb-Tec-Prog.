namespace AdAbnb.Presentation
{
    partial class Frm_HistRent_rnt
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
            this.dtv2 = new System.Windows.Forms.DataGridView();
            this.lblTitle = new System.Windows.Forms.Label();
            this.btnBack = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dtv2)).BeginInit();
            this.SuspendLayout();
            // 
            // dtv2
            // 
            this.dtv2.AllowUserToAddRows = false;
            this.dtv2.AllowUserToDeleteRows = false;
            this.dtv2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.dtv2.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dtv2.Location = new System.Drawing.Point(202, 172);
            this.dtv2.Name = "dtv2";
            this.dtv2.ReadOnly = true;
            this.dtv2.RowHeadersWidth = 51;
            this.dtv2.RowTemplate.Height = 29;
            this.dtv2.Size = new System.Drawing.Size(601, 367);
            this.dtv2.TabIndex = 0;
            this.dtv2.CellContentDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dtv2_CellContentDoubleClick);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Location = new System.Drawing.Point(202, 111);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(190, 20);
            this.lblTitle.TabIndex = 1;
            this.lblTitle.Text = "Imóveis alugados por você:";
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(418, 597);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(94, 29);
            this.btnBack.TabIndex = 2;
            this.btnBack.Text = "Voltar";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Frm_HistRent_rnt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 666);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.dtv2);
            this.Name = "Frm_HistRent_rnt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Frm_HistRent_rnt";
            this.Load += new System.EventHandler(this.Frm_HistRent_rnt_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dtv2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DataGridView dtv2;
        private Label lblTitle;
        private Button btnBack;
    }
}