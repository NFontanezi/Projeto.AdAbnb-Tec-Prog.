namespace AdAbnb.Presentation
{
    partial class Frm
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
            this.lblLoginTitle = new System.Windows.Forms.Label();
            this.lblEmailLogin = new System.Windows.Forms.Label();
            this.txbEmailLogin = new System.Windows.Forms.TextBox();
            this.lblPasswordLogin = new System.Windows.Forms.Label();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // lblLoginTitle
            // 
            this.lblLoginTitle.AutoSize = true;
            this.lblLoginTitle.Font = new System.Drawing.Font("Segoe UI", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblLoginTitle.Location = new System.Drawing.Point(30, 31);
            this.lblLoginTitle.Name = "lblLoginTitle";
            this.lblLoginTitle.Size = new System.Drawing.Size(64, 30);
            this.lblLoginTitle.TabIndex = 0;
            this.lblLoginTitle.Text = "Login";
            // 
            // lblEmailLogin
            // 
            this.lblEmailLogin.AutoSize = true;
            this.lblEmailLogin.Location = new System.Drawing.Point(38, 121);
            this.lblEmailLogin.Name = "lblEmailLogin";
            this.lblEmailLogin.Size = new System.Drawing.Size(36, 15);
            this.lblEmailLogin.TabIndex = 1;
            this.lblEmailLogin.Text = "Email";
            // 
            // txbEmailLogin
            // 
            this.txbEmailLogin.Location = new System.Drawing.Point(41, 143);
            this.txbEmailLogin.Name = "txbEmailLogin";
            this.txbEmailLogin.Size = new System.Drawing.Size(240, 23);
            this.txbEmailLogin.TabIndex = 2;
            // 
            // lblPasswordLogin
            // 
            this.lblPasswordLogin.AutoSize = true;
            this.lblPasswordLogin.Location = new System.Drawing.Point(38, 188);
            this.lblPasswordLogin.Name = "lblPasswordLogin";
            this.lblPasswordLogin.Size = new System.Drawing.Size(39, 15);
            this.lblPasswordLogin.TabIndex = 1;
            this.lblPasswordLogin.Text = "Senha";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(41, 210);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(240, 23);
            this.textBox1.TabIndex = 2;
            // 
            // Frm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.lblPasswordLogin);
            this.Controls.Add(this.txbEmailLogin);
            this.Controls.Add(this.lblEmailLogin);
            this.Controls.Add(this.lblLoginTitle);
            this.Name = "Frm";
            this.Text = "Frm";
            this.Load += new System.EventHandler(this.Frm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblLoginTitle;
        private Label lblEmailLogin;
        private TextBox txbEmailLogin;
        private Label lblPasswordLogin;
        private TextBox textBox1;
    }
}