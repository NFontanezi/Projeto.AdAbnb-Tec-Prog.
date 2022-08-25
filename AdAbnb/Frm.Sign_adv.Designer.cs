namespace AdAbnb.Presentation
{
    partial class FormSign_adv
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormSign_adv));
            this.btnRegistration = new System.Windows.Forms.Button();
            this.btnSign = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegistration
            // 
            this.btnRegistration.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnRegistration.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRegistration.ForeColor = System.Drawing.Color.Transparent;
            this.btnRegistration.Location = new System.Drawing.Point(204, 193);
            this.btnRegistration.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRegistration.Name = "btnRegistration";
            this.btnRegistration.Size = new System.Drawing.Size(214, 93);
            this.btnRegistration.TabIndex = 0;
            this.btnRegistration.Text = "Cadastre-se!";
            this.btnRegistration.UseVisualStyleBackColor = false;
            this.btnRegistration.Click += new System.EventHandler(this.btnRegistration_Click_1);
            // 
            // btnSign
            // 
            this.btnSign.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnSign.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSign.ForeColor = System.Drawing.Color.Transparent;
            this.btnSign.Location = new System.Drawing.Point(466, 193);
            this.btnSign.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnSign.Name = "btnSign";
            this.btnSign.Size = new System.Drawing.Size(214, 93);
            this.btnSign.TabIndex = 0;
            this.btnSign.Text = "Login!";
            this.btnSign.UseVisualStyleBackColor = false;
            this.btnSign.Click += new System.EventHandler(this.btnSign_Click_1);
            // 
            // btnBack
            // 
            this.btnBack.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnBack.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBack.ForeColor = System.Drawing.Color.Transparent;
            this.btnBack.Location = new System.Drawing.Point(324, 372);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(244, 76);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Voltar ao Menu Principal";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.Teal;
            this.lblTitle.Location = new System.Drawing.Point(324, 90);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(246, 37);
            this.lblTitle.TabIndex = 2;
            this.lblTitle.Text = "Para anunciar...";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // FormSign_adv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSign);
            this.Controls.Add(this.btnRegistration);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormSign_adv";
            this.Text = "AdaBnb - Anuncie";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnRegistration;
        private Button btnSign;
        private Button btnBack;
        private Label lblTitle;
        private PictureBox pictureBox1;
    }
}