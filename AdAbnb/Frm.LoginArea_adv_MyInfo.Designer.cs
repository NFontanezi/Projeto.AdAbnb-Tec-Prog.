namespace AdAbnb.Presentation
{
    partial class frmLoginAreaAdv_MyInfo
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
            this.btnVoltar = new System.Windows.Forms.Button();
            this.lblMyInfo_adv = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnVoltar
            // 
            this.btnVoltar.Location = new System.Drawing.Point(283, 293);
            this.btnVoltar.Name = "btnVoltar";
            this.btnVoltar.Size = new System.Drawing.Size(228, 50);
            this.btnVoltar.TabIndex = 0;
            this.btnVoltar.Text = "Voltar";
            this.btnVoltar.UseVisualStyleBackColor = true;
            this.btnVoltar.Click += new System.EventHandler(this.btnVoltar_Click);
            // 
            // lblMyInfo_adv
            // 
            this.lblMyInfo_adv.AutoSize = true;
            this.lblMyInfo_adv.Location = new System.Drawing.Point(295, 128);
            this.lblMyInfo_adv.Name = "lblMyInfo_adv";
            this.lblMyInfo_adv.Size = new System.Drawing.Size(0, 15);
            this.lblMyInfo_adv.TabIndex = 1;
            // 
            // frmLoginAreaAdv_MyInfo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblMyInfo_adv);
            this.Controls.Add(this.btnVoltar);
            this.Name = "frmLoginAreaAdv_MyInfo";
            this.Text = "Frm";
            this.Load += new System.EventHandler(this.frmLoginAreaAdv_MyInfo_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnVoltar;
        private Label lblMyInfo_adv;
    }
}