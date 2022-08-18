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
            this.SuspendLayout();
            // 
            // btnNewAdv
            // 
            this.btnNewAdv.Location = new System.Drawing.Point(88, 123);
            this.btnNewAdv.Name = "btnNewAdv";
            this.btnNewAdv.Size = new System.Drawing.Size(260, 130);
            this.btnNewAdv.TabIndex = 0;
            this.btnNewAdv.Text = "Criar Novo Anuncio";
            this.btnNewAdv.UseVisualStyleBackColor = true;
            this.btnNewAdv.Click += new System.EventHandler(this.btnNewAdv_Click);
            // 
            // btnAdvOn
            // 
            this.btnAdvOn.Location = new System.Drawing.Point(410, 123);
            this.btnAdvOn.Name = "btnAdvOn";
            this.btnAdvOn.Size = new System.Drawing.Size(260, 130);
            this.btnAdvOn.TabIndex = 0;
            this.btnAdvOn.Text = "Ver Anuncios ativos";
            this.btnAdvOn.UseVisualStyleBackColor = true;
            this.btnAdvOn.Click += new System.EventHandler(this.btnAdvOn_Click);
            // 
            // frmAdvArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnAdvOn);
            this.Controls.Add(this.btnNewAdv);
            this.Name = "frmAdvArea";
            this.Text = "Area Anuncio";
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnNewAdv;
        private Button btnAdvOn;
    }
}