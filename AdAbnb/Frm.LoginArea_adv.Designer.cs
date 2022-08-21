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
            this.btnNewAdv.Location = new System.Drawing.Point(101, 164);
            this.btnNewAdv.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnNewAdv.Name = "btnNewAdv";
            this.btnNewAdv.Size = new System.Drawing.Size(297, 173);
            this.btnNewAdv.TabIndex = 0;
            this.btnNewAdv.Text = "Criar Novo Anuncio";
            this.btnNewAdv.UseVisualStyleBackColor = true;
            this.btnNewAdv.Click += new System.EventHandler(this.btnNewAdv_Click);
            // 
            // btnAdvOn
            // 
            this.btnAdvOn.Location = new System.Drawing.Point(469, 164);
            this.btnAdvOn.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAdvOn.Name = "btnAdvOn";
            this.btnAdvOn.Size = new System.Drawing.Size(297, 173);
            this.btnAdvOn.TabIndex = 0;
            this.btnAdvOn.Text = "Ver Anuncios ativos";
            this.btnAdvOn.UseVisualStyleBackColor = true;
            this.btnAdvOn.Click += new System.EventHandler(this.btnAdvOn_Click);
            // 
            // frmAdvArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.btnAdvOn);
            this.Controls.Add(this.btnNewAdv);
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "frmAdvArea";
            this.Text = "Area Anuncio";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private Button btnNewAdv;
        private Button btnAdvOn;
    }
}