namespace AdAbnb.Presentation
{
    partial class frmLogin
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLogin));
            this.lblLoginTitle = new System.Windows.Forms.Label();
            this.lblEmailLogin = new System.Windows.Forms.Label();
            this.txbEmailLogin = new System.Windows.Forms.TextBox();
            this.lblPasswordLogin = new System.Windows.Forms.Label();
            this.txbPasswordLogin = new System.Windows.Forms.TextBox();
            this.btnLogin = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // lblLoginTitle
            // 
            this.lblLoginTitle.AutoSize = true;
            this.lblLoginTitle.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblLoginTitle.ForeColor = System.Drawing.Color.Teal;
            this.lblLoginTitle.Location = new System.Drawing.Point(149, 100);
            this.lblLoginTitle.Name = "lblLoginTitle";
            this.lblLoginTitle.Size = new System.Drawing.Size(94, 37);
            this.lblLoginTitle.TabIndex = 0;
            this.lblLoginTitle.Text = "Login";
            // 
            // lblEmailLogin
            // 
            this.lblEmailLogin.AutoSize = true;
            this.lblEmailLogin.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblEmailLogin.ForeColor = System.Drawing.Color.Teal;
            this.lblEmailLogin.Location = new System.Drawing.Point(68, 176);
            this.lblEmailLogin.Name = "lblEmailLogin";
            this.lblEmailLogin.Size = new System.Drawing.Size(48, 18);
            this.lblEmailLogin.TabIndex = 1;
            this.lblEmailLogin.Text = "Email";
            // 
            // txbEmailLogin
            // 
            this.txbEmailLogin.Location = new System.Drawing.Point(72, 206);
            this.txbEmailLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbEmailLogin.Name = "txbEmailLogin";
            this.txbEmailLogin.Size = new System.Drawing.Size(274, 27);
            this.txbEmailLogin.TabIndex = 2;
            // 
            // lblPasswordLogin
            // 
            this.lblPasswordLogin.AutoSize = true;
            this.lblPasswordLogin.Font = new System.Drawing.Font("Century Gothic", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblPasswordLogin.ForeColor = System.Drawing.Color.Teal;
            this.lblPasswordLogin.Location = new System.Drawing.Point(68, 266);
            this.lblPasswordLogin.Name = "lblPasswordLogin";
            this.lblPasswordLogin.Size = new System.Drawing.Size(54, 18);
            this.lblPasswordLogin.TabIndex = 1;
            this.lblPasswordLogin.Text = "Senha";
            // 
            // txbPasswordLogin
            // 
            this.txbPasswordLogin.Location = new System.Drawing.Point(72, 295);
            this.txbPasswordLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txbPasswordLogin.Name = "txbPasswordLogin";
            this.txbPasswordLogin.Size = new System.Drawing.Size(274, 27);
            this.txbPasswordLogin.TabIndex = 2;
            // 
            // btnLogin
            // 
            this.btnLogin.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnLogin.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnLogin.ForeColor = System.Drawing.Color.Transparent;
            this.btnLogin.Location = new System.Drawing.Point(46, 400);
            this.btnLogin.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.Size = new System.Drawing.Size(154, 67);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Text = "Entrar";
            this.btnLogin.UseVisualStyleBackColor = false;
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnBack.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBack.ForeColor = System.Drawing.Color.Transparent;
            this.btnBack.Location = new System.Drawing.Point(208, 400);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(154, 67);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Voltar";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // frmLogin
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(418, 554);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnLogin);
            this.Controls.Add(this.txbPasswordLogin);
            this.Controls.Add(this.lblPasswordLogin);
            this.Controls.Add(this.txbEmailLogin);
            this.Controls.Add(this.lblEmailLogin);
            this.Controls.Add(this.lblLoginTitle);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmLogin";
            this.Text = "Login";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Frm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Label lblLoginTitle;
        private Label lblEmailLogin;
        private TextBox txbEmailLogin;
        private Label lblPasswordLogin;
        private TextBox txbPasswordLogin;
        private Button btnLogin;
        private Button btnBack;
        private PictureBox pictureBox1;
    }
}