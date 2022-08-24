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
            this.btnNewAdv = new System.Windows.Forms.Button();
            this.btnAdvOn = new System.Windows.Forms.Button();
            this.btbBack = new System.Windows.Forms.Button();
            this.btn_Infos = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btnNewAdv
            // 
            this.btnNewAdv.Location = new System.Drawing.Point(326, 123);
            this.btnNewAdv.Name = "btnNewAdv";
            this.btnNewAdv.Size = new System.Drawing.Size(182, 110);
            this.btnNewAdv.TabIndex = 0;
            this.btnNewAdv.Text = "Criar Novo Anuncio";
            this.btnNewAdv.UseVisualStyleBackColor = true;
            this.btnNewAdv.Click += new System.EventHandler(this.btnNewAdv_Click);
            // 
            // btnAdvOn
            // 
            this.btnAdvOn.Location = new System.Drawing.Point(529, 123);
            this.btnAdvOn.Name = "btnAdvOn";
            this.btnAdvOn.Size = new System.Drawing.Size(176, 110);
            this.btnAdvOn.TabIndex = 0;
            this.btnAdvOn.Text = "Ver Anuncios ativos";
            this.btnAdvOn.UseVisualStyleBackColor = true;
            this.btnAdvOn.Click += new System.EventHandler(this.btnAdvOn_Click);
            // 
            // btbBack
            // 
            this.btbBack.Location = new System.Drawing.Point(296, 292);
            this.btbBack.Name = "btbBack";
            this.btbBack.Size = new System.Drawing.Size(224, 57);
            this.btbBack.TabIndex = 1;
            this.btbBack.Text = "Voltar Menu Principal";
            this.btbBack.UseVisualStyleBackColor = true;
            this.btbBack.Click += new System.EventHandler(this.btbBack_Click);
            // 
            // btn_Infos
            // 
            this.btn_Infos.Location = new System.Drawing.Point(115, 123);
            this.btn_Infos.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.btn_Infos.Name = "btn_Infos";
            this.btn_Infos.Size = new System.Drawing.Size(178, 110);
            this.btn_Infos.TabIndex = 2;
            this.btn_Infos.Text = "Minhas informações";
            this.btn_Infos.UseVisualStyleBackColor = true;
            this.btn_Infos.Click += new System.EventHandler(this.btn_Infos_Click);
            // 
            // frmAdvArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btn_Infos);
            this.Controls.Add(this.btbBack);
            this.Controls.Add(this.btnAdvOn);
            this.Controls.Add(this.btnNewAdv);
            this.Name = "frmAdvArea";
            this.Text = "Area Anuncio";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.frmAdvArea_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnNewAdv;
        private Button btnAdvOn;
        private Button btbBack;
        private Button btn_Infos;
    }
}