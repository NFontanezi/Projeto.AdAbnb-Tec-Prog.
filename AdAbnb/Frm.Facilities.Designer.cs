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
            this.txbFacilities = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // txbFacilities
            // 
            this.txbFacilities.Location = new System.Drawing.Point(89, 74);
            this.txbFacilities.Multiline = true;
            this.txbFacilities.Name = "txbFacilities";
            this.txbFacilities.Size = new System.Drawing.Size(208, 156);
            this.txbFacilities.TabIndex = 0;
            // 
            // frmFacilities
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(378, 319);
            this.Controls.Add(this.txbFacilities);
            this.Name = "frmFacilities";
            this.Text = "Frm";
            this.Load += new System.EventHandler(this.Frm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txbFacilities;
    }
}