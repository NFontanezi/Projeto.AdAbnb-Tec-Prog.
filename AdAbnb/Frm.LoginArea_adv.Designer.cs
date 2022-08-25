namespace AdAbnb.Presentation
{
    partial class frmAdvArea
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAdvArea));
            this.btnNewAdv = new System.Windows.Forms.Button();
            this.btnAdvOn = new System.Windows.Forms.Button();
            this.btbBack = new System.Windows.Forms.Button();
            this.btn_Infos = new System.Windows.Forms.Button();
            this.lblTitle = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // btnNewAdv
            // 
            this.btnNewAdv.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnNewAdv.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnNewAdv.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnNewAdv.ForeColor = System.Drawing.Color.Transparent;
            this.btnNewAdv.Location = new System.Drawing.Point(351, 192);
            this.btnNewAdv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNewAdv.Name = "btnNewAdv";
            this.btnNewAdv.Size = new System.Drawing.Size(214, 93);
            this.btnNewAdv.TabIndex = 0;
            this.btnNewAdv.Text = "Criar Novo Anuncio";
            this.btnNewAdv.UseVisualStyleBackColor = false;
            this.btnNewAdv.Click += new System.EventHandler(this.btnNewAdv_Click);
            // 
            // btnAdvOn
            // 
            this.btnAdvOn.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnAdvOn.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btnAdvOn.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btnAdvOn.ForeColor = System.Drawing.Color.Transparent;
            this.btnAdvOn.Location = new System.Drawing.Point(571, 192);
            this.btnAdvOn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdvOn.Name = "btnAdvOn";
            this.btnAdvOn.Size = new System.Drawing.Size(214, 93);
            this.btnAdvOn.TabIndex = 0;
            this.btnAdvOn.Text = "Ver Anuncios ativos";
            this.btnAdvOn.UseVisualStyleBackColor = false;
            this.btnAdvOn.Click += new System.EventHandler(this.btnAdvOn_Click);
            // 
            // btbBack
            // 
            this.btbBack.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btbBack.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btbBack.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btbBack.ForeColor = System.Drawing.Color.Transparent;
            this.btbBack.Location = new System.Drawing.Point(335, 398);
            this.btbBack.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btbBack.Name = "btbBack";
            this.btbBack.Size = new System.Drawing.Size(256, 76);
            this.btbBack.TabIndex = 1;
            this.btbBack.Text = "Voltar Menu Principal";
            this.btbBack.UseVisualStyleBackColor = false;
            this.btbBack.Click += new System.EventHandler(this.btbBack_Click);
            // 
            // btn_Infos
            // 
            this.btn_Infos.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btn_Infos.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.btn_Infos.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.btn_Infos.ForeColor = System.Drawing.Color.Transparent;
            this.btn_Infos.Location = new System.Drawing.Point(131, 192);
            this.btn_Infos.Name = "btn_Infos";
            this.btn_Infos.Size = new System.Drawing.Size(214, 93);
            this.btn_Infos.TabIndex = 2;
            this.btn_Infos.Text = "Minhas informações";
            this.btn_Infos.UseVisualStyleBackColor = false;
            this.btn_Infos.Click += new System.EventHandler(this.btn_Infos_Click);
            // 
            // lblTitle
            // 
            this.lblTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.lblTitle.AutoSize = true;
            this.lblTitle.Font = new System.Drawing.Font("Century Gothic", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point);
            this.lblTitle.ForeColor = System.Drawing.Color.Teal;
            this.lblTitle.Location = new System.Drawing.Point(314, 71);
            this.lblTitle.Name = "lblTitle";
            this.lblTitle.Size = new System.Drawing.Size(313, 37);
            this.lblTitle.TabIndex = 3;
            this.lblTitle.Text = "Área do proprietário";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(12, -1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(123, 83);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 5;
            this.pictureBox1.TabStop = false;
            // 
            // frmAdvArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Cornsilk;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.lblTitle);
            this.Controls.Add(this.btn_Infos);
            this.Controls.Add(this.btbBack);
            this.Controls.Add(this.btnAdvOn);
            this.Controls.Add(this.btnNewAdv);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmAdvArea";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Área do proprietário";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmAdvArea_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Button btnNewAdv;
        private Button btnAdvOn;
        private Button btbBack;
        private Button btn_Infos;
        private Label lblTitle;
        private PictureBox pictureBox1;
    }
}