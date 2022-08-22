namespace AdAbnb.Presentation
{
    partial class Frm_ClientArea
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
            this.btn_Infos = new System.Windows.Forms.Button();
            this.btn_Rented = new System.Windows.Forms.Button();
            this.btn_Search = new System.Windows.Forms.Button();
            this.btnBack = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // btn_Infos
            // 
            this.btn_Infos.Location = new System.Drawing.Point(116, 246);
            this.btn_Infos.Name = "btn_Infos";
            this.btn_Infos.Size = new System.Drawing.Size(214, 70);
            this.btn_Infos.TabIndex = 0;
            this.btn_Infos.Text = "Minhas informações";
            this.btn_Infos.UseVisualStyleBackColor = true;
            this.btn_Infos.Click += new System.EventHandler(this.btn_Infos_Click);
            // 
            // btn_Rented
            // 
            this.btn_Rented.Location = new System.Drawing.Point(336, 246);
            this.btn_Rented.Name = "btn_Rented";
            this.btn_Rented.Size = new System.Drawing.Size(214, 70);
            this.btn_Rented.TabIndex = 1;
            this.btn_Rented.Text = "Já alugados";
            this.btn_Rented.UseVisualStyleBackColor = true;
            // 
            // btn_Search
            // 
            this.btn_Search.Location = new System.Drawing.Point(556, 246);
            this.btn_Search.Name = "btn_Search";
            this.btn_Search.Size = new System.Drawing.Size(214, 70);
            this.btn_Search.TabIndex = 2;
            this.btn_Search.Text = "Procurar imóveis";
            this.btn_Search.UseVisualStyleBackColor = true;
            this.btn_Search.Click += new System.EventHandler(this.btn_Search_Click);
            // 
            // btnBack
            // 
            this.btnBack.Location = new System.Drawing.Point(329, 397);
            this.btnBack.Name = "btnBack";
            this.btnBack.Size = new System.Drawing.Size(221, 34);
            this.btnBack.TabIndex = 3;
            this.btnBack.Text = "Voltar ao menu principal";
            this.btnBack.UseVisualStyleBackColor = true;
            this.btnBack.Click += new System.EventHandler(this.btnBack_Click);
            // 
            // Frm_ClientArea
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(914, 600);
            this.Controls.Add(this.btnBack);
            this.Controls.Add(this.btn_Search);
            this.Controls.Add(this.btn_Rented);
            this.Controls.Add(this.btn_Infos);
            this.Name = "Frm_ClientArea";
            this.Text = "Frm_ClientArea";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.ResumeLayout(false);

        }

        #endregion

        private Button btn_Infos;
        private Button btn_Rented;
        private Button btn_Search;
        private Button btnBack;
    }
}