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
            this.lbl_Adv = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            this.SuspendLayout();
            // 
            // btnRegistration
            // 
            this.btnRegistration.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnRegistration.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnRegistration.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnRegistration.ForeColor = System.Drawing.Color.Transparent;
            this.btnRegistration.Location = new System.Drawing.Point(217, 220);
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
            this.btnSign.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnSign.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnSign.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnSign.ForeColor = System.Drawing.Color.Transparent;
            this.btnSign.Location = new System.Drawing.Point(479, 220);
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
            this.btnBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnBack.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnBack.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnBack.ForeColor = System.Drawing.Color.Transparent;
            this.btnBack.Location = new System.Drawing.Point(335, 381);
            this.btnBack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(244, 76);
            this.btnBack.TabIndex = 1;
            this.btnBack.Text = "Voltar ao Menu Principal";
            this.btnBack.UseVisualStyleBackColor = false;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // lbl_Adv
            // 
            this.lbl_Adv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lbl_Adv.AutoSize = true;
            this.lbl_Adv.Font = new System.Drawing.Font("Century Gothic", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lbl_Adv.ForeColor = System.Drawing.Color.Teal;
            this.lbl_Adv.Location = new System.Drawing.Point(290, 90);
            this.lbl_Adv.Name = "lbl_Adv";
            this.lbl_Adv.Size = new System.Drawing.Size(343, 70);
            this.lbl_Adv.TabIndex = 6;
            this.lbl_Adv.Text = "ANUNCIAR";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(12, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(181, 101);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // FormSign_adv
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.lbl_Adv);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btnSign);
            this.Controls.Add(this.btnRegistration);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.MinimumSize = new System.Drawing.Size(932, 647);
            this.Name = "FormSign_adv";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "AdaBnb - Anuncie";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnRegistration;
        private Button btnSign;
        private Button btnBack;
        private Label lbl_Adv;
        private PictureBox pictureBox2;
    }
}