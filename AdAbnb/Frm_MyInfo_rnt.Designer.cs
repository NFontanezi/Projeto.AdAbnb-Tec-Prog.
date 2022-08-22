namespace AdAbnb.Presentation
{
    partial class Frm_MyInfo_rnt
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
            this.lblNameBlank = new System.Windows.Forms.Label();
            this.lbInfoBlank = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblNameBlank
            // 
            this.lblNameBlank.AutoSize = true;
            this.lblNameBlank.Location = new System.Drawing.Point(256, 124);
            this.lblNameBlank.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblNameBlank.Name = "lblNameBlank";
            this.lblNameBlank.Size = new System.Drawing.Size(0, 23);
            this.lblNameBlank.TabIndex = 2;
            // 
            // lbInfoBlank
            // 
            this.lbInfoBlank.AutoSize = true;
            this.lbInfoBlank.Location = new System.Drawing.Point(212, 124);
            this.lbInfoBlank.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbInfoBlank.Name = "lbInfoBlank";
            this.lbInfoBlank.Size = new System.Drawing.Size(0, 23);
            this.lbInfoBlank.TabIndex = 3;
            // 
            // Frm_MyInfo_rnt
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 23F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.lbInfoBlank);
            this.Controls.Add(this.lblNameBlank);
            this.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.ForeColor = System.Drawing.Color.Teal;
            this.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.Name = "Frm_MyInfo_rnt";
            this.Text = "Minhas informações";
            this.Load += new System.EventHandler(this.Frm_MyInfo_rnt_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Label lblNameBlank;
        private Label lbInfoBlank;
    }
}