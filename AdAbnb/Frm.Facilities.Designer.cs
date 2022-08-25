namespace AdAbnb.Presentation
{
    partial class frmFacilities
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmFacilities));
            this.txbFacilities = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txbFacilities
            // 
            this.txbFacilities.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.txbFacilities.Font = new System.Drawing.Font("Century Gothic", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.txbFacilities.ForeColor = System.Drawing.Color.Teal;
            this.txbFacilities.Location = new System.Drawing.Point(102, 99);
            this.txbFacilities.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbFacilities.Multiline = true;
            this.txbFacilities.Name = "txbFacilities";
            this.txbFacilities.Size = new System.Drawing.Size(237, 207);
            this.txbFacilities.TabIndex = 0;
            // 
            // frmFacilities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(432, 425);
            this.Controls.Add(this.txbFacilities);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmFacilities";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Comodidades";
            this.Load += new System.EventHandler(this.Frm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txbFacilities;
    }
}